using ScrollApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollApp2.ViewModels
{
    public class ProductPageViewModel : BindableObject
    {
        public ObservableCollection<ProductModel> WineList { get; set; }
        public ObservableCollection<ProductModel> AllDrinksList { get; set; }

        public ProductPageViewModel()
        {
            WineList = new ObservableCollection<ProductModel>();
            WineList.Add(new ProductModel
            {
                ProductId = 1,
                ProductName = "Wine 101",
                Quantity = "4",
            });
            //WineList.Add(new ProductModel { ProductId = 1, ProductName = "Wine 1", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });
            //WineList.Add(new ProductModel { ProductId = 2, ProductName = "Wine 2", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });
            //WineList.Add(new ProductModel { ProductId = 3, ProductName = "Wine 3", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });
            //WineList.Add(new ProductModel { ProductId = 4, ProductName = "Wine 4", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });


            //   CitiesList = GetCities().OrderBy(t => t.Value).ToList();

            AllDrinksList = new ObservableCollection<ProductModel>();
        }
    }
}
