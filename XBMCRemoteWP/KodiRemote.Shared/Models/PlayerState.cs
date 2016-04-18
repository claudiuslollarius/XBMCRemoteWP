using GalaSoft.MvvmLight;

namespace XBMCRemoteWP.Models
{
    public class PlayerState : ViewModelBase
    {
        public PlayerState()
        {
            CurrentPlayerItem = new PlayerItem();
            CurrentPlayerProperties = new PlayerProperties();
            PlayerType = Players.None;
        }

        private PlayerItem currentPlayerItem;
        public PlayerItem CurrentPlayerItem
        {
            get { return currentPlayerItem; }
            set { Set(ref currentPlayerItem, value); }
        }

        private PlayerProperties currentPlayerProperties;
        public PlayerProperties CurrentPlayerProperties
        {
            get { return currentPlayerProperties; }
            set { Set(ref currentPlayerProperties, value); }
        }

        public Players PlayerType { get; set; }
    }
}
