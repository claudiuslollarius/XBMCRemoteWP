﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using XBMCRemoteWP.Models.Video;
using XBMCRemoteWP.RPCWrappers;
using XBMCRemoteWP.Helpers;

namespace XBMCRemoteWP.Pages.Video
{
    public partial class AllTVShowsPage : PhoneApplicationPage
    {
        private List<TVShow> allTVShows;
        public AllTVShowsPage()
        {
            InitializeComponent();
            this.Loaded += AllTVShowsPage_Loaded;
        }

        void AllTVShowsPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (allTVShows == null)
                LoadTVShows();
        }

        private async void LoadTVShows()
        {
            ConnectionManager.ManageSystemTray(true);
            allTVShows = await VideoLibrary.GetTVShows();
            AllTVShowsLLS.ItemsSource = allTVShows;
            ConnectionManager.ManageSystemTray(false);
        }

        private void TVShowWrapper_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TVShow tappedTVShow = (sender as Grid).DataContext as TVShow;
            GlobalVariables.CurrentTVShow = tappedTVShow;
            NavigationService.Navigate(new Uri("/Pages/Video/TVShowDetailsPanorama.xaml", UriKind.Relative));
        }

        private void RefreshAppBarButton_Click(object sender, EventArgs e)
        {
            LoadTVShows();
        }

        private void SearchAppBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Video/SearchTVShowsPage.xaml", UriKind.Relative));
        }
    }
}