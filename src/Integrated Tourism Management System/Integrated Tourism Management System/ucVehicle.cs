using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Tourism_Management_System
{
    public partial class ucVehicle : UserControl
    {
        private frmModuleSelection frmModuleSelection;
        private frmTransportBooking frmTransportBooking;
        private string vehicleID;
        private int bookingID;

        public ucVehicle(vehicle ve, attractionbooking ab, frmModuleSelection frmModuleSelection)
        {
            InitializeComponent();

            this.frmModuleSelection = frmModuleSelection;
            frmTransportBooking = new frmTransportBooking(frmModuleSelection);
            vehicleID = ve.VehicleID;
            bookingID = ab.AttractionBookingID;

            pbVehicle.Image = Image.FromFile("../Image/VehiclePhotos/" + ve.VehiclePhoto);
            lblShowName.Text = ve.VehicleName;
            lblShowType.Text = ve.VehicleType;
            lblShowCapacity.Text = ve.Capacity.ToString();
            lblShowGear.Text = ve.Gear;
            lblShowColor.Text = ve.Color;
            lblShowPrice.Text = ve.Price.ToString();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to book \n" + lblShowName.Text + "?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //update the status
                using (var dbContext = new tickettailor_dbEntities())
                {
                    var vehicle = (from i in dbContext.vehicle
                                   where i.VehicleID.Equals(vehicleID)
                                   select i).FirstOrDefault();

                    var booking = (from i in dbContext.attractionbooking
                                   where i.AttractionBookingID.Equals(bookingID)
                                   select i).FirstOrDefault();

                    if (vehicle.VehicleType == "car")
                        booking.Status = "Car";
                    else if (vehicle.VehicleType == "coach")
                        booking.Status = "Coach";

                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).vehicle = vehicle;
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).attractionBooking = booking;
                    dbContext.SaveChanges();

                    frmTransportBooking.MdiParent = frmModuleSelection;
                    frmTransportBooking.Dock = DockStyle.Fill;
                    frmTransportBooking.Show();
                }
            }
        }
    }
}
