using App1.Models;
using System;
using System.ComponentModel;

namespace App1.ViewModel
{
    //todo: change properties "UserId"
    public class DeviceTypeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DeviceType _deviceType;

        public DeviceTypeViewModel()
        {
            _deviceType = new DeviceType();
        }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int DeviceTypeId
        {
            get { return _deviceType.DeviceTypeId; }
            set
            {
                if (_deviceType.DeviceTypeId != value)
                {
                    _deviceType.DeviceTypeId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Наименовение типа устройства
        /// </summary>
        public string DeviceTypeName
        {
            get { return _deviceType.DeviceTypeName; }
            set
            {
                if (_deviceType.DeviceTypeName != value)
                {
                    _deviceType.DeviceTypeName = value;
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
