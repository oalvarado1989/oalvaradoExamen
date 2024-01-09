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
        string[] contraseñas = { "uisrael2024", "parcial1", "2024" };

        string usuarioIngresado = txtUsuario.Text;
        string contraseñaIngresada = txtContrasena.Text;

        bool autenticado = false;
        int indiceUsuario = -1;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioIngresado && contraseñas[i] == contraseñaIngresada)
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
            DisplayAlert("Error de autenticación","Dato incorrecto", "OK");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Información del Desarrollador", "Nombre: Javier Alvarado \nCurso: 8vo A\n","Ok");
    }
}
