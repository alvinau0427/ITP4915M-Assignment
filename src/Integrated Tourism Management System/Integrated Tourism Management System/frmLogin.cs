using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Data.Entity;

namespace Integrated_Tourism_Management_System
{
    public partial class frmLogin : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmInfo frmInfo;
        private frmConsole frmConsole;
        private frmRoster frmRoster;

        // Timer function
        Timer t = new Timer();

        public staff staff { get; set; }

        public frmLogin(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmInfo = new frmInfo(frmModuleSelection);
            frmConsole = new frmConsole(frmModuleSelection);
            frmRoster = new frmRoster(frmModuleSelection);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblHead.Text = "";
            lblName.Text = "";

            tmrSystemClock.Interval = 1000;
            tmrSystemClock.Start();

            DateTime today = DateTime.Now;
            DateTime destDay = new DateTime(2016, 06, 30);

            toolStripStatusLabel1.Text = "Clock : " + DateTime.Now;
            toolStripStatusLabel2.Text = " Timer : " + ((int)(destDay - today).TotalDays) + " days left";
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Press "Enter" button for Login
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var userID = txtUserID.Text;
            var password = dataHash(txtPassword.Text);
            staff staffList = null;
            driver driverList = null;

            if (txtUserID.Text == "")
            {
                errorProvider.SetError(txtUserID, "Please the details of the user account.");
            }
            else if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Please the details of the user account.");
            }
            else
            {
                errorProvider.Clear();
                using (var dbContext = new tickettailor_dbEntities())
                {
                    // Login for staff
                    var staff = (from list in dbContext.staff
                                 where ((list.StaffID == userID && list.Pass == password) || (list.StaffID == userID && list.SparePass == password))
                                 select list).FirstOrDefault();

                    // Login for driver
                    var driver = (from list in dbContext.driver
                                  where ((list.DriverID == userID && list.Pass == password) || (list.DriverID == userID && list.SparePass == password))
                                  select list).FirstOrDefault();

                    if (staff == null && driver == null)
                    {
                        MessageBox.Show("Incorrect user name or password, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (staff != null)
                    {
                        staffList = staff;
                        MessageBox.Show("Login successful. Welcome, " + lblName.Text + " !", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmConsole.MdiParent = frmModuleSelection;
                        ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).staff = staff;
                        frmModuleSelection.staffControlToolStripMenuItem.Enabled = true;
                        frmModuleSelection.loginSystemToolStripMenuItem.Enabled = false;
                        if (frmModuleSelection.staff.Position == "Administrator" || frmModuleSelection.staff.Ctype == "Admin")
                        {
                            frmModuleSelection.createUserAccountToolStripMenuItem.Enabled = true;
                        }
                        frmConsole.Dock = DockStyle.Fill;
                        frmConsole.Show();
                    }
                    else if (driver != null)
                    {
                        driverList = driver;
                        MessageBox.Show("Login successful. Welcome, " + lblName.Text + " !", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).driver = driver;
                        frmModuleSelection.driverControlToolStripMenuItem.Enabled = true;
                        frmModuleSelection.loginSystemToolStripMenuItem.Enabled = false;
                        frmInfo.Close();
                        frmInfo = new frmInfo(frmModuleSelection);
                        frmInfo.MdiParent = frmModuleSelection;
                        frmInfo.Dock = DockStyle.Fill;
                        frmInfo.Show();
                        frmRoster.Show();
                    }
                }
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0)
            {
                MessageBox.Show("Missing the user ID, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserID.Clear();
                txtPassword.Clear();
            }
            else
            {
                using (var dbContext = new tickettailor_dbEntities())
                {
                    var staff = (from list in dbContext.staff
                                 where list.StaffID == txtUserID.Text
                                 select list).FirstOrDefault();

                    var driver = (from list in dbContext.driver
                                  where list.DriverID == txtUserID.Text
                                  select list).FirstOrDefault();

                    if (staff != null)
                    {
                        string tempPass = dataHash("000000");
                        staff.SparePass = tempPass;
                        dbContext.SaveChanges();
                        MessageBox.Show("The spare password is set up to '000000' alreadly.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (driver != null)
                    {
                        string tempPass = dataHash("000000");
                        driver.SparePass = tempPass;
                        dbContext.SaveChanges();
                        MessageBox.Show("The spare password is set up to '000000' alreadly.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect user ID. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                txtUserID.Text = "";
                txtPassword.Text = "";
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            string loginID = txtUserID.Text;

            using (var dbContext = new tickettailor_dbEntities())
            {
                var staff = (from list in dbContext.staff
                             where list.StaffID == loginID
                             select list).FirstOrDefault();

                var driver = (from list in dbContext.driver
                              where list.DriverID == loginID
                              select list).FirstOrDefault();

                if (staff == null && driver == null)
                {
                    lblHead.Text = "";
                    lblName.Text = "";
                }
                else if (staff != null)
                {
                    lblName.Text = staff.StaffName;
                    if (staff.Gender.ToUpper().Equals("M"))
                    {
                        lblHead.Text = "MR.";
                        lblName.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lblHead.Text = "MS.";
                        lblName.ForeColor = Color.Red;
                    }
                }
                else if (driver != null)
                {
                    lblName.Text = driver.StaffName;
                    if (driver.Gender.ToUpper().Equals("M"))
                    {
                        lblHead.Text = "MR.";
                        lblName.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lblHead.Text = "MS.";
                        lblName.ForeColor = Color.Red;
                    }
                }
            }
        }

        private string dataHash(string text)
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = sha.Hash;
            StringBuilder str = new StringBuilder();
            foreach (byte b in result)
            {
                str.Append(b.ToString("x2"));
            }
            return str.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}