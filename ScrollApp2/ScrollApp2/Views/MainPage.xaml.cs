using ScrollApp2.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        int idOfNewPage;
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Products:
                        MenuPages.Add(id, new NavigationPage(new ProductPage()));
                        break;
                    case (int)MenuItemType.ShoppingCart:
                        MenuPages.Add(id, new NavigationPage(new ShoppingCartPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.BarcodeReader:
                        MenuPages.Add(id, new NavigationPage(new BarcodeReaderPage()));
                        break;
                }

                idOfNewPage = id;
            }

            idOfNewPage = id;

            var newPage = MenuPages[id];

            if (newPage != null)// && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;

                //  ListViewMenu.SelectedItem = 0;
            }
        }
    }
}
