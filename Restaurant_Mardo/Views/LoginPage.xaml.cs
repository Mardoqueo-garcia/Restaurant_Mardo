using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_Mardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            //validamos los datos que ingresen en nuestros entry
            if (txtUser.Text == "Mardoqueo" && txtPassword.Text == "0580")
            {
                //si son correctos nos enviara a la pagiona de inicio
                Navigation.PushAsync(new MyHomeMaster());
            }
            else
            {

                DisplayAlert("Advertencia", "El usuario o clave son incorrectos", "Aceptar");
                txtUser.Focus();
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //este es cuando den un toque a nuestro label, nos llevara a la pantalla de registros
            Navigation.PushAsync(new RegistroPage());
        }
    }
}