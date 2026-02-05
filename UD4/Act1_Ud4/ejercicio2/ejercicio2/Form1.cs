using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Element;
using iText.Layout.Properties;
using Document = iText.Layout.Document;
using Color = System.Drawing.Color;
namespace ejercicio2
{
    public partial class Form1 : Form
    {
        string fotoRuta = "";   // defino un string con la ruta de la foto
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar el placeholder en los richTextBox
            SetPlaceholder(richTextBox1, "Educación");
            SetPlaceholder(richTextBox2, "Experiencia laboral");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cuadro de dialogo que permite seleccionar la imagen 
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.Title = "Seleccionar una foto";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fotoRuta = openFileDialog.FileName;
                    MessageBox.Show("Foto seleccionada correctamente.", "Foto cargada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Si la carpeta no existe, la crea
            /*string carpeta = @"C:\pdf";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            // Ruta donde se guardará el PDF
            string rutaPDF = Path.Combine(carpeta, "curriculumPrueba.pdf");*/

            // Selector de ubicación para guardar el PDF
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Currículum como PDF";
                saveFileDialog.FileName = "curriculum.pdf"; // nombre por defecto

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    // Si el usuario cancela, salir de la función
                    return;
                }

                string rutaPDF = saveFileDialog.FileName;

                // Crear un documento PDF
                using (var pdfWriter = new PdfWriter(rutaPDF))
                {
                    using (var pdf = new PdfDocument(pdfWriter))
                    {
                        // Crear un documento iText
                        var document = new Document(pdf);

                        // Agregar cabecera al documento
                        Paragraph cabecera = new Paragraph("Currículum Vitae");
                        cabecera.SetTextAlignment(TextAlignment.CENTER);
                        cabecera.SetFontSize(20);
                        document.Add(cabecera);

                        // Agregar linea separadora
                        LineSeparator lineaSeparadora = new LineSeparator(new SolidLine());
                        document.Add(lineaSeparadora);

                        // Agregar imagen
                        // Si la ruta es correcta crea el Image y lo añade a al document
                        if (File.Exists(fotoRuta))
                        {
                            ImageData imageData = ImageDataFactory.Create(fotoRuta);
                            iText.Layout.Element.Image imagen =
                                new iText.Layout.Element.Image(imageData);

                            imagen.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                            imagen.SetWidth(200);
                            imagen.SetMarginTop(10);

                            document.Add(imagen);
                        }
                        else
                        {
                            MessageBox.Show("Para crear el PDF, primero debes seleccionar tu foto");
                        }

                        // Campos de texto
                        // Validar campo Nombre
                        /*if (!ValidarCampo(textBox1, "Nombre"))
                            return;*/

                        // Agregar nombre
                        Paragraph nombre = new Paragraph("Nombre: " + textBox1.Text);
                        nombre.SetTextAlignment(TextAlignment.LEFT);
                        nombre.SetFontSize(15);
                        document.Add(nombre);

                        // Validar campo correo
                        /*if (!ValidarCampo(textBox2, "Correo"))
                            return;*/
                        // Agregar correo
                        Paragraph correo = new Paragraph("Correo: " + textBox2.Text);
                        correo.SetTextAlignment(TextAlignment.LEFT);
                        correo.SetFontSize(12);
                        document.Add(correo);

                        // Validar campo correo
                        /*if (!ValidarCampo(textBox3, "Teléfono"))
                            return;*/
                        // Agregar correo
                        Paragraph telefono = new Paragraph("Teléfono: " + textBox3.Text);
                        telefono.SetTextAlignment(TextAlignment.LEFT);
                        telefono.SetFontSize(12);
                        document.Add(telefono);

                        // Validar campo correo
                        /*if (!ValidarCampo(textBox4, "Dirección"))
                            return;*/
                        // Agregar correo
                        Paragraph direccion = new Paragraph("Dirección: " + textBox4.Text);
                        direccion.SetTextAlignment(TextAlignment.LEFT);
                        direccion.SetFontSize(12);
                        document.Add(direccion);

                        // Agregar otra linea separadora
                        document.Add(lineaSeparadora);
                        // Agregar el parrafo de Educación
                        Paragraph educacionTitulo = new Paragraph("Educación:");
                        educacionTitulo.SetFontSize(16);
                        document.Add(educacionTitulo);
                        Paragraph educacion = new Paragraph(richTextBox1.Text);
                        document.Add(educacion);

                        // Agregar otra linea separadora
                        document.Add(lineaSeparadora);
                        // Agregar el parrafo de Educación
                        Paragraph expLaboralTitulo = new Paragraph("Experiencia laboral:");
                        expLaboralTitulo.SetFontSize(16);
                        document.Add(expLaboralTitulo);
                        Paragraph expLaboral = new Paragraph(richTextBox2.Text);
                        document.Add(expLaboral);

                    }
                }

                // Mensaje informando que el PDF se creó
                MessageBox.Show($"PDF generado correctamente en:\n{rutaPDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Funcion que comprueba que un campo no esté vacio (no es necesaria en esta actividad)
        /*
        private bool ValidarCampo(TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(
                    $"El campo \"{nombreCampo}\" no puede estar vacío",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                textBox.Focus();
                return false;
            }
            return true;
        }*/

        // Función para configurar placeholder en los richTextBox
        private void SetPlaceholder(RichTextBox rtb, string placeholderText)
        {
            rtb.Text = placeholderText;
            rtb.ForeColor = Color.Gray;

            rtb.GotFocus += (s, e) =>
            {
                if (rtb.Text == placeholderText)
                {
                    rtb.Text = "";
                    rtb.ForeColor = Color.Black; // color normal
                }
            };

            rtb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(rtb.Text))
                {
                    rtb.Text = placeholderText;
                    rtb.ForeColor = Color.Gray;
                }
            };
        }
    }
}
