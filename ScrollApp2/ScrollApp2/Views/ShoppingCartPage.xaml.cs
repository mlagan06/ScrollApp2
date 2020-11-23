using ScrollApp2.Models;
using ScrollApp2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollApp2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShoppingCartPage : ContentPage
    {
        ShoppingCartViewModel ShoppingCartViewModel = new ShoppingCartViewModel();
        //private Dictionary<int, int> PickerUniquieIdDict = new Dictionary<int, int>();

        public decimal TotalForAllItems;
        private bool deleteProduct = false; 

       public ShoppingCartPage ()
		{
            InitializeComponent();

            //if (App.globalShoppingCartOC != null)
            //{
            //    // ProductModel P = new ProductModel();
            //    //P.Add(new ProductModel { ProductId = 5, ProductName = "Gin", Image = "Gin.jpg", Description = "700ml", Price = 13.99M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });

            //    //App.globalShoppingCartOC.Add(new ProductModel { ProductId = 5, ProductName = "Gin", Quantity="3" });

            //    foreach (ProductModel Model in App.globalShoppingCartOC)
            //    {
            //        var _quantity = Convert.ToDecimal(Model.Quantity);
            //        if (_quantity > 0)
            //        {
            //            ShoppingCartViewModel.ShoppingCartList.Add(Model);
            //        }
            //    }
            //}

            var x = App.globalShoppingCartOC;



            //if (App.GlobalWinePickerUniquieIdDict != null)
            //{
            //    PickerUniquieIdDict = App.GlobalWinePickerUniquieIdDict;
            //}

           // NoItemsInShoppingCart.Text = App.NoOfItemsInShoppingCartGlobalVar;

         //   this.BindingContext = this;
            BindingContext = ShoppingCartViewModel;
        }

        public async void QuantityChanged(object sender, EventArgs e)
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
            else
            {
              //  ShoppingCartViewModel.ShoppingCartList.Clear();

              //  App.globalShoppingCartOC = ShoppingCartViewModel.ShoppingCartList;

                var x = 1;

              //  App.globalShoppingCartOC.Where(x => x.ProductId == 1).FirstOrDefault().Quantity = product.Quantity;
                //App.globalShoppingCartOC.Add(new ProductModel
                //{
                //    ProductId = 5,
                //    ProductName = "Wine Wine Wine",
                //    Quantity = quantity.ToString()
                //});
                //App.globalShoppingCartOC.Add(new ProductModel
                //{
                //    ProductId = 5,
                //    ProductName = "Wine 105",
                //    Quantity = quantity.ToString()
                //});
                //App.globalShoppingCartOC.Add(new ProductModel
                //{
                //    ProductId = 5,
                //    ProductName = "Wine 105",
                //    Quantity = quantity.ToString()
                //});
            }
        }

        protected override void OnDisappearing()
        {
            var x = 1;

            App.globalShoppingCartOC = ShoppingCartViewModel.ShoppingCartList;
          //  ShoppingCartViewModel.ShoppingCartList.Clear();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //your code here;

          //  var a = App.globalShoppingCartOC;

           // var c = ShoppingCartViewModel.ShoppingCartList;

            ShoppingCartViewModel.ShoppingCartList.Clear();

            if(ShoppingCartViewModel.ShoppingCartList.Count < 1)
            {
                // ShoppingCartViewModel.ShoppingCartList = App.globalShoppingCartOC;
                // return

                foreach (ProductModel Model in App.globalShoppingCartOC)
                {
                    var _quantity = Convert.ToDecimal(Model.Quantity);
                    if (_quantity > 0)
                    {
                        ShoppingCartViewModel.ShoppingCartList.Add(Model);
                    }
                }

                return;
            }

            //foreach (var product in App.globalShoppingCartOC)
            //{
            //    var _quantity = Convert.ToDecimal(product.Quantity);
            //    if (_quantity > 0)
            //    {
            //        //TODO NEED TO ADD IN STATMENT TO CHECK IF EXISTS, IF SO, UPDATE, IF NOT ADD
            //        ShoppingCartViewModel.ShoppingCartList.Where(x => x.ProductId == product.ProductId).FirstOrDefault().Quantity = product.Quantity;
            //    }
            //    else
            //    {
            //        ShoppingCartViewModel.ShoppingCartList.Remove(ShoppingCartViewModel.ShoppingCartList.Where(x => x.ProductId == product.ProductId).FirstOrDefault());
            //    }
            //   // ShoppingCartViewModel.ShoppingCartList.Add(product);

            //    //var _quantity = Convert.ToDecimal(product.Quantity);
            //    // if (_quantity > 0)
            //    //   ShoppingCartViewModel.ShoppingCartList.Where(x => x.ProductId == product.ProductId).FirstOrDefault().Quantity = product.Quantity;
            //}

            //var d = ShoppingCartViewModel.ShoppingCartList;
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

        void ShoppingCartClicked(object sender, EventArgs e)
        {
            var x = 1;
        }
    }
}