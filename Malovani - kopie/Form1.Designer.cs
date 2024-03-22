namespace Malovani
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.numericUpDownPolygon = new System.Windows.Forms.NumericUpDown();
            this.buttonPolygon = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonCalligraphyPen = new System.Windows.Forms.Button();
            this.buttonMarker = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.buttonNewCanvas = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonDarkPurple = new System.Windows.Forms.Button();
            this.buttonLightPurple = new System.Windows.Forms.Button();
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonLightBlue = new System.Windows.Forms.Button();
            this.buttonDarkBlue = new System.Windows.Forms.Button();
            this.buttonLightGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonDarkGreen = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonDarkGrey = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonLightGrey = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPolygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.Controls.Add(this.numericUpDownPolygon);
            this.panelCanvas.Controls.Add(this.buttonPolygon);
            this.panelCanvas.Controls.Add(this.buttonEllipse);
            this.panelCanvas.Controls.Add(this.buttonRectangle);
            this.panelCanvas.Controls.Add(this.buttonEraser);
            this.panelCanvas.Controls.Add(this.buttonCalligraphyPen);
            this.panelCanvas.Controls.Add(this.buttonMarker);
            this.panelCanvas.Controls.Add(this.buttonBrush);
            this.panelCanvas.Controls.Add(this.buttonPencil);
            this.panelCanvas.Controls.Add(this.trackBarThickness);
            this.panelCanvas.Controls.Add(this.buttonNewCanvas);
            this.panelCanvas.Controls.Add(this.panelColor);
            this.panelCanvas.Location = new System.Drawing.Point(29, 12);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(900, 700);
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // numericUpDownPolygon
            // 
            this.numericUpDownPolygon.Location = new System.Drawing.Point(840, 340);
            this.numericUpDownPolygon.Name = "numericUpDownPolygon";
            this.numericUpDownPolygon.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownPolygon.TabIndex = 12;
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.BackColor = System.Drawing.Color.White;
            this.buttonPolygon.Location = new System.Drawing.Point(842, 278);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(58, 56);
            this.buttonPolygon.TabIndex = 11;
            this.buttonPolygon.UseVisualStyleBackColor = false;
            this.buttonPolygon.Click += new System.EventHandler(this.buttonPolygon_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.White;
            this.buttonEllipse.Location = new System.Drawing.Point(842, 154);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(58, 56);
            this.buttonEllipse.TabIndex = 10;
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.White;
            this.buttonRectangle.Location = new System.Drawing.Point(842, 216);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(58, 56);
            this.buttonRectangle.TabIndex = 9;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonEraser.Location = new System.Drawing.Point(154, 12);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(58, 56);
            this.buttonEraser.TabIndex = 8;
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonCalligraphyPen
            // 
            this.buttonCalligraphyPen.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonCalligraphyPen.Location = new System.Drawing.Point(410, 12);
            this.buttonCalligraphyPen.Name = "buttonCalligraphyPen";
            this.buttonCalligraphyPen.Size = new System.Drawing.Size(58, 56);
            this.buttonCalligraphyPen.TabIndex = 7;
            this.buttonCalligraphyPen.UseVisualStyleBackColor = false;
            this.buttonCalligraphyPen.Click += new System.EventHandler(this.buttonCalligraphyPen_Click);
            // 
            // buttonMarker
            // 
            this.buttonMarker.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonMarker.Location = new System.Drawing.Point(346, 12);
            this.buttonMarker.Name = "buttonMarker";
            this.buttonMarker.Size = new System.Drawing.Size(58, 56);
            this.buttonMarker.TabIndex = 6;
            this.buttonMarker.UseVisualStyleBackColor = false;
            this.buttonMarker.Click += new System.EventHandler(this.buttonMarker_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonBrush.Location = new System.Drawing.Point(282, 12);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(58, 56);
            this.buttonBrush.TabIndex = 5;
            this.buttonBrush.UseVisualStyleBackColor = false;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonPencil.Location = new System.Drawing.Point(218, 12);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(58, 56);
            this.buttonPencil.TabIndex = 4;
            this.buttonPencil.UseVisualStyleBackColor = false;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(520, 12);
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(123, 69);
            this.trackBarThickness.TabIndex = 3;
            this.trackBarThickness.Scroll += new System.EventHandler(this.trackBarThickness_Scroll);
            // 
            // buttonNewCanvas
            // 
            this.buttonNewCanvas.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonNewCanvas.Location = new System.Drawing.Point(42, 12);
            this.buttonNewCanvas.Name = "buttonNewCanvas";
            this.buttonNewCanvas.Size = new System.Drawing.Size(73, 71);
            this.buttonNewCanvas.TabIndex = 1;
            this.buttonNewCanvas.UseVisualStyleBackColor = false;
            this.buttonNewCanvas.Click += new System.EventHandler(this.buttonNewCanvas_Click);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.buttonDarkPurple);
            this.panelColor.Controls.Add(this.buttonLightPurple);
            this.panelColor.Controls.Add(this.buttonPink);
            this.panelColor.Controls.Add(this.buttonLightBlue);
            this.panelColor.Controls.Add(this.buttonDarkBlue);
            this.panelColor.Controls.Add(this.buttonLightGreen);
            this.panelColor.Controls.Add(this.buttonYellow);
            this.panelColor.Controls.Add(this.buttonDarkGreen);
            this.panelColor.Controls.Add(this.buttonOrange);
            this.panelColor.Controls.Add(this.buttonRed);
            this.panelColor.Controls.Add(this.buttonBlack);
            this.panelColor.Controls.Add(this.buttonDarkGrey);
            this.panelColor.Controls.Add(this.buttonBrown);
            this.panelColor.Controls.Add(this.buttonLightGrey);
            this.panelColor.Controls.Add(this.buttonWhite);
            this.panelColor.Location = new System.Drawing.Point(697, 3);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(200, 120);
            this.panelColor.TabIndex = 0;
            // 
            // buttonDarkPurple
            // 
            this.buttonDarkPurple.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonDarkPurple.Location = new System.Drawing.Point(120, 80);
            this.buttonDarkPurple.Name = "buttonDarkPurple";
            this.buttonDarkPurple.Size = new System.Drawing.Size(40, 40);
            this.buttonDarkPurple.TabIndex = 15;
            this.buttonDarkPurple.UseVisualStyleBackColor = false;
            this.buttonDarkPurple.Click += new System.EventHandler(this.buttonDarkPurple_Click);
            // 
            // buttonLightPurple
            // 
            this.buttonLightPurple.BackColor = System.Drawing.Color.Orchid;
            this.buttonLightPurple.Location = new System.Drawing.Point(80, 80);
            this.buttonLightPurple.Name = "buttonLightPurple";
            this.buttonLightPurple.Size = new System.Drawing.Size(40, 40);
            this.buttonLightPurple.TabIndex = 14;
            this.buttonLightPurple.UseVisualStyleBackColor = false;
            this.buttonLightPurple.Click += new System.EventHandler(this.buttonLightPurple_Click);
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.Pink;
            this.buttonPink.Location = new System.Drawing.Point(160, 80);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(40, 40);
            this.buttonPink.TabIndex = 13;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.buttonPink_Click);
            // 
            // buttonLightBlue
            // 
            this.buttonLightBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonLightBlue.Location = new System.Drawing.Point(40, 80);
            this.buttonLightBlue.Name = "buttonLightBlue";
            this.buttonLightBlue.Size = new System.Drawing.Size(40, 40);
            this.buttonLightBlue.TabIndex = 12;
            this.buttonLightBlue.UseVisualStyleBackColor = false;
            this.buttonLightBlue.Click += new System.EventHandler(this.buttonLightBlue_Click);
            // 
            // buttonDarkBlue
            // 
            this.buttonDarkBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonDarkBlue.Location = new System.Drawing.Point(0, 80);
            this.buttonDarkBlue.Name = "buttonDarkBlue";
            this.buttonDarkBlue.Size = new System.Drawing.Size(40, 40);
            this.buttonDarkBlue.TabIndex = 11;
            this.buttonDarkBlue.UseVisualStyleBackColor = false;
            this.buttonDarkBlue.Click += new System.EventHandler(this.buttonDarkBlue_Click);
            // 
            // buttonLightGreen
            // 
            this.buttonLightGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonLightGreen.Location = new System.Drawing.Point(120, 40);
            this.buttonLightGreen.Name = "buttonLightGreen";
            this.buttonLightGreen.Size = new System.Drawing.Size(40, 40);
            this.buttonLightGreen.TabIndex = 10;
            this.buttonLightGreen.UseVisualStyleBackColor = false;
            this.buttonLightGreen.Click += new System.EventHandler(this.buttonLightGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(80, 40);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(40, 40);
            this.buttonYellow.TabIndex = 9;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonDarkGreen
            // 
            this.buttonDarkGreen.BackColor = System.Drawing.Color.Green;
            this.buttonDarkGreen.Location = new System.Drawing.Point(160, 40);
            this.buttonDarkGreen.Name = "buttonDarkGreen";
            this.buttonDarkGreen.Size = new System.Drawing.Size(40, 40);
            this.buttonDarkGreen.TabIndex = 8;
            this.buttonDarkGreen.UseVisualStyleBackColor = false;
            this.buttonDarkGreen.Click += new System.EventHandler(this.buttonDarkGreen_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonOrange.Location = new System.Drawing.Point(40, 40);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(40, 40);
            this.buttonOrange.TabIndex = 7;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(0, 40);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(40, 40);
            this.buttonRed.TabIndex = 6;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(120, 0);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(40, 40);
            this.buttonBlack.TabIndex = 5;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonDarkGrey
            // 
            this.buttonDarkGrey.BackColor = System.Drawing.Color.Gray;
            this.buttonDarkGrey.Location = new System.Drawing.Point(80, 0);
            this.buttonDarkGrey.Name = "buttonDarkGrey";
            this.buttonDarkGrey.Size = new System.Drawing.Size(40, 40);
            this.buttonDarkGrey.TabIndex = 4;
            this.buttonDarkGrey.UseVisualStyleBackColor = false;
            this.buttonDarkGrey.Click += new System.EventHandler(this.buttonDarkGrey_Click);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.Sienna;
            this.buttonBrown.Location = new System.Drawing.Point(160, 0);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(40, 40);
            this.buttonBrown.TabIndex = 3;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.buttonBrown_Click);
            // 
            // buttonLightGrey
            // 
            this.buttonLightGrey.BackColor = System.Drawing.Color.LightGray;
            this.buttonLightGrey.Location = new System.Drawing.Point(40, 0);
            this.buttonLightGrey.Name = "buttonLightGrey";
            this.buttonLightGrey.Size = new System.Drawing.Size(40, 40);
            this.buttonLightGrey.TabIndex = 2;
            this.buttonLightGrey.UseVisualStyleBackColor = false;
            this.buttonLightGrey.Click += new System.EventHandler(this.buttonLightGrey_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(0, 0);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(40, 40);
            this.buttonWhite.TabIndex = 1;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 731);
            this.Controls.Add(this.panelCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPolygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonDarkPurple;
        private System.Windows.Forms.Button buttonLightPurple;
        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonLightBlue;
        private System.Windows.Forms.Button buttonDarkBlue;
        private System.Windows.Forms.Button buttonLightGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonDarkGreen;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonDarkGrey;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonLightGrey;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonNewCanvas;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Button buttonCalligraphyPen;
        private System.Windows.Forms.Button buttonMarker;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonPolygon;
        private System.Windows.Forms.NumericUpDown numericUpDownPolygon;
    }
}

