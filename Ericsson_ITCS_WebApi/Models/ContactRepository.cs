using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    public class ContactRepository:IContactRepository
    {
        private List<Contact> contacts = new List<Contact>();
        private int _nextId = 1;


        public ContactRepository()
        {
            Post(new Contact { Name="Sefa YILMAZ",Email="sefayilmaz91@gmail.com" ,MobilePhone="5422051534",WorkPhone="2320000000",JobTitle="Software Developer",Manager="Onder Savas", Departman="SDQ" }    );
            Post(new Contact { Name = "Halil Burak CETINKAYA",Email="halilBurak@gmail.com" , MobilePhone = "5077155025",WorkPhone="2320000000",JobTitle = "Software Developer",Manager="Onder Savas", Departman="SDQ" });
            Post(new Contact { Name = "Ali KAYA ", Email = "alikaya@gmail.com", MobilePhone = "1234567890", WorkPhone = "2320000000", JobTitle = "Data Analyst", Manager = "Onder Savas", Departman = "SDQ" });
            Post(new Contact { Name = "Ayse OZTURK ", Email = "ayseozturk@gmail.com", MobilePhone = "9876543210", WorkPhone = "2320000000", JobTitle = "Consultant", Manager = "Onder Savas", Departman = "SDQ" });
            Post(new Contact { Name = "Sınem KIR ", Email = "sinemkır@gmail.com", MobilePhone = "1112223330", WorkPhone = "2320000000", JobTitle = "DBA", Manager = "Onder Savas", Departman = "SDQ" });
        }
   

        #region Methods
        public IEnumerable<Contact> GetAll()
        {
            return contacts;
        }

        public Contact Get(int id)
        {
            return contacts.Find(p => p.ContactId == id);
        }

        public void Post(Contact newContact)
        {
            if (newContact == null)
            {
                throw new ArgumentNullException("Ops ! Contact object is null that was sended !");
            }
            newContact.ContactId= _nextId++;
            contacts.Add(newContact);
          
        }

        public bool Update(Contact updatedContact)
        {
            if (updatedContact == null)
            {
                throw new ArgumentNullException("Ops ! Contact object is null that was sended !");
            }
            else
            {
                var contact = this.Get(updatedContact.ContactId);
                if (contact.ContactId == -1)
                {
                    return false;
                }
                contact.Name = updatedContact.Name;
                contact.Email = updatedContact.Email;
                contact.MobilePhone = updatedContact.MobilePhone;
                contact.WorkPhone = updatedContact.WorkPhone;
                contact.JobTitle = updatedContact.JobTitle;
                contact.Manager = updatedContact.Manager;
                contact.Departman = updatedContact.Departman;
                return true;
            }
            
        }

        public void Delete(int id)
        {
            contacts.RemoveAll(p => p.ContactId == id);
        }

        #endregion
    }

}