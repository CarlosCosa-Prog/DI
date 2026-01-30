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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            // SQL que muestra el contenido de la tabla clientes
            string consulta = "SELECT * FROM clientes";
            // Crea un puente entre un conjunto de datos y MySql
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion.conexio());

            //Representa una tabla de datos en memoria
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
