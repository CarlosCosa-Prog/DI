using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        // método que se ejecuta cuando se carga el formulario
        private void FormContenedor_Load(object sender, EventArgs e)
        {
            conexion.CrearBaseYTablaSiNoExiste();
            CargarClientes();
        }

        // método que obtiene los clientes de la base de datos y los muestra en el DataGridView
        private void CargarClientes()
        {
            try
            {
                // Se establece la conexión con la base de datos
                using (MySqlConnection cn = conexion.conexio())
                {
                    cn.Open();

                    // Consulta para obtener todos los clientes
                    string consulta = "SELECT * FROM clientes";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, cn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }
    }
}
