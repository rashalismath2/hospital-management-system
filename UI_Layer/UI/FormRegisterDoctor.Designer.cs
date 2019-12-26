namespace UI_Layer
{
    partial class frmRegisterDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtResident = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.txtGender = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDoctorRegister = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGender.SuspendLayout();
            this.pnlContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(403, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(404, 20);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(576, 400);
            this.dataGridView1.TabIndex = 52;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(151, 487);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(28, 158);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(72, 16);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "User Type";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Operator",
            "Nurse"});
            this.comboBoxUserType.Location = new System.Drawing.Point(151, 156);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(203, 21);
            this.comboBoxUserType.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(27, 449);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(330, 20);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.Text = "Password";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(0, 28);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(200, 20);
            this.txtMobile.TabIndex = 12;
            this.txtMobile.Text = "Mobile";
            // 
            // txtResident
            // 
            this.txtResident.Location = new System.Drawing.Point(0, 3);
            this.txtResident.Name = "txtResident";
            this.txtResident.Size = new System.Drawing.Size(200, 20);
            this.txtResident.TabIndex = 11;
            this.txtResident.Text = "Resident";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(330, 20);
            this.txtId.TabIndex = 53;
            this.txtId.Text = "Id";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radioButtonFemale);
            this.grpGender.Controls.Add(this.radioButtonMale);
            this.grpGender.Location = new System.Drawing.Point(151, 180);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(204, 33);
            this.grpGender.TabIndex = 38;
            this.grpGender.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(119, 10);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(7, 10);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(28, 191);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(56, 16);
            this.txtGender.TabIndex = 37;
            this.txtGender.Text = "Gender";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(27, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(330, 20);
            this.txtFirstName.TabIndex = 35;
            this.txtFirstName.Text = "First Name";
            // 
            // lblDoctorRegister
            // 
            this.lblDoctorRegister.AutoSize = true;
            this.lblDoctorRegister.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorRegister.ForeColor = System.Drawing.Color.Navy;
            this.lblDoctorRegister.Location = new System.Drawing.Point(282, 13);
            this.lblDoctorRegister.Name = "lblDoctorRegister";
            this.lblDoctorRegister.Size = new System.Drawing.Size(250, 24);
            this.lblDoctorRegister.TabIndex = 34;
            this.lblDoctorRegister.Text = "Doctor Registration Form";
            // 
            // txtContact
            // 
            this.txtContact.AutoSize = true;
            this.txtContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(24, 370);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(57, 16);
            this.txtContact.TabIndex = 44;
            this.txtContact.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(27, 329);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 20);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(151, 262);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 51);
            this.txtAddress.TabIndex = 42;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(28, 262);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(60, 16);
            this.lbladdress.TabIndex = 41;
            this.lbladdress.Text = "Address";
            // 
            // pnlContact
            // 
            this.pnlContact.Controls.Add(this.txtMobile);
            this.pnlContact.Controls.Add(this.txtResident);
            this.pnlContact.Location = new System.Drawing.Point(154, 355);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(200, 50);
            this.pnlContact.TabIndex = 45;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(28, 225);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(90, 16);
            this.lblDOB.TabIndex = 40;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(27, 417);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(330, 20);
            this.txtRole.TabIndex = 55;
            this.txtRole.Text = "Doctor Role";
            // 
            // frmRegisterDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 529);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDoctorRegister);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisterDoctor";
            this.Text = "Register Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtResident;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDoctorRegister;
        private System.Windows.Forms.Label txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRole;
    }
}