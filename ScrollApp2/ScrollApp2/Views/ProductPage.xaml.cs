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
        private ObservableCollection<ProductModel> DrinksToPurchaseList = new ObservableCollection<ProductModel>();
        private bool isWineListVisible = false;

        public ProductPage()
        {
            InitializeComponent();
            productPage_ViewModal = new ProductPageViewModel();
            BindingContext = productPage_ViewModal;
        }

        private async void ShoppingCartClicked(object sender, EventArgs e)
        {
            App.NewPageToLoad = "Shopping Cart";
            MenuPage tempMenu = new MenuPage();
            int IdOfMenuClicked = tempMenu.GetIdForNavigationMenu("Shopping Cart");

            App.globalShoppingCartOC = DrinksToPurchaseList;
            await RootPage.NavigateFromMenu(IdOfMenuClicked);
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            //var item = (ProductModel)picker.BindingContext;
            //DrinksToPurchaseList.Add(item);
             
            //Dummy Data used to test
            var _productId = 1;
            var _quantity = "4";
            var _productName = "WINE 110011";
            ProductModel item = new ProductModel() { ProductId = _productId, ProductName = _productName, Quantity = _quantity };

            DrinksToPurchaseList.Add(item);

        }
    }
}