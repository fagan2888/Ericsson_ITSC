using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericsson_ITSC_Library
{
   public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string JobTitle { get; set; }
        public string Manager { get; set; }
        public string Departman { get; set; }
        //public byte[] Photo { get; set; }
    }
}
