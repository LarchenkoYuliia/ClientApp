using App1.Repositories;
using App1.ViewModel;
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

        private async void DevicesListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            var selectedDevice = e.ItemData as DeviceViewModel;
            var answer = await DisplayAlert("Добавить устройство?", string.Format("Добавление {0}", selectedDevice.DeviceName), "Yes", "No");
            if (answer)
            {
                //todo: добавить процедуру добавления комнат
                await DisplayAlert("Da", "da", "ok");
            }

            await Navigation.PopModalAsync();
            return;
        }
    }
}