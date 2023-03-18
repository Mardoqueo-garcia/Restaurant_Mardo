using Restaurant_Mardo.Views.ViewsOther;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_Mardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyHomeMasterFlyout : ContentPage
    {
        public ListView ListView;

        public MyHomeMasterFlyout()
        {
            InitializeComponent();

            BindingContext = new MyHomeMasterFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MyHomeMasterFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyHomeMasterFlyoutMenuItem> MenuItems { get; set; }

            public MyHomeMasterFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyHomeMasterFlyoutMenuItem>(new[]
                {
                    new MyHomeMasterFlyoutMenuItem { Id = 0, Title = "Inicio", IconSource = "HomeIcon.png", TargetType=typeof(HomePage)},
                    new MyHomeMasterFlyoutMenuItem { Id = 1, Title = "Comida", IconSource = "FoodIcon.png", TargetType=typeof(FoodsPage) },
                    new MyHomeMasterFlyoutMenuItem { Id = 2, Title = "Bebidas", IconSource = "DrinkIcon.png", TargetType=typeof(DrinkPage) },
                    new MyHomeMasterFlyoutMenuItem { Id = 3, Title = "Postres", IconSource = "DessertIcon.png", TargetType=typeof(DessertPage) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion

        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            //cerramos seseion
            Navigation.PushAsync(new LoginPage());
        }
    }
}