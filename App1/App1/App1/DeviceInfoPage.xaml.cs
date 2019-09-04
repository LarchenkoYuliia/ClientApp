using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeviceInfoPage : ContentPage
	{
		public DeviceInfoPage (DeviceViewModel deviseViewModel)
		{
			InitializeComponent ();
            DeviceInfoName.Text = deviseViewModel.DeviceName;
            DeviceInfoModel.Text = deviseViewModel.Model;
            DeviceInfoWarrantyExpirationDate.Text = string.Format("Дата истечения гарантийного срока {0}",
                deviseViewModel.WarrantyExpirationDate.ToShortDateString());
            //todo: добавить возможность корректировки даты истечения срока годности
		}

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}