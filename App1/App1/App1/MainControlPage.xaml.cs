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
	public partial class MainControlPage : ContentPage
	{
		public MainControlPage ()
		{
			InitializeComponent ();
            FirstButton.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            SecondButton.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            ThirdButton.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            FourthButton.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            FiveButton.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            SixhButton.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            ImageBadroom.Source = ImageSource.FromResource("App1.Resources.nightstand.png");

            FirstButton1.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            SecondButton1.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            ThirdButton1.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            FourthButton1.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            FiveButton1.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            SixhButton1.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            ImageBadroom1.Source = ImageSource.FromResource("App1.Resources.nightstand.png");

            FirstButton2.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            SecondButton2.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            ThirdButton2.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            FourthButton2.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            FiveButton2.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            SixhButton2.ImageSource = ImageSource.FromResource("App1.Resources.nightstand.png");
            ImageBadroom2.Source = ImageSource.FromResource("App1.Resources.nightstand.png");

        }
	}
}