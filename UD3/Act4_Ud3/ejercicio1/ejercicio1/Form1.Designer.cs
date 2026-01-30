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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButtonInsertar = new ToolStripButton();
            toolStripButtonListar = new ToolStripButton();
            toolStripButtonBuscar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonInsertar, toolStripButtonListar, toolStripButtonBuscar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.MinimumSize = new Size(800, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 40);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInsertar
            // 
            toolStripButtonInsertar.AutoSize = false;
            toolStripButtonInsertar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonInsertar.Image = (Image)resources.GetObject("toolStripButtonInsertar.Image");
            toolStripButtonInsertar.ImageTransparentColor = Color.Magenta;
            toolStripButtonInsertar.Margin = new Padding(0);
            toolStripButtonInsertar.Name = "toolStripButtonInsertar";
            toolStripButtonInsertar.Size = new Size(50, 50);
            toolStripButtonInsertar.Text = "toolStripButton1";
            toolStripButtonInsertar.Click += toolStripButtonInsertar_Click;
            // 
            // toolStripButtonListar
            // 
            toolStripButtonListar.AutoSize = false;
            toolStripButtonListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonListar.Image = (Image)resources.GetObject("toolStripButtonListar.Image");
            toolStripButtonListar.ImageTransparentColor = Color.Magenta;
            toolStripButtonListar.Name = "toolStripButtonListar";
            toolStripButtonListar.Size = new Size(50, 50);
            toolStripButtonListar.Text = "toolStripButton2";
            toolStripButtonListar.Click += toolStripButtonListar_Click;
            // 
            // toolStripButtonBuscar
            // 
            toolStripButtonBuscar.AutoSize = false;
            toolStripButtonBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonBuscar.Image = (Image)resources.GetObject("toolStripButtonBuscar.Image");
            toolStripButtonBuscar.ImageTransparentColor = Color.Magenta;
            toolStripButtonBuscar.Name = "toolStripButtonBuscar";
            toolStripButtonBuscar.Size = new Size(50, 50);
            toolStripButtonBuscar.Text = "toolStripButton3";
            toolStripButtonBuscar.Click += toolStripButtonBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonInsertar;
        private ToolStripButton toolStripButtonListar;
        private ToolStripButton toolStripButtonBuscar;
    }
}
