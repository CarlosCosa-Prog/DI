namespace ejercicio2
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
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            panelSubCompras = new Panel();
            botoSubCompras3 = new Button();
            botoSubCompras2 = new Button();
            botoSubCompras1 = new Button();
            panelCompras = new Panel();
            botoCompras = new Button();
            panelSubClientes = new Panel();
            botoSubClientes4 = new Button();
            botoSubClientes3 = new Button();
            botoSubClientes2 = new Button();
            botoSubClientes1 = new Button();
            panelClientes = new Panel();
            botoClientes = new Button();
            panelSubProductes = new Panel();
            botoSubProductes3 = new Button();
            botoSubProductes2 = new Button();
            botoSubProductes1 = new Button();
            panelProductes = new Panel();
            botoProductes = new Button();
            panelContenidor = new Panel();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
            panelSubCompras.SuspendLayout();
            panelCompras.SuspendLayout();
            panelSubClientes.SuspendLayout();
            panelClientes.SuspendLayout();
            panelSubProductes.SuspendLayout();
            panelProductes.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 123);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoScroll = true;
            panelPrincipal.BackColor = Color.Teal;
            panelPrincipal.Controls.Add(panelSubCompras);
            panelPrincipal.Controls.Add(panelCompras);
            panelPrincipal.Controls.Add(panelSubClientes);
            panelPrincipal.Controls.Add(panelClientes);
            panelPrincipal.Controls.Add(panelSubProductes);
            panelPrincipal.Controls.Add(panelProductes);
            panelPrincipal.Controls.Add(panelLogo);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(250, 680);
            panelPrincipal.TabIndex = 1;
            // 
            // panelSubCompras
            // 
            panelSubCompras.BackColor = Color.LightSeaGreen;
            panelSubCompras.Controls.Add(botoSubCompras3);
            panelSubCompras.Controls.Add(botoSubCompras2);
            panelSubCompras.Controls.Add(botoSubCompras1);
            panelSubCompras.Dock = DockStyle.Top;
            panelSubCompras.Location = new Point(0, 566);
            panelSubCompras.Name = "panelSubCompras";
            panelSubCompras.Size = new Size(233, 132);
            panelSubCompras.TabIndex = 7;
            // 
            // botoSubCompras3
            // 
            botoSubCompras3.Dock = DockStyle.Top;
            botoSubCompras3.FlatAppearance.BorderSize = 0;
            botoSubCompras3.FlatStyle = FlatStyle.Flat;
            botoSubCompras3.ForeColor = Color.AntiqueWhite;
            botoSubCompras3.Location = new Point(0, 88);
            botoSubCompras3.Name = "botoSubCompras3";
            botoSubCompras3.Padding = new Padding(35, 0, 0, 0);
            botoSubCompras3.Size = new Size(233, 44);
            botoSubCompras3.TabIndex = 2;
            botoSubCompras3.Text = "Proveedores";
            botoSubCompras3.TextAlign = ContentAlignment.MiddleLeft;
            botoSubCompras3.UseVisualStyleBackColor = true;
            // 
            // botoSubCompras2
            // 
            botoSubCompras2.Dock = DockStyle.Top;
            botoSubCompras2.FlatAppearance.BorderSize = 0;
            botoSubCompras2.FlatStyle = FlatStyle.Flat;
            botoSubCompras2.ForeColor = Color.AntiqueWhite;
            botoSubCompras2.Location = new Point(0, 44);
            botoSubCompras2.Name = "botoSubCompras2";
            botoSubCompras2.Padding = new Padding(35, 0, 0, 0);
            botoSubCompras2.Size = new Size(233, 44);
            botoSubCompras2.TabIndex = 1;
            botoSubCompras2.Text = "Facturación";
            botoSubCompras2.TextAlign = ContentAlignment.MiddleLeft;
            botoSubCompras2.UseVisualStyleBackColor = true;
            // 
            // botoSubCompras1
            // 
            botoSubCompras1.Dock = DockStyle.Top;
            botoSubCompras1.FlatAppearance.BorderSize = 0;
            botoSubCompras1.FlatStyle = FlatStyle.Flat;
            botoSubCompras1.ForeColor = Color.AntiqueWhite;
            botoSubCompras1.Location = new Point(0, 0);
            botoSubCompras1.Name = "botoSubCompras1";
            botoSubCompras1.Padding = new Padding(35, 0, 0, 0);
            botoSubCompras1.Size = new Size(233, 44);
            botoSubCompras1.TabIndex = 0;
            botoSubCompras1.Text = "Informes de compras";
            botoSubCompras1.TextAlign = ContentAlignment.MiddleLeft;
            botoSubCompras1.UseVisualStyleBackColor = true;
            // 
            // panelCompras
            // 
            panelCompras.BackColor = Color.Teal;
            panelCompras.Controls.Add(botoCompras);
            panelCompras.Dock = DockStyle.Top;
            panelCompras.Location = new Point(0, 521);
            panelCompras.Name = "panelCompras";
            panelCompras.Size = new Size(233, 45);
            panelCompras.TabIndex = 8;
            // 
            // botoCompras
            // 
            botoCompras.Dock = DockStyle.Top;
            botoCompras.FlatAppearance.BorderSize = 0;
            botoCompras.FlatStyle = FlatStyle.Flat;
            botoCompras.ForeColor = Color.AntiqueWhite;
            botoCompras.Location = new Point(0, 0);
            botoCompras.Name = "botoCompras";
            botoCompras.Padding = new Padding(10, 0, 0, 0);
            botoCompras.Size = new Size(233, 45);
            botoCompras.TabIndex = 0;
            botoCompras.Text = "Compras";
            botoCompras.TextAlign = ContentAlignment.MiddleLeft;
            botoCompras.UseVisualStyleBackColor = true;
            botoCompras.Click += botoCompras_Click;
            // 
            // panelSubClientes
            // 
            panelSubClientes.BackColor = Color.LightSeaGreen;
            panelSubClientes.Controls.Add(botoSubClientes4);
            panelSubClientes.Controls.Add(botoSubClientes3);
            panelSubClientes.Controls.Add(botoSubClientes2);
            panelSubClientes.Controls.Add(botoSubClientes1);
            panelSubClientes.Dock = DockStyle.Top;
            panelSubClientes.Location = new Point(0, 345);
            panelSubClientes.Name = "panelSubClientes";
            panelSubClientes.Size = new Size(233, 176);
            panelSubClientes.TabIndex = 5;
            // 
            // botoSubClientes4
            // 
            botoSubClientes4.Dock = DockStyle.Top;
            botoSubClientes4.FlatAppearance.BorderSize = 0;
            botoSubClientes4.FlatStyle = FlatStyle.Flat;
            botoSubClientes4.ForeColor = Color.AntiqueWhite;
            botoSubClientes4.Location = new Point(0, 132);
            botoSubClientes4.Name = "botoSubClientes4";
            botoSubClientes4.Padding = new Padding(35, 0, 0, 0);
            botoSubClientes4.Size = new Size(233, 44);
            botoSubClientes4.TabIndex = 3;
            botoSubClientes4.Text = "Listado Clientes API";
            botoSubClientes4.TextAlign = ContentAlignment.MiddleLeft;
            botoSubClientes4.UseVisualStyleBackColor = true;
            botoSubClientes4.Click += botoSubClientes4_Click;
            // 
            // botoSubClientes3
            // 
            botoSubClientes3.Dock = DockStyle.Top;
            botoSubClientes3.FlatAppearance.BorderSize = 0;
            botoSubClientes3.FlatStyle = FlatStyle.Flat;
            botoSubClientes3.ForeColor = Color.AntiqueWhite;
            botoSubClientes3.Location = new Point(0, 88);
            botoSubClientes3.Name = "botoSubClientes3";
            botoSubClientes3.Padding = new Padding(35, 0, 0, 0);
            botoSubClientes3.Size = new Size(233, 44);
            botoSubClientes3.TabIndex = 2;
            botoSubClientes3.Text = "Buscar clientes";
            botoSubClientes3.TextAlign = ContentAlignment.MiddleLeft;
            botoSubClientes3.UseVisualStyleBackColor = true;
            // 
            // botoSubClientes2
            // 
            botoSubClientes2.Dock = DockStyle.Top;
            botoSubClientes2.FlatAppearance.BorderSize = 0;
            botoSubClientes2.FlatStyle = FlatStyle.Flat;
            botoSubClientes2.ForeColor = Color.AntiqueWhite;
            botoSubClientes2.Location = new Point(0, 44);
            botoSubClientes2.Name = "botoSubClientes2";
            botoSubClientes2.Padding = new Padding(35, 0, 0, 0);
            botoSubClientes2.Size = new Size(233, 44);
            botoSubClientes2.TabIndex = 1;
            botoSubClientes2.Text = "Insertar clientes";
            botoSubClientes2.TextAlign = ContentAlignment.MiddleLeft;
            botoSubClientes2.UseVisualStyleBackColor = true;
            // 
            // botoSubClientes1
            // 
            botoSubClientes1.Dock = DockStyle.Top;
            botoSubClientes1.FlatAppearance.BorderSize = 0;
            botoSubClientes1.FlatStyle = FlatStyle.Flat;
            botoSubClientes1.ForeColor = Color.AntiqueWhite;
            botoSubClientes1.Location = new Point(0, 0);
            botoSubClientes1.Name = "botoSubClientes1";
            botoSubClientes1.Padding = new Padding(35, 0, 0, 0);
            botoSubClientes1.Size = new Size(233, 44);
            botoSubClientes1.TabIndex = 0;
            botoSubClientes1.Text = "Listado Clientes";
            botoSubClientes1.TextAlign = ContentAlignment.MiddleLeft;
            botoSubClientes1.UseVisualStyleBackColor = true;
            botoSubClientes1.Click += botoSubClientes1_Click;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.Teal;
            panelClientes.Controls.Add(botoClientes);
            panelClientes.Dock = DockStyle.Top;
            panelClientes.Location = new Point(0, 300);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(233, 45);
            panelClientes.TabIndex = 6;
            // 
            // botoClientes
            // 
            botoClientes.Dock = DockStyle.Top;
            botoClientes.FlatAppearance.BorderSize = 0;
            botoClientes.FlatStyle = FlatStyle.Flat;
            botoClientes.ForeColor = Color.AntiqueWhite;
            botoClientes.Location = new Point(0, 0);
            botoClientes.Name = "botoClientes";
            botoClientes.Padding = new Padding(10, 0, 0, 0);
            botoClientes.Size = new Size(233, 45);
            botoClientes.TabIndex = 0;
            botoClientes.Text = "Clientes";
            botoClientes.TextAlign = ContentAlignment.MiddleLeft;
            botoClientes.UseVisualStyleBackColor = true;
            botoClientes.Click += botoClientes_Click;
            // 
            // panelSubProductes
            // 
            panelSubProductes.BackColor = Color.LightSeaGreen;
            panelSubProductes.Controls.Add(botoSubProductes3);
            panelSubProductes.Controls.Add(botoSubProductes2);
            panelSubProductes.Controls.Add(botoSubProductes1);
            panelSubProductes.Dock = DockStyle.Top;
            panelSubProductes.Location = new Point(0, 168);
            panelSubProductes.Name = "panelSubProductes";
            panelSubProductes.Size = new Size(233, 132);
            panelSubProductes.TabIndex = 2;
            // 
            // botoSubProductes3
            // 
            botoSubProductes3.Dock = DockStyle.Top;
            botoSubProductes3.FlatAppearance.BorderSize = 0;
            botoSubProductes3.FlatStyle = FlatStyle.Flat;
            botoSubProductes3.ForeColor = Color.AntiqueWhite;
            botoSubProductes3.Location = new Point(0, 88);
            botoSubProductes3.Name = "botoSubProductes3";
            botoSubProductes3.Padding = new Padding(35, 0, 0, 0);
            botoSubProductes3.Size = new Size(233, 44);
            botoSubProductes3.TabIndex = 2;
            botoSubProductes3.Text = "Productes Z";
            botoSubProductes3.TextAlign = ContentAlignment.MiddleLeft;
            botoSubProductes3.UseVisualStyleBackColor = true;
            // 
            // botoSubProductes2
            // 
            botoSubProductes2.Dock = DockStyle.Top;
            botoSubProductes2.FlatAppearance.BorderSize = 0;
            botoSubProductes2.FlatStyle = FlatStyle.Flat;
            botoSubProductes2.ForeColor = Color.AntiqueWhite;
            botoSubProductes2.Location = new Point(0, 44);
            botoSubProductes2.Name = "botoSubProductes2";
            botoSubProductes2.Padding = new Padding(35, 0, 0, 0);
            botoSubProductes2.Size = new Size(233, 44);
            botoSubProductes2.TabIndex = 1;
            botoSubProductes2.Text = "Productes Y";
            botoSubProductes2.TextAlign = ContentAlignment.MiddleLeft;
            botoSubProductes2.UseVisualStyleBackColor = true;
            // 
            // botoSubProductes1
            // 
            botoSubProductes1.Dock = DockStyle.Top;
            botoSubProductes1.FlatAppearance.BorderSize = 0;
            botoSubProductes1.FlatStyle = FlatStyle.Flat;
            botoSubProductes1.ForeColor = Color.AntiqueWhite;
            botoSubProductes1.Location = new Point(0, 0);
            botoSubProductes1.Name = "botoSubProductes1";
            botoSubProductes1.Padding = new Padding(35, 0, 0, 0);
            botoSubProductes1.Size = new Size(233, 44);
            botoSubProductes1.TabIndex = 0;
            botoSubProductes1.Text = "Productes X";
            botoSubProductes1.TextAlign = ContentAlignment.MiddleLeft;
            botoSubProductes1.UseVisualStyleBackColor = true;
            // 
            // panelProductes
            // 
            panelProductes.BackColor = Color.Teal;
            panelProductes.Controls.Add(botoProductes);
            panelProductes.Dock = DockStyle.Top;
            panelProductes.Location = new Point(0, 123);
            panelProductes.Name = "panelProductes";
            panelProductes.Size = new Size(233, 45);
            panelProductes.TabIndex = 2;
            // 
            // botoProductes
            // 
            botoProductes.Dock = DockStyle.Top;
            botoProductes.FlatAppearance.BorderSize = 0;
            botoProductes.FlatStyle = FlatStyle.Flat;
            botoProductes.ForeColor = Color.AntiqueWhite;
            botoProductes.Location = new Point(0, 0);
            botoProductes.Name = "botoProductes";
            botoProductes.Padding = new Padding(10, 0, 0, 0);
            botoProductes.Size = new Size(233, 45);
            botoProductes.TabIndex = 0;
            botoProductes.Text = "Productes";
            botoProductes.TextAlign = ContentAlignment.MiddleLeft;
            botoProductes.UseVisualStyleBackColor = true;
            botoProductes.Click += botoProductes_Click;
            // 
            // panelContenidor
            // 
            panelContenidor.BackColor = Color.MediumTurquoise;
            panelContenidor.Dock = DockStyle.Fill;
            panelContenidor.Location = new Point(250, 0);
            panelContenidor.Name = "panelContenidor";
            panelContenidor.Size = new Size(708, 680);
            panelContenidor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 680);
            Controls.Add(panelContenidor);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "FormEmpresa";
            Load += Form1_Load;
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelSubCompras.ResumeLayout(false);
            panelCompras.ResumeLayout(false);
            panelSubClientes.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelSubProductes.ResumeLayout(false);
            panelProductes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panelPrincipal;
        private PictureBox pictureBox1;
        private Panel panelProductes;
        private Button botoProductes;
        private Panel panelSubProductes;
        private Button botoSubProductes3;
        private Button botoSubProductes2;
        private Button botoSubProductes1;
        private Panel panelSubCompras;
        private Button botoSubCompras3;
        private Button botoSubCompras2;
        private Button botoSubCompras1;
        private Panel panelCompras;
        private Button botoCompras;
        private Panel panelSubClientes;
        private Button botoSubClientes3;
        private Button botoSubClientes2;
        private Button botoSubClientes1;
        private Panel panelClientes;
        private Button botoClientes;
        private Panel panelContenidor;
        private Button botoSubClientes4;
    }
}
