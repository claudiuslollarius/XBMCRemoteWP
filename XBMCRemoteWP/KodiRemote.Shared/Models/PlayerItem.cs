using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace XBMCRemoteWP.Models
{
    public class PlayerItem : ViewModelBase
    {
        private string thumbnail;
        public string Thumbnail
        {
            get { return thumbnail; }
            set { Set(ref thumbnail, value); }
        }

        private string fanart;
        public string Fanart
        {
            get { return fanart; }
            set { Set(ref fanart, value); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        private string showTitle; 
        public string ShowTitle
        {
            get { return showTitle; }
            set { Set(ref showTitle, value); }
        }

        private string tagline;
        public string Tagline
        {
            get { return tagline; }
            set { Set(ref tagline, value); }
        }

        private List<string> artist;
        public List<string> Artist
        {
            get { return artist; }
            set { Set(ref artist, value); }
        }
        public string Label { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }        

    }
}
