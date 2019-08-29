using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private LoginViewModel _viewModel = new LoginViewModel();

        private void Login_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(LoginTextInput.Text))
            {
                LoginTextLayout.HasError = true;
            }
            else
            {
                LoginTextLayout.HasError = false;
            }
            if (string.IsNullOrEmpty(PasswordTextInput.Text))
            {
                PasswordTextLayout.HasError = true;
            }
            else
            {
                PasswordTextLayout.HasError = false;
            }
            _viewModel.Login =  LoginTextInput.Text.ToString();
            _viewModel.Password = PasswordTextInput.Text.ToString();
            var _mainControlPage = new MainControlPage();
            Navigation.PushModalAsync(_mainControlPage);
        }

        private void AuthButton_Clicked(object sender, EventArgs e)
        {
            var _regPage = new RegistrationPage();
            Navigation.PushModalAsync(_regPage);
        }
    }
}
