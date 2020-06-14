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
    public partial class frmTransportBooking : Form
    {
        private frmModuleSelection frmModuleSelection;
        private frmCustomer frmCustomer;

        Dictionary<string, Dictionary<int, ComboboxItem>> driverBooking = new Dictionary<string, Dictionary<int, ComboboxItem>>();
        private double vehiclePrice = 0;
        private string vehicleID;
        private int bookingID;
        private vehicle ve;
        private attractionbooking ab;

        public frmTransportBooking(frmModuleSelection frm)
        {
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmCustomer = new frmCustomer(frmModuleSelection);
        }

        private void frmTransportBooking_Load(object sender, EventArgs e)
        {
            ve = ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).vehicle;
            ab = ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).attractionBooking;

            vehicleID = ve.VehicleID;
            bookingID = ab.AttractionBookingID;

            vehiclePrice = Convert.ToDouble(ve.Price);
            lblVehicle.Text = ve.VehicleName.ToString();
            lblType.Text = ve.VehicleType.ToString();
            lblCapacity.Text = ve.Capacity.ToString();
            lblStatus.Text = ab.Status.ToString();
            picVehicle.Image = Image.FromFile("../Image/VehiclePhotos/" + ve.VehiclePhoto);

            if (ve.VehicleType.ToString() == "coach")
                btnDriver.Visible = true;
            else
                btnDriver.Visible = false;

            updateStatus();
            updateEquipment(ve.VehicleType.ToString());
            updatePrice();
        }

        private void updateStatus()
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                var status = (from i in dbContext.attractionbooking
                              where i.AttractionBookingID.Equals(bookingID)
                              select i.Status).FirstOrDefault();

                lblStatus.Text = status.ToString();
                lblStatus.Font = new Font("Calibri", 12, FontStyle.Bold);
                if (status.ToString() == "Confirmed")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Blue;
                    btnOK.Enabled = true;
                    btnConfirm.Enabled = false;
                }
                else
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    btnOK.Enabled = false;
                    btnConfirm.Enabled = true;
                }
            }
        }

        private void updateEquipment(string type)
        {
            dgvEquip.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var equipment = (from i in dbContext.equipment
                                 where i.Suitable.Equals(type)
                                 select i);

                dgvEquip.RowTemplate.Height = 40;
                foreach (var i in equipment.ToList())
                {
                    Image image = Image.FromFile("../Image/EquipPhotos/" + i.EquipPhoto);
                    dgvEquip.Rows.Add(i.EquipID, i.Equipment1, i.Suitable, i.Price, image, "0");
                }
            }
        }

        private void updatePrice()
        {
            DateTime dropoff = dtpDropoff.Value.Date;
            DateTime pickup = dtpPickup.Value.Date;
            int day = (dropoff - pickup).Days + 1;
            lblBookDay.ForeColor = System.Drawing.Color.Black;
            lblBookDay.Font = new Font("Calibri", 12);
            if (day < 1)
            {
                day = 0;
                lblBookDay.ForeColor = System.Drawing.Color.Red;
                lblBookDay.Font = new Font("Calibri", 12, FontStyle.Bold);
            }

            lblBookDay.Text = day.ToString();
            lblTCharges.Text = (vehiclePrice * day).ToString();

            double equipPrice = 0;
            foreach (DataGridViewRow row in dgvEquip.Rows)
            {
                if (Convert.ToInt32(row.Cells["EquipNum"].Value) > 0)
                    equipPrice += Convert.ToDouble(row.Cells["EquipPrice"].Value) * Convert.ToDouble(row.Cells["EquipNum"].Value);
            }
            lblECharges.Text = equipPrice.ToString();
            lblTotal.Text = (equipPrice + (vehiclePrice * day)).ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lblBookDay.Text == "0")
            {
                MessageBox.Show("The booking day at lease 1 day.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lblType.Text == "coach" && !hasAnyDate())
                return;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var booking = (from i in dbContext.attractionbooking
                               where i.AttractionBookingID.Equals(bookingID)
                               select i).FirstOrDefault();

                booking.Status = "Confirmed";
                dbContext.SaveChanges();
            }
            updateStatus();
            grbTBooking.Enabled = false;
        }

        private Boolean hasAnyDate()
        {
            foreach (var i in driverBooking)
            {
                if (driverBooking[i.Key].Values.Any())
                    return true;
            }
            MessageBox.Show("Please select driver first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lblBookDay.Text == "0")
            {
                MessageBox.Show("The booking day at lease 1 day.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Do you confirm all the bookings?", "Confirm Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dbContext = new tickettailor_dbEntities())
                {
                    //insert vehicle booking
                    var vBookingID = (from i in dbContext.vehiclebooking.OrderByDescending(i => i.VehicleBookingID)
                                      select i).FirstOrDefault();

                    int lastNo;
                    if (vBookingID == null)
                        lastNo = 1;
                    else
                        lastNo = vBookingID.VehicleBookingID + 1;

                    vehiclebooking vBooking = new vehiclebooking();

                    vBooking.VehicleBookingID = lastNo;
                    vBooking.VehicleID = vehicleID;
                    vBooking.AttractionBookingID = bookingID;
                    vBooking.BookDay = Convert.ToInt32(lblBookDay.Text);
                    vBooking.OrderBy = ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).staff.StaffID;
                    vBooking.OrderDate = DateTime.Now;
                    vBooking.PickupDate = dtpPickup.Value.Date;
                    vBooking.DropoffDate = dtpDropoff.Value.Date;

                    decimal dCost = 0;
                    if (lblType.Text == "coach")
                    {
                        foreach (var i in driverBooking)
                        {
                            foreach (var j in driverBooking[i.Key])
                                dCost += j.Value.DriverCost;
                        }
                    }
                    vBooking.DriverCost = dCost;

                    vBooking.VehicleBookPrice = Convert.ToDecimal(lblTCharges.Text);

                    dbContext.vehiclebooking.Add(vBooking);


                    //insert driver booking
					Dictionary<driverbooking, driverbooking> alldriverbooking = new Dictionary<driverbooking, driverbooking>();
                    if (lblType.Text == "coach")
                    {
                        foreach (var i in driverBooking)
                        {
                            foreach (var j in driverBooking[i.Key])
                            {
                                driverbooking dBooking = new driverbooking();
                                dBooking.DriverRosterID = j.Value.RosterID; //insert rosterid
                                dBooking.BookingDate = DateTime.ParseExact(i.Key, "yyyy-MM-dd", null); //insert date
                                dBooking.CustID = null;
                                dBooking.VehicleBookingID = lastNo;
                                dbContext.driverbooking.Add(dBooking);
								alldriverbooking.Add(dBooking, dBooking);
                            }
                        }
                    }
					((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).driverbooking = alldriverbooking;

                    //insert equipment booking
                    foreach (DataGridViewRow row in dgvEquip.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["EquipNum"].Value) > 0)
                        {
                            equipmentlist eBooking = new equipmentlist();
                            eBooking.VehicleBookingID = lastNo;
                            eBooking.EquipID = row.Cells["EquipID"].Value.ToString();
                            eBooking.EquipNum = Convert.ToInt32(row.Cells["EquipNum"].Value);
                            eBooking.EquipBookPrice = (decimal)(Convert.ToDouble(row.Cells["EquipPrice"].Value) * Convert.ToDouble(row.Cells["EquipNum"].Value));

                            dbContext.equipmentlist.Add(eBooking);
                        }
                    }
                    dbContext.SaveChanges();
                    frmCustomer.MdiParent = frmModuleSelection;
                    frmCustomer.Dock = DockStyle.Fill;
                    frmCustomer.Show();
                    Dispose();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = Convert.ToInt32(dgvEquip.Rows[e.RowIndex].Cells["EquipNum"].Value);
            if (dgvEquip.Columns[e.ColumnIndex].Name == "Add")
            {
                dgvEquip.Rows[e.RowIndex].Cells["EquipNum"].Value = num + 1;

            }
            else if (dgvEquip.Columns[e.ColumnIndex].Name == "Subtract" && num > 0)
            {
                dgvEquip.Rows[e.RowIndex].Cells["EquipNum"].Value = num - 1;
            }
            updatePrice();
        }

        private void dtpPickup_ValueChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void dtpDropoff_ValueChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            DateTime dropoff = dtpDropoff.Value.Date;
            DateTime pickup = dtpPickup.Value.Date;

            frmDriverBooking frmDriver = new frmDriverBooking(pickup, dropoff, driverBooking, ve);
            if (frmDriver.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                driverBooking = frmDriver.dateDriver;
            }
        }
    }
}
