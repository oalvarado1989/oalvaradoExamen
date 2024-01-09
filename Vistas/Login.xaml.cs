using System.Security.Principal;

namespace oalvaradoExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
        string[] contrase�as = { "uisrael2024", "parcial1", "2024" };

        string usuarioIngresado = txtUsuario.Text;
        string contrase�aIngresada = txtContrasena.Text;

        bool autenticado = false;
        int indiceUsuario = -1;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioIngresado && contrase�as[i] == contrase�aIngresada)
            {
                autenticado = true;
                indiceUsuario = i;
                break;
            }
        }

        if (autenticado)
        {
            string usuario = txtUsuario.Text;

            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        else
        {
            DisplayAlert("Error de autenticaci�n","Dato incorrecto", "OK");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informaci�n del Desarrollador", "Nombre: Javier Alvarado \nCurso: 8vo A\n","Ok");
    }
}
