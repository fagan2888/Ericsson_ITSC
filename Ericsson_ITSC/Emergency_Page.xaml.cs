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
using Ericsson_ITSC;
using Microsoft.Phone.Tasks;

namespace Ericsson_ITSC
{
    public partial class Emergency_Page : PhoneApplicationPage
    {
        List<Emergency> emergencies = new List<Emergency>();
        public Emergency_Page()
        {
            InitializeComponent();

            emergencies.Add(new Emergency { Name = "Ambulans", Number = "112" });
            emergencies.Add(new Emergency { Name = "Polis", Number = "155" });
            EmergencyNumbersList.ItemsSource = emergencies;
        }
        private void Call_Click(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            var contact = (Emergency)button.CommandParameter;

            PhoneCallTask arama = new PhoneCallTask();

            arama.DisplayName = contact.Name;
            arama.PhoneNumber = contact.Number;
            arama.Show();
        }
    }
}