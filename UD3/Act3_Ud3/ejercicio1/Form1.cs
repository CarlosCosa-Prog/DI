using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void botonCargarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo un DataSet para cargar el fichero xml
                DataSet ds = new DataSet();
                ds.ReadXml("clientes.xml");

                // Utilizo el DataSource para cargar la tabla clientes en el dataGridView
                dataGridView.DataSource = ds.Tables["cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el XML: " + ex.Message);
            }
            // También es posible hacerlo con:
            /**/
            // y después utilizar un foreach para mostrar cada campo de la tabla


        }

        private void botonListadoClientes_Click(object sender, EventArgs e)
        {
            // También es posible cargar el fichero xml con:
            try
            {
                // Cargar el fichero XML
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("clientes.xml");

                // Limpiar el ComboBox antes de cargar
                comboBox.Items.Clear();

                // Obtener todos los nodos <cliente>
                XmlNodeList clientes = xmlDoc.GetElementsByTagName("cliente");

                foreach (XmlNode cliente in clientes)
                {
                    string id = cliente["id"].InnerText;
                    string nombre = cliente["nombre"].InnerText;
                    string apellidos = cliente["apellidos"].InnerText;

                    // Lo que se mostrará en el ComboBox
                    comboBox.Items.Add($"{id} - {nombre} {apellidos}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ComboBox: " + ex.Message);
            }
        }
    }
}
