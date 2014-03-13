using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    public class GeoLocationRepository: IGeoLocationRepository 
    {
        private List<GeoLocation> geoLocations = new List<GeoLocation>();


        public GeoLocationRepository()
        {
            Post(new GeoLocation { Name = "Sefa Yılmaz EV ", Latitude = 38.466778, Longitude = 27.214870 });
            Post(new GeoLocation { Name = "Bornova Hükümet Konağı ", Latitude = 38.466778, Longitude = 27.214870 } );
            Post(new GeoLocation { Name = "İzmir Saat Kulesi ", Latitude = 38.466778, Longitude = 27.214870 } );
            Post(new GeoLocation { Name = "Ege Üniversitesi Bilgisayar Mühendisliği ", Latitude = 38.466778, Longitude = 27.214870 } );
            Post(new GeoLocation { Name = "Konak Atatürk Kültür Merkezi ", Latitude = 38.466778, Longitude = 27.214870 });
        }


        #region methods

        public IEnumerable<GeoLocation> GetAll()
        {
            return geoLocations;
        }

        public GeoLocation GetByName (string name)
        {
            return geoLocations.Find(p => p.Name  == name);
        }

        public void Post(GeoLocation newGeoLocation)
        {
            if (newGeoLocation == null)
            {
                throw new ArgumentNullException("Opps ! GeoLocation object is null that was sended !");
            }
            geoLocations.Add(newGeoLocation);
          
        }

        public bool Update(GeoLocation updatedGeoLocation)
        {
            if (updatedGeoLocation == null)
            {
                throw new ArgumentNullException("Opps ! GeoLocation object is null that was sended !");
            }
            else
            {
                var geoLocation = this.GetByName(updatedGeoLocation.Name);
                if (geoLocation.Name == null)
                {
                    return false;
                }
                geoLocation.Latitude = updatedGeoLocation.Latitude;
                geoLocation.Longitude = updatedGeoLocation.Longitude; 
                return true;
            }
            
        }

        public void Delete(string name)
        {
            geoLocations.RemoveAll(p => p.Name  == name);
        }

        #endregion 


    }
}