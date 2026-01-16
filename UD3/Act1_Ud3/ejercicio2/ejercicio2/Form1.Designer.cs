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
            label1 = new Label();
            label2 = new Label();
            textPeso = new TextBox();
            textAltura = new TextBox();
            botonCalcular = new Button();
            botonLimpiar = new Button();
            label3 = new Label();
            textResultado = new TextBox();
            labelIMC = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce tu peso (En Kilos)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 1;
            label2.Text = "Introduce tu altura (En metros)";
            // 
            // textPeso
            // 
            textPeso.Location = new Point(195, 22);
            textPeso.Name = "textPeso";
            textPeso.Size = new Size(100, 23);
            textPeso.TabIndex = 2;
            // 
            // textAltura
            // 
            textAltura.Location = new Point(195, 58);
            textAltura.Name = "textAltura";
            textAltura.Size = new Size(100, 23);
            textAltura.TabIndex = 3;
            // 
            // botonCalcular
            // 
            botonCalcular.BackColor = Color.LightGreen;
            botonCalcular.Location = new Point(12, 97);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(126, 39);
            botonCalcular.TabIndex = 4;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = false;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // botonLimpiar
            // 
            botonLimpiar.BackColor = Color.LightCoral;
            botonLimpiar.Location = new Point(169, 97);
            botonLimpiar.Name = "botonLimpiar";
            botonLimpiar.Size = new Size(126, 39);
            botonLimpiar.TabIndex = 5;
            botonLimpiar.Text = "Limpiar";
            botonLimpiar.UseVisualStyleBackColor = false;
            botonLimpiar.Click += botonLimpiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 164);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Indice";
            // 
            // textResultado
            // 
            textResultado.Location = new Point(169, 161);
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(100, 23);
            textResultado.TabIndex = 7;
            // 
            // labelIMC
            // 
            labelIMC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelIMC.AutoSize = true;
            labelIMC.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIMC.ForeColor = SystemColors.ControlText;
            labelIMC.Location = new Point(34, 207);
            labelIMC.Name = "labelIMC";
            labelIMC.Size = new Size(0, 34);
            labelIMC.TabIndex = 8;
            labelIMC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(315, 280);
            Controls.Add(labelIMC);
            Controls.Add(textResultado);
            Controls.Add(label3);
            Controls.Add(botonLimpiar);
            Controls.Add(botonCalcular);
            Controls.Add(textAltura);
            Controls.Add(textPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textPeso;
        private TextBox textAltura;
        private Button botonCalcular;
        private Button botonLimpiar;
        private Label label3;
        private TextBox textResultado;
        private Label labelIMC;
    }
}
