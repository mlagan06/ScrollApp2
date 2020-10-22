using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ScrollApp2.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
        //Event
        public event PropertyChangedEventHandler PropertyChanged;

        //Fields
        private string _ProductName;
        private string _Quantity;

        //Constructor
        public ProductModel()
        {
            //Subscription
            this.PropertyChanged += OnPropertyChanged;
        }

        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }

        //Properties
        public string Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                OnPropertyChanged();
            }
        }

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

                if (_Quantity == "0")
                {
                   // Quantity = "6";
                }
            }
        }

       // [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
