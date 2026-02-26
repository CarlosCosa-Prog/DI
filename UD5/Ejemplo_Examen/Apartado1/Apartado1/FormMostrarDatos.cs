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
            // añade al combo box el nombre de las tablas
            comboBox1.Items.Add("clientes");
            comboBox1.Items.Add("coches");

            // selecciona la primera opcion por defecto
            comboBox1.SelectedIndex = 0;
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            mostrarTabla();

        }
        public void mostrarTabla()
        {
            // guardar el nombre de la tabla seleccionada del comboBox
            string seleccionado = comboBox1.SelectedItem.ToString();

            // crear sql con la consulta
            string consulta = "SELECT * FROM " + seleccionado;

            // adaptador que trae datos de la base de datos y los guarda
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion.Conectar());
            
            // tabla donde se almacena los resultados de la consulta
            DataTable dt = new DataTable();
            // ejecuta la consulta y pone los resultados dentro de la tabla
            adapter.Fill(dt);
            // muestra los datos en el data grid
            dataGridView1.DataSource = dt;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            // comprueba que hay alguna fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // guarda en una variable la fila seleccionada
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                // guarda el nombre de la tabla seleccionada segun el valor del comboBox
                string tabla = comboBox1.SelectedItem.ToString();

                // guarda el nombre de la columna id
                string columnaId = dataGridView1.Columns[0].Name;

                // guarda el valor del id
                var id = fila.Cells[0].Value;
                

                string consulta = "DELETE FROM " + tabla + " WHERE " + columnaId + " = @id";

                // ejecutar la consulta dentro del try catch
                try
                {
                    // utilizar el using para el autoclousable
                    using (MySqlConnection conn = conexion.Conectar())
                    {
                        conn.Open();    // abrir la conexion
                        // crear el comando de eliminar
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        // asociar el id con @id de la tabla de la base de datos
                        cmd.Parameters.AddWithValue("@id", id);
                        // ejecutar la eliminación
                        cmd.ExecuteNonQuery();
                    }

                    // refresca el DataGridView para ver los cambios
                    mostrarTabla();

                    MessageBox.Show("Fila eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
    }
}
