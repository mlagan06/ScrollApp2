using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ScrollApp2.Views;
using ScrollApp2.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ScrollApp2
{
    public partial class App : Application
    {
        public static string NoOfItemsInShoppingCartGlobalVar { get; set; }
        public static string NewPageToLoad { get; set; }
        public static ObservableCollection<ProductModel> globalShoppingCartOC { get; set; }
        public static Dictionary<int, int> GlobalWinePickerUniquieIdDict = new Dictionary<int, int>();
        public static int QuantityPreviouslyDeleted { get; set; }


        public App()
        {
            InitializeComponent();

            globalShoppingCartOC = new ObservableCollection<ProductModel>();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
