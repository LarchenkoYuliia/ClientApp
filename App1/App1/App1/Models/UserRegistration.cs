using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class UserRegistration
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string UserLogin { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string UserPassword { get; set; }

        /// <summary>
        /// Пароль повторный
        /// </summary>
        public string UserPasswordRe { get; set; }
    }
}
