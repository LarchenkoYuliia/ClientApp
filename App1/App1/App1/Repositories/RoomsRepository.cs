using App1.ViewModel;
using System.Collections.ObjectModel;

namespace App1.Repositories
{
    public class RoomsRepository
    {
        private ObservableCollection<RoomNameViewModel> roomNames;

        public ObservableCollection<RoomNameViewModel> RoomNames
        {
            get { return roomNames; }
            set { this.roomNames = value; }
        }

        public RoomsRepository()
        {
            GenrateInfo();
        }

        internal void GenrateInfo()
        {
            roomNames = new ObservableCollection<RoomNameViewModel>();
            roomNames.Add(new RoomNameViewModel() { RoomNameId = 1, RoomName = "Кухня" });
            roomNames.Add(new RoomNameViewModel() { RoomNameId = 2, RoomName = "Спальня" });
            roomNames.Add(new RoomNameViewModel() { RoomNameId = 3, RoomName = "Гостевая" });
            roomNames.Add(new RoomNameViewModel() { RoomNameId = 4, RoomName = "Коридор" });
            roomNames.Add(new RoomNameViewModel() { RoomNameId = 5, RoomName = "Гостинная" });
        }
    }
}
