namespace Apartado1
{
    partial class FormMostrarDatos
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            botonMostrar = new Button();
            botonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(211, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(509, 238);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 1;
            // 
            // botonMostrar
            // 
            botonMostrar.Location = new Point(29, 65);
            botonMostrar.Name = "botonMostrar";
            botonMostrar.Size = new Size(146, 23);
            botonMostrar.TabIndex = 2;
            botonMostrar.Text = "Mostrar datos";
            botonMostrar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(211, 281);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(509, 23);
            botonEliminar.TabIndex = 3;
            botonEliminar.Text = "Eliminar datos";
            botonEliminar.UseVisualStyleBackColor = true;
            // 
            // FormMostrarDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 339);
            Controls.Add(botonEliminar);
            Controls.Add(botonMostrar);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "FormMostrarDatos";
            Text = "FormMostrarDatos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button botonMostrar;
        private Button botonEliminar;
    }
}