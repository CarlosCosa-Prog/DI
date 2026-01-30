using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// usings necesarios para utilizar la API
using System.Net.Http;
using System.Text.Json;

namespace ejercicio2
{
    public partial class FormContenedorAPI : Form
    {
        // creación del cliente http
        private readonly HttpClient _httpClient = new HttpClient();
        public FormContenedorAPI()
        {
            InitializeComponent();
        }
        private async Task CargarClientesApiAsync()
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/users";

                // Petición GET
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                // Leer JSON
                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Deserializar usando TU clase ApiUser
                List<ApiUser> users =
                    JsonSerializer.Deserialize<List<ApiUser>>(json, options);

                // Personalizar datos para el DataGridView
                var data = users.Select(u => new
                {
                    u.Id,
                    Nombre = u.Name,
                    Usuario = u.Username,
                    Email = u.Email,
                    Ciudad = u.Address.City,
                    Telefono = u.Phone,
                    Empresa = u.Company.Name
                }).ToList();

                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes desde la API:\n" + ex.Message);
            }
        }

        private async void FormContenedorAPI_Load(object sender, EventArgs e)
        {
            await CargarClientesApiAsync();
        }
    }
}
