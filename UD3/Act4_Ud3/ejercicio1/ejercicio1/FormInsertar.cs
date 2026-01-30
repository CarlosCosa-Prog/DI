using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejercicio1
{
    public partial class FormInsertar : Form
    {
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            // Cojo el texto de los textBox y los guardo en variables 
            string nombre = textBoxNombre.Text;
            string apellidos = textBoxApellidos.Text;
            string telefono = textBoxTelefono.Text;

            // Creo la consulta SQL que inserta un cliente con todos los parámetros en la tabla clientes
            string sql = "INSERT INTO clientes(nombre, apellidos, telefono) VALUES(@nombre, @apellidos, @telefono)";

            // LLamada a la funcion que genera la conexion con la base de datos
            MySqlConnection conexionBD = conexion.conexio();

            try
            {
                conexionBD.Open();

                // MySqlCommand permite realizar operaciones sobre la base de datos una vez está establecida la conexión
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                // Definimos los parámetros
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellidos", apellidos);
                comando.Parameters.AddWithValue("@telefono", telefono);

                // ExecuteNonQuery permite insertar, actualizar y eliminar datos de la base de datos.
                comando.ExecuteNonQuery();
                textBoxNombre.Text = "";
                textBoxApellidos.Text = "";
                textBoxTelefono.Text = "";
                MessageBox.Show("Registro guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();

            }
        }
    }
}