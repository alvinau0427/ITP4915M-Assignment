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
    public partial class frmConsole : Form
    {
        // Form Connection
        private frmModuleSelection frmModuleSelection;
        private frmCustomer frmCustomer;
        private frmOrder frmOrder;
        private frmInfo frmInfo;

        // Get form value
        private staff staff;
        private int tag;
        public void setTag(int tag)
        {
            this.tag = tag;
        }

        public int getTag()
        {
            return tag;
        }
        // Timer function
        Timer t = new Timer();

        public frmConsole(frmModuleSelection frm)
        {
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmCustomer = new frmCustomer(frmModuleSelection);
            frmOrder = new frmOrder(frmModuleSelection);
            frmInfo = new frmInfo(frmModuleSelection);
        }

        private void frmConsole_Load(object sender, EventArgs e)
        {
            staff = frmModuleSelection.staff;
            t.Interval = 1000;
            t.Start();

            DateTime today = DateTime.Now;
            DateTime destDay = new DateTime(2016, 06, 17);
            toolStripStatusLabel1.Text = "Clock : " + DateTime.Now;
            toolStripStatusLabel2.Text = " Timer : " + ((int)(destDay - today).TotalDays) + " days left";
            toolStripStatusLabel3.Text = " Status : Login Successful";

            txtStaffID.Text = frmModuleSelection.staff.StaffID;
            txtFullName.Text = frmModuleSelection.staff.StaffName;
            txtGender.Text = frmModuleSelection.staff.Gender;
            txtEmail.Text = frmModuleSelection.staff.Email;
            txtCenter.Text = frmModuleSelection.staff.Center;
            txtPosition.Text = frmModuleSelection.staff.Position;
            txtLate.Text = frmModuleSelection.staff.Late.ToString();
            picIcon.Image = Image.FromFile("../Image/StaffPhotos/" + staff.SImage);
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            if (txtNumberTag.Text != "")
            {
                ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).tag = txtNumberTag.Text;
                reOpenConsole();
                frmOrder.MdiParent = frmModuleSelection;
                frmOrder.Dock = DockStyle.Fill;
                frmOrder.Show();
            }
        }

        private void reOpenConsole()
        {
            // Reload the information form to turn off the youtube video
            this.Close();
            var temp = new frmConsole(frmModuleSelection);
            temp.MdiParent = frmModuleSelection;
            temp.Dock = DockStyle.Fill;
            temp.Show();
            Dispose();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to sign out this user account?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // frmModuleSelection.staff = null;
                frmModuleSelection.loginSystemToolStripMenuItem.Enabled = true;
                frmModuleSelection.staffControlToolStripMenuItem.Enabled = false;
                frmModuleSelection.createUserAccountToolStripMenuItem.Enabled = false;
                frmInfo.MdiParent = frmModuleSelection;
                frmInfo.Dock = DockStyle.Fill;
                frmInfo.Show();
                this.Close();
                MessageBox.Show("You have signed out.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm all the bookings?", "Confirm Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reOpenConsole();
                frmCustomer.MdiParent = frmModuleSelection;
                frmCustomer.Dock = DockStyle.Fill;
                frmCustomer.Show();
            }
        }
    }
}