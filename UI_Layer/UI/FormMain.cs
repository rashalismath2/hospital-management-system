using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnDashBorad_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(dashboard);
            dashboard.Show();

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmRegisterDoctor frmRegisterDoctor = new frmRegisterDoctor();
            frmRegisterDoctor.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmRegisterDoctor);
            frmRegisterDoctor.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            fromPatientRegistration fromPatientRegistration = new fromPatientRegistration();
            fromPatientRegistration.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(fromPatientRegistration);
            fromPatientRegistration.Show();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            frmNurseRegister frmNurseRegister = new frmNurseRegister();
            frmNurseRegister.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmNurseRegister);
            frmNurseRegister.Show();
        }
    }
}
