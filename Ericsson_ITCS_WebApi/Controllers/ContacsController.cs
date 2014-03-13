using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ericsson_ITCS_WebApi.Models;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Controllers
{
    public class ContacsController : ApiController
    {
        static readonly IContactRepository repository = new ContactRepository();

        #region Methods

        public IEnumerable<Contact> GetAllContacts()
        {
            return repository.GetAll();
        }

        public Contact GetContact(int id)
        {
            Contact item = repository.Get(id);
            if (item == null)
            {
                throw new ArgumentNullException("Ops ! There is no Contact with id #" + id + "  !");
            }
            return item;
        }

        public void PostContact(Contact newContact)
        {
            repository.Post(newContact);
        }

        public void PutContact(int id,Contact contact)
        {
            contact.ContactId=id;
             if (!repository.Update(contact))
            {
                throw new ArgumentNullException("Ops ! Contact object is null that was sended !");
            }
        }

        public void DeleteContact(int id)
        {
            Contact item = repository.Get(id);
            if (item==null)
            {
                throw new ArgumentNullException("Ops ! There is no contact with id #"+id+"  !" ); 
            }
        }

        #endregion
    }
}
