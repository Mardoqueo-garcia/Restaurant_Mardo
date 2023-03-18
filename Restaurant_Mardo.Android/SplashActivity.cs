using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_Mardo.Droid
{
    [Activity(Label = "Restaurant Mardo", Icon = "@mipmap/iconappsm", Theme = "@style/SplashTheme",
        MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //indicaremos que queremos iniciar esta actividad
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}