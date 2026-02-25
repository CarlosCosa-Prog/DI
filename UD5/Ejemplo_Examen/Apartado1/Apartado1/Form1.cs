using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System.Security.Cryptography.X509Certificates;

namespace Apartado1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarCocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarCoche f = new FormRegistrarCoche();
            f.ShowDialog();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente f = new FormRegistrarCliente();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarDatos f = new FormMostrarDatos();
            f.ShowDialog();
        }
    }

    internal class conexion
    {
        private static string servidor = "localhost";
        private static string bd = "taller_carlos_cosa";
        private static string usuario = "root";
        private static string pass = "";

        public static MySqlConnection Conectar()
        {
            CrearBaseDeDatosSiNoExiste();
            CrearTablaSiNoExiste();

            string cadenaConexion = $"Server={servidor};Database={bd};User ID={usuario};Password={pass};";
            return new MySqlConnection(cadenaConexion);
        }
        public static void CrearBaseDeDatosSiNoExiste()
        {
            string cadenaConexion = $"Server={servidor};User ID={usuario};Password={pass};";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string crearBD = $"CREATE DATABASE IF NOT EXISTS {bd} CHARACTER SET utf8mb4;";
                new MySqlCommand(crearBD, conexion).ExecuteNonQuery();
            }
        }

        public static void CrearTablaSiNoExiste()
        {
            string cadenaConexion = $"Server={servidor};Database={bd};User ID={usuario};Password={pass};";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                string crearTablaCoches = @"CREATE TABLE IF NOT EXISTS coches (
                    idCoche INT(11) NOT NULL AUTO_INCREMENT,
                    marca VARCHAR(50) NOT NULL,
                    modelo VARCHAR(50) NOT NULL,
                    anio INT(4) NOT NULL,
                    numeroChasis VARCHAR(20) NOT NULL,
                    PRIMARY KEY (idCoche))"; 

                string crearTablaClientes = @"CREATE TABLE IF NOT EXISTS clientes (
                    idCliente INT(11) NOT NULL AUTO_INCREMENT,
                    nombre VARCHAR(50) NOT NULL,
                    apellidos VARCHAR(50) NOT NULL,
                    telefono INT(11) NOT NULL,
                    PRIMARY KEY (idCliente))";

                new MySqlCommand(crearTablaCoches, conexion).ExecuteNonQuery();
                new MySqlCommand(crearTablaClientes, conexion).ExecuteNonQuery();
            }
        }

    }
}
