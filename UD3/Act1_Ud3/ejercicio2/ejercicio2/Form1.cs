namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Calcular el IMC
        private void botonCalcular_Click(object sender, EventArgs e)
        {

            // Llamada a la función para comprobar vacíos
            if (comprobarVacio())
                return;

            // Llamada a la funcion validar númericos
            // Se le pasa el campo y el texto que quieres mostrar para que la función sea más corta y escalable
            if (!ValidarNumerico(textAltura, "Altura") || !ValidarNumerico(textPeso, "Peso"))
                return; 

            // Llamada a la funcion para comprobar si alguno es negativo
            if (ComprobarNegativos())
                return;


            double peso = Convert.ToDouble(textPeso.Text);
            double altura = Convert.ToDouble(textAltura.Text);
            double imc = peso / (altura * altura);

            // Mostrar el resultado con dos decimales
            textResultado.Text = imc.ToString("0.00");

            // Si el imc es mayor a 30 saldrá un mensaje en rojo mientras que si es menor saldrá un mensaje en verde
            if (imc > 30)
            {
                labelIMC.Text = "Deberías cuidarte";
                labelIMC.ForeColor = Color.Red;
            }
            else
            {
                labelIMC.Text = "Está en forma";
                labelIMC.ForeColor = Color.Green;
            }
        }

        // Funcion que comprueba que los campos textBox no estén vacíos
        private bool comprobarVacio()
        {
            // Campo vacío (Altura) y (Peso)
            if (string.IsNullOrWhiteSpace(textAltura.Text) && string.IsNullOrWhiteSpace(textPeso.Text))
            {
                MessageBox.Show(
                    "Los campos Altura y Peso no pueden estar vacíos",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            // Campo vacío (Altura)
            if (string.IsNullOrWhiteSpace(textAltura.Text))
            {
                MessageBox.Show(
                    "El campo Altura no puede estar vacío",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            // Campo vacío (Peso)
            if (string.IsNullOrWhiteSpace(textPeso.Text))
            {
                MessageBox.Show(
                    "El campo Peso no puede estar vacío",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            // No hay ningun campo vacio
            return false;
        }

        // Funcion que compruebe que los textBox sean numéricos
        private bool ValidarNumerico(TextBox caja, string nombreCampo)
        {
            // Intenta convertir el texto a double, por lo que si no es valido aparece el mensaje
            if (!double.TryParse(caja.Text, out double valor))
            {
                MessageBox.Show(
                    $"El campo {nombreCampo} debe contener un número válido",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false; 
            }

            return true;
        }
        // Funcion que compruebe que los textBox no sean negativos
        private bool ComprobarNegativos()
        {
            double altura = Convert.ToDouble(textAltura.Text);
            double peso = Convert.ToDouble(textPeso.Text);

            // Comprobar si alguno es negativo
            if (altura < 0 || peso < 0)
            {
                MessageBox.Show(
                    "No se admiten números negativos",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }

            return false;
        }

        // Limpiar los campos
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textAltura.Clear();
            textPeso.Clear();
            textResultado.Clear();
        }
    }
}
