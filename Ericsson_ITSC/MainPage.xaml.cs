using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ericsson_ITSC.Resources;

namespace Ericsson_ITSC
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLocations_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Office_Locations.xaml", UriKind.Relative));
        }

        private void btnEmergency_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Emergency_Page.xaml", UriKind.Relative));
        }

        private void btnToDo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/To_Do_List.xaml", UriKind.Relative));
        }

        private void btnAnno_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Announcements_Page.xaml", UriKind.Relative));
        }

        private void btnPeople_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/People.xaml", UriKind.Relative));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Uygulamadan Çıkış
            Application.Current.Terminate();
        }
    }
}