namespace ejercicio1
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
            titulo = new Label();
            label1 = new Label();
            boton1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.DarkCyan;
            titulo.Location = new Point(19, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(566, 45);
            titulo.TabIndex = 0;
            titulo.Text = "CONVERSOR DE GRADOS A FAHRENHEIT";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 79);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduce los grados para convertir";
            label1.Click += label2_Click;
            // 
            // boton1
            // 
            boton1.Location = new Point(228, 114);
            boton1.Name = "boton1";
            boton1.Size = new Size(100, 22);
            boton1.TabIndex = 2;
            boton1.Text = "Convertir";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 79);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(boton1);
            Controls.Add(label1);
            Controls.Add(titulo);
            Name = "Form1";
            Text = "Conversor grados celsius a Fahrenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label label1;
        private Button boton1;
        private TextBox textBox1;
        private Label label2;
    }
}
