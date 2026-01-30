using MySqlConnector;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.CrearBaseYTablaSiNoExiste();
        }

        private void toolStripButtonInsertar_Click(object sender, EventArgs e)
        {
            FormInsertar f = new FormInsertar();
            f.Show();
        }

        private void toolStripButtonListar_Click(object sender, EventArgs e)
        {
            FormListar f = new FormListar();
            f.Show();
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar f = new FormBuscar();
            f.Show();
        }
    }
    // Clase que contiene la función para establecer una conexión con la base de datos
    internal class conexion
    {
        public static MySqlConnection conexio()
        {
            // Variables que contienen los datos necesarios para establecer la conexión con la base de datos
            string servidor = "localhost";
            string bd = "empresa";
            string usuario = "root";
            string pass = "";

            string cadenaConexion =
            "Server=" + servidor + ";" +
            "Database=" + bd + ";" +
            "User ID=" + usuario + ";" +
            "Password=" + pass + ";";

            MySqlConnection conexionBD;
            try
            {
                conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException e)
            {
                Console.Write("Error en la conexion " + e.Message);
            }
            return null;
        }
        // Método para crear la base de datos y la tabla si no existe
        public static void CrearBaseYTablaSiNoExiste()
        {
            string servidor = "localhost";
            string usuario = "root";
            string pass = "";
            string nombreBaseDatos = "empresa";

            try
            {
                // Conexión sin base de datos específica
                string cadenaConexion = $"Server={servidor};User ID={usuario};Password={pass};";
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Crear la base de datos si no existe
                    string crearBD = $"CREATE DATABASE IF NOT EXISTS {nombreBaseDatos} CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;";
                    MySqlCommand cmdCrearBD = new MySqlCommand(crearBD, conexion);
                    cmdCrearBD.ExecuteNonQuery();

                    // Crear la tabla si no existe
                    string crearTabla = $@"
                CREATE TABLE IF NOT EXISTS {nombreBaseDatos}.clientes (
                    idCliente INT(11) NOT NULL AUTO_INCREMENT,
                    nombre VARCHAR(50) NOT NULL,
                    apellidos VARCHAR(50) NOT NULL,
                    telefono INT(11) NOT NULL,
                    PRIMARY KEY (idCliente)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;";

                    MySqlCommand cmdCrearTabla = new MySqlCommand(crearTabla, conexion);
                    cmdCrearTabla.ExecuteNonQuery();

                    Console.WriteLine($"La base de datos '{nombreBaseDatos}' no existía y se ha creado correctamente (junto con la tabla 'clientes').");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al crear la base de datos o la tabla: " + ex.Message);
            }
        }
    }
}
