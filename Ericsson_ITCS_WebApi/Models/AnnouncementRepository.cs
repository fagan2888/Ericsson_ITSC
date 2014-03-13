using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    public class AnnouncementRepository:IAnnouncementRepository
    {
        private List<Announcement> announcements = new List<Announcement>();
        private int _nextId = 1;


        public AnnouncementRepository()
        {
            Post(new Announcement { Title = "Ericsson Dinner", Content = "Dinner is at 8.00 pm" });
            Post(new Announcement { Title = "Meetin 1", Content = "Meeting 1 is at 3.20 pm" });
            Post(new Announcement { Title = "Meetin 2", Content = "Meeting 2 is at 1.20 pm" });
            Post(new Announcement { Title = "Meetin 3", Content = "Meeting 3 is at 11.20 am" });
            Post(new Announcement { Title = "Meetin 4", Content = "Meeting 4 is at 10.20 am" });

        }

        #region Methods
        

        public IEnumerable<Announcement> GetAll()
        {
            return announcements;
        }

        public Announcement Get(int id)
        {
            return announcements.Find(p => p.id == id);
        }

        public void Post(Announcement newAnnouncement)
        {
            if (newAnnouncement == null)
            {
                throw new ArgumentNullException("Ops ! Announcement object is null that was sended !");
            }
            newAnnouncement.id = _nextId++;
            announcements.Add(newAnnouncement);
          
        }

        public bool Update(Announcement updatedAnnouncement)
        {
            if (updatedAnnouncement == null)
            {
                throw new ArgumentNullException("Ops ! Announcement object is null that was sended !");
            }
            else
            {
                var announcement = this.Get(updatedAnnouncement.id);
                if (announcement.id == -1)
                {
                    return false;
                }
                announcement.Title = updatedAnnouncement.Title;
                announcement.Content = updatedAnnouncement.Content; 
                return true;
            }
            
        }

        public void Delete(int id)
        {
            announcements.RemoveAll(p => p.id == id);
        }

        #endregion
    }
}