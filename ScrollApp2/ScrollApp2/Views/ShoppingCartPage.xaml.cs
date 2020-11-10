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
        private Dictionary<int, int> PickerUniquieIdDict = new Dictionary<int, int>();

        public decimal TotalForAllItems;

        public ShoppingCartPage ()
		{
            InitializeComponent();

            if (App.globalShoppingCartOC != null)
            {
                // ProductModel P = new ProductModel();
                //P.Add(new ProductModel { ProductId = 5, ProductName = "Gin", Image = "Gin.jpg", Description = "700ml", Price = 13.99M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });

                //App.globalShoppingCartOC.Add(new ProductModel { ProductId = 5, ProductName = "Gin", Quantity="3" });

                foreach (ProductModel Model in App.globalShoppingCartOC)
                {
                    var _quantity = Convert.ToDecimal(Model.Quantity);
                    if (_quantity > 0)
                    {
                        ShoppingCartViewModel.ShoppingCartList.Add(Model);
                    }
                }
            }

            if (App.GlobalWinePickerUniquieIdDict != null)
            {
                PickerUniquieIdDict = App.GlobalWinePickerUniquieIdDict;
            }

            NoItemsInShoppingCart.Text = App.NoOfItemsInShoppingCartGlobalVar;

            this.BindingContext = this;
            BindingContext = ShoppingCartViewModel;
        }

        void QuantityChanged(object sender, EventArgs e)
        {
            var x = 1;
        }

        void ShoppingCartClicked(object sender, EventArgs e)
        {
            var x = 1;
        }
    }
}