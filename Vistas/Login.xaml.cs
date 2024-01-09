namespace jnarvaezExamen.Vistas;

public partial class Login : ContentPage
{
    string[] users = { "estudiante2024", "examen1", "Stali Sarango" };
    string[] passwords = { "uisrael2024", "parcial1", "2024" };
    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContrasena.Text;


        int index = Array.IndexOf(users, usuarioIngresado);
        if (index != -1 && passwords[index] == contrasenaIngresada)
        {

            string nombreUsuarioConectado = users[index];
            DisplayAlert("Bienvenido", $"¡Hola {nombreUsuarioConectado}!", "Aceptar");


            Navigation.PushAsync(new Registro(nombreUsuarioConectado));
        }
        else
        {

            DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "Cancelar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        
    }
}