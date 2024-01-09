namespace oalvaradoExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario conectado: " + usuario;
	}
}