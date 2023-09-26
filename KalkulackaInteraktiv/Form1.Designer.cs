namespace KalkulackaInteraktiv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonScitani = new System.Windows.Forms.Button();
            this.buttonDeleni = new System.Windows.Forms.Button();
            this.buttonMocnina = new System.Windows.Forms.Button();
            this.buttonOdmocnina = new System.Windows.Forms.Button();
            this.buttonNasobeni = new System.Windows.Forms.Button();
            this.buttonOdcitani = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonScitani
            // 
            this.buttonScitani.Location = new System.Drawing.Point(415, 135);
            this.buttonScitani.Name = "buttonScitani";
            this.buttonScitani.Size = new System.Drawing.Size(59, 56);
            this.buttonScitani.TabIndex = 0;
            this.buttonScitani.Text = "+";
            this.buttonScitani.UseVisualStyleBackColor = true;
            this.buttonScitani.Click += new System.EventHandler(this.buttonScitani_Click);
            // 
            // buttonDeleni
            // 
            this.buttonDeleni.Location = new System.Drawing.Point(516, 229);
            this.buttonDeleni.Name = "buttonDeleni";
            this.buttonDeleni.Size = new System.Drawing.Size(59, 56);
            this.buttonDeleni.TabIndex = 1;
            this.buttonDeleni.Text = ":";
            this.buttonDeleni.UseVisualStyleBackColor = true;
            this.buttonDeleni.Click += new System.EventHandler(this.buttonDeleni_Click);
            // 
            // buttonMocnina
            // 
            this.buttonMocnina.Location = new System.Drawing.Point(618, 135);
            this.buttonMocnina.Name = "buttonMocnina";
            this.buttonMocnina.Size = new System.Drawing.Size(114, 56);
            this.buttonMocnina.TabIndex = 2;
            this.buttonMocnina.Text = "mocnina";
            this.buttonMocnina.UseVisualStyleBackColor = true;
            this.buttonMocnina.Click += new System.EventHandler(this.buttonMocnina_Click);
            // 
            // buttonOdmocnina
            // 
            this.buttonOdmocnina.Location = new System.Drawing.Point(618, 229);
            this.buttonOdmocnina.Name = "buttonOdmocnina";
            this.buttonOdmocnina.Size = new System.Drawing.Size(114, 56);
            this.buttonOdmocnina.TabIndex = 3;
            this.buttonOdmocnina.Text = "odmocnina";
            this.buttonOdmocnina.UseVisualStyleBackColor = true;
            // 
            // buttonNasobeni
            // 
            this.buttonNasobeni.Location = new System.Drawing.Point(516, 135);
            this.buttonNasobeni.Name = "buttonNasobeni";
            this.buttonNasobeni.Size = new System.Drawing.Size(59, 56);
            this.buttonNasobeni.TabIndex = 4;
            this.buttonNasobeni.Text = "*";
            this.buttonNasobeni.UseVisualStyleBackColor = true;
            this.buttonNasobeni.Click += new System.EventHandler(this.buttonNasobeni_Click);
            // 
            // buttonOdcitani
            // 
            this.buttonOdcitani.Location = new System.Drawing.Point(415, 229);
            this.buttonOdcitani.Name = "buttonOdcitani";
            this.buttonOdcitani.Size = new System.Drawing.Size(59, 56);
            this.buttonOdcitani.TabIndex = 5;
            this.buttonOdcitani.Text = "-";
            this.buttonOdcitani.UseVisualStyleBackColor = true;
            this.buttonOdcitani.Click += new System.EventHandler(this.buttonOdcitani_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 31);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 31);
            this.textBox2.TabIndex = 7;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(203, 242);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(103, 31);
            this.textBoxResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "První číslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Druhé číslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Výsledek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOdcitani);
            this.Controls.Add(this.buttonNasobeni);
            this.Controls.Add(this.buttonOdmocnina);
            this.Controls.Add(this.buttonMocnina);
            this.Controls.Add(this.buttonDeleni);
            this.Controls.Add(this.buttonScitani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonScitani;
        private Button buttonDeleni;
        private Button buttonMocnina;
        private Button buttonOdmocnina;
        private Button buttonNasobeni;
        private Button buttonOdcitani;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}