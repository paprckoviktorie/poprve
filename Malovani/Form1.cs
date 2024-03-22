using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Malovani
{
    public enum WritingType //Enum mi ukázal ChatGPT, definovala jsem si jim druhy per/štětců/gumu.
    {
        Pencil,
        Line,
        Image, 
        Eraser,
        Ellipse,
        Rectangle,
        Polygon
    }

    public partial class Form1 : Form
    {
        private GraphicsPath chosenPath = new GraphicsPath();
        private Pen drawingPen = new Pen(Color.Black, 5);

        private bool isDrawing = false; //Indikuje, zda právě píšeme.
        private bool isErasing = false; //Indikuje, zda právě gumujeme.
        private bool isDrawingLine = false;
        private bool isDrawingEllipse = false;
        private bool isDrawingRectangle = false;
        private bool isDrawingPolygon = false;
        private bool isPolygonDialogOpen = false; //Díky ChatGPT.

        private Color chosenColor = Color.Black; //Nastavení základní barvy pera na černou.

        private WritingType selectedWritingType = WritingType.Pencil;

        private int thickness = 5;
        private Color eraser = Color.White; //Barva gumy je (logicky) bílá.

        private Point startingPoint;
        private Point endingPoint;
        private Point lastPoint;


        public Form1()
        {
            InitializeComponent();
            panelCanvas.BackColor = Color.White; //Nastavení barvy plátna na bílou.

            buttonPencil.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Pencil2.png");
            buttonPencil.BackgroundImageLayout = ImageLayout.Stretch;

            buttonImage.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Image.png");
            buttonImage.BackgroundImageLayout = ImageLayout.Stretch;

            buttonLine.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Line.png");
            buttonLine.BackgroundImageLayout = ImageLayout.Stretch;

            buttonEraser.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Eraser.png");
            buttonEraser.BackgroundImageLayout = ImageLayout.Stretch;

            buttonNewCanvas.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Canvas.png");
            buttonNewCanvas.BackgroundImageLayout = ImageLayout.Stretch;

            buttonEllipse.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Ellipse.png");
            buttonEllipse.BackgroundImageLayout = ImageLayout.Stretch;

            buttonRectangle.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Rectangle.png");
            buttonRectangle.BackgroundImageLayout = ImageLayout.Stretch;

            buttonPolygon.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Triangle.png");
            buttonPolygon.BackgroundImageLayout = ImageLayout.Stretch;

            int trackBarMiddleValue = trackBarThickness.Maximum / 2;
            trackBarThickness.Value = trackBarMiddleValue;
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (selectedWritingType == WritingType.Polygon && isDrawingPolygon && isPolygonDialogOpen && polygonPoints.Count > 1)
            {
                e.Graphics.DrawPolygon(new Pen(chosenColor, thickness), polygonPoints.ToArray());
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                chosenPath.Dispose();
            }

            isDrawing = false;
            isErasing = false;

            if (e.Button == MouseButtons.Left && isDrawingEllipse)
            {
                endingPoint = e.Location;
                isDrawingEllipse = false;

                using (Graphics graphics = panelCanvas.CreateGraphics())
                {
                    Rectangle ellipse = new Rectangle (Math.Min(startingPoint.X, endingPoint.X), Math.Min(startingPoint.Y, endingPoint.Y), Math.Abs(startingPoint.X - endingPoint.X), Math.Abs(startingPoint.Y-endingPoint.Y));
                    graphics.DrawEllipse(new Pen(chosenColor, thickness), ellipse);
                }
            }

            if (e.Button == MouseButtons.Left && isDrawingRectangle)
            {
                endingPoint = e.Location; 
                isDrawingRectangle = false;

                using (Graphics graphics = panelCanvas.CreateGraphics())
                {
                    Rectangle rectangle = new Rectangle(Math.Min(startingPoint.X, endingPoint.X), Math.Min(startingPoint.Y, endingPoint.Y), Math.Abs(startingPoint.X - endingPoint.X), Math.Abs(startingPoint.Y - endingPoint.Y));
                    graphics.DrawRectangle(new Pen(chosenColor, thickness), rectangle);
                }
            }

            if (e.Button == MouseButtons.Left && isDrawingPolygon)
            {
                isDrawingPolygon = false;
                DrawPolygon(polygonPoints.Count);
            }
            selectedWritingType = WritingType.Pencil;

            if (e.Button == MouseButtons.Left && isDrawingLine)
            {
                isDrawingLine = false;
            }
        }

        private List<Point> polygonPoints = new List<Point>();

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;

            if (selectedWritingType == WritingType.Eraser)
            {
                isErasing = true; //Zapíná mazání, pokud je zvoleno.
            }
            else if (selectedWritingType == WritingType.Line && e.Button == MouseButtons.Left)
            {
                startingPoint = e.Location;
                isDrawingLine = true;
            }
            else if (selectedWritingType == WritingType.Ellipse)
            {
                startingPoint = e.Location;
                isDrawingEllipse = true;
            }
            else if (selectedWritingType == WritingType.Rectangle)
            {
                startingPoint = e.Location;
                isDrawingRectangle = true;
            }
            else if (selectedWritingType == WritingType.Polygon)
            {
                polygonPoints.Clear();
                isDrawingPolygon = true;
                using (var dialog = new PolygonInputDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        int numberOfPoints = dialog.NumberOfPoints;

                        if (numberOfPoints >= 3 && numberOfPoints <= 10)
                        {
                            DrawPolygon(numberOfPoints);
                        }
                        else
                        {
                            MessageBox.Show("Zadej platný počet úhlů (3-10).", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                polygonPoints.Add(e.Location);
            }
            else 
            {
                isDrawing = true; //Jinak zapne kreslení.
                chosenPath = new GraphicsPath();
                chosenPath.StartFigure(); //Nová cesta pro kreslení
                chosenPath.AddLine(e.X, e.Y, e.X, e.Y);
            }

            if (e.Button == MouseButtons.Left && selectedWritingType == WritingType.Ellipse)
            {
                isDrawingEllipse = true;
                startingPoint = e.Location; 
            }
        }
        private List<Point> drawingPoints = new List<Point>();

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing || isErasing)
            {
                using (Graphics graphics = panelCanvas.CreateGraphics())
                {
                    if (isDrawing)
                    {
                        chosenPath.AddLine(lastPoint, e.Location);
                        graphics.DrawPath(drawingPen, chosenPath);
                    }

                    else if (isErasing)
                    {
                        graphics.FillRectangle(new SolidBrush(panelCanvas.BackColor), e.X, e.Y, thickness, thickness);
                        } 
                }
            }
            lastPoint = e.Location;

            if (isDrawingEllipse)
            {
                endingPoint = e.Location;
            }

            if (isDrawingRectangle)
            {
                endingPoint = e.Location;
            }

            if (isDrawingLine && e.Button == MouseButtons.Left)
            {
                using (Graphics graphics = panelCanvas.CreateGraphics())
                {
                    endingPoint = e.Location;
                    graphics.DrawLine(new Pen(panelCanvas.BackColor, thickness), startingPoint, lastPoint);
                    graphics.DrawLine(drawingPen, startingPoint, e.Location);
                }
                endingPoint = e.Location;
         //isDrawingLine = false;
            }

            if (isDrawingPolygon && isPolygonDialogOpen)
            {
               if (e.Button == MouseButtons.Left)
                {
                    polygonPoints.Add(e.Location);
                    panelCanvas.Refresh();
                }
                polygonPoints.Add(e.Location);
            }
        }

        private void buttonNewCanvas_Click(object sender, EventArgs e)
        {
            panelCanvas.Refresh(); //Plátno se vyprázdní.
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            chosenColor = buttonWhite.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonLightGrey_Click(object sender, EventArgs e)
        {
            chosenColor = buttonLightGrey.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonDarkGrey_Click(object sender, EventArgs e)
        {
            chosenColor = buttonDarkGrey.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            chosenColor = buttonBlack.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            chosenColor = buttonBrown.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            chosenColor = buttonRed.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            chosenColor = buttonOrange.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            chosenColor = buttonYellow.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonLightGreen_Click(object sender, EventArgs e)
        {
            chosenColor = buttonLightGreen.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonDarkGreen_Click(object sender, EventArgs e)
        {
            chosenColor = buttonDarkGreen.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonDarkBlue_Click(object sender, EventArgs e)
        {
            chosenColor = buttonDarkBlue.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonLightBlue_Click(object sender, EventArgs e)
        {
            chosenColor = buttonLightBlue.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonLightPurple_Click(object sender, EventArgs e)
        {
            chosenColor = buttonLightPurple.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonDarkPurple_Click(object sender, EventArgs e)
        {
            chosenColor = buttonDarkPurple.BackColor;
            drawingPen.Color = chosenColor;
        }

        private void buttonPink_Click(object sender, EventArgs e)
        {            
                chosenColor = buttonPink.BackColor;
                drawingPen.Color = chosenColor;
 
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            thickness = trackBarThickness.Value;
            drawingPen.Width = thickness;
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.Pencil;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            isErasing = true;
            selectedWritingType = WritingType.Eraser;
            chosenColor = eraser;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.Ellipse;
            isErasing = false;
            isDrawing = false;
            isDrawingRectangle = false;
            isDrawingEllipse = true;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.Rectangle;
            isErasing = false;
            isDrawing = false;
            isDrawingEllipse = false;
            isDrawingLine = false;
            isDrawingRectangle = true;

        }

        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            isErasing = false;
            isDrawing = false;
            isDrawingEllipse = false;
            isDrawingRectangle = false;
            isDrawingPolygon = true;
            polygonPoints.Clear();

            using (var dialog = new PolygonInputDialog())
            {
                isPolygonDialogOpen = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int numberOfPoints = dialog.NumberOfPoints;

                    if (numberOfPoints >=3 && numberOfPoints <= 10)
                    {
                        DrawPolygon(numberOfPoints);
                    }
                    else
                    {
                        MessageBox.Show("Zadej platný počet úhlů (3-10).", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                isPolygonDialogOpen = false; 
            }
        }

            private void DrawPolygon(int numberOfPoints)
            {
                Point[] points = GeneratePolygonPoints(numberOfPoints);

                using (Graphics graphics = panelCanvas.CreateGraphics())
                {
                    graphics.DrawPolygon(new Pen(chosenColor, thickness), points);
                }
            }
            private Point[] GeneratePolygonPoints(int numberOfPoints)
            {
                //Implementuju generování bodů víceúhelníku.
                Point[] points = new Point[numberOfPoints];
            double degrees = 2 * Math.PI / numberOfPoints;

            for (int i = 0; i< numberOfPoints; i++)
            {
                double angle = degrees * i;
                int x = (int)(panelCanvas.Width / 2 + panelCanvas.Width / 4 * Math.Cos(angle));
                int y = (int)(panelCanvas.Height/2 + panelCanvas.Height / 4 * Math.Sin(angle));
                points[i] = new Point(x, y); 
            }
            return points;
            }

        private void buttonImage_Click(object sender, EventArgs e)

        {
            isErasing = false;
            isDrawingEllipse = false;
            isDrawingRectangle = false;
            isDrawingPolygon = false;
            isDrawingLine = false;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Obrázky |*.jpg;*.jpeg;*.png;*.gif |Všechny soubory| *.*";
            openFileDialog.Title = "Vyber obrázek.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string userImagePath = openFileDialog.FileName;
                try
                {
                    Image image = Image.FromFile(userImagePath);
                    pictureBoxImage.Image = image;

                    int widthMultiple = 0;
                    int heightMultiple = 0;

                    using (var sizeDialog = new MultipleSizeDialog(pictureBoxImage, lastPoint, widthMultiple, heightMultiple))
                    {
                        sizeDialog.LastPoint = lastPoint;

                        if (sizeDialog.ShowDialog() == DialogResult.OK)
                        {
                            widthMultiple = sizeDialog.WidthMultiple;
                            heightMultiple = sizeDialog.HeightMultiple;
                        }
                    }

                    pictureBoxImage.Image = new Bitmap(widthMultiple, heightMultiple);
                    pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při načítání: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.Line;
            isErasing = false;
            isDrawing = false;
            isDrawingEllipse = false;
            isDrawingRectangle = false;
            isDrawingLine = true;
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {

        }
    }


    public partial class MultipleSizeDialog : Form
    {
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
        private Button buttonOK;
        private Button buttonCancel;
        private PictureBox pictureBoxImage;
        private Point lastPoint;
        private int widthMultiple = 1;
        private int heightMultiple = 1;

        public Point LastPoint { get; set; }


        public int WidthMultiple
        {
            get { return (int)numericUpDownWidth.Value; }
        }

        public int HeightMultiple
        {
            get { return (int)numericUpDownHeight.Value; }
        }

        public MultipleSizeDialog(PictureBox pictureBox, Point lastPoint, int widthMultiple, int heightMultiple)
        {
            this.Text = "Velikost obrázku";
            this.pictureBoxImage = pictureBox;
            this.lastPoint = lastPoint;
            this.widthMultiple = widthMultiple;
            this.heightMultiple = heightMultiple;

            numericUpDownWidth = new NumericUpDown();
            numericUpDownWidth.Minimum = 1;
            numericUpDownWidth.Maximum = 100;
            numericUpDownWidth.Value = 50;
            numericUpDownWidth.Location = new Point(100, 130);
            numericUpDownWidth.Size = new Size(100, 20);
            this.Controls.Add(numericUpDownWidth);

            numericUpDownHeight = new NumericUpDown();
            numericUpDownHeight.Minimum = 1;
            numericUpDownHeight.Maximum = 100;
            numericUpDownHeight.Value = 50;
            numericUpDownHeight.Location = new Point(100, 160);
            numericUpDownHeight.Size = new Size(100, 20);
            this.Controls.Add(numericUpDownHeight);

            buttonOK = new Button();
            buttonOK.Text = "OK";
            buttonOK.Location = new Point(50, 200);
            buttonOK.Size = new Size(100, 50);
            this.Controls.Add(buttonOK);
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Click += buttonOK_Click;

            buttonCancel = new Button();
            buttonCancel.Text = "Cancel";
            buttonCancel.Location = new Point(160, 200);
            buttonCancel.Size = new Size(100, 50);
            this.Controls.Add(buttonCancel);
            buttonCancel.DialogResult = DialogResult.Cancel;

            LastPoint = new Point(0, 0);

            Image image = pictureBoxImage.Image;

            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;

            buttonOK.Click += (sender, e) =>
            {
                widthMultiple = WidthMultiple;
                heightMultiple = HeightMultiple;
                DialogResult = DialogResult.OK;
                Close();
            };
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            widthMultiple = WidthMultiple;
            heightMultiple = HeightMultiple;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
    public partial class PolygonInputDialog : Form
    {
        public int NumberOfPoints
        {
            get { return (int)numericUpDownPolygon.Value; }
        }
        private NumericUpDown numericUpDownPolygon;

        public PolygonInputDialog()
        {
            Label polygonInstruction = new Label();
            polygonInstruction.Text = ("Zadej počet cípů.");
            polygonInstruction.Location = new Point(100, 70);
            polygonInstruction.AutoSize = true;
            this.Controls.Add(polygonInstruction);

            numericUpDownPolygon = new NumericUpDown();
            numericUpDownPolygon.Minimum = 3;
            numericUpDownPolygon.Maximum = 10;

            numericUpDownPolygon.Location = new Point(100, 100);
            numericUpDownPolygon.Size = new Size(100, 50);

            this.Controls.Add(numericUpDownPolygon);

            Button buttonOk = new Button();
            buttonOk.Text = "OK";
            buttonOk.Location = new Point(100, 200);
            buttonOk.Size = new Size(100, 50);
            this.Controls.Add(buttonOk);
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Click += buttonOk_Click;

           //InitializeComponent();
        }

            private void buttonOk_Click(object sender, EventArgs e)
            {
            int numberOfPoints = (int)numericUpDownPolygon.Value;
                DialogResult = DialogResult.OK;
            Close();
            }

        }
    }

