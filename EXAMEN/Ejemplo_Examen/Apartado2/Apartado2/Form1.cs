using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System.Data;

namespace Apartado2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            string carpeta = @"C:\pdf";
            Directory.CreateDirectory(carpeta);

            string rutaPDF = Path.Combine(carpeta, "ejemplo.pdf");

            using (var pdfWriter = new PdfWriter(rutaPDF))
            {
                using (var pdf = new PdfDocument(pdfWriter))
                {
                    var document = new Document(pdf);
                    // a. Cabecera
                    Paragraph cabecera = new Paragraph("Cabecera de ejemplo");
                    cabecera.SetTextAlignment(TextAlignment.CENTER);
                    cabecera.SetFontSize(20);
                    document.Add(cabecera);

                    // b. Sub-Cabecera
                    Paragraph subcabecera = new Paragraph("Sub-cabecera");
                    subcabecera.SetTextAlignment(TextAlignment.CENTER);
                    subcabecera.SetFontSize(18);
                    document.Add(subcabecera);

                    // c. Línea separadora
                    LineSeparator separador = new LineSeparator(new SolidLine());
                    document.Add(separador);

                    // d. Párrafo
                    Paragraph parrafo = new Paragraph("dsskkdjksjdkskdjskdjkjsdkdjkdkdjdkjdsjkd");
                    document.Add(parrafo);

                    // e. Imagen
                    // ruta base del ejecutable
                    string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
                    // subir hasta la carpeta donde está la imagen
                    string rutaImagen = @"C:\Users\karlo\Desktop\Ejemplo_Examen\taller.jpeg";

                    // Si la ruta es correcta crea la imagen y la añade al document
                    if (File.Exists(rutaImagen))
                    {
                        document.Add(
                        new iText.Layout.Element.Image(
                            ImageDataFactory.Create(rutaImagen))
                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                        .SetWidth(500)
                        .SetMarginTop(15)
                        );
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra la imagen: " + rutaImagen);
                    }

                    // f. Tabla
                    // se le pasa el numero de columnas
                    Table tabla = new Table(2);

                    // Encabezados
                    tabla.AddCell(new Cell().Add(new Paragraph("Nombre")));
                    tabla.AddCell(new Cell().Add(new Paragraph("Apellido")));

                    // Segunda fila
                    tabla.AddCell(new Cell().Add(new Paragraph("Carlos")));
                    tabla.AddCell(new Cell().Add(new Paragraph("Cosa")));

                    // Tercer fila
                    tabla.AddCell(new Cell().Add(new Paragraph("Antonio")));
                    tabla.AddCell(new Cell().Add(new Paragraph("Perez")));

                    tabla.SetTextAlignment(TextAlignment.CENTER);
                    tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    tabla.SetMarginTop(50);
                    tabla.SetWidth(200);

                    // añade la tabla al document
                    document.Add(tabla);

                    // g. numeración de páginas
                    int n = pdf.GetNumberOfPages();
                    for (int i = 1; i <= n; i++)
                    {
                        document.ShowTextAligned(new Paragraph(String.Format("Página" + i + " de " + n)),
                            100, 40, i, TextAlignment.RIGHT,
                            VerticalAlignment.TOP, 0);
                    }
                    
                    // cierra el document (dejamos de añadir mas cosas)
                    document.Close();

                    // h. Al crear el PDF tiene que salir un mensaje 
                    MessageBox.Show(
                        $"PDF generado correctamente en: \n{rutaPDF}",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        // Genera el PDF con los valores del DataGridView
        private void boton2_Click(object sender, EventArgs e)
        {
            // Crea la carpeta
            string carpeta = @"C:\pdf";
            
            Directory.CreateDirectory(carpeta);
            

            // Ruta donde se guardará el PDF
            string rutaPDF = Path.Combine(carpeta, "tabla.pdf");

            // Crear un documento PDF
            using (var pdfWriter = new PdfWriter(rutaPDF))
            {
                using (var pdf = new PdfDocument(pdfWriter))
                {
                    // Crear un documento iText
                    var document = new Document(pdf);

                    // Agregar cabecera al documento
                    Paragraph cabecera = new Paragraph("PDF COCHES");
                    cabecera.SetTextAlignment(TextAlignment.CENTER);
                    cabecera.SetFontSize(20);
                    document.Add(cabecera);

                    // Agregar tabla
                    Table tabla = new Table(4);

                    // Encabezados de la tabla con fondo gris
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Marca")));
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Modelo")));
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Año")));
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Numero Chasis")));

                    // Recorrer filas del DataGridView
                    foreach (DataGridViewRow fila in dataGridView.Rows)
                    {
                        if (!fila.IsNewRow) // ignorar fila vacía de edición
                        {
                            tabla.AddCell(fila.Cells["marca"].Value?.ToString() ?? "");
                            tabla.AddCell(fila.Cells["modelo"].Value?.ToString() ?? "");
                            tabla.AddCell(fila.Cells["anio"].Value?.ToString() ?? "");
                            tabla.AddCell(fila.Cells["numeroChasis"].Value?.ToString() ?? "");
                        }
                    }

                    tabla.SetTextAlignment(TextAlignment.CENTER);
                    tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    tabla.SetWidth(500);
                    document.Add(tabla);

                    // Cierra el documento
                    document.Close();

                    // Mensaje que se muestra al crear el pdf
                    MessageBox.Show(
                    $"PDF generado correctamente en:\n{rutaPDF}",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM coches";

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion.Conectar());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
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


                new MySqlCommand(crearTablaCoches, conexion).ExecuteNonQuery();
            }
        }
    }
}
