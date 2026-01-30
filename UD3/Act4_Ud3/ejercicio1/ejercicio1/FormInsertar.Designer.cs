namespace ejercicio1
{
    partial class FormInsertar
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
            groupBox1 = new GroupBox();
            buttonInsertar = new Button();
            textBoxTelefono = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonInsertar);
            groupBox1.Controls.Add(textBoxTelefono);
            groupBox1.Controls.Add(textBoxApellidos);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // buttonInsertar
            // 
            buttonInsertar.Location = new Point(6, 189);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(209, 23);
            buttonInsertar.TabIndex = 6;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(115, 140);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(100, 23);
            textBoxTelefono.TabIndex = 5;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(115, 88);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(100, 23);
            textBoxApellidos.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(115, 41);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 138);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // FormInsertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 365);
            Controls.Add(groupBox1);
            Name = "FormInsertar";
            Text = "FormInsertar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button buttonInsertar;
        private TextBox textBoxTelefono;
        private TextBox textBoxApellidos;
        private TextBox textBoxNombre;
        private Label label3;
    }
}