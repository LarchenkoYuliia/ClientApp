using App1.Repositories;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddDevicePage : ContentPage
	{
		public AddDevicePage ()
		{
			InitializeComponent ();
            DevicesRepository viewModel = new DevicesRepository();
            DevicesListView.ItemsSource = viewModel.DeviceList;
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}