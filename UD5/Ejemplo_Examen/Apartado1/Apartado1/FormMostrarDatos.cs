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
    public partial class FormMostrarDatos : Form
    {
        public FormMostrarDatos()
        {
            InitializeComponent();
        }

        private void FormMostrarDatos_Load(object sender, EventArgs e)
        {
            // 1. Llenamos el ComboBox con los nombres de las tablas
            comboBox1.Items.Add("clientes");
            comboBox1.Items.Add("coches");

            // 2. Seleccionamos la primera opción para evitar null
            comboBox1.SelectedIndex = 0;
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            mostrarTabla();

        }
        public void mostrarTabla()
        {
            // 3. Ahora sí podemos usar SelectedItem
            string seleccionado = comboBox1.SelectedItem.ToString();

            // SQL que muestra el contenido de la tabla seleccionada
            string consulta = "SELECT * FROM " + seleccionado;

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion.Conectar());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
