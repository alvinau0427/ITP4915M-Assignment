using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Tourism_Management_System
{
    public partial class frmRoster : Form
    {
        private frmModuleSelection frmModuleSelection;
        private frmInfo frmInfo;

        // Get form value
        private driver driver;

        // Timer function
        Timer t = new Timer();

        public frmRoster(frmModuleSelection frm)
        {
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmInfo = new frmInfo(frmModuleSelection);
        }

        private void frmRoster_Load(object sender, EventArgs e)
        {
            driver = frmModuleSelection.driver;
            t.Interval = 1000;
            t.Start();

            DateTime today = DateTime.Now;
            DateTime destDay = new DateTime(2016, 06, 30);
            toolStripStatusLabel1.Text = "Clock : " + DateTime.Now;
            toolStripStatusLabel2.Text = " Timer : " + ((int)(destDay - today).TotalDays) + " days left";
            toolStripStatusLabel3.Text = " Status : Login Successful";

            txtStaffID.Text = frmModuleSelection.driver.DriverID;
            txtFullName.Text = frmModuleSelection.driver.StaffName;
            txtGender.Text = frmModuleSelection.driver.Gender;
            txtEmail.Text = frmModuleSelection.driver.Email;
            txtCenter.Text = frmModuleSelection.driver.Center;
            txtPosition.Text = frmModuleSelection.driver.Position;
            txtLate.Text = frmModuleSelection.driver.Late.ToString();
            picIcon.Image = Image.FromFile("../Image/StaffPhotos/" + driver.SImage);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to sign out this user account?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // frmModuleSelection.driver = null;
                frmModuleSelection.loginSystemToolStripMenuItem.Enabled = true;
                frmModuleSelection.driverControlToolStripMenuItem.Enabled = false;
                frmInfo.MdiParent = frmModuleSelection;
                frmInfo.Dock = DockStyle.Fill;
                frmInfo.Show();
                this.Close();
                MessageBox.Show("You have signed out.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
