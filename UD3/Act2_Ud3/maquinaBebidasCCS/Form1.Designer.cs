namespace maquinaBebidasCCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            imagen1 = new PictureBox();
            labelPrecio1 = new Label();
            txtStock1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            labelPrecio2 = new Label();
            imagen2 = new PictureBox();
            txtStock2 = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            labelPrecio4 = new Label();
            imagen4 = new PictureBox();
            txtStock4 = new TextBox();
            panel4 = new Panel();
            label6 = new Label();
            labelPrecio3 = new Label();
            imagen3 = new PictureBox();
            txtStock3 = new TextBox();
            panel5 = new Panel();
            label8 = new Label();
            labelPrecio5 = new Label();
            imagen5 = new PictureBox();
            txtStock5 = new TextBox();
            panel6 = new Panel();
            label11 = new Label();
            txtTotal = new TextBox();
            label10 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen5).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Location = new Point(37, 404);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(426, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(207, 34);
            button1.TabIndex = 0;
            button1.Text = "Nuevo cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(216, 3);
            button2.Name = "button2";
            button2.Size = new Size(207, 34);
            button2.TabIndex = 1;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imagen1
            // 
            imagen1.BackColor = Color.White;
            imagen1.Cursor = Cursors.Hand;
            imagen1.Image = (Image)resources.GetObject("imagen1.Image");
            imagen1.Location = new Point(3, 3);
            imagen1.Name = "imagen1";
            imagen1.Size = new Size(96, 99);
            imagen1.SizeMode = PictureBoxSizeMode.Zoom;
            imagen1.TabIndex = 2;
            imagen1.TabStop = false;
            imagen1.Click += imagen1_Click;
            // 
            // labelPrecio1
            // 
            labelPrecio1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio1.Location = new Point(105, 19);
            labelPrecio1.Name = "labelPrecio1";
            labelPrecio1.Size = new Size(100, 23);
            labelPrecio1.TabIndex = 3;
            labelPrecio1.Text = "1.00€";
            labelPrecio1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStock1
            // 
            txtStock1.Location = new Point(105, 79);
            txtStock1.Name = "txtStock1";
            txtStock1.ReadOnly = true;
            txtStock1.Size = new Size(100, 23);
            txtStock1.TabIndex = 4;
            txtStock1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Location = new Point(105, 53);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "Quedan";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelPrecio1);
            panel1.Controls.Add(imagen1);
            panel1.Controls.Add(txtStock1);
            panel1.Location = new Point(37, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 107);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(labelPrecio2);
            panel2.Controls.Add(imagen2);
            panel2.Controls.Add(txtStock2);
            panel2.Location = new Point(253, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 107);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(105, 53);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Quedan";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelPrecio2
            // 
            labelPrecio2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio2.Location = new Point(105, 19);
            labelPrecio2.Name = "labelPrecio2";
            labelPrecio2.Size = new Size(100, 23);
            labelPrecio2.TabIndex = 3;
            labelPrecio2.Text = "1.00€";
            labelPrecio2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imagen2
            // 
            imagen2.BackColor = Color.White;
            imagen2.Cursor = Cursors.Hand;
            imagen2.Image = Properties.Resources.aquarius;
            imagen2.Location = new Point(3, 3);
            imagen2.Name = "imagen2";
            imagen2.Size = new Size(96, 99);
            imagen2.SizeMode = PictureBoxSizeMode.Zoom;
            imagen2.TabIndex = 2;
            imagen2.TabStop = false;
            imagen2.Click += imagen2_Click;
            // 
            // txtStock2
            // 
            txtStock2.Location = new Point(105, 79);
            txtStock2.Name = "txtStock2";
            txtStock2.ReadOnly = true;
            txtStock2.Size = new Size(100, 23);
            txtStock2.TabIndex = 4;
            txtStock2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(labelPrecio4);
            panel3.Controls.Add(imagen4);
            panel3.Controls.Add(txtStock4);
            panel3.Location = new Point(253, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 107);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.Location = new Point(105, 53);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 5;
            label4.Text = "Quedan";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelPrecio4
            // 
            labelPrecio4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio4.Location = new Point(105, 19);
            labelPrecio4.Name = "labelPrecio4";
            labelPrecio4.Size = new Size(100, 23);
            labelPrecio4.TabIndex = 3;
            labelPrecio4.Text = "0.50€";
            labelPrecio4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imagen4
            // 
            imagen4.BackColor = Color.White;
            imagen4.Cursor = Cursors.Hand;
            imagen4.Image = Properties.Resources.agua;
            imagen4.Location = new Point(3, 3);
            imagen4.Name = "imagen4";
            imagen4.Size = new Size(96, 99);
            imagen4.SizeMode = PictureBoxSizeMode.Zoom;
            imagen4.TabIndex = 2;
            imagen4.TabStop = false;
            imagen4.Click += imagen4_Click;
            // 
            // txtStock4
            // 
            txtStock4.Location = new Point(105, 79);
            txtStock4.Name = "txtStock4";
            txtStock4.ReadOnly = true;
            txtStock4.Size = new Size(100, 23);
            txtStock4.TabIndex = 4;
            txtStock4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(labelPrecio3);
            panel4.Controls.Add(imagen3);
            panel4.Controls.Add(txtStock3);
            panel4.Location = new Point(37, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 107);
            panel4.TabIndex = 8;
            // 
            // label6
            // 
            label6.Location = new Point(105, 53);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Quedan";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelPrecio3
            // 
            labelPrecio3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio3.Location = new Point(105, 19);
            labelPrecio3.Name = "labelPrecio3";
            labelPrecio3.Size = new Size(100, 23);
            labelPrecio3.TabIndex = 3;
            labelPrecio3.Text = "1.75€";
            labelPrecio3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imagen3
            // 
            imagen3.BackColor = Color.White;
            imagen3.Cursor = Cursors.Hand;
            imagen3.Image = Properties.Resources.heineken;
            imagen3.Location = new Point(3, 3);
            imagen3.Name = "imagen3";
            imagen3.Size = new Size(96, 99);
            imagen3.SizeMode = PictureBoxSizeMode.Zoom;
            imagen3.TabIndex = 2;
            imagen3.TabStop = false;
            imagen3.Click += imagen3_Click;
            // 
            // txtStock3
            // 
            txtStock3.Location = new Point(105, 79);
            txtStock3.Name = "txtStock3";
            txtStock3.ReadOnly = true;
            txtStock3.Size = new Size(100, 23);
            txtStock3.TabIndex = 4;
            txtStock3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.Controls.Add(label8);
            panel5.Controls.Add(labelPrecio5);
            panel5.Controls.Add(imagen5);
            panel5.Controls.Add(txtStock5);
            panel5.Location = new Point(37, 280);
            panel5.Name = "panel5";
            panel5.Size = new Size(210, 107);
            panel5.TabIndex = 10;
            // 
            // label8
            // 
            label8.Location = new Point(105, 53);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 5;
            label8.Text = "Quedan";
            label8.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelPrecio5
            // 
            labelPrecio5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio5.Location = new Point(105, 19);
            labelPrecio5.Name = "labelPrecio5";
            labelPrecio5.Size = new Size(100, 23);
            labelPrecio5.TabIndex = 3;
            labelPrecio5.Text = "1.00€";
            labelPrecio5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imagen5
            // 
            imagen5.BackColor = Color.White;
            imagen5.Cursor = Cursors.Hand;
            imagen5.Image = Properties.Resources.fanta;
            imagen5.Location = new Point(3, 3);
            imagen5.Name = "imagen5";
            imagen5.Size = new Size(96, 99);
            imagen5.SizeMode = PictureBoxSizeMode.Zoom;
            imagen5.TabIndex = 2;
            imagen5.TabStop = false;
            imagen5.Click += imagen5_Click;
            // 
            // txtStock5
            // 
            txtStock5.Location = new Point(105, 79);
            txtStock5.Name = "txtStock5";
            txtStock5.ReadOnly = true;
            txtStock5.Size = new Size(100, 23);
            txtStock5.TabIndex = 4;
            txtStock5.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.Controls.Add(label11);
            panel6.Controls.Add(txtTotal);
            panel6.Location = new Point(253, 280);
            panel6.Name = "panel6";
            panel6.Size = new Size(210, 107);
            panel6.TabIndex = 11;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 19);
            label11.Name = "label11";
            label11.Size = new Size(204, 23);
            label11.TabIndex = 3;
            label11.Text = "Total a pagar";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Location = new Point(48, 53);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(109, 23);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(37, 9);
            label10.Name = "label10";
            label10.Size = new Size(426, 42);
            label10.TabIndex = 12;
            label10.Text = "Selecciona la bebida";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 468);
            Controls.Add(label10);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagen1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox imagen1;
        private Label labelPrecio1;
        private Button button1;
        private Button button2;
        private TextBox txtStock1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label labelPrecio2;
        private PictureBox imagen2;
        private TextBox txtStock2;
        private Panel panel3;
        private Label label4;
        private Label labelPrecio4;
        private PictureBox imagen4;
        private TextBox txtStock4;
        private Panel panel4;
        private Label label6;
        private Label labelPrecio3;
        private PictureBox imagen3;
        private TextBox txtStock3;
        private Panel panel5;
        private Label label8;
        private Label labelPrecio5;
        private PictureBox imagen5;
        private TextBox txtStock5;
        private Panel panel6;
        private Label label11;
        private TextBox txtTotal;
        private Label label10;
    }
}
