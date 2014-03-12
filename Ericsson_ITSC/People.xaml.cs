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
using Microsoft.Phone.Tasks;
//using System.Windows.Controls;


namespace Ericsson_ITSC
{
    public partial class People : PhoneApplicationPage
    {
        List<Contacts> contacts = new List<Contacts>();
        public People()
        {
            InitializeComponent();

            
            contacts.Add(new Contacts() { FirstName = "First", LastName = "Last", CellPhone = "05550003322", JobTitle = "Developer" });
            contacts.Add(new Contacts() { FirstName = "First 1", LastName = "Last", CellPhone = "05550003322", JobTitle = "Developer" });
            contacts.Add(new Contacts() { FirstName = "First 2", LastName = "Last", CellPhone = "05550003322", JobTitle = "Developer" });
            contacts.Add(new Contacts() { FirstName = "First 3", LastName = "Last", CellPhone = "05550003322", JobTitle = "Developer" });
            contacts.Add(new Contacts() { FirstName = "First 4", LastName = "Last", CellPhone = "05550003322", JobTitle = "Developer" });
            contacts.Add(new Contacts() { FirstName = "First 5", LastName = "Last", CellPhone = "05550003322", JobTitle = "Developer" });

            ContactList.ItemsSource = contacts;
        }

        private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var search = ((TextBox)sender).Text;
            var result = contacts.FindAll(i => i.FirstName.Contains(search) || i.LastName.Contains(search));

            ContactList.ItemsSource = result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            var contact = (Contacts)button.CommandParameter;

            PhoneCallTask arama = new PhoneCallTask();

            arama.DisplayName = contact.FirstName + " " + contact.LastName;
            arama.PhoneNumber = contact.CellPhone;
            arama.Show();
        }

        private void ContactDetail_Click(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            var contact = (Contacts)button.CommandParameter;


            NavigationService.Navigate(new Uri("/PeopleDetails.xaml", UriKind.Relative));
        }

    }
}