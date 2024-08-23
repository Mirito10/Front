using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Front.Views.Login;

public partial class Login : ContentPage
{
    private readonly string laURL = "http://localhost:5180/";


    public Login()
    {
        InitializeComponent();
    }

    private async void Boton_Loguearse(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string password = contrasenaEntry.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Por favor, ingrese su correo y contraseña.", "OK");
            return;
        }

        var loginData = new
        {
            correo = email,  // Cambiado a 'correo'
            contrasena = password  // Cambiado a 'contrasena'
        };

        string jsonContent = JsonConvert.SerializeObject(loginData);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        using (HttpClient client = new HttpClient())
        {
            string fullUrl = laURL + "Usuario/Verificar";
            Debug.WriteLine($"URL completa: {fullUrl}");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = await client.PostAsync(fullUrl, content);

                string responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine($"Respuesta completa: {responseContent}");

                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Éxito", "Inicio de sesión exitoso!", "OK");
                }
                else
                {
                    await DisplayAlert("Error", $"Inicio de sesión fallido. Detalles: {responseContent}", "OK");
                }
            }
            catch (HttpRequestException httpEx)
            {
                await DisplayAlert("Error", $"Error de solicitud HTTP: {httpEx.Message}", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error inesperado: {ex.Message}", "OK");
            }

        }
    }


    private async void Boton_Registrarse(object sender, EventArgs e)
    {
        // Lógica de registro
    }
}


