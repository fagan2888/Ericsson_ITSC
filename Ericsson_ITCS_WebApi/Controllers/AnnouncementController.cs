using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ericsson_ITSC_Library;
using Ericsson_ITCS_WebApi.Models;

namespace Ericsson_ITCS_WebApi.Controllers
{
    public class AnnouncementController : ApiController
    {
        static readonly IAnnouncementRepository  repository = new AnnouncementRepository();

        public IEnumerable<Announcement> GetAllAnnouncement()
        {
            return repository.GetAll();
        }

        public Announcement GetAnnouncement(int id)
        {
            Announcement item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public void PostAnnouncement(Announcement newAnnouncement)
        {
            repository.Post(newAnnouncement);
        }

        public void PutAnnouncement(int id, Announcement announcement)
        {
            announcement.id = id;
            if (!repository.Update(announcement))
            {
                throw new ArgumentNullException("Ops ! Announcement object is null that was sended !");
            }
        }

        public void DeleteAnnouncement(int id)
        {
            Announcement item = repository.Get(id);
            if (item == null)
            {
                throw new ArgumentNullException("Ops ! There is no announcement with " + id + "  !");
            }
        }

    }
}
