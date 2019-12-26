using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_Layer
{
    public class Operator
    {
        public int id { get; set; }
        public DateTime dob { get; set; }
        public string contact_resident { get; set; }
        public string contact_mobile { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public string password { get; set; }
        public string email { get; set; }
    }
}
