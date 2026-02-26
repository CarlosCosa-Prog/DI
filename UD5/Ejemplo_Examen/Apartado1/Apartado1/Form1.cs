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

    // clase que permite la conexión con la base de datos
    internal class conexion
    {
        private static string servidor = "localhost";
        private static string bd = "taller_carlos_cosa";
        private static string usuario = "root";
        private static string pass = "";

        // metodo conectar que devuelve un MySqlConection
        public static MySqlConnection Conectar()
        {
            // llamada de las funciones
            CrearBaseDeDatosSiNoExiste();
            CrearTablaSiNoExiste();

            // crea la cadena de conexion con el server, database, id y password
            string cadenaConexion = $"Server={servidor};Database={bd};User ID={usuario};Password={pass};";
            // devuelve el MysqlConnection con los datos de la conexion
            return new MySqlConnection(cadenaConexion);
        }

        public static void CrearBaseDeDatosSiNoExiste()
        {
            // crea la cadena IMPORTANTE (SIN LA BASE DE DATOS) ya que puede que todavia no exista
            string cadenaConexion = $"Server={servidor};User ID={usuario};Password={pass};";
            // using funciona como el try-withresources (implementa autoclousable)
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();    // abre la conexion
                // comando sql que crea la base de datos si no existe
                string crearBD = $"CREATE DATABASE IF NOT EXISTS {bd} CHARACTER SET utf8mb4;";
                // ejecuta el comando sin devolver datos con el ExecuteNonQuery
                new MySqlCommand(crearBD, conexion).ExecuteNonQuery();
            }
        }

        public static void CrearTablaSiNoExiste()
        {
            // sql con todos los datos
            string cadenaConexion = $"Server={servidor};Database={bd};User ID={usuario};Password={pass};";
            // using que le pasa la nueva conexion
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                // sql que crean las tablas
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

                // ejecuta los comando sql
                new MySqlCommand(crearTablaCoches, conexion).ExecuteNonQuery();
                new MySqlCommand(crearTablaClientes, conexion).ExecuteNonQuery();
            }
        }

    }
}
