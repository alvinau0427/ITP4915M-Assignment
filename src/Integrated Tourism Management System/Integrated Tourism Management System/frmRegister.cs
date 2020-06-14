using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Integrated_Tourism_Management_System
{
    public partial class frmRegister : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;

        public frmRegister(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            // Setup button enable
            btnPhoto.Enabled = false;

            using (var dbContext = new tickettailor_dbEntities())
            {
                var gender = (from list in dbContext.staff
                             select list.Gender).Distinct();
                foreach (var i in gender)
                {
                    cboGender.Items.Add(i);
                }
                cboGender.SelectedIndex = 0;

                var center = (from list in dbContext.staff
                             select list.Center).Distinct();
                foreach (var i in center)
                {
                    cboCenter.Items.Add(i);
                }
                cboCenter.SelectedIndex = 0;

                var position = (from list in dbContext.staff
                              select list.Position).Distinct();
                foreach (var i in position)
                {
                    cboPosition.Items.Add(i);
                }
                cboPosition.SelectedIndex = 0;

                var type = (from list in dbContext.staff
                                select list.Ctype).Distinct();
                foreach (var i in type)
                {
                    cboType.Items.Add(i);
                }
                cboType.SelectedIndex = 0;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please enter the user id.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txtName.Text == "")
            {
                MessageBox.Show("Please enter the user name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txtEmail.Text == "")
            {
                MessageBox.Show("Please enter the user email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the user password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MessageBox.Show("Do you confirm the above arrangement ?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string userID = txtUserID.Text;
                string userName = txtName.Text;
                string email = txtEmail.Text;
                string password = dataHash(txtPassword.Text);

                double salary = -999;
                Boolean parseSalaryDouble = Double.TryParse(txtSalary.Text, out salary);
                double late = -999;
                Boolean parseLateDouble = Double.TryParse(txtLate.Text, out late);

                if (salary < 0 || salary == -999)
                {
                    MessageBox.Show("Please input a valid number in salary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if(late < 0 || late == -999)
                {
                    MessageBox.Show("Please input a valid number in late.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var dbContext = new tickettailor_dbEntities())
                {
                    var list = from staffList in dbContext.staff
                               select staffList;
                    foreach (var i in list)
                    {
                        if (userID == i.StaffID || userName == i.StaffName)
                        {
                            MessageBox.Show("The following account is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    staff newStaff = new staff();
                    newStaff.StaffID = (userID != "") ? userID : null;
                    newStaff.StaffName = (userName != "") ? userName : null;
                    newStaff.Gender = cboGender.Text;
                    newStaff.Center = cboCenter.Text;
                    newStaff.Email = (email != "") ? email : null;
                    newStaff.Pass = (password != null) ? password : null;
                    newStaff.Position = cboPosition.Text;
                    newStaff.Salary = (salary != -999) ? (decimal)salary : (decimal)0.0;
                    newStaff.Ctype = cboType.Text;
                    newStaff.Late = (late != -999) ? (int)late : (int)0.0;
                    newStaff.SImage = "Staff.jpg";
                    newStaff.SparePass = null;
                    dbContext.staff.Add(newStaff);
                    dbContext.SaveChanges();
                    MessageBox.Show("The data entry of staff personal information success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
