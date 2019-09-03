using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.Repositories
{
    public class DevicesRepository
    {
        

        public ObservableCollection<DeviceViewModel> DeviceList
        {
            get { return _deviceViewModel; }
            set { this._deviceViewModel = value; }
        }
        private ObservableCollection<DeviceViewModel> _deviceViewModel = new ObservableCollection<DeviceViewModel>();

        public DevicesRepository()
        {
            GenerateDeviceList();
        }

        internal void GenerateDeviceList()
        {
            //var _deviceViewModel = new ObservableCollection<DeviceViewModel>();
            DeviceList.Add(new DeviceViewModel()
            {
                DeviceId = 1,
                DeviceName = "Lamp",
                Model = "Model 1",
                WarrantyExpirationDate = DateTime.MinValue
            });
            DeviceList.Add(new DeviceViewModel()
            {
                DeviceId = 2,
                DeviceName = "Lamp 2",
                Model = "Model 2",
                WarrantyExpirationDate = DateTime.MinValue
            });
        }
    }
}
