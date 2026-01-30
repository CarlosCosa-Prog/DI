using MySqlConnector;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ocultarSubmenus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.CrearBaseYTablaSiNoExiste();
        }
        // método que ocula los submenus 
        private void ocultarSubmenus()
        {
            panelSubClientes.Visible = false;
            panelSubCompras.Visible = false;
            panelSubProductes.Visible = false;
        }

        // método que compruebe si hay algun panel que esté visible, si es asi lo oculta
        private void mostrarSubmenus(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                ocultarSubmenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Llamada del método que mostrará los submenus al hacer click en los botones de los menus
        private void botoProductes_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelSubProductes);
        }

        private void botoClientes_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelSubClientes);
        }

        private void botoCompras_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelSubCompras);
        }

        private Form formularioActivo = null;

        // método para abrir un formulario hijo dentro de un panel contenedor
        private void abrirFormulario(Form hijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = hijo;

            hijo.TopLevel = false;

            hijo.Dock = DockStyle.Fill;

            hijo.FormBorderStyle = FormBorderStyle.None;

            panelContenidor.Dock = DockStyle.Fill;

            panelContenidor.Controls.Add(hijo);

            panelContenidor.Tag = hijo;

            hijo.BringToFront();

            hijo.Show();
        }

        // llama al método que abre la función, cuando se hace clic en el boton, y se le pasa el nombre del contenedor 
        private void botoSubClientes1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormContenedor());
            ocultarSubmenus();
        }

        private void botoSubClientes4_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormContenedorAPI());
            ocultarSubmenus();
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