namespace Practica18_vs
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Location = new Point(146, 27);
            label1.Name = "label1";
            label1.Size = new Size(468, 15);
            label1.TabIndex = 0;
            label1.Text = "Diagrama que pida los 3 lados de un triangulo y diga si es equilatiro, isoceles o escaleno";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(228, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 68);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(576, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 243);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 159);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "Longitud lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 202);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Longitud lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 243);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 5;
            label4.Text = "Longitud lado C";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(140, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Decision";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 295);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(391, 295);
            button3.Name = "button3";
            button3.Size = new Size(76, 23);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 360);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 12;
            label5.Text = "Tipo Triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 352);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
    }
}