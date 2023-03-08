namespace PAINT
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPapel = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chBox1 = new System.Windows.Forms.CheckBox();
            this.chBox2 = new System.Windows.Forms.CheckBox();
            this.chBox3 = new System.Windows.Forms.CheckBox();
            this.chBox4 = new System.Windows.Forms.CheckBox();
            this.chBox5 = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBorra = new System.Windows.Forms.Button();
            this.chB6 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chBoxReal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPapel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox2.Location = new System.Drawing.Point(45, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(169, 12);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(357, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(41, 53);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(31, 26);
            this.txtR.TabIndex = 4;
            this.txtR.Text = "0";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(41, 85);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(31, 26);
            this.txtG.TabIndex = 6;
            this.txtG.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(41, 117);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(31, 26);
            this.txtB.TabIndex = 8;
            this.txtB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // txtPapel
            // 
            this.txtPapel.BackColor = System.Drawing.Color.White;
            this.txtPapel.Location = new System.Drawing.Point(129, 63);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(841, 472);
            this.txtPapel.TabIndex = 9;
            this.txtPapel.TabStop = false;
            this.txtPapel.Paint += new System.Windows.Forms.PaintEventHandler(this.txtPapel_Paint);
            this.txtPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseDown);
            this.txtPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseMove);
            this.txtPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseUp);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(598, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 44);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 194);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 35);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(12, 149);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(89, 39);
            this.btnPintar.TabIndex = 12;
            this.btnPintar.Text = "PINTAR";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // chBox1
            // 
            this.chBox1.AutoSize = true;
            this.chBox1.Location = new System.Drawing.Point(11, 240);
            this.chBox1.Name = "chBox1";
            this.chBox1.Size = new System.Drawing.Size(65, 23);
            this.chBox1.TabIndex = 14;
            this.chBox1.Text = "LINEA";
            this.chBox1.UseVisualStyleBackColor = true;
            // 
            // chBox2
            // 
            this.chBox2.AutoSize = true;
            this.chBox2.Location = new System.Drawing.Point(11, 269);
            this.chBox2.Name = "chBox2";
            this.chBox2.Size = new System.Drawing.Size(68, 23);
            this.chBox2.TabIndex = 15;
            this.chBox2.Text = "ELIPSE";
            this.chBox2.UseVisualStyleBackColor = true;
            // 
            // chBox3
            // 
            this.chBox3.AutoSize = true;
            this.chBox3.Location = new System.Drawing.Point(11, 298);
            this.chBox3.Name = "chBox3";
            this.chBox3.Size = new System.Drawing.Size(114, 23);
            this.chBox3.TabIndex = 16;
            this.chBox3.Text = "ELIPSE LLENO";
            this.chBox3.UseVisualStyleBackColor = true;
            this.chBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chBox4
            // 
            this.chBox4.AutoSize = true;
            this.chBox4.Location = new System.Drawing.Point(11, 327);
            this.chBox4.Name = "chBox4";
            this.chBox4.Size = new System.Drawing.Size(104, 23);
            this.chBox4.TabIndex = 17;
            this.chBox4.Text = "CUADRADO";
            this.chBox4.UseVisualStyleBackColor = true;
            // 
            // chBox5
            // 
            this.chBox5.AutoSize = true;
            this.chBox5.Location = new System.Drawing.Point(11, 356);
            this.chBox5.Name = "chBox5";
            this.chBox5.Size = new System.Drawing.Size(115, 23);
            this.chBox5.TabIndex = 18;
            this.chBox5.Text = "RECTANGULO";
            this.chBox5.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(18, 447);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(89, 35);
            this.btnMostrar.TabIndex = 19;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBorra
            // 
            this.btnBorra.Location = new System.Drawing.Point(18, 488);
            this.btnBorra.Name = "btnBorra";
            this.btnBorra.Size = new System.Drawing.Size(89, 35);
            this.btnBorra.TabIndex = 20;
            this.btnBorra.Text = "BORRAR";
            this.btnBorra.UseVisualStyleBackColor = true;
            this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
            // 
            // chB6
            // 
            this.chB6.AutoSize = true;
            this.chB6.Location = new System.Drawing.Point(12, 387);
            this.chB6.Name = "chB6";
            this.chB6.Size = new System.Drawing.Size(89, 23);
            this.chB6.TabIndex = 21;
            this.chB6.Text = "RANDOM";
            this.chB6.UseVisualStyleBackColor = true;
            // 
            // chBoxReal
            // 
            this.chBoxReal.AutoSize = true;
            this.chBoxReal.Location = new System.Drawing.Point(10, 421);
            this.chBoxReal.Name = "chBoxReal";
            this.chBoxReal.Size = new System.Drawing.Size(113, 23);
            this.chBoxReal.TabIndex = 22;
            this.chBoxReal.Text = "TIEMPO REAL";
            this.chBoxReal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 547);
            this.Controls.Add(this.chBoxReal);
            this.Controls.Add(this.chB6);
            this.Controls.Add(this.btnBorra);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chBox5);
            this.Controls.Add(this.chBox4);
            this.Controls.Add(this.chBox3);
            this.Controls.Add(this.chBox2);
            this.Controls.Add(this.chBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPapel);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TrackBar trackBar1;
        private Label label1;
        private TextBox txtR;
        private TextBox txtG;
        private Label label2;
        private TextBox txtB;
        private Label label3;
        private PictureBox txtPapel;
        private Button btnGuardar;
        private Button btnBorrar;
        private Button btnPintar;
        private Label label4;
        private CheckBox chBox1;
        private CheckBox chBox2;
        private CheckBox chBox3;
        private CheckBox chBox4;
        private CheckBox chBox5;
        private Button btnMostrar;
        private Button btnBorra;
        private CheckBox chB6;
        private ColorDialog colorDialog1;
        private CheckBox chBoxReal;
    }
}