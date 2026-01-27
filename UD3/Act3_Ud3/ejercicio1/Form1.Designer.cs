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
            comboBox = new ComboBox();
            dataGridView = new DataGridView();
            botonListadoClientes = new Button();
            botonCargarClientes = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(146, 65);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(164, 23);
            comboBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(340, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(479, 237);
            dataGridView.TabIndex = 1;
            // 
            // botonListadoClientes
            // 
            botonListadoClientes.Location = new Point(16, 65);
            botonListadoClientes.Name = "botonListadoClientes";
            botonListadoClientes.Size = new Size(114, 24);
            botonListadoClientes.TabIndex = 2;
            botonListadoClientes.Text = "Listado Clientes";
            botonListadoClientes.UseVisualStyleBackColor = true;
            botonListadoClientes.Click += botonListadoClientes_Click;
            // 
            // botonCargarClientes
            // 
            botonCargarClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botonCargarClientes.Location = new Point(414, 296);
            botonCargarClientes.Name = "botonCargarClientes";
            botonCargarClientes.Size = new Size(323, 33);
            botonCargarClientes.TabIndex = 3;
            botonCargarClientes.Text = "Cargar Clientes";
            botonCargarClientes.UseVisualStyleBackColor = true;
            botonCargarClientes.Click += botonCargarClientes_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(397, 41);
            label1.TabIndex = 4;
            label1.Text = "Clientes";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 374);
            Controls.Add(label1);
            Controls.Add(botonCargarClientes);
            Controls.Add(botonListadoClientes);
            Controls.Add(dataGridView);
            Controls.Add(comboBox);
            MinimumSize = new Size(890, 413);
            Name = "Form1";
            Text = "Listado Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox;
        private DataGridView dataGridView;
        private Button botonListadoClientes;
        private Button botonCargarClientes;
        private Label label1;
    }
}
