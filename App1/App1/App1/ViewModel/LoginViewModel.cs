using App1.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModel
{
    public class LoginViewModel : BaseNotify
    {
        public string Login
        {
            get => _login;
            set
            {
                SetPropertyChanged(ref _login, value);
            }
        }
        private string _login;

        public string Password
        {
            get => _password;
            set
            {
                SetPropertyChanged(ref _password, value);
            }
        }
        private string _password;
    }
}
