using System.ComponentModel;
using System.Windows.Forms;

namespace maquinaBebidasCCS
{
    public partial class Form1 : Form
    {
        int stockCocacola = 20;
        int stockAquarius = 20;
        int stockCerveza = 20;
        int stockAgua = 20;
        int stockFanta = 20;
        double total = 0.00;

        public Form1()
        {
            InitializeComponent();
            CargarStock();
            NuevoCliente();
        }

        // se le pasa una variable por referencia
        private void CambiarStock(ref int stock, String bebida)
        {
            // si el stock es mayor a 0 se le resta 1 al stock, sino aparece el mensaje de que se ha quedado sin stock
            if (stock > 0)
                stock--;
            else
                MessageBox.Show(
                    $"No queda stock de {bebida} ",
                    "Error de stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        // actualizar stock 
        private void CargarStock()
        {
            txtStock1.Text = stockCocacola.ToString();
            txtStock2.Text = stockAquarius.ToString();
            txtStock3.Text = stockCerveza.ToString();
            txtStock4.Text = stockAgua.ToString();
            txtStock5.Text = stockFanta.ToString();
        }

        // funcion que cambia el total a pagar a 0
        private void NuevoCliente()
        {
            txtTotal.Text = "0.00€";
        }
        // funcion que suma el precio de la bebida al precio a pagar
        private void ComprarBebida(double precio)
        {
            total += precio;
            txtTotal.Text = total.ToString("0.00") + "€";
        }
        // funcion del boton salir
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente();
        }

        private void imagen1_Click(object sender, EventArgs e)
        {
            CambiarStock(ref stockCocacola, "Coca Cola");
            CargarStock();
            ComprarBebida(1.00);
        }
        private void imagen2_Click(object sender, EventArgs e)
        {
            CambiarStock(ref stockAquarius, "Aquarius");
            CargarStock();
            ComprarBebida(1.00);
        }

        private void imagen3_Click(object sender, EventArgs e)
        {
            CambiarStock(ref stockCerveza, "Heineken");
            CargarStock();
            ComprarBebida(1.75);
        }

        private void imagen4_Click(object sender, EventArgs e)
        {
            CambiarStock(ref stockAgua, "Agua");
            CargarStock();
            ComprarBebida(0.50);
        }

        private void imagen5_Click(object sender, EventArgs e)
        {
            CambiarStock(ref stockFanta, "Fanta");
            CargarStock();
            ComprarBebida(1.00);
        }
    }
}