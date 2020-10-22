using ScrollApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ScrollApp2.ViewModels
{
    public class ShoppingCartViewModel
    {
        //  public ObservableCollection<ProductModel> FoodList { get; set; }
        public ObservableCollection<ProductModel> ShoppingCartList { get; set; }

        public ShoppingCartViewModel()
        {
            //FoodList = new ObservableCollection<ProductModel>();
            //FoodList.Add(new ProductModel { ProductId = 1, ProductName = "Guinness", Image = "Guinness.jpg", Description = "12 x 300ml Cans", Price = 12.50M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });
            //FoodList.Add(new ProductModel { ProductId = 2, ProductName = "Harp", Image = "Harp.jpg", Description = "12 x 440ml Cans", Price = 9.99M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });
            //FoodList.Add(new ProductModel { ProductId = 3, ProductName = "Whiskey", Image = "Jameson.jpg", Description = "700ml", Price = 10.00M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });
            //FoodList.Add(new ProductModel { ProductId = 4, ProductName = "Vodka", Image = "Smirnoff.jpg", Description = "1000ml", Price = 13.99M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });
            //FoodList.Add(new ProductModel { ProductId = 5, ProductName = "Gin", Image = "Gin.jpg", Description = "700ml", Price = 13.99M, Quantity = 0, SubTotalForItem = 0.00M, Genre = "Wine" });

            ShoppingCartList = new ObservableCollection<ProductModel>();

            //   CitiesList = GetCities().OrderBy(t => t.Value).ToList();
        }
    }
}
