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
    public class GeoLocationController : ApiController
    {
        static readonly IGeoLocationRepository repository = new GeoLocationRepository();

        public IEnumerable<GeoLocation> GetAllGeoLocation()
        {
            return repository.GetAll();
        }

        public GeoLocation GetGeoLocation(string name)
        {
            GeoLocation item = repository.GetByName(name);
            if (item == null)
            {
                throw new ArgumentNullException("Opps ! There is no GeoLocation with name  #" + name + "  !");
            }
            return item;
        }

        public void PostGeoLocation(GeoLocation newGeoLocation)
        {
            repository.Post(newGeoLocation);
        }

        public void PutGeoLocation( GeoLocation geoLocation)                        //  update coordinates with name that are given
        {
            
            if (!repository.Update(geoLocation))
            {
                throw new ArgumentNullException("Opps ! There is no geolocation with name #"+geoLocation.Name+" !");
            }
        }

        public void DeleteGeoLocation(string name)
        {
            GeoLocation item = repository.GetByName(name);
            if (item == null)
            {
                throw new ArgumentNullException("Ops ! There is no geoLocation with name  #" + name + "  !");
            }
        }

    }
}
