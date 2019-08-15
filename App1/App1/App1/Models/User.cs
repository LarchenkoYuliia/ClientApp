using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class User : UserRegistration
    {
        /// <summary>
       /// Уникальный номер пользователя
       /// </summary>
       public int UserID { get; set; }

       /// <summary>
       /// Имя пользователя
       /// </summary>
       public string UserName { get; set; }

       /// <summary>
       /// Фамилия
       /// </summary>
       public string UserSurname { get; set; }
    }
}
