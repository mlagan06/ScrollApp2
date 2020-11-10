using ScrollApp2.ViewModels;
using ScrollApp2.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScrollApp2.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
      // ProductPageViewModel PPVM = new ProductPageViewModel();

        //        public int ProductId { get; set; }
        //        public string ProductName { get; set; }
        //        public string Quantity { get; set; }
        //    }
        //}
        //Event
        public event PropertyChangedEventHandler PropertyChanged;

        //Fields
        //[PrimaryKey, AutoIncrement]
        private int _ProductId;
        private string _ProductName;
        private string _Quantity;
        private string tempQuantity = "-1";

        //Constructor
        public ProductModel()
        {
            //Subscription
            this.PropertyChanged += OnPropertyChanged;
           // _ProductId = ProductId;

        }

        [PrimaryKey, AutoIncrement]
        public int ProductId
        {
            get { return _ProductId; }
            set
            {
                if (_ProductId == value) return;
                _ProductId = value;
                OnPropertyChanged();
            }
        }

        //Properties
        public string Quantity
        {
            get {
                App.QuantityPreviouslyDeleted = Convert.ToInt32(_Quantity);
               // tempQuantity = _Quantity;
               // return _Quantity;

                if (_Quantity == null) return "";
                else return _Quantity;
            }
            set
            {
                if (_Quantity == "0")
                {
                    

                    //RemoveItem();
                }
                _Quantity = value;
                OnPropertyChanged();
            }
        }

        //public async Task RemoveItem()
        //{
        //    var action = await DisplayAlert("Are you sure you want to remove ", productName + ".", "Yes", "No");

        //    if (action)
        //    {
        //        var x = 1;
        //    }
        //    else // user clicks 'NO' when asked if wish to remove item
        //    {
        //        var x = 2;
        //    }
        //}

        public string ProductName
        {
            get { return _ProductName; }
            set
            {
                _ProductName = value;
                OnPropertyChanged();
            }
        }

        //[MaxLength(50)]
        //public string Description { get; set; }

        //public string Image { get; set; }

        //public decimal Price { get; set; }

        //public decimal SubTotalForItem { get; set; }

        //public string Genre { get; set; }

        //OnPropertyChanged
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Quantity))
            {
                //Do anything that needs doing when the Quantity changes here...
                //var time = "hello

                if (Convert.ToInt32(_Quantity) == 0)
                {
                   // RemoveItem("jimmy");


                }
            }
        }

        // [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task RemoveItem(string productName)
        {
            //Call 
           // ProductPage p = new ProductPage();
           // await p.RemoveItem("jimmy");
        }
    }
}
