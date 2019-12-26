using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_Layer
{
    public class Appointment
    {
        public int doctor_id { get; set; }
        public int patient_id { get; set; }
        public DateTime date { get; set; }
        public int appointment_no { get; set; }
    }
}
