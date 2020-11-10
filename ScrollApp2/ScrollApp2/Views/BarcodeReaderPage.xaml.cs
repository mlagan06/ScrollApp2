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
	public partial class BarcodeReaderPage : ContentPage
	{
		public BarcodeReaderPage()
		{
			InitializeComponent ();
		}

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scanResultText.Text = result.Text + " (type: " + result.BarcodeFormat.ToString() + ")";

                BarcodeCaptured.IsVisible = true;
            });
        }

        private void SaveNewProduct(object sender, EventArgs e)
        {
            ProductSaved.IsVisible = true;
        }

    }
}