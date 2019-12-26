using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_Layer
{
    public class Appointment
    {

        public Doctor doctor { get; set; }
        public Patient patient { get; set; }
        public DateTime date { get; set; }
        public int appointment_no { get; set; }
    }
}
