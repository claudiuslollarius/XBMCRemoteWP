﻿using XBMCRemoteWP.Models;
using XBMCRemoteWP.Models.Audio;
using XBMCRemoteWP.Models.Video;

namespace XBMCRemoteWP.Helpers
{
    public static class GlobalVariables
    {
        public static int CurrentAlbumId { get; set; }

        public static Album CurrentAlbum { get; set; }

        public static Artist CurrentArtist { get; set; }

        public static TVShow CurrentTVShow { get; set; }

        public static Movie CurrentMovie { get; set; }

        //public static NowPlayingItem NowPlaying { get; set; }

        public static PlayerState CurrentPlayerState { get; set; }
    }
}
