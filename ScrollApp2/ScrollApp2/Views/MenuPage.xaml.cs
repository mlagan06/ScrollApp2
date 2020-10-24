using ScrollApp2.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Products, Title="Products", Icon =  "back_nav.png", Name = "test" },
                new HomeMenuItem {Id = MenuItemType.ShoppingCart, Title="Shopping Cart", Icon =  "back_nav.png"},
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse", Icon =  "back_nav.png"},
                new HomeMenuItem {Id = MenuItemType.About, Title="About", Icon =  "back_nav.png"},
                new HomeMenuItem {Id = MenuItemType.BarcodeReader, Title="Barcode Reader", Icon =  "back_nav.png"},
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        public int GetIdForNavigationMenu(string title)
        {
            //THIS IS NOT ID 'MENU ITEM TYPE' FROM MENU ITEM LIST, IT IS THE ID OF RECORD INSIDE THE MENU ITEMS LISTVIEW
            //as 'id' in first record is 'Id = MenuItemType.Products', but the id we need is the id of where this record is
            //stored inside menuItems ListView so, products will be '0', shoppingCart '1' etc...
            int IdOfMenuItemsRecordInsideList = 0;
            int tempId = -1;
            foreach (var v in menuItems)
            {
                if (v.Title == title)
                {
                    tempId = IdOfMenuItemsRecordInsideList;
                    break;
                }

                IdOfMenuItemsRecordInsideList++;
            }

            return tempId;
        }
    }
}