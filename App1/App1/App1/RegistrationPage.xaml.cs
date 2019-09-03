using App1.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrationPage : ContentPage
	{
        private UserViewModel _userViewModel = new UserViewModel();
		public RegistrationPage ()
		{
			InitializeComponent ();
		}

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            if (SurnameTextInput.Text == string.Empty)
            {
                TextLayoutSurname.HasError = true;
            }
            else
            {
                TextLayoutSurname.HasError = false;
            }

            if (NameTextInput.Text == string.Empty)
            {
                TextLayoutName.HasError = true;
            }
            else
            {
                TextLayoutName.HasError = false;
            }

            if (LoginRegTextInput.Text == string.Empty)
            {
                TextLayoutLogin.HasError = true;
            }
            else
            {
                TextLayoutLogin.HasError = false;
            }

            if (PasswordRegTextInput.Text == string.Empty)
            {
                TextLayoutPassword.HasError = true;
            }
            else
            {
                TextLayoutPassword.HasError = false;
            }
            _userViewModel.UserPassword = PasswordRegTextInput.Text.ToString();
            _userViewModel.UserPasswordRe = PasswordReTextInput.Text.ToString();
            if (!_userViewModel.UserPassword.Equals(_userViewModel.UserPasswordRe))
            {
                TextLayoutRePassword.HasError = true;
            }
            else
            {
                TextLayoutRePassword.HasError = false;
            }

            var _regRoomsPage = new RoomRegistration();
            //Navigation.PopAsync();
            Navigation.PushModalAsync(_regRoomsPage);
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}