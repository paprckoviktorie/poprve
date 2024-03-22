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
        Brush,
        CalligraphyPen,
        Marker, 
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

            buttonBrush.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Brush.png");
            buttonBrush.BackgroundImageLayout = ImageLayout.Stretch;

            buttonMarker.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Marker.png");
            buttonMarker.BackgroundImageLayout = ImageLayout.Stretch;

            buttonCalligraphyPen.BackgroundImage = Image.FromFile("C:\\Users\\Viki\\Documents\\GymVod\\PROGRAMOVANI\\poprve\\Malovani\\Pen2.png");
            buttonCalligraphyPen.BackgroundImageLayout = ImageLayout.Stretch;

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

            if (isDrawing && selectedWritingType == WritingType.Brush)
            {
                using (SolidBrush brush = new SolidBrush(chosenColor))
                {
                    for (int i = 1; i < drawingPoints.Count; i++)
                    {
                        e.Graphics.DrawLine(new Pen(brush, thickness), drawingPoints[i - 1], drawingPoints[i]);
                    }
                }
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
        }

        private List<Point> polygonPoints = new List<Point>();

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;

            if (selectedWritingType == WritingType.Eraser)
            {
                isErasing = true; //Zapíná mazání, pokud je zvoleno.
            }
            else if (selectedWritingType == WritingType.Brush)
            {
                isDrawing = true;
                
            }
            else if (selectedWritingType == WritingType.Marker)
            {
                isDrawing = true;
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
                        if (isDrawing && selectedWritingType == WritingType.Brush)
                        {
                            drawingPoints.Add(e.Location);
                        }
                        else if (selectedWritingType == WritingType.Marker)
                        {
                            graphics.FillEllipse(new SolidBrush(chosenColor), e.X - thickness / 2, e.Y - thickness / 2, thickness, thickness);
                        }
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

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.Brush;
            isErasing = false;
            isDrawingEllipse = false;
            isDrawingRectangle = false;
            isDrawingPolygon = false;
        }

        private void buttonMarker_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.Marker;
            isErasing = false;
            isDrawingEllipse = false;
            isDrawingRectangle = false;
            isDrawingPolygon = false;
        }

        private void buttonCalligraphyPen_Click(object sender, EventArgs e)
        {
            selectedWritingType = WritingType.CalligraphyPen;
            isErasing = false;
            isDrawingEllipse = false;
            isDrawingRectangle = false;
            isDrawingPolygon = false;
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

