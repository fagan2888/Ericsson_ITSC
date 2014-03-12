using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ericsson_ITCS_WebApi.Models
{
    public class GeoLocation
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
    }
}