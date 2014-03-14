using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ericsson_ITSC_Library;

namespace Ericsson_ITSC
{
    public partial class Announcements_Page : PhoneApplicationPage
    {
        List<Announcement> announcements = new List<Announcement>();
        public Announcements_Page()
        {
            InitializeComponent();

            announcements.Add(new Announcement { id = 1, Title = "Ericsson Dinner", Content = "Dinner is at 8.00 pm" });
            announcements.Add(new Announcement { id = 2, Title = "Meeting 1", Content = "Meeting 1 is at 3.20 pm" });
            announcements.Add(new Announcement { id = 3, Title = "Meeting 2", Content = "Meeting 2 is at 1.20 pm" });
            announcements.Add(new Announcement { id = 4, Title = "Meeting 3", Content = "Meeting 3 is at 11.20 am" });
            announcements.Add(new Announcement { id = 5, Title = "Meeting 4", Content = "Meeting 4 is at 10.20 am" });
            AnnouncementsList.ItemsSource = announcements;
        }

        private void AnnouncementsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Announcements will be here soon.");
        }
    }
}