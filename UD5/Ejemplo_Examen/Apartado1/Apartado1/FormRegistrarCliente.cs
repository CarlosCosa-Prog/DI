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
            string nombre = textNombre.Text;
            string apellidos = textApellidos.Text;

            string sql = "INSERT INTO clientes(nombre, apellidos) VALUES(@nombre, @apellidos)";
            MySqlConnection con = conexion.Conectar();
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellidos", apellidos);

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
