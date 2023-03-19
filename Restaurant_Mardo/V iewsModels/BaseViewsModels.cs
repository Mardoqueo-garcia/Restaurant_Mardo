using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; // para tareas asincronas
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;


namespace Restaurant_Mardo.V_iewsModels
{
    public class BaseViewsModels
    {
        public class BaseViewModel : INotifyPropertyChanged
        {
            //INotifyPropertyChanged : nos notifica si un dato de nuestra vista se altera y lo actualiza al nuevo dato

            //cuando queremos navegar de una pagina uno a otra pagina
            public INavigation Navigation;

            public event PropertyChangedEventHandler PropertyChanged;

            //este controlador es para ver que comando se ha modificado y asi lo actualiza
            public void OnpropertyChanged([CallerMemberName] string nombre = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
            }

            //es paea cuando queramos controlar fotos en nuestra aplicacion
            private ImageSource foto;
            public ImageSource Foto
            {
                get { return foto; }
                set
                {
                    foto = value;
                    OnpropertyChanged();
                }
            }

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            //cuando queremos manejar alertas dentro de nuestro viewsmodels
            public async Task DisplayAlert(string title, string message, string cancel)
            {
                await Application.Current.MainPage.DisplayAlert(title, message, cancel);
            }

            public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
            {
                return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
            }

            protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
            {
                if (EqualityComparer<T>.Default.Equals(field, value))
                {
                    return false;
                }

                field = value;
                OnPropertyChanged(propertyName);

                return true;
            }

            private string _title;
            public string Title
            {
                get { return _title; }
                set
                {
                    SetProperty(ref _title, value);
                }
            }

            //cuando queramos trabajar datos de tipo booleano
            private bool _isBusy;
            public bool IsBusy
            {
                get { return _isBusy; }
                set
                {
                    SetProperty(ref _isBusy, value);
                }
            }

            //encargado de recibir informacion, por ejmeplo de un entry
            protected void SetValue<T>(ref T backingFieled, T value, [CallerMemberName] string propertyName = null)
            {
                if (EqualityComparer<T>.Default.Equals(backingFieled, value))

                {

                    return;

                }

                backingFieled = value;

                OnPropertyChanged(propertyName);
            }
        }
    }
}
