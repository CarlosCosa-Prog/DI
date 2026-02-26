using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Apartado1
{
    public partial class FormRegistrarCoche : Form
    {
        public FormRegistrarCoche()
        {
            InitializeComponent();
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {   
            // comprueba que el campo de numeros sea valido
            if (!comprobarCampo()) return;

            // guarda los valores de los textBox
            string marca = textMarca.Text;
            string modelo = textModelo.Text;
            int anio = int.Parse(textAño.Text);
            string numeroChasis = textChasis.Text;

            string sql = "INSERT INTO coches(marca, modelo, anio, numeroChasis) VALUES(@marca, @modelo, @anio, @numeroChasis)";
          
            try
            {
                // abre la conexion con el using
                using (MySqlConnection con = conexion.Conectar())
                {
                    con.Open();

                    // crea y ejecuta la consulta del insert 
                    MySqlCommand comando = new MySqlCommand(sql, con);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@modelo", modelo);
                    comando.Parameters.AddWithValue("@anio", anio);
                    comando.Parameters.AddWithValue("@numeroChasis", numeroChasis);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Coche registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool comprobarCampo()
        {
            // comprueba que el campo del textBoxAño sea un int
            if (!int.TryParse(textAño.Text, out int año))
            {
                MessageBox.Show(
                    "Debe introducir un número entero válido",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }
    }
}
