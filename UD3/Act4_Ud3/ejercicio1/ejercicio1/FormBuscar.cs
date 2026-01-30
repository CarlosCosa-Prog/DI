using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el usuario ingresó algo
            if (string.IsNullOrWhiteSpace(textBoxIdentificador.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente.");
                return;
            }

            // Convertimos el texto a entero
            if (!int.TryParse(textBoxIdentificador.Text, out int idCliente))
            {
                MessageBox.Show("El identificador debe ser un número válido.");
                return;
            }

            // Consulta correcta con el nombre real del campo
            string consulta = "SELECT nombre, apellidos, telefono FROM clientes WHERE idCliente = @idCliente";

            try
            {
                using (MySqlConnection conexionBD = conexion.conexio())
                {
                    conexionBD.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read()) // Si encontró un registro
                        {
                            textBoxNombre.Text = lector["nombre"].ToString();
                            textBoxApellidos.Text = lector["apellidos"].ToString();
                            textBoxTelefono.Text = lector["telefono"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún cliente con ese identificador.");
                            // Limpiamos los TextBox
                            textBoxNombre.Text = "";
                            textBoxApellidos.Text = "";
                            textBoxTelefono.Text = "";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }

    }
}
