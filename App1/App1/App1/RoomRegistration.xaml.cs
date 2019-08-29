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
	public partial class RoomRegistration : ContentPage
	{
		public RoomRegistration ()
		{
			InitializeComponent ();
		}

        private void DoneButton_Clicked(object sender, EventArgs e)
        {
            var _mainControlPage = new MainControlPage();
            Navigation.PushModalAsync(_mainControlPage);
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}