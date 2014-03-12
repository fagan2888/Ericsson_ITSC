using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    interface IAnnouncementRepository
    {
        IEnumerable<Announcement> GetAll();
        Announcement Get(int id);
        void Post(Announcement contact);
        bool Update(Announcement updatedContact);
        void Delete(int id);
    }
}
