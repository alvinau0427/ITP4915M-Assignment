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
    public partial class frmCruiseBooking : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmAttraction frmAttraction;
        private frmCustomer frmCustomer;
        private DataGridViewRow chosenCruise;

        // Define a variable of the value
        string cruiseNo;
        string cruiseName;
        double adultPrice;
        double childPrice;
        string tourDay;
        string startDate;
        
        public frmCruiseBooking(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmAttraction = new frmAttraction(frmModuleSelection);
            frmCustomer = new frmCustomer(frmModuleSelection);
        }

        private void frmCruiseBooking_Load(object sender, EventArgs e)
        {
            chosenCruise = frmModuleSelection.chosenCruise;
            if (chosenCruise != null)
            {
                cruiseNo = Convert.ToString(chosenCruise.Cells[0].Value);
                cruiseName = Convert.ToString(chosenCruise.Cells[1].Value);
                adultPrice = Convert.ToDouble(chosenCruise.Cells[2].Value);
                childPrice = Convert.ToDouble(chosenCruise.Cells[2].Value) * 0.6;
                tourDay = Convert.ToString(chosenCruise.Cells[3].Value);
                startDate = Convert.ToString(chosenCruise.Cells[6].Value);
                getData();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Confirm the above reservation?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new tickettailor_dbEntities())
                {
                    cruisebooking cruise = new cruisebooking();

                    cruise.CruiseBookingID = context.cruisebooking.Select(i => i.CruiseBookingID).OrderByDescending(i => i).FirstOrDefault() + 1;
                    cruise.CruiseNo = cruiseNo;
                    cruise.AdultNum = Convert.ToInt32(nudAdultNum.Value);
                    cruise.ChildNum = Convert.ToInt32(nudChildNum.Value);
                    cruise.AdultPrice = Convert.ToInt32(nudAdultNum.Value) * Convert.ToInt32(adultPrice);
                    cruise.ChildPrice = Convert.ToInt32(nudChildNum.Value) * Convert.ToInt32(childPrice);
                    cruise.OrderDate = DateTime.Now.Date;
                    cruise.OrderBy = frmModuleSelection.staff.StaffID;
                    cruise.CustID = null;

                    context.cruisebooking.Add(cruise);
                    context.SaveChanges();
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).cruiseBooking = cruise;

                    MessageBox.Show("The order confirmation success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Do you have other booking?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Dispose();
                    }
                    else
                    {
                        Dispose();
                        frmCustomer.MdiParent = frmModuleSelection;
                        frmCustomer.Dock = DockStyle.Fill;
                        frmCustomer.Show();
                    }
                }
            }
        }

        private void changeTotal()
        {
            txtAdultTotal.Text = Convert.ToString(adultPrice * Convert.ToInt32(nudAdultNum.Value));
            txtChildTotal.Text = Convert.ToString(childPrice * Convert.ToInt32(nudChildNum.Value));
            txtTicketTotal.Text = Convert.ToString(Convert.ToDouble(txtAdultTotal.Text) + Convert.ToDouble(txtChildTotal.Text));
        }

        private void nudAdultNum_MouseUp(object sender, MouseEventArgs e)
        {
            changeTotal();
        }

        private void nudChildNum_MouseUp(object sender, MouseEventArgs e)
        {
            changeTotal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you cancel the above reservation?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void getData()
        {
            txtCruiseNo.Text = cruiseNo;
            txtCruiseName.Text = cruiseName;
            txtAdultFare.Text = Convert.ToString(adultPrice);
            txtChildFare.Text = Convert.ToString(childPrice);
            txtTourDay.Text = tourDay;
            txtStartDate.Text = startDate;
            changeTotal();
        }
    }
}
