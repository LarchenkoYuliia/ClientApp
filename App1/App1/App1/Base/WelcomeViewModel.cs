using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.Base
{
    public class WelcomeViewModel : BaseViewModel
    {
        /// <summary>
        /// Первая надпись
        /// </summary>
        public string FirstLabelText
        {
            get { return _firstLabelText; }
            set { SetPropertyChanged(ref _firstLabelText, value); }
        }

        private string _firstLabelText;

        /// <summary>
        /// Первая надпись
        /// </summary>
        public string SecondLabelText
        {
            get { return _secondLabelText; }
            set { SetPropertyChanged(ref _secondLabelText, value); }
        }

        private string _secondLabelText;

        /// <summary>
        /// Текст на кнопке входа
        /// </summary>
        public string AuthButtonText
        {
            get { return _authButtonText; }
            set { SetPropertyChanged(ref _authButtonText, value); }
        }

        private string _authButtonText;

        public string AuthenticationStatus
        {
            get { return _authenticationStatus; }
            set { SetPropertyChanged(ref _authenticationStatus, value); }
        }

        private string _authenticationStatus;

        public WelcomeViewModel()
        {
            //Title = Resources.Welcome;
            //FirstLabelText = Resources.FirstGreetingsLine;
            //SecondLabelText = Resources.SecondGreetingsLine;
            //AuthButtonText = Resources.EnterCaps;
        }

        /// <summary>
        /// Попробовать залогиниться используя данные для входа из хранилища или из текущей сессии
        /// </summary>
        /// <returns></returns>
        /*public async Task<LoginInfo> TryLoginFromCurrentSessionOrSecureStorage()
        {
            AuthenticationStatus = Resources.SigningIn;
            LoginInfo result;
            using (new Busy(this))
            {
                result = await LoginHelper.TryLoginFromCurrentSessionOrSecureStorage();
            }
            AuthenticationStatus = string.Empty;
            return result;
        }*/
    }

}
