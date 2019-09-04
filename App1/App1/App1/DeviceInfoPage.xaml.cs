﻿using App1.ViewModel;
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
            ttt.Text = deviseViewModel.DeviceName;
		}
	}
}