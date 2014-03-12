using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact Get(int id);
        void Post(Contact contact);
        bool Update(Contact updatedContact);
        void Delete(int id);
    }
}
