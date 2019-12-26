using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_Layer
{
    public class Patient
    {
        public int id { get; set; }
        public int doctor_id { get; set; }
        public int created_date { get; set; }
        public DateTime dob { get; set; }
        public string contact_residen { get; set; }
        public string contact_mobile { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
