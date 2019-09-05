using Android.Widget;
using App1.Models;
using App1.Repositories;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class DeviceViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        private App1.Models.Device _device;

        /// <summary>
        /// 
        /// </summary>
        public DeviceViewModel()
        {
            _device = new App1.Models.Device();
        }

        public ICommand OpenInfoPage { get; }

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
                    OnPropertyChanged("DeviceId");
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
                    OnPropertyChanged("DeviceName");
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
                    OnPropertyChanged("WarrantyExpirationDate");
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
                    OnPropertyChanged("Model");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }
        private bool isVisible = false;

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
