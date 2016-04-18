using GalaSoft.MvvmLight;

namespace XBMCRemoteWP.Models
{
    public class PlayerProperties : ViewModelBase
    {
        private bool partyMode;
        public bool PartyMode
        {
            get { return partyMode; }
            set { Set(ref partyMode, value); }
        }

        private int speed;
        public int Speed
        {
            get { return speed; }
            set { Set(ref speed, value); }
        }

        private bool shuffled;
        public bool Shuffled
        {
            get { return shuffled; }
            set { Set(ref shuffled, value); }
        }

        private string repeat;
        public string Repeat
        {
            get { return repeat; }
            set { Set(ref repeat, value); }
        }
    }
}
