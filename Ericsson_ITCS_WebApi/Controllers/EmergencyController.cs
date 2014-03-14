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
    public class EmergencyController : ApiController
    {
        static readonly IEmergencyRepository repository = new EmergencyRepository();

        #region Methods

        public IEnumerable<Emergency> GetAllEmergency()
        {
            return repository.GetAll();
        }

        public Emergency GetEmergency(string name)
        {
            Emergency item = repository.GetByNAme(name);
            if (item == null)
            {
                throw new ArgumentNullException("Opps ! There is no Emergency with name  #" + name + "  !");
            }
            return item;
        }

        public void PostEmergency(Emergency newEmergency)
        {
            repository.Post(newEmergency);
        }

        public void PutEmergency(Emergency emergency)                        //  update number with name that are given
        {

            if (!repository.Update(emergency))
            {
                throw new ArgumentNullException("Opps ! There is no Emergency with name #" + emergency.Name + " !");
            }
        }

        public void DeleteEmergency(string name)
        {
            Emergency item = repository.GetByNAme(name);
            if (item == null)
            {
                throw new ArgumentNullException("Opps ! There is no Emergency with name  #" + name + "  !");
            }
        }
        
        #endregion 

    }
}
