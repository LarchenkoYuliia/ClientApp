using App1.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeviceInfoPage : ContentPage
	{
        public DeviceViewModel DeviceViewModel { get; set; }

		public DeviceInfoPage (DeviceViewModel deviceViewModel)
		{
			InitializeComponent ();
            init(deviceViewModel);
            DeviceInfoName.Text = DeviceViewModel.DeviceName;
            DeviceInfoModel.Text = DeviceViewModel.Model;
            
            if(DeviceViewModel.WarrantyExpirationDate != DateTime.MinValue)
            {
                var date = DeviceViewModel.WarrantyExpirationDate.Date;
                var day = string.Empty;
                var month = string.Empty;
                var year = string.Empty;
                if(date.Day < 10)
                {
                    day = "0" + date.Day.ToString();
                }
                if(date.Month < 10)
                {
                    month = "0" + date.Month.ToString();
                }
                year = date.Year.ToString();
                DateTextInput.Value = day + "/" + month + "/" + year;
            }
            //DeviceInfoWarrantyExpirationDate.Text = string.Format("Дата истечения гарантийного срока {0}",
            //    deviseViewModel.WarrantyExpirationDate.ToShortDateString());
            //todo: добавить возможность корректировки даты истечения срока годности
		}

        private void init(DeviceViewModel deviceViewModel)
        {
            DeviceViewModel = deviceViewModel;
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void DateTextInput_ValueChanged(object sender, Syncfusion.XForms.MaskedEdit.ValueChangedEventArgs eventArgs)
        {
            /*string date = eventArgs.Value.ToString();

            if (!string.IsNullOrEmpty(date))
            {
                try
                {
                    DateTime datetime = DateTime.ParseExact(date, CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern, CultureInfo.InvariantCulture);
                    
                        DeviceViewModel.WarrantyExpirationDate = datetime.Date;
                        //DeviceViewModel.IsChange = true;
                        DisplayAlert("ok","ok", "ok");
                    
                }
                catch (Exception exception)
                {
                    DisplayAlert("Error", "Invalid Date format", "Ok");
                }
            }*/
        }
    }
}