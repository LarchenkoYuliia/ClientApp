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
        Image infoImage;
        Image settingsImage;
        Image deleteImage;
        int itemIndex = -1;

        public DeviceTuner ()
		{
			InitializeComponent ();
            ImageButtonAddDevice.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            DevicesRepository viewModel = new DevicesRepository();
            DeviceListView.ItemsSource = viewModel.DeviceList;
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

        private void InfoImg_BindingContextChanged(object sender, EventArgs e)
        {
            if (infoImage == null)
            {
                infoImage = sender as Image;
                //(infoImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(SetFavorites) });
                infoImage.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            }
        }

        private void SettingsImg_BindingContextChanged(object sender, EventArgs e)
        {
            if (settingsImage == null)
            {
                settingsImage = sender as Image;
                //(settingsImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(SetFavorites) });
                settingsImage.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            }
        }

        private void DeleteImg_BindingContextChanged(object sender, EventArgs e)
        {
            if (deleteImage == null)
            {
                deleteImage = sender as Image;
                //(deleteImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(SetFavorites) });
                deleteImage.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            }
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}