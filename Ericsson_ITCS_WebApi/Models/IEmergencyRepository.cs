using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ericsson_ITSC_Library;

namespace Ericsson_ITCS_WebApi.Models
{
    interface IEmergencyRepository
    {
        IEnumerable<Emergency> GetAll();
        Emergency GetByNAme(string  name);
        void Post(Emergency emergency);
        bool Update(Emergency updatedEmergency);
        void Delete(string  name);
    }
}
