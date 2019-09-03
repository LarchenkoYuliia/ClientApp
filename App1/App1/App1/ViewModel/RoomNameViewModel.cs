using App1.Models;
using System.ComponentModel;

namespace App1.ViewModel
{
    //todo: change properties "UserId"
    public class RoomNameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private RoomNames _roomNames;

        public RoomNameViewModel()
        {
            _roomNames = new RoomNames();
        }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int RoomNameId
        {
            get { return _roomNames.RoomNameId; }
            set
            {
                if (_roomNames.RoomNameId != value)
                {
                    _roomNames.RoomNameId = value;
                    OnPropertyChanged("RoomNameId");
                }
            }
        }

        /// <summary>
        /// Название комнаты
        /// </summary>
        public string RoomName
        {
            get { return _roomNames.RoomName; }
            set
            {
                if (_roomNames.RoomName != value)
                {
                    _roomNames.RoomName = value;
                    OnPropertyChanged("RoomName");
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
