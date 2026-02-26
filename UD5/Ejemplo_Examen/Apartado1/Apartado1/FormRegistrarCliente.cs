using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apartado1
{
    public partial class FormRegistrarCliente : Form
    {
        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void botonAñadirCliente_Click(object sender, EventArgs e)
        {
            // guarda los valores de los textBox
            string nombre = textNombre.Text;
            string apellidos = textApellidos.Text;

            // prepara la consulta SQL con parámetros
            string sql = "INSERT INTO clientes(nombre, apellidos) VALUES(@nombre, @apellidos)";

            try
            {
                // abre la conexion con el using
                using (MySqlConnection con = conexion.Conectar())
                {
                    con.Open();

                    // crea y ejecuta la consulta del insert
                    MySqlCommand comando = new MySqlCommand(sql, con);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente " + nombre + " " + apellidos + " registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
