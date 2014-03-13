using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    interface IGeoLocationRepository
    {
        IEnumerable<GeoLocation> GetAll();
        GeoLocation GetByName(string name);
        void Post(GeoLocation geoLocation);
        bool Update(GeoLocation updatedGeoLocation);
        void Delete(string name);
    }
}
