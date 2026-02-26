namespace Apartado2
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
            dataGridView = new DataGridView();
            boton1 = new Button();
            boton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 104);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(776, 297);
            dataGridView.TabIndex = 0;
            // 
            // boton1
            // 
            boton1.Location = new Point(12, 48);
            boton1.Name = "boton1";
            boton1.Size = new Size(248, 29);
            boton1.TabIndex = 1;
            boton1.Text = "Generar PDF 1";
            boton1.UseVisualStyleBackColor = true;
            // 
            // boton2
            // 
            boton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boton2.Location = new Point(540, 48);
            boton2.Name = "boton2";
            boton2.Size = new Size(248, 29);
            boton2.TabIndex = 2;
            boton2.Text = "Generar PDF 2";
            boton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton2);
            Controls.Add(boton1);
            Controls.Add(dataGridView);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button boton1;
        private Button boton2;
    }
}
