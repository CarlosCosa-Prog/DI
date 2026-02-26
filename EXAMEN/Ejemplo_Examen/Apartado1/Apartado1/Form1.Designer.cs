namespace Apartado1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bindingSource1 = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            registroDeDatosToolStripMenuItem = new ToolStripMenuItem();
            registrarCocheToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            mostrarDatosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroDeDatosToolStripMenuItem, mostrarDatosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(764, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registroDeDatosToolStripMenuItem
            // 
            registroDeDatosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarCocheToolStripMenuItem, registrarClienteToolStripMenuItem });
            registroDeDatosToolStripMenuItem.Name = "registroDeDatosToolStripMenuItem";
            registroDeDatosToolStripMenuItem.Size = new Size(110, 20);
            registroDeDatosToolStripMenuItem.Text = "Registro de datos";
            // 
            // registrarCocheToolStripMenuItem
            // 
            registrarCocheToolStripMenuItem.Name = "registrarCocheToolStripMenuItem";
            registrarCocheToolStripMenuItem.Size = new Size(158, 22);
            registrarCocheToolStripMenuItem.Text = "Registrar coche";
            registrarCocheToolStripMenuItem.Click += registrarCocheToolStripMenuItem_Click;
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(158, 22);
            registrarClienteToolStripMenuItem.Text = "Registrar cliente";
            registrarClienteToolStripMenuItem.Click += registrarClienteToolStripMenuItem_Click;
            // 
            // mostrarDatosToolStripMenuItem
            // 
            mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            mostrarDatosToolStripMenuItem.Size = new Size(92, 20);
            mostrarDatosToolStripMenuItem.Text = "Mostrar datos";
            mostrarDatosToolStripMenuItem.Click += mostrarDatosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 399);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Taller de coches";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registroDeDatosToolStripMenuItem;
        private ToolStripMenuItem registrarCocheToolStripMenuItem;
        private ToolStripMenuItem registrarClienteToolStripMenuItem;
        private ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}
