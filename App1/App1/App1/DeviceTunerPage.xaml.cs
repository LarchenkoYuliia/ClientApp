using App1.Repositories;
using App1.ViewModel;
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

        public DeviceViewModel DeviceViewModel { get; set; }

        public DeviceTuner ()
		{
			InitializeComponent ();
            ImageButtonAddDevice.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            DevicesRepository viewModel = new DevicesRepository();
            DeviceListView.ItemsSource = viewModel.DeviceList;
        }

        private void openInfoDevicePage(DeviceViewModel deviceViewModel)
        {
            var _deviceInfoPagee = new DeviceInfoPage(deviceViewModel);
            Navigation.PushModalAsync(_deviceInfoPagee);
            this.DeviceListView.ResetSwipe();
        }

        private async void  deleteDevice(DeviceViewModel deviceViewModel)
        {
            this.DeviceListView.ResetSwipe();
            
            var answer = await DisplayAlert("Удалить устройство?", string.Format("Удаление {0} из списка устройств", deviceViewModel.DeviceName), "Yes", "No");
            if (answer)
            {
                //todo: добавить удаление устройства (удаление в БД)
                await DisplayAlert("Wait", "Удаление в разработке", "Cancel");
            }
        }

        private void ImageButtonAddDevice_Clicked(object sender, EventArgs e)
        {
            var _addDevicePage = new AddDevicePage();
            Navigation.PushModalAsync(_addDevicePage);
        }

        private void InfoImg_BindingContextChanged(object sender, EventArgs e)
        {
            if (infoImage == null)
            {
                infoImage = sender as Image;
                (infoImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(async() =>
                    {
                        if(infoImage != null && infoImage.BindingContext != null)
                        {
                            DeviceViewModel = infoImage.BindingContext as DeviceViewModel;
                            openInfoDevicePage(DeviceViewModel);
                        }
                    })
                });

                infoImage.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            }
        }

        private void DeleteImg_BindingContextChanged(object sender, EventArgs e)
        {
            if (deleteImage == null)
            {
                deleteImage = sender as Image;
                (deleteImage.Parent as View).GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(async () => 
                     {
                         if(deleteImage != null && deleteImage.BindingContext != null)
                         {
                             DeviceViewModel = deleteImage.BindingContext as DeviceViewModel;
                             deleteDevice(DeviceViewModel);
                         }
                     })
                });

                deleteImage.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            }
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void DeviceListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            var selectedDevice = e.ItemData as DeviceViewModel;
            var _settingsDevisePage = new SettingsDevisePage(selectedDevice);
            Navigation.PushModalAsync(_settingsDevisePage);
        }
    }
}