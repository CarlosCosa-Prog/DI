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

        private void textAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if (!comprobarCampo()) return;

            string marca = textMarca.Text;
            string modelo = textModelo.Text;
            int anio = int.Parse(textAño.Text);
            string numeroChasis = textChasis.Text;

            string sql = "INSERT INTO coches(marca, modelo, anio, numeroChasis) VALUES(@marca, @modelo, @anio, @numeroChasis)";
            MySqlConnection con = conexion.Conectar();
            con.Open();
            try
            {
                 MySqlCommand comando = new MySqlCommand(sql,con);
                 comando.Parameters.AddWithValue("@marca", marca);
                 comando.Parameters.AddWithValue("@modelo", modelo);
                 comando.Parameters.AddWithValue("@anio", anio);
                 comando.Parameters.AddWithValue("@numeroChasis", numeroChasis);

                 comando.ExecuteNonQuery();
                 MessageBox.Show("Registro guardado correctamente");
                 con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool comprobarCampo()
        {
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
