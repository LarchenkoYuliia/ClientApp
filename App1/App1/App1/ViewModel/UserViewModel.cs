using App1.Models;
using System.ComponentModel;

namespace App1.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private User _user;

        public UserViewModel()
        {
            _user = new User();
        }

        /// <summary>
        /// Уникальный номер пользователя
        /// </summary>
        public int UserID
        {
            get { return _user.UserID; }
            set
            {
                if (_user.UserID != value)
                {
                    _user.UserID = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName
        {
            get { return _user.UserName; }
            set
            {
                if (_user.UserName != value)
                {
                    _user.UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string UserSurname
        {
            get { return _user.UserSurname; }
            set
            {
                if (_user.UserSurname != value)
                {
                    _user.UserSurname = value;
                    OnPropertyChanged("UserSurname");
                }
            }
        }

        /// <summary>
        /// Логин
        /// </summary>
        public string UserLogin
        {
            get { return _user.UserLogin; }
            set
            {
                if (_user.UserLogin != value)
                {
                    _user.UserLogin = value;
                    OnPropertyChanged("UserLogin");
                }
            }
        }

        /// <summary>
        /// Пароль
        /// </summary>
        public string UserPassword
        {
            get { return _user.UserPassword; }
            set
            {
                if (_user.UserPassword != value)
                {
                    _user.UserPassword = value;
                    OnPropertyChanged("UserPassword");
                }
            }
        }

        /// <summary>
        /// Пароль повторный
        /// </summary>
        public string UserPasswordRe
        {
            get { return _user.UserPasswordRe; }
            set
            {
                if (_user.UserPasswordRe != value)
                {
                    _user.UserPasswordRe = value;
                    OnPropertyChanged("UserPasswordRe");
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
