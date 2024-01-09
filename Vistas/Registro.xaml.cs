namespace oalvaradoExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario conectado: " + usuario;
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double montoInicial = Convert.ToDouble(txtMonto.Text);
        double pagoMensual = (1500 - montoInicial)/ 4 + (0.4 * 1500);
        double total = montoInicial + (pagoMensual * 4);

        if(montoInicial>=1500)
        {
            DisplayAlert("Error de autenticación", "Error", "OK");
        }
        else
        {
            txtPagoMensual.Text = pagoMensual.ToString();
        }
 
    }


    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = Fecha.Date.ToString();
        string ciudad = Ciudad.Items.Count.ToString();
        string pais = Pais.Items.Count.ToString();
        string montoInicial = txtMonto.Text;
        string pagoMensual = txtPagoMensual.Text;
        double total = Convert.ToDouble(montoInicial) + Convert.ToDouble(pagoMensual);

        DisplayAlert("RESUMEN \n", "Nombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad + 
            "\nFecha: " + fecha + "\nCiudad: " + ciudad + "\nPais: " + pais + "\nMonto Inicial: " + montoInicial 
            + "\nPago Mensual: " + pagoMensual + "\nTotal: " + total, "OK");


    }
}