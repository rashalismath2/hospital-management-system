using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Layer;
using BI_Layer;

namespace UI_Layer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email=txtEmail.Text.ToString();
            string password = txtPassword.Text.ToString();
            string userType = comboBoxUserType.SelectedItem.ToString();

            switch (userType) {

                case "Doctor":
                    break;

                case "Nurse":
                    break;

                case "Operator":
                    Boolean check=checkForUser("Operator",email,password);
                    if (check)
                    {
                        new frmMain().Show();
                        this.Hide();
                    }
                    else {
                       MessageBox.Show("Auth failed message","Check email and password",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Admin":
                    break;

            }

        }

        public Boolean checkForUser(string type,string email,string password) {

            if (type=="Operator") {

                OperatorDAL operatorDAL = new OperatorDAL();
                Operator oprtr = operatorDAL.getOperatorByEmail(email.ToLower());

                if (oprtr != null && oprtr.password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
