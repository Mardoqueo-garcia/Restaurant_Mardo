﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_Mardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyHomeMaster : FlyoutPage
    {
        public MyHomeMaster()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        //creamos un metodo para saber que al tocar algo de nuestra lista, esta nos lleve a la pantalla
        //que demos click
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //le pasamos lo que seleccionemos
            var item = e.SelectedItem as MyHomeMasterFlyoutMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}