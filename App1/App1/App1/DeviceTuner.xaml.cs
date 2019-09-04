using App1.Repositories;
using App1.ViewModel;
using Syncfusion.XForms.Buttons;
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

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {
            if(sender == null)
            {
                return;
            }
            var button = sender as SfButton;
            if(button == null)
            {
                return;
            }
            var deviceViewModel = button.BindingContext;
            var _settingsDevisePage = new SettingsDevisePage(deviceViewModel as DeviceViewModel);
            Navigation.PushModalAsync(_settingsDevisePage);
        }

        private void InfoButton_Clicked(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var button = sender as SfButton;
            if (button == null)
            {
                return;
            }
            var deviceViewModel = button.BindingContext;
            var _deviceInfoPage = new DeviceInfoPage(deviceViewModel as DeviceViewModel);
            Navigation.PushModalAsync(_deviceInfoPage);
        }
    }
}