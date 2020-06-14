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
    public partial class frmAttractionBooking : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmTransport frmTransport;
        private frmCustomer frmCustomer;

        public frmAttractionBooking(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmTransport = new frmTransport(frmModuleSelection);
            frmCustomer = new frmCustomer(frmModuleSelection);
        }

        private void frmAttractionBooking_Load(object sender, EventArgs e)
        {
            attraction att = frmModuleSelection.chosenAttraction;

            if (att == null)
            {
                MessageBox.Show("Please search and choose a attraction first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtAttName.Text = att.AttractName;
            txtCity.Text = att.City;
            txtDuration.Text = att.Duration;
            txtCancel.Text = att.Cancellation;
            Image img = Image.FromFile("../Image/AttractionPhotos/" + att.AttractPhoto);
            picAttPhoto.Image = img;
            /*
            try
            {
                Image img = Image.FromFile("../Image/AttractionImage/" + att.AttractPhoto);
                picAttPhoto.Image = img;
            }
            catch (Exception)
            {
                picAttPhoto.Image = null;
            }
            */

            using (var dbContext = new tickettailor_dbEntities())
            {
                var Adult = (from i in dbContext.attractionprice
                             where i.AttractName == att.AttractName && i.Visitor == "Adult"
                             select i).FirstOrDefault();

                var Child = (from i in dbContext.attractionprice
                             where i.AttractName == att.AttractName && i.Visitor == "Child"
                             select i).FirstOrDefault();

                txtPriceAdult.Text = Adult.Price.ToString();
                txtPriceChild.Text = Child.Price.ToString();
            }
            calPrice("Adult");
            calPrice("Child");
        }

        private void calPrice(string visitor)
        {
            try
            {
                if (visitor == "Adult")
                {
                    int num = Convert.ToInt32(nudNumAdult.Value);
                    int price = Convert.ToInt32(txtPriceAdult.Text);
                    txtTotalAdult.Text = Convert.ToString(num * price);
                    txtTotal.Text = (Convert.ToInt32(txtTotalAdult.Text) + Convert.ToInt32(txtTotalChild.Text)).ToString();
                    return;
                }
            }
            catch (Exception)
            {
                txtTotalAdult.Text = "0";
            }
            try
            {
                if (visitor == "Child")
                {
                    int num = Convert.ToInt32(nudNumChild.Value);
                    int price = Convert.ToInt32(txtPriceChild.Text);
                    txtTotalChild.Text = Convert.ToString(num * price);
                    txtTotal.Text = (Convert.ToInt32(txtTotalAdult.Text) + Convert.ToInt32(txtTotalChild.Text)).ToString();
                    return;
                }
            }
            catch (Exception)
            {
                txtTotalChild.Text = "0";
            }
        }

        private void nudAdultNum_ValueChanged(object sender, EventArgs e)
        {
            calPrice("Adult");
        }

        private void nudChildNum_ValueChanged(object sender, EventArgs e)
        {
            calPrice("Child");
        }

        private void btnConfirmTicket_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                MessageBox.Show("Please input at least one ticket.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(nudNumAdult.Value == 0)
            {
                MessageBox.Show("The required quantity of adult must be at least one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Do you Confirm the above reservation?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new tickettailor_dbEntities())
                {
                    attractionbooking attBooking = new attractionbooking();
                    attBooking.AttractionBookingID = context.attractionbooking.Select(i => i.AttractionBookingID).OrderByDescending(i => i).FirstOrDefault() + 1;
                    attBooking.AttractName = Convert.ToString(txtAttName.Text);
                    attBooking.AdultNum = Convert.ToInt32(nudNumAdult.Value);
                    attBooking.ChildNum = Convert.ToInt32(nudNumChild.Value);
                    attBooking.AdultPrice = Convert.ToInt32(txtTotalAdult.Text);
                    attBooking.ChildPrice = Convert.ToInt32(txtTotalChild.Text);
                    attBooking.Status = "Self Organized";
                    attBooking.OrderDate = DateTime.Now;
                    attBooking.OrderBy = frmModuleSelection.staff.StaffID;
                    attBooking.CustID = null;
                    context.attractionbooking.Add(attBooking);
                    context.SaveChanges();
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).attractionBooking = attBooking;

                    MessageBox.Show("The order confirmation success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Do you want to book the vehivle?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Dispose();
                        frmTransport.MdiParent = frmModuleSelection;
                        frmTransport.Dock = DockStyle.Fill;
                        frmTransport.Show();
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

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you cancel the above reservation ?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
