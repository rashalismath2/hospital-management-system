namespace UI_Layer
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNurseCount = new System.Windows.Forms.Label();
            this.lblNurse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPatientCount = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.grpDoctorCount = new System.Windows.Forms.GroupBox();
            this.lblDoctorCount = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.grpPharmacy = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnPharmacy = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSettings = new System.Windows.Forms.Button();
            this.btnAppoinment = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDoctorCount.SuspendLayout();
            this.grpPharmacy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTop.Controls.Add(this.groupBox2);
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Controls.Add(this.grpDoctorCount);
            this.pnlTop.Controls.Add(this.lblDashboard);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 52);
            this.pnlTop.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNurseCount);
            this.groupBox2.Controls.Add(this.lblNurse);
            this.groupBox2.Location = new System.Drawing.Point(876, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(65, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblNurseCount
            // 
            this.lblNurseCount.AutoSize = true;
            this.lblNurseCount.Location = new System.Drawing.Point(22, 27);
            this.lblNurseCount.Name = "lblNurseCount";
            this.lblNurseCount.Size = new System.Drawing.Size(13, 13);
            this.lblNurseCount.TabIndex = 2;
            this.lblNurseCount.Text = "2";
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblNurse.Location = new System.Drawing.Point(9, 8);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(40, 14);
            this.lblNurse.TabIndex = 1;
            this.lblNurse.Text = "Nurse";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPatientCount);
            this.groupBox1.Controls.Add(this.lblPatient);
            this.groupBox1.Location = new System.Drawing.Point(796, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(65, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblPatientCount
            // 
            this.lblPatientCount.AutoSize = true;
            this.lblPatientCount.Location = new System.Drawing.Point(22, 27);
            this.lblPatientCount.Name = "lblPatientCount";
            this.lblPatientCount.Size = new System.Drawing.Size(13, 13);
            this.lblPatientCount.TabIndex = 2;
            this.lblPatientCount.Text = "2";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblPatient.Location = new System.Drawing.Point(9, 8);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(45, 14);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Patient";
            // 
            // grpDoctorCount
            // 
            this.grpDoctorCount.Controls.Add(this.lblDoctorCount);
            this.grpDoctorCount.Controls.Add(this.lblDoctor);
            this.grpDoctorCount.Location = new System.Drawing.Point(712, 3);
            this.grpDoctorCount.Name = "grpDoctorCount";
            this.grpDoctorCount.Size = new System.Drawing.Size(65, 46);
            this.grpDoctorCount.TabIndex = 2;
            this.grpDoctorCount.TabStop = false;
            this.grpDoctorCount.Enter += new System.EventHandler(this.grpDoctorCount_Enter);
            // 
            // lblDoctorCount
            // 
            this.lblDoctorCount.AutoSize = true;
            this.lblDoctorCount.Location = new System.Drawing.Point(22, 27);
            this.lblDoctorCount.Name = "lblDoctorCount";
            this.lblDoctorCount.Size = new System.Drawing.Size(13, 13);
            this.lblDoctorCount.TabIndex = 2;
            this.lblDoctorCount.Text = "2";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.Location = new System.Drawing.Point(8, 8);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(50, 14);
            this.lblDoctor.TabIndex = 1;
            this.lblDoctor.Text = "Doctors";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.Location = new System.Drawing.Point(13, 17);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(113, 24);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // grpPharmacy
            // 
            this.grpPharmacy.Controls.Add(this.pictureBox6);
            this.grpPharmacy.Controls.Add(this.btnPharmacy);
            this.grpPharmacy.Location = new System.Drawing.Point(268, 124);
            this.grpPharmacy.Name = "grpPharmacy";
            this.grpPharmacy.Size = new System.Drawing.Size(119, 55);
            this.grpPharmacy.TabIndex = 9;
            this.grpPharmacy.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(7, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.Location = new System.Drawing.Point(37, 15);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.Size = new System.Drawing.Size(73, 30);
            this.btnPharmacy.TabIndex = 1;
            this.btnPharmacy.Text = "Pharmacy";
            this.btnPharmacy.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.lblSettings);
            this.groupBox7.Location = new System.Drawing.Point(593, 124);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(119, 55);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblSettings
            // 
            this.lblSettings.Location = new System.Drawing.Point(38, 14);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(73, 30);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            this.lblSettings.UseVisualStyleBackColor = true;
            // 
            // btnAppoinment
            // 
            this.btnAppoinment.Location = new System.Drawing.Point(39, 14);
            this.btnAppoinment.Name = "btnAppoinment";
            this.btnAppoinment.Size = new System.Drawing.Size(73, 30);
            this.btnAppoinment.TabIndex = 1;
            this.btnAppoinment.Text = "Appoinment";
            this.btnAppoinment.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox4);
            this.groupBox6.Controls.Add(this.btnAppoinment);
            this.groupBox6.Location = new System.Drawing.Point(430, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 55);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 529);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.grpPharmacy);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDoctorCount.ResumeLayout(false);
            this.grpDoctorCount.PerformLayout();
            this.grpPharmacy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpDoctorCount;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNurseCount;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPatientCount;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDoctorCount;
        private System.Windows.Forms.GroupBox grpPharmacy;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnPharmacy;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lblSettings;
        private System.Windows.Forms.Button btnAppoinment;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}