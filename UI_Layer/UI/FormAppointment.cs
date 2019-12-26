using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BI_Layer;
using DB_Layer;

namespace UI_Layer.UI
{
    public partial class FormAppointment : Form
    {
        private Patient patient;
        private List<Doctor> doctors;
        private Appointment appointment;
        public FormAppointment()
        {
            InitializeComponent();
        }

        public FormAppointment(Patient patient)
        {
            this.patient = patient;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            //setting starting values for elements in the interface
            txtPatient.Text = patient.first_name + " " + patient.last_name;

            dateTimePicker1.Value = DateTime.Today;

            this.doctors = new DoctorDAL().Select();

            foreach (Doctor doctor in this.doctors) {
                comboBoxDoctor.Items.Add(doctor.first_name+" "+doctor.last_name);
            }
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get doctor id
            string first_name = comboBoxDoctor.Text.Split(' ')[0];
            string last_name = comboBoxDoctor.Text.Split(' ')[1];
            int doctor_id=this.doctors.Find(x=>x.first_name==first_name && x.last_name==last_name).id;

            //creating a appointment record in doctor_has_patient table
            this.appointment=new Appointment
            {
                doctor_id = doctor_id,
                patient_id = int.Parse(txtPatient.Text),
                date = dateTimePicker1.Value,
                appointment_no = int.Parse(comboBoxAppointmentNumber.Text)
            };

            int affectedRows=new AppointmentDAL().Add(this.appointment);

            //if successful
            if (affectedRows > 0)
            {
                MessageBox.Show("Appointment added");
            }
            else {
                MessageBox.Show("Couldnt add appointment");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete record
            int affectedRows = new AppointmentDAL().Delete(this.appointment);

            //if successful
            if (affectedRows > 0)
            {
                MessageBox.Show("Appointment deleted");
            }
            else
            {
                MessageBox.Show("Couldnt delete appointment");
            }
        }
    }
}
