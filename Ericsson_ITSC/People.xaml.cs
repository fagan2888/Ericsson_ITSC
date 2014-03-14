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
        List<Contact> contacts = new List<Contact>();
        public People()
        {
            InitializeComponent();


            contacts.Add(new Contact() { ContactId=1, Name="Sefa Yılmaz", Email="sefayilmaz91@gmail.com", MobilePhone="5422051534",JobTitle="Software Developer",Manager="Onder Savas", Departman="SDQ"});
            contacts.Add(new Contact() { ContactId=2, Name="Halil Burak Cetinkaya", Email="hburak.cetinkaya@gmail.com", MobilePhone="5077155025",JobTitle="Software Developer",Manager="Onder Savas", Departman="SDQ"});
            contacts.Add(new Contact() { ContactId=3, Name="Ali KAYA", Email="alikaya@gmail.com", MobilePhone="1234567890",JobTitle="Software Developer",Manager="Onder Savas", Departman="SDQ"});
            contacts.Add(new Contact() { ContactId = 4, Name = "Wesley Sneijder", Email = "wesley.sneijder@outlook.com", MobilePhone = "05305303030", JobTitle = "Midfielder", Departman = "Midfield", Manager = "Onder Savas", WorkPhone = "" });
            ContactList.ItemsSource = contacts;
        }

        private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var search = ((TextBox)sender).Text;
            var result = contacts.FindAll(i => i.Name.Contains(search));

            ContactList.ItemsSource = result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            var contact = (Contact)button.CommandParameter;

            PhoneCallTask arama = new PhoneCallTask();

            arama.DisplayName = contact.Name;
            arama.PhoneNumber = contact.MobilePhone;
            arama.Show();
        }

        private void ContactDetail_Click(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender);
            var contact = (Contact)button.CommandParameter;

            PeopleDetails.contact = contact;
            NavigationService.Navigate(new Uri("/PeopleDetails.xaml", UriKind.Relative));
        }

    }
}