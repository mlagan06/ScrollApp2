using ScrollApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollApp2.ViewModels
{
    public class ProductPageViewModel : BindableObject, INotifyPropertyChanged
    {
        public ObservableCollection<ProductModel> WineList { get; set; }



        // private ProductModel _productModel;

        public ProductPageViewModel()
        {

            //if (App.globalShoppingCartOC.Count > 0)
            //{
            //    _wineList = App.globalShoppingCartOC;
            //    WineList = App.globalShoppingCartOC;
            //    return;
            //}

            //Subscription
            //  this.PropertyChanged += OnPropertyChanged;

            //WineList = new ObservableCollection<ProductModel>();
            //WineList.Add(new ProductModel
            //{
            //    ProductId = 1,
            //    ProductName = "Wine 101",
            //    Quantity = "4",
            //});
            //WineList.Add(new ProductModel { ProductId = 1, ProductName = "Wine 1", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });
            //WineList.Add(new ProductModel { ProductId = 2, ProductName = "Wine 2", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });
            //WineList.Add(new ProductModel { ProductId = 3, ProductName = "Wine 3", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });
            //WineList.Add(new ProductModel { ProductId = 4, ProductName = "Wine 4", Image = "wine.jpg", Quantity = "0", Description = "700ml", Price = 13.99M, SubTotalForItem = 0.00M, Genre = "Wine" });

            WineList = new ObservableCollection<ProductModel>();
            WineList.Add(new ProductModel
            {
                ProductId = 1,
                ProductName = "Wine 101",//,
                Quantity = "0"
            });
            WineList.Add(new ProductModel
            {
                ProductId = 2,
                ProductName = "Wine 102",//,
                Quantity = "0"
            });
            WineList.Add(new ProductModel
            {
                ProductId = 3,
                ProductName = "Wine 103",//,
                Quantity = "0"
            });

            //   CitiesList = GetCities().OrderBy(t => t.Value).ToList();

            //_productModel = new ProductModel
            //{
            //    ProductId = 1,
            //    ProductName = "Wine 101",
            //    Quantity = "4",
            //};


            //  AllDrinksList = new ObservableCollection<ProductModel>();
        }

        //Event
        //public event PropertyChangedEventHandler PropertyChanged;

        //public ObservableCollection<ProductModel> AllDrinksList
        //{
        //    get { return _allDrinksList; }
        //    set
        //    {
        //        if (_allDrinksList != value)
        //        {
        //            _allDrinksList = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        ////Fields
        //private int _ProductId { get; set; }
        //private string _ProductName { get; set; }
        //private string _Quantity { get; set; }

        //[PrimaryKey, AutoIncrement]
        // public int ProductId { get; set; }

        //public int ProductId
        //{
        //    get { return _AllDrinksList.Where(x => x.ProductId == ProductId).FirstOrDefault().ProductId; }
        //    set
        //    {
        //        _AllDrinksList.Where(x => x.ProductId == ProductId).FirstOrDefault().ProductId = value;
        //        OnPropertyChanged();
        //    }


        //public int ProductId
        //{
        //    get { return _AllDrinksList.Where(x => x.ProductId == ProductId).FirstOrDefault().ProductId; }
        //    set
        //    {
        //        _AllDrinksList.Where(x => x.ProductId == ProductId).FirstOrDefault().ProductId = value;
        //        OnPropertyChanged();
        //    }
        //}

        //Properties
        //public string Quantity
        //{
        //    get
        //    {
        //        return _wineList.FirstOrDefault().Quantity;
        //    }
        //    set
        //    {
        //        var a = _wineList;
        //        var b = WineList;
        //        _wineList.FirstOrDefault().Quantity = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public string ProductName
        //{
        //    get { return _ProductName; }
        //    set
        //    {
        //        _ProductName = value;
        //        OnPropertyChanged();
        //    }
        //}

        //[MaxLength(50)]
        //public string Description { get; set; }

        //public string Image { get; set; }

        //public decimal Price { get; set; }

        //public decimal SubTotalForItem { get; set; }

        //public string Genre { get; set; }

        // OnPropertyChanged
        //private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    var a = e.PropertyName;

        //    var x = 1;
        //    //if (e.PropertyName == nameof(Quantity))
        //    //{
        //    //    //Do anything that needs doing when the Quantity changes here...
        //    //    var time = "hello";

        //    //    //if (Convert.ToInt32(_Quantity) > 0)
        //    //    //{
        //    //    //    // globalShoppingCartOC.Add
        //    //    //    // Quantity = "6";
        //    //    //}
        //    //}
        //}

        ////[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //  public async Task RemoveItem(string productName, int productId, int quantityToRemove)

    }
}
