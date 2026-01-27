namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Comprobar si hay campos vacíos
            if (ComprobarCamposVacios()) return;

            // Comprobar si los valores son numéricos
            if (ComprobarValorNumerico()) return;

            // Comprobar que la edad sea mayor de 18
            ComprobarEdad();

            // Llamada de la funcion de mostrarResumen
            MostrarResumen();
        }
        // Comprobar si la edad es mayor de 18 años
        private bool ComprobarEdad()
        {
            int edad = int.Parse(textBoxEdad.Text);
            int edad2 = int.Parse(textBoxEdadInt.Text);
            if (edad < 18 || edad2 < 18)
            {
                MessageBox.Show(
                    "La edad debe ser mayor de 18 años",
                    "Error rango de edad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }
            return false;
        }
        // Comprobar si la edad es un valor númerico
        private bool ComprobarValorNumerico()
        {
            int numero1;
            int numero2;

            if (!int.TryParse(textBoxEdad.Text, out numero1) || !int.TryParse(textBoxEdad.Text, out numero2))
            {
                MessageBox.Show(
                    "Debes introducir un número válido en el campo edad",
                    "Error de formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }
            return false;
        }
        // Comprobar que los campos no estén vacios
        private bool ComprobarCamposVacios()
        {
            // Comprobar campo Nombre
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show(
                    "El campo Nombre no puede estár vacio.",
                    "Error campo vacio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            // Comprobar campo Apellidos
            if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
            {
                MessageBox.Show(
                    "El campo Apellidos no puede estár vacio.",
                    "Error campo vacio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            // Comprobar campo Edad (Sobre mi)
            if (string.IsNullOrWhiteSpace(textBoxEdad.Text))
            {
                MessageBox.Show(
                    "El campo Edad no puede estár vacio.",
                    "Error campo vacio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            return false;
        }
        //  Funcion que muestre el resumen 
        private void MostrarResumen()
        {
            string mensaje = "";
            string aficiones = "";
            string intereses = "";

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control interno in groupBox.Controls)
                    {
                        if (interno is TextBox textBox)
                        {
                            if (textBox == textBoxNombre)
                                mensaje += "Nombre: " + textBox.Text + "\n";

                            if (textBox == textBoxApellidos)
                                mensaje += "Apellidos: " + textBox.Text + "\n";

                            if (textBox == textBoxEdad)
                                mensaje += "Edad: " + textBox.Text + "\n";

                            if (textBox == textBoxEdadInt)
                                intereses += "Edad interés: " + textBox.Text + "\n";
                        }

                        if (interno is CheckBox checkBox && checkBox.Checked)
                        {
                            aficiones += "- " + checkBox.Text + "\n";
                        }

                        if (interno is RadioButton radio && radio.Checked)
                        {
                            intereses += "Sexo interés: " + radio.Text + "\n";
                        }
                    }
                }
            }

            mensaje += "\nAficiones:\n" + aficiones;
            mensaje += "\nIntereses:\n" + intereses;

            MessageBox.Show(
                mensaje,
                "Resumen del registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
