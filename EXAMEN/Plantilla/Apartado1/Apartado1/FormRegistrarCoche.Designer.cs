namespace Apartado1
{
    partial class FormRegistrarCoche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label8 = new Label();
            groupBox1 = new GroupBox();
            botonInsertar = new Button();
            textChasis = new TextBox();
            label7 = new Label();
            textAño = new TextBox();
            label6 = new Label();
            textModelo = new TextBox();
            label5 = new Label();
            textMarca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 450);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(12, 24);
            label8.Name = "label8";
            label8.Size = new Size(271, 45);
            label8.TabIndex = 2;
            label8.Text = "Insertar un nuevo coche";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(botonInsertar);
            groupBox1.Controls.Add(textChasis);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textAño);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textModelo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textMarca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 301);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Coche";
            // 
            // botonInsertar
            // 
            botonInsertar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            botonInsertar.Location = new Point(106, 191);
            botonInsertar.Name = "botonInsertar";
            botonInsertar.Size = new Size(93, 23);
            botonInsertar.TabIndex = 11;
            botonInsertar.Text = "Insertar";
            botonInsertar.UseVisualStyleBackColor = true;
            // 
            // textChasis
            // 
            textChasis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textChasis.Location = new Point(106, 148);
            textChasis.Name = "textChasis";
            textChasis.Size = new Size(93, 23);
            textChasis.TabIndex = 10;
            // 
            // label7
            // 
            label7.Location = new Point(6, 148);
            label7.Name = "label7";
            label7.Padding = new Padding(8, 0, 0, 0);
            label7.Size = new Size(94, 23);
            label7.TabIndex = 9;
            label7.Text = "Nº Chasis:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textAño
            // 
            textAño.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textAño.Location = new Point(106, 106);
            textAño.Name = "textAño";
            textAño.Size = new Size(93, 23);
            textAño.TabIndex = 8;
            // 
            // label6
            // 
            label6.Location = new Point(6, 106);
            label6.Name = "label6";
            label6.Padding = new Padding(8, 0, 0, 0);
            label6.Size = new Size(94, 23);
            label6.TabIndex = 7;
            label6.Text = "Año:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textModelo
            // 
            textModelo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textModelo.Location = new Point(106, 71);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(93, 23);
            textModelo.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Padding = new Padding(8, 0, 0, 0);
            label5.Size = new Size(94, 23);
            label5.TabIndex = 5;
            label5.Text = "Modelo:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textMarca
            // 
            textMarca.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textMarca.Location = new Point(106, 32);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(93, 23);
            textMarca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 179);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Padding = new Padding(8, 0, 0, 0);
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormRegistrarCoche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 450);
            Controls.Add(panel1);
            MinimumSize = new Size(311, 489);
            Name = "FormRegistrarCoche";
            Text = "FormRegistrarCoche";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textMarca;
        private Button botonInsertar;
        private TextBox textChasis;
        private Label label7;
        private TextBox textAño;
        private Label label6;
        private TextBox textModelo;
        private Label label5;
        private Label label8;
    }
}