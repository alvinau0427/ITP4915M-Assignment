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
    public partial class frmTransport : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;

        // Setup variable
        int bookingID;

        public frmTransport(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmTransport_Load(object sender, EventArgs e)
        {
            this.cboBooking.Items.Clear();
            cboBooking.Items.Add("All");
            cboBooking.SelectedIndex = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var staff = (from i in dbContext.attractionbooking
                             select i.staff.StaffID).Distinct().OrderBy(i => i);

                foreach (var name in staff.ToList())
                {
                    cboBooking.Items.Add(name);
                }
            }
            loadBooking(cboBooking.Text);
        }

        private void cboBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBooking(cboBooking.Text);
        }

        private void loadBooking(string condition)
        {
            this.dataGridView1.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var attBooking = (from i in dbContext.attractionbooking
                                  where i.staff.StaffID == condition || cboBooking.SelectedIndex == 0
                                  select i);

                foreach (var i in attBooking.ToList())
                {
                    dataGridView1.Rows.Add(i.AttractionBookingID,
                                           i.AttractName,
                                           i.AdultNum,
                                           i.ChildNum,
                                           i.AdultPrice,
                                           i.ChildPrice,
                                           i.Status,
                                           ((DateTime)i.OrderDate).ToString("yyyy-MM-dd"),
                                           i.OrderBy);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;
            //add item to combo box
            this.cboVehicle.Items.Clear();
            cboVehicle.Items.Add("All");
            using (var dbContext = new tickettailor_dbEntities())
            {
                var vehicleType = (from i in dbContext.vehicle
                                   select i.VehicleType).Distinct();
                foreach (var i in vehicleType.ToList())
                {
                    cboVehicle.Items.Add(i);
                }
            }
            cboVehicle.SelectedIndex = 0;
            groupBox2.Visible = true;
        }

        private void cboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVehicle(cboVehicle.Text);
        }

        private void loadVehicle(string condition)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var vehicle = (from i in dbContext.vehicle
                               where i.VehicleType == condition || cboVehicle.SelectedIndex == 0
                               select i);

                int d1Row = dataGridView1.SelectedCells[0].RowIndex;
                bookingID = Convert.ToInt32(dataGridView1.Rows[d1Row].Cells["AttractionBookingID"].Value);

                var booking = (from i in dbContext.attractionbooking
                               where i.AttractionBookingID.Equals(bookingID)
                               select i).FirstOrDefault();

                foreach (var i in vehicle.ToList())
                {
                    ucVehicle uc = new ucVehicle(i, booking, frmModuleSelection);
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
