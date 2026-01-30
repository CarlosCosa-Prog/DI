namespace ejercicio1
{
    partial class FormBuscar
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
            buttonBuscar = new Button();
            textBoxTelefono = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxIdentificador = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxIdentificador);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(textBoxTelefono);
            groupBox1.Controls.Add(textBoxApellidos);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 337);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(34, 236);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(209, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar Cliente";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(143, 187);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(100, 23);
            textBoxTelefono.TabIndex = 5;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(143, 135);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(100, 23);
            textBoxApellidos.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(143, 88);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(34, 185);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 133);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 86);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBoxIdentificador
            // 
            textBoxIdentificador.Location = new Point(97, 44);
            textBoxIdentificador.Name = "textBoxIdentificador";
            textBoxIdentificador.Size = new Size(146, 23);
            textBoxIdentificador.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 42);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 7;
            label4.Text = "Identificar";
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 394);
            Controls.Add(groupBox1);
            Name = "FormBuscar";
            Text = "FormBuscar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxIdentificador;
        private Label label4;
        private Button buttonBuscar;
        private TextBox textBoxTelefono;
        private TextBox textBoxApellidos;
        private TextBox textBoxNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}