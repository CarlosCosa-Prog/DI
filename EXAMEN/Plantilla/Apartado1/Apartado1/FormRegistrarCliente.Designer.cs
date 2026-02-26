namespace Apartado1
{
    partial class FormRegistrarCliente
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
            textApellidos = new TextBox();
            textNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            botonAñadirCliente = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textApellidos);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(97, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // textApellidos
            // 
            textApellidos.Location = new Point(96, 72);
            textApellidos.Name = "textApellidos";
            textApellidos.Size = new Size(133, 23);
            textApellidos.TabIndex = 3;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(96, 31);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(133, 23);
            textNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 0, 0);
            label3.Size = new Size(84, 23);
            label3.TabIndex = 1;
            label3.Text = "Apellidos:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 0, 0);
            label2.Size = new Size(84, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 37);
            label1.TabIndex = 1;
            label1.Text = "Registrar nuevo cliente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botonAñadirCliente
            // 
            botonAñadirCliente.Location = new Point(193, 174);
            botonAñadirCliente.Name = "botonAñadirCliente";
            botonAñadirCliente.Size = new Size(153, 23);
            botonAñadirCliente.TabIndex = 2;
            botonAñadirCliente.Text = "Añadir cliente";
            botonAñadirCliente.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 255);
            Controls.Add(botonAñadirCliente);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(478, 294);
            Name = "FormRegistrarCliente";
            Text = "FormRegistrarCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textApellidos;
        private TextBox textNombre;
        private Label label3;
        private Label label2;
        private Button botonAñadirCliente;
    }
}