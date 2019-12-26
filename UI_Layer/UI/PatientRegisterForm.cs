using DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Layer.UI;

namespace UI_Layer
{
    public partial class fromPatientRegistration : Form
    {
        public fromPatientRegistration()
        {
            InitializeComponent();
        }

        private void fromPatientRegistration_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || txtId.Text.Equals("Id"))
            {
                MessageBox.Show("Please select the patient");
            }
            else {
                new FormAppointment(new PatientDAL().Select(int.Parse(txtId.Text))).Show();
            }
        }
    }
}
