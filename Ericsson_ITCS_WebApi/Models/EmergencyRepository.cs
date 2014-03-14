using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    public class EmergencyRepository:IEmergencyRepository
    {
        private List<Emergency> emergencies = new List<Emergency>();


        public EmergencyRepository()
        {
            Post(new Emergency { Name = "E 0", Number = "100" });
            Post(new Emergency { Name = "E 1", Number = "200" });
            Post(new Emergency { Name = "E 2", Number = "300" });
            Post(new Emergency { Name = "E 3", Number = "400" });
            Post(new Emergency { Name = "E 4", Number = "500" });

        }

        #region Methods


        public IEnumerable<Emergency> GetAll()
        {
            return emergencies;
        }

        public Emergency GetByName(string name)
        {
            return emergencies.Find(p => p.Name == name);
        }

        public void Post(Emergency newEmergency)
        {
            if (newEmergency == null)
            {
                throw new ArgumentNullException("Opps ! Number object is null that was sended !");
            }
            emergencies.Add(newEmergency);
          
        }

        public bool Update(Emergency updatedEmergency)
        {
            if (updatedEmergency == null  )
            {
                throw new ArgumentNullException("Opps ! Emergency object is null that was sended !");
            }
            else
            {
                var emergency = this.GetByName(updatedEmergency.Name);
                if (emergency.Name == "")
                {
                    return false;
                }
                emergency.Number = updatedEmergency.Number; 
                return true;
            }
            
        }

        public void Delete(string name)
        {
            emergencies.RemoveAll(p => p.Name == name);
        }

        #endregion
    }
}