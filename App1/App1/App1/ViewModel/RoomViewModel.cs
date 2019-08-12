using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.ViewModel
{
    //todo: properties "UserId"
    public class RoomViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Room _room;

        public RoomViewModel()
        {
            _room = new Room();
        }
        /// <summary>
        /// Уникальный номер в базе данных
        /// </summary>
        public int RoomId
        {
            get { return _room.RoomId; }
            set
            {
                if (_room.RoomId != value)
                {
                    _room.RoomId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Номер пользователя
        /// </summary>
        public int UserId
        {
            get { return _room.UserId; }
            set
            {
                if (_room.UserId != value)
                {
                    _room.UserId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Уникальный идентификатор наименования комнаты
        /// </summary>
        public int RoomNameId
        {
            get { return _room.RoomNameId; }
            set
            {
                if (_room.RoomNameId != value)
                {
                    _room.RoomNameId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }
   
        /// <summary>
        /// Уникальный идентификатор устройства
        /// </summary>
        public int DeviceId
        {
            get { return _room.DeviceId; }
            set
            {
                if (_room.DeviceId != value)
                {
                    _room.DeviceId = value;
                    OnPropertyChanged("UserId");
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
