using ScrollApp2.Models;
using ScrollApp2.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPageViewModel productPage_ViewModal;
        private bool ZeroQuantitySelected = false;
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
       // private ObservableCollection<ProductModel> DrinksToPurchaseList = new ObservableCollection<ProductModel>();
        private bool isWineListVisible = false;
        private bool deleteProduct = false;

        public ProductPage()
        {
            InitializeComponent();
            productPage_ViewModal = new ProductPageViewModel();
            BindingContext = productPage_ViewModal;
        }

        private async void ShoppingCartClicked(object sender, EventArgs e)
        {
            var x = productPage_ViewModal;


            App.NewPageToLoad = "Shopping Cart";
            MenuPage tempMenu = new MenuPage();
            int IdOfMenuClicked = tempMenu.GetIdForNavigationMenu("Shopping Cart");

            App.globalShoppingCartOC = productPage_ViewModal.WineList;
            await RootPage.NavigateFromMenu(IdOfMenuClicked);
        }

        public async void QuantityChanged(Object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int quantity = picker.SelectedIndex;
            if (quantity == 0)
            {
                int previousQuantity = App.QuantityPreviouslyDeleted;
                await RemoveItem();

                if (deleteProduct)
                {
                    deleteProduct = false;
                    return;
                }

                picker.SelectedIndex = previousQuantity;
            }
        }

        public async Task RemoveItem()
        {
            string productName = "jim";
            var action = await DisplayAlert("Are you sure you want to remove ", productName + ".", "Yes", "No");

            if (action)
            {
                deleteProduct = true;
            }
            else // user clicks 'NO' when asked if wish to remove item
            {
                deleteProduct = false;
            }

        }

        //void QuantityChanged(object sender, EventArgs e)
        //{
        //    var x = 1;

        //    RemoveItem("beer 1");
        //}
        //    var picker = (Picker)sender;
        //    //var item = (ProductModel)picker.BindingContext;
        //    //DrinksToPurchaseList.Add(item);

        //    //Dummy Data used to test
        //    var _productId = 1;
        //    var _quantity = "4";
        //    var _productName = "WINE 110011";
        //    ProductModel item = new ProductModel() { ProductId = _productId, ProductName = _productName, Quantity = _quantity };

        //    DrinksToPurchaseList.Add(item);

        //}


    }
}