using Restaurant_Mardo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_Mardo
{
    public partial class App : Application
    {
        public static object Navigator { get; internal set; }

        public App()
        {
            InitializeComponent();
            //hacemos esto para que podamos usar la navegacion de paginas, nuestra primer pagina a mostrar
            // es la de inicio de sesion
            MainPage = new NavigationPage(new MyHomeMaster());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
