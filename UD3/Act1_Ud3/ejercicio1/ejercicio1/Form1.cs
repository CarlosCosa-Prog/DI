namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Campo vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(
                    "El campo no puede estar vacío",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // No es un número válido
            if (!double.TryParse(textBox1.Text, out double grados))
            {
                MessageBox.Show(
                    "Debe introducir un número válido",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Es necesario hacer el tryParse para evitar errores si el usuario no introduce un número
            //double grados = Convert.ToDouble(textBox1.Text);
            double fahrenheit = (grados * 1.8) + 32;
            label2.Text = $"La conversión a Fahrenheit es: {fahrenheit} ºF";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
