using App1.Repositories;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeviceTuner : ContentPage
	{
        public DeviceTuner ()
		{
			InitializeComponent ();
            ImageButtonAddDevice.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            DevicesRepository viewModel = new DevicesRepository();
            DevicesListView.ItemsSource = viewModel.DeviceList;
        }

        private void ImageButtonAddDevice_Clicked(object sender, EventArgs e)
        {
            var _addDevicePage = new AddDevicePage();
            Navigation.PushModalAsync(_addDevicePage);
        }
    }
}