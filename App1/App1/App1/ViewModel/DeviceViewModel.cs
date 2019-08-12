using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.ViewModel
{
    //todo: write property on OnPropertyChanged("UserId");
    public class DeviceViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        private Device _device;

        /// <summary>
        /// 
        /// </summary>
        public DeviceViewModel()
        {
            _device = new Device();
        }

        /// <summary>
        /// Уникальный номер усройства
        /// </summary>
        public int DeviceId
        {
            get { return _device.DeviceId; }
            set
            {
                if (_device.DeviceId != value)
                {
                    _device.DeviceId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Название устройства
        /// </summary>
        public string DeviceName
        {
            get { return _device.DeviceName; }
            set
            {
                if (_device.DeviceName != value)
                {
                    _device.DeviceName = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Дата истечения гарантии устройства
        /// </summary>
        public DateTime WarrantyExpirationDate
        {
            get { return _device.WarrantyExpirationDate; }
            set
            {
                if (_device.WarrantyExpirationDate != value)
                {
                    _device.WarrantyExpirationDate = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// Модель устройства
        /// </summary>
        public string Model
        {
            get { return _device.Model; }
            set
            {
                if (_device.Model != value)
                {
                    _device.Model = value;
                    OnPropertyChanged("UserId");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
