

using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using iText.Kernel.Colors;


namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Si la carpeta no existe, la crea
            string carpeta = @"C:\pdf";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            // Ruta donde se guardará el PDF
            string rutaPDF = Path.Combine(carpeta, "prueba4.pdf");

            // Crear un documento PDF
            using (var pdfWriter = new PdfWriter(rutaPDF))
            {
                using (var pdf = new PdfDocument(pdfWriter))
                {
                    // Crear un documento iText
                    var document = new Document(pdf);

                    // Agregar cabecera al documento
                    Paragraph cabecera = new Paragraph("DESENVOLUPAMENT D'INTERFÍCIES");
                    cabecera.SetTextAlignment(TextAlignment.CENTER);
                    cabecera.SetFontSize(20);
                    document.Add(cabecera);

                    // Agregar Sub-Cabecera al documento
                    Paragraph subcabecera = new Paragraph("2º DAM");
                    subcabecera.SetTextAlignment(TextAlignment.CENTER);
                    subcabecera.SetFontSize(16);
                    document.Add(subcabecera);

                    // Agregar linea separadora
                    LineSeparator lineaSeparadora = new LineSeparator(new SolidLine());
                    document.Add(lineaSeparadora);

                    // Agregar Parrafo 
                    Paragraph parrafo = new Paragraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
                    parrafo.SetTextAlignment(TextAlignment.CENTER);
                    parrafo.SetFontSize(12);
                    document.Add(parrafo);

                    // Agregar imagen
                    // Ruta base del ejecutable
                    string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

                    // Subimos hasta Act1_Ud4
                    string rutaImagen = Path.GetFullPath(
                        Path.Combine(rutaBase, @"..\..\..\..\..\imagen.png")
                    );

                    // Si la ruta es correcta crea el Image y lo añade a al document
                    if (File.Exists(rutaImagen))
                    {
                        ImageData imageData = ImageDataFactory.Create(rutaImagen);
                        iText.Layout.Element.Image imagen =
                            new iText.Layout.Element.Image(imageData);

                        imagen.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        imagen.SetWidth(500);
                        imagen.SetMarginTop(15);

                        document.Add(imagen);
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra la imagen:\n" + rutaImagen);
                    }

                    // Agregar tabla
                    Table tabla = new Table(2);

                    // Encabezados de la tabla con fondo gris
                    tabla.AddCell(new Cell().Add(new Paragraph("Ciutat"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY));

                    tabla.AddCell(new Cell().Add(new Paragraph("Població"))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY));

                    // El resto de celdas de la tabla
                    tabla.AddCell(new Cell().Add(new Paragraph("Alcoi")));
                    tabla.AddCell(new Cell().Add(new Paragraph("59.000")));

                    tabla.AddCell(new Cell().Add(new Paragraph("Ibi")));
                    tabla.AddCell(new Cell().Add(new Paragraph("23.403")));

                    tabla.AddCell(new Cell().Add(new Paragraph("Onil")));
                    tabla.AddCell(new Cell().Add(new Paragraph("74.075")));

                    tabla.SetTextAlignment(TextAlignment.CENTER);
                    tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    tabla.SetMarginTop(50);
                    tabla.SetWidth(200);
                    document.Add(tabla);

                    // Numero de páginas
                    int n = pdf.GetNumberOfPages();
                    for (int i = 1; i <= n; i++)
                    {
                        document.ShowTextAligned(new Paragraph(String
                           .Format("Página" + i + " de " + n)),
                            559, 806, i, TextAlignment.RIGHT,
                            VerticalAlignment.TOP, 0);
                    }
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
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellidos", "Apellidos");
            dataGridView1.Columns.Add("telefono", "Telefono");

            dataGridView1.Rows.Add("Iván", "Martos", "12345");
            dataGridView1.Rows.Add("Manolo", "López", "12345");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Si la carpeta no existe, la crea
            string carpeta = @"C:\pdf";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

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
                    Paragraph cabecera = new Paragraph("PDF CLIENTES");
                    cabecera.SetTextAlignment(TextAlignment.CENTER);
                    cabecera.SetFontSize(20);
                    document.Add(cabecera);

                    // Agregar tabla
                    Table tabla = new Table(3);

                    // Encabezados de la tabla con fondo gris
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Nombre")));
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Apellidos")));
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph("Telefono")));


                    // Recorrer filas del DataGridView
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (!fila.IsNewRow) // ignorar fila vacía de edición
                        {
                            tabla.AddCell(fila.Cells["nombre"].Value?.ToString() ?? "");
                            tabla.AddCell(fila.Cells["apellidos"].Value?.ToString() ?? "");
                            tabla.AddCell(fila.Cells["telefono"].Value?.ToString() ?? "");
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
    }
}
