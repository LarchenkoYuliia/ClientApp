using App1.Repositories;
using App1.ViewModel;
using Syncfusion.ListView.XForms;
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
	public partial class DeviceTuner : ContentPage
	{
        public DeviceTuner ()
		{
			InitializeComponent ();
            ImageButtonAddDevice.Source = ImageSource.FromResource("App1.Resources.nightstand.png");
            DevicesRepository viewModel = new DevicesRepository();
            DevicesListView.ItemsSource = viewModel.DeviceList;
            
        }

    }
}