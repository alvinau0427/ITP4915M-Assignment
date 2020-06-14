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

namespace Integrated_Tourism_Management_System
{
    public partial class frmProductManagement : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        OpenFileDialog ofd;
        private int airScheIndex, airClassIndex, hotelIndex, roomIndex, cruiseIndex, organIndex, attrIndex, vehicleIndex, equipIndex;

        public frmProductManagement(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            loadAirSchedule();
            btnFlightUpdate.Enabled = false;
            btnHotelDelete.Enabled = false;
            loadAirClass();
            btnClassUpdate.Enabled = false;
            btnClassDelete.Enabled = false;
            loadHotel();
            btnHotelUpdate.Enabled = false;
            btnHotelDelete.Enabled = false;
            loadHotelRoom();
            btnHotelRoomUpdate.Enabled = false;
            btnHotelRoomDelete.Enabled = false;
            loadCruise();
            btnCruiseUpdate.Enabled = false;
            btnCruiseDelete.Enabled = false;
            loadOrgan();
            btnOrganUpdate.Enabled = false;
            btnOrganDelete.Enabled = false;
            loadAttraction();
            btnAttractionUpdate.Enabled = false;
            btnAttractionDelete.Enabled = false;
            btnUploadImage.Enabled = false;
            loadVehicle();
            btnVehicleUpdate.Enabled = false;
            btnVehicleDelete.Enabled = false;
            btnVehicleUpload.Enabled = false;
            loadEquipment();
            btnEquipUpdate.Enabled = false;
            btnEquipDelete.Enabled = false;
            btnEquipUpload.Enabled = false;
        }

        private void loadAirSchedule()
        {
            cboOrigin.Items.Clear();
            cboDestination.Items.Clear();
            cboAircraft.Items.Clear();
            cboFlightNo.Items.Clear();
            cboFlightType.Items.Clear();
            dgvFlight.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var origin = (from l in dbContext.flightschedule
                                select l.Origin).Distinct();
                foreach (var o in origin.ToList())
                {
                    cboOrigin.Items.Add(o);
                }

                var dest = (from l in dbContext.flightschedule
                                select l.Dest).Distinct();
                foreach (var d in dest.ToList())
                {
                    cboDestination.Items.Add(d);
                }

                var aircraft = (from l in dbContext.flightschedule
                                select l.Aircraft).Distinct();
                foreach (var a in aircraft.ToList())
                {
                    cboAircraft.Items.Add(a);
                }

                var flightNo = (from l in dbContext.flightclass
                                select l.FlightNo).Distinct();
                foreach (var c in flightNo.ToList())
                {
                    cboFlightNo.Items.Add(c);
                }

                var flightType = (from l in dbContext.flightclass
                                select l.FlightType).Distinct();
                foreach (var t in flightType.ToList())
                {
                    cboFlightType.Items.Add(t);
                }

                var schudule = from l in dbContext.flightschedule
                            select l;

                foreach (var s in schudule.ToList())
                {
                    dgvFlight.Rows.Add(s.FlightID,
                                      s.carrier1.IATA,
                                      s.Origin,
                                      s.Dest,
                                      s.Aircraft,
                                      s.EDD,
                                      s.ETD,
                                      s.EDA,
                                      s.ETA,
                                      s.FlightNo,
                                      s.FlightType);
                }
            }
        }

        private void loadAirClass()
        {
            cboClass.Items.Clear();
            cboType.Items.Clear();
            dgvClass.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var airClass = (from l in dbContext.flightclass
                               select l.Class).Distinct();

                foreach (var c in airClass.ToList())
                {
                    cboClass.Items.Add(c);
                }
                var airType = (from l in dbContext.flightclass
                                select l.FlightType).Distinct();

                foreach (var t in airType.ToList())
                {
                    cboType.Items.Add(t);
                }

                var airClasses = from l in dbContext.flightclass
                            select l;

                foreach (var c in airClasses.ToList())
                {
                    dgvClass.Rows.Add(c.FlightNo,
                                      c.Class,
                                      c.FlightType,
                                      c.Price_Adult,
                                      c.Price_Children,
                                      c.Price_Infant,
                                      c.Tax);
                }
            }
        }

        private void loadHotel()
        {
            dgvHotel.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var hotel = from l in dbContext.hotel
                            select l;

                foreach (var h in hotel.ToList())
                {
                    dgvHotel.Rows.Add(h.HotelID,
                                      h.Hotel_chi_name,
                                      h.Hotel_en_name,
                                      h.Star,
                                      h.Rating,
                                      h.Region,
                                      h.Address,
                                      h.Tel);
                }
            }
        }

        private void loadHotelRoom()
        {
            cmbHotel.Items.Clear();
            dgvHotelRoom.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var roomList = (from l in dbContext.hotel_room
                                select l.HotelID).Distinct();
                foreach (var room in roomList.ToList())
                {
                    cmbHotel.Items.Add(room);
                }

                var list = from l in dbContext.hotel_room
                           select l;

                foreach (var hotelRoom in list.ToList())
                {
                    dgvHotelRoom.Rows.Add(hotelRoom.Hotel_roomID,
                                           hotelRoom.Hotel_chi_name,
                                           hotelRoom.Hotel_room_name,
                                           hotelRoom.Hotel_room_size,
                                           hotelRoom.Max_adult,
                                           hotelRoom.Max_child,
                                           hotelRoom.Hotel_room_description,
                                           hotelRoom.Fare,
                                           hotelRoom.HotelID);
                }
            }
        }

        private void loadCruise()
        {
            comBoxOrganC.Items.Clear();
            dgvCruise.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var corganizer = from l in dbContext.corganizer
                                 select l;
                foreach (var cor in corganizer.ToList())
                {
                    comBoxOrganC.Items.Add(cor.OrganizerE);
                }

                var list = from l in dbContext.cruise
                           select l;


                foreach (var cruise in list.ToList())
                {
                    dgvCruise.Rows.Add(cruise.CruiseNo,
                                           cruise.CruiseName,
                                           cruise.RefPrice,
                                           cruise.TourDay,
                                           cruise.corganizer.OrganizerE,
                                           cruise.Info,
                                           cruise.StartDate.Value.ToString("dd-MM-yyyy"));
                }
            }
        }

        private void loadOrgan()
        {
            dgvOrgan.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var list = from l in dbContext.corganizer
                           select l;


                foreach (var corganizer in list.ToList())
                {
                    dgvOrgan.Rows.Add(corganizer.OrganID,
                                           corganizer.OrganizerE,
                                           corganizer.OrganizerC);
                }
            }
        }

        private void loadAttraction()
        {
            dgvAttraction.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var list = from l in dbContext.attraction
                           select l;
                string name;
                foreach (var attr in list.ToList())
                {
                    name = attr.AttractName;
                    var adultPrice = (from l in dbContext.attractionprice
                                      where l.AttractName.Contains(name) && l.Visitor.Contains("Adult")
                                      select l).FirstOrDefault();

                    var childPrice = (from l in dbContext.attractionprice
                                      where l.AttractName.Contains(name) && l.Visitor.Contains("Child")
                                      select l).FirstOrDefault();

                    dgvAttraction.Rows.Add(attr.AttractName,
                                           attr.Duration,
                                           attr.Cancellation,
                                           attr.AttractPhoto,
                                           attr.City,
                                           adultPrice.Price,
                                           childPrice.Price);
                }
            }
        }

        private void loadVehicle()
        {
            cmbVehicleType.Items.Clear();
            cmbGear.Items.Clear();
            dgvVehicle.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var vehicleType = (from l in dbContext.vehicle
                                   select l.VehicleType).Distinct();
                foreach (var type in vehicleType.ToList())
                {
                    cmbVehicleType.Items.Add(type);
                }

                var gear = (from l in dbContext.vehicle
                            select l.Gear).Distinct();

                foreach (var g in gear.ToList())
                {
                    cmbGear.Items.Add(g);
                }

                var vehicle = from l in dbContext.vehicle
                              select l;

                foreach (var v in vehicle.ToList())
                {
                    dgvVehicle.Rows.Add(v.VehicleID,
                                        v.VehicleName,
                                        v.Price,
                                        v.VehicleType,
                                        v.Capacity,
                                        v.Gear,
                                        v.Color,
                                        v.VehiclePhoto);
                }
            }
        }

        private void loadEquipment()
        {
            cmbSuitable.Items.Clear();
            dgvEquip.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var suitable = (from l in dbContext.equipment
                                select l.Suitable).Distinct();
                foreach (var s in suitable.ToList())
                {
                    cmbSuitable.Items.Add(s);
                }

                var equipment = from l in dbContext.equipment
                                select l;

                foreach (var e in equipment.ToList())
                {
                    dgvEquip.Rows.Add(e.EquipID,
                                        e.Equipment1,
                                        e.Suitable,
                                        e.Price,
                                        e.EquipPhoto);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* #################### - - - - - - - - - - Air - - - - - - - - - - #################### */
        private void dgvFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            airScheIndex = e.RowIndex;
            txtFlightID.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[0].Value);
            txtCarrier.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[1].Value);
            cboOrigin.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[2].Value);
            cboDestination.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[3].Value);
            cboAircraft.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[4].Value);
            dtpEDD.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[5].Value);
            dtpETD.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[6].Value);
            dtpEDA.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[7].Value);
            dtpETA.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[8].Value);
            cboFlightNo.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[9].Value);
            cboFlightType.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells[10].Value);

            if (dgvFlight.Rows[airScheIndex].Cells[0].Value != null)
            {
                btnFlightUpdate.Enabled = true;
                btnFlightDelete.Enabled = true;
            }
            else
            {
                btnFlightUpdate.Enabled = false;
                btnFlightDelete.Enabled = false;
            }
        }

        private void btnFlightInsert_Click(object sender, EventArgs e)
        {
            int id = -999;
            Boolean parseIdInt = Int32.TryParse(txtFlightID.Text, out id);

            if (id == -999)
            {
                MessageBox.Show("Please input an integer in FlightID box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbContext = new tickettailor_dbEntities())
            {
                var list = from l in dbContext.flightschedule
                           select l;
                foreach (var f in list)
                {
                    if (id == f.FlightID)
                    {
                        MessageBox.Show("The FlightID is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                flightschedule newFlightSchedule = new flightschedule();

                newFlightSchedule.FlightID = id;
                var carrier = (from l in dbContext.carrier
                               where l.IATA == txtCarrier.Text
                               select l).FirstOrDefault();
                newFlightSchedule.Carrier = carrier.CID;
                newFlightSchedule.Origin = Convert.ToString(cboOrigin.SelectedItem);
                newFlightSchedule.Dest = Convert.ToString(cboDestination.SelectedItem);
                newFlightSchedule.Aircraft = Convert.ToString(cboAircraft.SelectedItem);
                newFlightSchedule.EDA = dtpEDA.Value;
                newFlightSchedule.EDD = dtpEDD.Value;
                newFlightSchedule.ETA = dtpETA.Value.TimeOfDay;
                newFlightSchedule.ETD = dtpETD.Value.TimeOfDay;

                int dayMinutes;
                int timeMinutes;
                if (dtpETA.Value.Hour >= dtpETD.Value.Hour)
                {
                    dayMinutes = (dtpEDA.Value.Day - dtpEDD.Value.Day) * 24 * 60;
                    if (dtpETA.Value.Minute > dtpETD.Value.Minute)
                        timeMinutes = (dtpETA.Value.Hour - dtpETD.Value.Hour) * 60 + (dtpETA.Value.Minute - dtpETD.Value.Minute);
                    else
                        timeMinutes = (dtpETA.Value.Hour - dtpETD.Value.Hour - 1) * 60 + (dtpETA.Value.Minute + 60 - dtpETD.Value.Minute);
                }
                    
                else
                {
                    dayMinutes = (dtpEDA.Value.Day - dtpEDD.Value.Day - 1) * 24 * 60;
                    if (dtpETA.Value.Minute > dtpETD.Value.Minute)
                        timeMinutes = (dtpETA.Value.Hour - dtpETD.Value.Hour) * 60 + (dtpETA.Value.Minute - dtpETD.Value.Minute);
                    else
                        timeMinutes = (dtpETA.Value.Hour + 24 - dtpETD.Value.Hour - 1) * 60 + (dtpETA.Value.Minute + 60 - dtpETD.Value.Minute);
                } 
                newFlightSchedule.TravelTime = dayMinutes + timeMinutes;
                newFlightSchedule.FlightNo = Convert.ToString(cboFlightNo.SelectedItem);
                newFlightSchedule.FlightType = Convert.ToString(cboFlightType.SelectedItem);

                DialogResult result = MessageBox.Show("FlightID:   " + newFlightSchedule.FlightID +
                                                        "\n\nCarrier:\n" + txtCarrier.Text +
                                                        "\n\nDestination:\n" + newFlightSchedule.Dest +
                                                        "\n\nAircraft:\n" + newFlightSchedule.Aircraft +
                                                        "\n\nEstimated Date Of Arrival:\n" + newFlightSchedule.EDA +
                                                        "\n\nEstimated Time Of Arrival:\n" + newFlightSchedule.ETA +
                                                        "\n\nEstimated Date Of Departure:\n" + newFlightSchedule.EDD +
                                                        "\n\nEstimated Time Of Departure:\n" + newFlightSchedule.ETD +
                                                        "\n\nFlightNo:\n" + newFlightSchedule.FlightNo +
                                                        "\n\nFlightType:\n" + newFlightSchedule.FlightType, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.flightschedule.Add(newFlightSchedule);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAirSchedule();
                }
            }
        }

        private void btnFlightUpdate_Click(object sender, EventArgs e)
        {
            int id = -999;
            Boolean parseIdInt = Int32.TryParse(txtFlightID.Text, out id);

            if (id == -999)
            {
                MessageBox.Show("Please input an integer in FlightID box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToInt32(dgvFlight.Rows[airScheIndex].Cells["FlightID"].Value) != Convert.ToInt32(txtFlightID.Text))
                {
                    MessageBox.Show("The FlightID should not be changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFlightID.Text = Convert.ToString(dgvFlight.Rows[airScheIndex].Cells["FlightID"].Value);
                    id = Convert.ToInt32(dgvFlight.Rows[airScheIndex].Cells["FlightID"].Value);
                }

                DialogResult result = MessageBox.Show("FlightID:   " + txtFlightID.Text +
                                                        "\n\nCarrier:\n" + txtCarrier.Text +
                                                        "\n\nDestination:\n" + cboDestination.SelectedItem +
                                                        "\n\nAircraft:\n" + cboAircraft.SelectedItem +
                                                        "\n\nEstimated Date Of Arrival:\n" + dtpEDA.Value.ToString("yyyy-MM-dd") +
                                                        "\n\nEstimated Time Of Arrival:\n" + dtpETA.Value.ToString("HH:mm") +
                                                        "\n\nEstimated Date Of Departure:\n" + dtpEDD.Value.ToString("yyyy-MM-dd") +
                                                        "\n\nEstimated Time Of Departure:\n" + dtpETD.Value.ToString("HH:mm") +
                                                        "\n\nFlightNo:\n" + cboFlightNo.SelectedItem +
                                                        "\n\nFlightType:\n" + cboFlightType.SelectedItem, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var airSchedule = (from list in dbContext.flightschedule
                                     where list.FlightID == id
                                     select list).FirstOrDefault();
                    var carrier = (from list in dbContext.carrier
                                       where list.IATA == txtCarrier.Text
                                       select list.CID).FirstOrDefault();

                    airSchedule.Carrier = carrier;
                    airSchedule.Dest = Convert.ToString(cboDestination.SelectedItem);
                    airSchedule.Aircraft = Convert.ToString(cboAircraft.SelectedItem);
                    airSchedule.EDA = dtpEDA.Value;
                    airSchedule.ETA = dtpETA.Value.TimeOfDay;
                    airSchedule.EDD = dtpEDD.Value;
                    airSchedule.ETD = dtpETD.Value.TimeOfDay;
                    airSchedule.FlightNo = Convert.ToString(cboFlightNo.SelectedItem);
                    airSchedule.FlightType = Convert.ToString(cboFlightType.SelectedItem);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAirSchedule();
                }
            }
        }

        private void btnFlightDelete_Click(object sender, EventArgs e)
        {
            if (dgvFlight.Rows[airScheIndex] != null)
            {
                int id = Convert.ToInt32(dgvFlight.Rows[airScheIndex].Cells["FlightID"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "FlightID:  " + dgvFlight.Rows[airScheIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem = (from list in dbContext.flightschedule
                                          where list.FlightID == id
                                          select list).FirstOrDefault();
                        dbContext.flightschedule.Remove(deleteItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadAirSchedule();
                    }
                }
            }
        }


        private void cboFlightNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                var no = (from l in dbContext.flightclass
                               where l.FlightNo == ((string)cboFlightNo.SelectedItem)
                               select l.FlightNo).FirstOrDefault();
                txtCarrier.Text = no.Substring(0,2);
            }
        }

        /* #################### - - - - - - - - - - Class - - - - - - - - - - #################### */
        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            airClassIndex = e.RowIndex;
            txtClassFlightNo.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[0].Value);
            cboClass.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[1].Value);
            cboType.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[2].Value);
            txtAdult.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[3].Value);
            txtChildren.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[4].Value);
            txtInfact.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[5].Value);
            txtTax.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[6].Value);

            if (dgvClass.Rows[airClassIndex].Cells[0].Value != null)
            {
                btnClassUpdate.Enabled = true;
                btnClassDelete.Enabled = true;
            }
            else
            {
                btnClassUpdate.Enabled = false;
                btnClassDelete.Enabled = false;
            }
        }

        private void btnClassInsert_Click(object sender, EventArgs e)
        {
            using (var content = new tickettailor_dbEntities())
            {
                if (txtClassFlightNo.Text == "")
                {
                    MessageBox.Show("Please input the FlightNo.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var carrier = (from l in content.carrier
                               where l.IATA == txtClassFlightNo.Text.Substring(0,2)
                               select l).FirstOrDefault();
                if (carrier == null)
                {
                    MessageBox.Show("The carrier number is not existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double aPrice = 0;
                double cPrice = 0;
                double iPrice = 0;
                double tax = 0;
                Boolean parseAdultDouble = Double.TryParse(txtAdult.Text, out aPrice);
                Boolean parseChildDouble = Double.TryParse(txtChildren.Text, out cPrice);
                Boolean parseInfantDouble = Double.TryParse(txtInfact.Text, out iPrice);
                Boolean parseTaxDouble = Double.TryParse(txtTax.Text, out tax);

                var list = (from l in content.flightclass
                            select l.FlightNo).Distinct();
                foreach (var no in list)
                {
                    if (txtClassFlightNo.Text == no)
                    {
                        MessageBox.Show("The FlightNo is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                flightclass newClass = new flightclass();

                newClass.FlightNo = txtClassFlightNo.Text;
                newClass.Class = Convert.ToString(cboClass.SelectedItem);
                newClass.FlightType = Convert.ToString(cboType.SelectedItem);
                newClass.Price_Adult = (decimal)aPrice;
                newClass.Price_Children = (decimal)cPrice;
                newClass.Price_Infant = (decimal)iPrice;
                newClass.Tax = (decimal)tax;

                DialogResult result = MessageBox.Show("FlightNo:   " + newClass.FlightNo +
                                                        "\n\nClass:\n" + newClass.Class +
                                                        "\n\nFlightType:\n" + newClass.FlightType +
                                                        "\n\nAdult Price:\n" + newClass.Price_Adult +
                                                        "\n\nChildren Price:\n" + newClass.Price_Children +
                                                        "\n\nInfant Price:\n" + newClass.Price_Infant +
                                                        "\n\nTax:\n" + newClass.Tax, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    content.flightclass.Add(newClass);
                    content.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAirClass();
                }
            }    
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            double aPrice = 0;
            double cPrice = 0;
            double iPrice = 0;
            double tax = 0;
            Boolean parseAdultDouble = Double.TryParse(txtAdult.Text, out aPrice);
            Boolean parseChildDouble = Double.TryParse(txtChildren.Text, out cPrice);
            Boolean parseInfantDouble = Double.TryParse(txtInfact.Text, out iPrice);
            Boolean parseTaxDouble = Double.TryParse(txtTax.Text, out tax);

            string no = txtClassFlightNo.Text;
            string airClass = Convert.ToString(cboClass.SelectedItem);
            string type = Convert.ToString(cboType.SelectedItem);
            using (var dbContext = new tickettailor_dbEntities())
            {
                if ((string)dgvClass.Rows[airClassIndex].Cells["fno"].Value != txtClassFlightNo.Text)
                {
                    MessageBox.Show("The FlightNo should not be changed.");
                    no = txtClassFlightNo.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells["fno"].Value);
                }
                if ((string)dgvClass.Rows[airClassIndex].Cells["cla"].Value != Convert.ToString(cboClass.SelectedItem))
                {
                    MessageBox.Show("The FlightClass should not be changed.");
                    airClass = cboClass.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells["cla"].Value);
                }
                if ((string)dgvClass.Rows[airClassIndex].Cells["Fty"].Value != Convert.ToString(cboType.SelectedItem))
                {
                    MessageBox.Show("The FlightType should not be changed.");
                    type = cboType.Text = Convert.ToString(dgvClass.Rows[airClassIndex].Cells["Fty"].Value);
                }
                    DialogResult result = MessageBox.Show("FlightNo:   " + txtClassFlightNo.Text +
                                                         "\n\nClass:\n" + cboClass.SelectedItem +
                                                         "\n\nFlightType:\n" + cboType.SelectedItem +
                                                         "\n\nAdult Price:\n" + aPrice +
                                                         "\n\nChildren Price:\n" + cPrice +
                                                         "\n\nInfant Price:\n" + iPrice +
                                                         "\n\nTax:\n" + tax, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var c = (from list in dbContext.flightclass
                                 where list.FlightNo == no 
                                 && list.Class == airClass
                                 && list.FlightType == type
                                 select list).FirstOrDefault();
                    c.Price_Adult = (decimal)aPrice;
                    c.Price_Children = (decimal)cPrice;
                    c.Price_Infant = (decimal)iPrice;
                    c.Tax = (decimal)tax;
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAirClass();
                }
            }
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            if (dgvClass.Rows[airClassIndex] != null)
            {
                string no = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[0].Value);
                string cla = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[1].Value);
                string typ = Convert.ToString(dgvClass.Rows[airClassIndex].Cells[2].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "FlightNo:  " + no, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var c = (from list in dbContext.flightclass
                                 where list.FlightNo == no
                                 && list.Class == cla
                                 && list.FlightType == typ
                                 select list).FirstOrDefault();
                        dbContext.flightclass.Remove(c);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadAirClass();
                    }
                }
            }
        }

        /* #################### - - - - - - - - - - HOTEL - - - - - - - - - - #################### */
        private void dgvHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hotelIndex = e.RowIndex;
            txtHotelID.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[0].Value);
            txtChineseName.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[1].Value);
            txtEnglishName.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[2].Value);
            txtStar.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[3].Value);
            txtRating.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[4].Value);
            txtRegion.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[5].Value);
            txtAddress.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[6].Value);
            txtTel.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells[7].Value);

            if (dgvHotel.Rows[hotelIndex].Cells[0].Value != null)
            {
                btnHotelUpdate.Enabled = true;
                btnHotelDelete.Enabled = true;
            }
            else
            {
                btnHotelUpdate.Enabled = false;
                btnHotelDelete.Enabled = false;
            }
        }

        private void btnHotelInsert_Click(object sender, EventArgs e)
        {
            int id = -999;
            double star = -999;
            double rating = -999;
            int tel = 0;
            Boolean parseIdInt = Int32.TryParse(txtHotelID.Text, out id);
            Boolean parseStarDouble = Double.TryParse(txtStar.Text, out star);
            Boolean parseRatingDouble = Double.TryParse(txtRating.Text, out rating);
            Boolean parseTelInt = Int32.TryParse(txtTel.Text, out tel);

            if (id == -999)
            {
                MessageBox.Show("Please input an integer in HotelID box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (star < 0 || star > 5)
            {
                MessageBox.Show("Please input a number (0-5) in Star box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (rating < 0 || rating > 5)
            {
                MessageBox.Show("Please input a number (0-5) in Rating box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!((txtTel.Text).Length == 0 || (txtTel.Text).Length == 8 && tel != 0))
            {
                MessageBox.Show("Please input a valid telephone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string chineseName = txtChineseName.Text;
            string englishName = txtEnglishName.Text;
            string region = txtRegion.Text;
            string address = txtAddress.Text;

            using (var dbContext = new tickettailor_dbEntities())
            {
                var list = from l in dbContext.hotel
                           select l;
                foreach (var hotel in list)
                {
                    if (id == hotel.HotelID)
                    {
                        MessageBox.Show("The HotelID is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                hotel newHotel = new hotel();

                newHotel.HotelID = id;
                newHotel.Hotel_chi_name = (chineseName != "") ? chineseName : null;
                newHotel.Hotel_en_name = (englishName != "") ? englishName : null;
                newHotel.Star = (star != -999) ? (decimal)star : (decimal)0.0;
                newHotel.Rating = (rating != -999) ? (decimal)rating : (decimal)0.0;
                newHotel.Region = (region != "") ? region : null;
                newHotel.Address = (address != "") ? address : null;
                newHotel.Tel = (tel != 0) ? tel.ToString() : null;

                DialogResult result = MessageBox.Show("HotelID:   " + newHotel.HotelID +
                                                        "\n\nChineseName:\n" + newHotel.Hotel_chi_name +
                                                        "\n\nEnglishName:\n" + newHotel.Hotel_en_name +
                                                        "\n\nStar:\n" + newHotel.Star +
                                                        "\n\nRating:\n" + newHotel.Rating +
                                                        "\n\nRegion:\n" + newHotel.Region +
                                                        "\n\nAddress:\n" + newHotel.Address +
                                                        "\n\nTel:\n" + newHotel.Tel, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.hotel.Add(newHotel);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadHotel();
                }
            }
        }

        private void btnHotelUpdate_Click(object sender, EventArgs e)
        {
            int id = -999;
            double star = -999;
            double rating = -999;
            int tel = 0;
            Boolean parseIdInt = Int32.TryParse(txtHotelID.Text, out id);
            Boolean parseStarDouble = Double.TryParse(txtStar.Text, out star);
            Boolean parseRatingDouble = Double.TryParse(txtRating.Text, out rating);
            Boolean parseTelInt = Int32.TryParse(txtTel.Text, out tel);

            if (id == -999)
            {
                MessageBox.Show("Please input an integer in HotelID box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (star < 0 || star > 5)
            {
                MessageBox.Show("Please input a number (0-5) in Star box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (rating < 0 || rating > 5)
            {
                MessageBox.Show("Please input a number (0-5) in Rating box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!((txtTel.Text).Length == 0 || (txtTel.Text).Length == 8 && tel != 0))
            {
                MessageBox.Show("Please input a valid telephone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string chineseName = txtChineseName.Text;
            string englishName = txtEnglishName.Text;
            string region = txtRegion.Text;
            string address = txtAddress.Text;

            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToInt32(dgvHotel.Rows[hotelIndex].Cells["HotelID"].Value) != Convert.ToInt32(txtHotelID.Text))
                {
                    MessageBox.Show("The HotelID should not be changed.");
                    txtHotelID.Text = Convert.ToString(dgvHotel.Rows[hotelIndex].Cells["HotelID"].Value);
                    id = Convert.ToInt32(dgvHotel.Rows[hotelIndex].Cells["HotelID"].Value);
                }
                string Hotel_chi_name = (chineseName != "") ? chineseName : null;
                string Hotel_en_name = (englishName != "") ? englishName : null;
                decimal Star = (star != -999) ? (decimal)star : (decimal)0.0;
                decimal Rating = (rating != -999) ? (decimal)rating : (decimal)0.0;
                string Region = (region != "") ? region : null;
                string Address = (address != "") ? address : null;
                string Tel = (tel != 0) ? tel.ToString() : null;

                DialogResult result = MessageBox.Show("HotelID:   " + id +
                                                        "\n\nChineseName:\n" + Hotel_chi_name +
                                                        "\n\nEnglishName:\n" + Hotel_en_name +
                                                        "\n\nStar:\n" + Star +
                                                        "\n\nRating:\n" + Rating +
                                                        "\n\nRegion:\n" + Region +
                                                        "\n\nAddress:\n" + Address +
                                                        "\n\nTel:\n" + Tel, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var hotel = (from list in dbContext.hotel
                                 where list.HotelID == id
                                 select list).FirstOrDefault();
                    hotel.Hotel_chi_name = Hotel_chi_name;
                    hotel.Hotel_en_name = Hotel_en_name;
                    hotel.Star = Star;
                    hotel.Rating = Rating;
                    hotel.Region = Region;
                    hotel.Address = Address;
                    hotel.Tel = Tel;
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadHotel();
                }
            }
        }

        private void btnHotelDelete_Click(object sender, EventArgs e)
        {
            if (dgvHotel.Rows[hotelIndex] != null)
            {
                int id = Convert.ToInt32(dgvHotel.Rows[hotelIndex].Cells["HotelID"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "HotelNo:  " + dgvHotel.Rows[hotelIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem = (from list in dbContext.hotel
                                          where list.HotelID == id
                                          select list).FirstOrDefault();
                        dbContext.hotel.Remove(deleteItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadHotel();
                    }
                }
            }
        }

        /* #################### - - - - - - - - - - HOTEL ROOM - - - - - - - - - - #################### */

        private void dgvHotelRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomIndex = e.RowIndex;
            txtHotelRoomID.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[0].Value);
            txtHotelRoomName.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[2].Value);
            txtRoomSize.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[3].Value);
            nudMaxAdult.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[4].Value);
            nudMaxChild.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[5].Value);
            txtDescription.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[6].Value);
            txtFare.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells[7].Value);
            cmbHotel.SelectedIndex = Convert.ToInt32(dgvHotelRoom.Rows[roomIndex].Cells[8].Value) - 1;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var hotel = (from l in dbContext.hotel
                             where l.HotelID == cmbHotel.SelectedIndex + 1
                             select l).FirstOrDefault();

                cmbHotel.SelectedIndex = hotel.HotelID - 1;
                txtHotelName.Text = hotel.Hotel_chi_name;
            }

            if (dgvHotelRoom.Rows[roomIndex].Cells[0].Value != null)
            {
                btnHotelRoomUpdate.Enabled = true;
                btnHotelRoomDelete.Enabled = true;
            }
            else
            {
                btnHotelRoomUpdate.Enabled = false;
                btnHotelRoomDelete.Enabled = false;
            }
        }

        private void btnHotelRoomInsert_Click(object sender, EventArgs e)
        {
            int roomid = -999;
            double fare = -999;
            Boolean parseIdInt = Int32.TryParse(txtHotelRoomID.Text, out roomid);
            Boolean parseFareDouble = Double.TryParse(txtFare.Text, out fare);

            if (roomid == -999)
            {
                MessageBox.Show("Please input an integer in Hotel Room ID box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (fare < 0 || fare == -999)
            {
                MessageBox.Show("Please input a valid number in Fare box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hotelName = txtHotelName.Text;
            string roomName = txtHotelRoomName.Text;
            string size = txtRoomSize.Text;
            int maxAdult = (int)nudMaxAdult.Value;
            int maxChild = (int)nudMaxChild.Value;
            string description = txtDescription.Text;

            using (var dbContext = new tickettailor_dbEntities())
            {
                var list = from l in dbContext.hotel_room
                           select l;
                foreach (var hotelRoom in list)
                {
                    if (roomid == hotelRoom.Hotel_roomID)
                    {
                        MessageBox.Show("The Hotel Room ID is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                hotel_room newHotelRoom = new hotel_room();

                newHotelRoom.Hotel_roomID = roomid;
                newHotelRoom.Hotel_room_name = (roomName != "") ? roomName : null;
                newHotelRoom.Hotel_room_size = (size != "") ? size : null;
                newHotelRoom.Max_adult = maxAdult;
                newHotelRoom.Max_child = maxChild;
                newHotelRoom.Hotel_room_description = (description != "") ? description : null;
                newHotelRoom.Fare = (fare != -999) ? (decimal)fare : (decimal)0.0;
                var hotel = (from l in dbContext.hotel
                             where l.HotelID == (int)cmbHotel.SelectedItem
                             select l).FirstOrDefault();
                newHotelRoom.HotelID = hotel.HotelID;
                newHotelRoom.Hotel_chi_name = hotel.Hotel_chi_name;

                DialogResult result = MessageBox.Show("Hotel Room ID:   " + newHotelRoom.Hotel_roomID +
                                                        "\n\nChineseName:\n" + newHotelRoom.Hotel_chi_name +
                                                        "\n\nRoomName:\n" + newHotelRoom.Hotel_room_name +
                                                        "\n\nRoomSize:\n" + newHotelRoom.Hotel_room_size +
                                                        "\n\nMax Adult:\n" + newHotelRoom.Max_adult +
                                                        "\n\nMax Child:\n" + newHotelRoom.Max_child +
                                                        "\n\nDescription:\n" + newHotelRoom.Hotel_room_description +
                                                        "\n\nFare:\n" + newHotelRoom.Fare +
                                                        "\n\nHotelID:\n" + newHotelRoom.HotelID, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.hotel_room.Add(newHotelRoom);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadHotelRoom();
                }
            }
        }

        private void btnHotelRoomUpdate_Click(object sender, EventArgs e)
        {
            int roomid = -999;
            double fare = -999;
            Boolean parseIdInt = Int32.TryParse(txtHotelRoomID.Text, out roomid);
            Boolean parseFareDouble = Double.TryParse(txtFare.Text, out fare);

            if (roomid == -999)
            {
                MessageBox.Show("Please input an integer in Hotel Room ID box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (fare < 0 || fare == -999)
            {
                MessageBox.Show("Please input a valid number in Fare box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToInt32(dgvHotelRoom.Rows[roomIndex].Cells["Hotel_room_ID"].Value) != Convert.ToInt32(txtHotelRoomID.Text))
                {
                    MessageBox.Show("The HotelRoomID should not be changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHotelRoomID.Text = Convert.ToString(dgvHotelRoom.Rows[roomIndex].Cells["Hotel_room_ID"].Value);
                    roomid = Convert.ToInt32(dgvHotelRoom.Rows[roomIndex].Cells["Hotel_room_ID"].Value);
                }
                var l = (from list in dbContext.hotel_room
                         where list.Hotel_roomID == roomid
                         select list).FirstOrDefault();
                if (l.HotelID != Convert.ToInt32(cmbHotel.SelectedItem))
                {
                    MessageBox.Show("The HotelID is not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbHotel.SelectedIndex = (int)l.HotelID - 1;
                }

                string Hotel_chi_name = (txtHotelName.Text != "") ? txtHotelName.Text : null;
                string Hotel_room_name = (txtHotelRoomName.Text != "") ? txtHotelRoomName.Text : null;
                string Hotel_room_size = (txtRoomSize.Text != "") ? txtRoomSize.Text : null;
                int Max_adult = (int)nudMaxAdult.Value;
                int Max_child = (int)nudMaxChild.Value;
                string Hotel_room_description = (txtDescription.Text != "") ? txtDescription.Text : null;
                decimal Fare = (fare != -999) ? (decimal)fare : (decimal)0.0;
                int HotelID = (int)cmbHotel.SelectedItem;

                DialogResult result = MessageBox.Show("Hotel Room ID:   " + roomid +
                                                        "\n\nChineseName:\n" + Hotel_chi_name +
                                                        "\n\nRoomName:\n" + Hotel_room_name +
                                                        "\n\nRoomSize:\n" + Hotel_room_size +
                                                        "\n\nMax Adult:\n" + Max_adult +
                                                        "\n\nMax Child:\n" + Max_child +
                                                        "\n\nDescription:\n" + Hotel_room_description +
                                                        "\n\nFare:\n" + Fare +
                                                        "\n\nHotelID:\n" + HotelID, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var hotelRoom = (from list in dbContext.hotel_room
                                     where list.Hotel_roomID == roomid
                                     select list).FirstOrDefault();
                    hotelRoom.Hotel_chi_name = Hotel_chi_name;
                    hotelRoom.Hotel_room_name = Hotel_room_name;
                    hotelRoom.Hotel_room_size = Hotel_room_size;
                    hotelRoom.Max_adult = Max_adult;
                    hotelRoom.Max_child = Max_child;
                    hotelRoom.Hotel_room_description = Hotel_room_description;
                    hotelRoom.Fare = Fare;
                    hotelRoom.HotelID = HotelID;
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadHotelRoom();
                }
            }
        }

        private void btnHotelRoomDelete_Click(object sender, EventArgs e)
        {
            if (dgvHotelRoom.Rows[roomIndex] != null)
            {
                int roomid = Convert.ToInt32(dgvHotelRoom.Rows[roomIndex].Cells["Hotel_room_ID"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "HotelRoomID:  " + dgvHotelRoom.Rows[roomIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem = (from list in dbContext.hotel_room
                                          where list.Hotel_roomID == roomid
                                          select list).FirstOrDefault();
                        dbContext.hotel_room.Remove(deleteItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadHotelRoom();
                    }
                }
            }
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var dbContent = new tickettailor_dbEntities())
            {
                var hotel = (from l in dbContent.hotel
                             where l.HotelID == cmbHotel.SelectedIndex + 1
                             select l).FirstOrDefault();
                txtHotelName.Text = hotel.Hotel_chi_name;
            }
        }

        /* #################### - - - - - - - - - - CRUISE - - - - - - - - - - #################### */

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.ShowDialog();
            if (ofd.CheckFileExists == true)
            {
                if (Path.GetExtension(ofd.FileName) == ".pdf")
                {
                    string[] FName;
                    FName = ofd.FileName.Split('\\');
                    txtInfo.Text = FName[FName.Length - 1];
                }
                else
                {
                    MessageBox.Show("Please select a pdf file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvCruise_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cruiseIndex = e.RowIndex;
            txtCruiseNo.Text = Convert.ToString(dgvCruise.Rows[cruiseIndex].Cells[0].Value);
            txtCruiseName.Text = Convert.ToString(dgvCruise.Rows[cruiseIndex].Cells[1].Value);
            txtPrice.Text = Convert.ToString(dgvCruise.Rows[cruiseIndex].Cells[2].Value);
            numDayC.Text = Convert.ToString(dgvCruise.Rows[cruiseIndex].Cells[3].Value);
            comBoxOrganC.Text = (dgvCruise.Rows[cruiseIndex].Cells[4].Value != null) ? Convert.ToString(dgvCruise.Rows[e.RowIndex].Cells[4].Value) : null;
            txtInfo.Text = "";
            dateTimePickerC.Text = Convert.ToString(dgvCruise.Rows[cruiseIndex].Cells[6].Value);

            if (dgvCruise.Rows[cruiseIndex].Cells[0].Value != null)
            {
                btnCruiseUpdate.Enabled = true;
                btnCruiseDelete.Enabled = true;
            }
            else
            {
                btnCruiseUpdate.Enabled = false;
                btnCruiseDelete.Enabled = false;
            }
        }

        private void addCruise(string cruiseNo, string cruiseName, double price, int tourDay, int organizer, string info, string startDate)
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                var cruise = from list in dbContext.cruise
                             select list;
                foreach (var cru in cruise)
                {
                    if (cruiseNo == cru.CruiseNo)
                    {
                        MessageBox.Show("The CruiseNo is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                cruise newCruise = new cruise();

                newCruise.CruiseNo = cruiseNo.ToUpper();
                newCruise.CruiseName = (cruiseName != "") ? cruiseName : null;
                newCruise.RefPrice = Convert.ToDecimal(price);
                newCruise.TourDay = tourDay;
                newCruise.OrganID = organizer;
                if (info != "")
                {
                    if (info == cruiseNo.ToUpper())
                        newCruise.Info = info;
                    else
                    {
                        MessageBox.Show("Due to the different names between CruiseNo and Info, the name of the Info will change the same as the CruiseNo automaticaly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        newCruise.Info = cruiseNo.ToUpper() + ".pdf";
                    }
                }
                else
                {
                    newCruise.Info = null;
                }
                newCruise.StartDate = Convert.ToDateTime(startDate);
                DialogResult result = MessageBox.Show("CruiseNo:   " + newCruise.CruiseNo +
                                                        "\n\nCruiseName:\n" + newCruise.CruiseName +
                                                        "\n\nRefPrice:             " + newCruise.RefPrice +
                                                        "\nTourDay:            " + newCruise.TourDay +
                                                        "\nOrganizer:         " + newCruise.OrganID +
                                                        "\nInfo:                     " + newCruise.Info +
                                                        "\nStartDate:          " + newCruise.StartDate, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.cruise.Add(newCruise);
                    dbContext.SaveChanges();
                    if (newCruise.Info != null)
                        File.Copy(ofd.FileName, "..\\CruiseInfo\\" + newCruise.Info);
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCruise();
                }
            }
        }

        private void modCruise(string cruiseNo, string cruiseName, double price, int tourDay, int organizer, string info, string startDate)
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                var cruise = (from list in dbContext.cruise
                              where list.CruiseNo == cruiseNo
                              select list).FirstOrDefault();

                if (cruiseNo != txtCruiseNo.Text)
                {
                    MessageBox.Show("The CruiseNo should not be changed.");
                    txtCruiseNo.Text = cruise.CruiseNo;
                }
                DialogResult result = MessageBox.Show("CruiseNo:  " + txtCruiseNo.Text +
                                                    "\n\nCruiseName:\n" + cruiseName +
                                                    "\n\nRefPrice:             " + price +
                                                    "\nTourDay:            " + tourDay +
                                                    "\nOrganizer:         " + comBoxOrganC.Text +
                                                    "\nInfo:                     " + info +
                                                    "\nStartDate:          " + startDate, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    cruise.CruiseName = cruiseName;
                    cruise.RefPrice = Convert.ToDecimal(price);
                    cruise.TourDay = tourDay;
                    cruise.OrganID = organizer;
                    if (info != "")
                    {
                        if (info == cruiseNo.ToUpper())
                            cruise.Info = info;
                        else
                        {
                            MessageBox.Show("Due to the different names between CruiseNo and Info, the name of the Info will change the same as the CruiseNo automaticaly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cruise.Info = cruiseNo.ToUpper() + ".pdf";
                            info = cruiseNo.ToUpper() + ".pdf";
                        }
                    }
                    cruise.StartDate = Convert.ToDateTime(startDate);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCruise();
                }
            }
        }

        private void deleteCruise(string cruiseNo)
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                var deleteItem = (from list in dbContext.cruise
                                  where list.CruiseNo == cruiseNo
                                  select list).FirstOrDefault();
                dbContext.cruise.Remove(deleteItem);
                dbContext.SaveChanges();
                MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCruise();
            }
        }

        private string checkFormat(string item, string format)
        {
            if (item.Length != format.Length)
                return "";

            item = item.ToUpper();
            for (int i = 0; i < item.Length; i++)
            {
                switch (format.Substring(i, 1))
                {
                    case "$":
                        if (item.Substring(i, 1).CompareTo("0") < 0 || item.Substring(i, 1).CompareTo("9") > 0)
                            return "";
                        break;
                    case "@":
                        if (item.Substring(i, 1).CompareTo("A") < 0 || item.Substring(i, 1).CompareTo("Z") > 0)
                            return "";
                        break;
                }
            }
            return item;
        }

        private void btnCruiseInsert_Click(object sender, EventArgs e)
        {
            string cruiseNo;
            string cruiseName;
            double price;
            int tourDay;
            int organizer;
            string info;
            string startDate;
            //Check data format: $ is numeric, @ is letter
            if (checkFormat(txtCruiseNo.Text, "@@@$$@") != "")
                cruiseNo = checkFormat(txtCruiseNo.Text, "@@@$$@");
            else
            {
                MessageBox.Show("The CruiseNo is not valid. (e.g. AAA11A)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cruiseName = txtCruiseName.Text;
            try
            {
                price = Convert.ToDouble(txtPrice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The Price is not valid, please input number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tourDay = Convert.ToInt32(numDayC.Text);
            if (comBoxOrganC.SelectedIndex >= 0)
                organizer = comBoxOrganC.SelectedIndex + 1;
            else
            {
                MessageBox.Show("Please select an organizer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            info = txtInfo.Text;
            startDate = dateTimePickerC.Text;
            addCruise(cruiseNo, cruiseName, price, tourDay, organizer, info, startDate);
        }

        private void btnCruiseUpdate_Click(object sender, EventArgs e)
        {
            string cruiseNo;
            string cruiseName;
            double price;
            int tourDay;
            int organizer;
            string info;
            string startDate;

            cruiseNo = dgvCruise.Rows[cruiseIndex].Cells[0].Value.ToString().ToUpper();
            cruiseName = txtCruiseName.Text;
            try
            {
                price = Convert.ToDouble(txtPrice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The Price is not valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tourDay = Convert.ToInt32(numDayC.Text);
            organizer = comBoxOrganC.SelectedIndex + 1;
            info = txtInfo.Text;
            startDate = dateTimePickerC.Text;

            modCruise(cruiseNo, cruiseName, price, tourDay, organizer, info, startDate);
        }

        private void btnCruiseDelete_Click(object sender, EventArgs e)
        {
            if (dgvCruise.Rows[cruiseIndex] != null)
            {
                string cruiseNo = dgvCruise.Rows[cruiseIndex].Cells["CruiseNo"].Value.ToString();
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "CruiseNo:  " + dgvCruise.Rows[cruiseIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    deleteCruise(cruiseNo);
                    loadCruise();
                }
            }
        }

        /* #################### - - - - - - - - - - ORGAN - - - - - - - - - - #################### */

        private void dgvOrgan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            organIndex = e.RowIndex;
            txtOrganID.Text = Convert.ToString(dgvOrgan.Rows[organIndex].Cells[0].Value);
            txtOrganEng.Text = Convert.ToString(dgvOrgan.Rows[organIndex].Cells[1].Value);
            txtOrganChi.Text = Convert.ToString(dgvOrgan.Rows[organIndex].Cells[2].Value);

            if (dgvOrgan.Rows[organIndex].Cells[0].Value != null)
            {
                btnOrganUpdate.Enabled = true;
                btnOrganDelete.Enabled = true;
            }
            else
            {
                btnOrganUpdate.Enabled = false;
                btnOrganDelete.Enabled = false;
            }
        }

        private void btnOrganInsert_Click(object sender, EventArgs e)
        {
            int id = -999;
            Boolean parseInt = Int32.TryParse(txtOrganID.Text, out id);
            if (id == -999)
            {
                MessageBox.Show("Please input an integer in OrganID box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ChineseName = txtOrganChi.Text;
            string EnglishName = txtOrganEng.Text;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var corganizer = from list in dbContext.corganizer
                                 select list;
                foreach (var c in corganizer)
                {
                    if (id == c.OrganID)
                    {
                        MessageBox.Show("The OrganID is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                corganizer newCorganizer = new corganizer();

                newCorganizer.OrganID = id;
                newCorganizer.OrganizerC = (ChineseName != "") ? ChineseName : null;
                newCorganizer.OrganizerE = (EnglishName != "") ? EnglishName : null;
                DialogResult result = MessageBox.Show("OrganID:   " + newCorganizer.OrganID +
                                                        "\n\nChineseName:\n" + newCorganizer.OrganizerC +
                                                        "\n\nEnglishName:\n" + newCorganizer.OrganizerE, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.corganizer.Add(newCorganizer);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadOrgan();
                }
            }
        }

        private void btnOrganUpdate_Click(object sender, EventArgs e)
        {
            int id = -999;
            Boolean parseInt = Int32.TryParse(txtOrganID.Text, out id);
            if (id == -999)
            {
                MessageBox.Show("Please input an integer in OrganID box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToInt32(dgvOrgan.Rows[organIndex].Cells["OrganID"].Value) != Convert.ToInt32(txtOrganID.Text))
                {
                    MessageBox.Show("The OrganID should not be changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOrganID.Text = Convert.ToString(dgvOrgan.Rows[organIndex].Cells["OrganID"].Value);
                    id = Convert.ToInt32(dgvOrgan.Rows[organIndex].Cells["OrganID"].Value);
                }

                string ChineseName = (txtOrganChi.Text != "") ? txtOrganChi.Text : null;
                string EnglishName = (txtOrganEng.Text != "") ? txtOrganEng.Text : null;

                DialogResult result = MessageBox.Show("OrganID:  " + txtOrganID.Text +
                                                    "\n\nChineseName:\n" + ChineseName +
                                                    "\n\nEnglishName:\n" + EnglishName, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var corganizer = (from list in dbContext.corganizer
                                      where list.OrganID == id
                                      select list).FirstOrDefault();

                    corganizer.OrganizerC = ChineseName;
                    corganizer.OrganizerE = EnglishName;
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadOrgan();
                }
            }
        }

        private void btnOrganDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrgan.Rows[organIndex] != null)
            {
                int id = Convert.ToInt32(dgvOrgan.Rows[organIndex].Cells["OrganID"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "OrganID:  " + dgvOrgan.Rows[organIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem = (from list in dbContext.corganizer
                                          where list.OrganID == id
                                          select list).FirstOrDefault();
                        dbContext.corganizer.Remove(deleteItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadOrgan();
                    }
                }
            }
        }

        /* #################### - - - - - - - - - - ATTRACTION - - - - - - - - - - #################### */
        private void dgvAttraction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            attrIndex = e.RowIndex;
            txtAttractionName.Text = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells[0].Value);
            txtDuration.Text = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells[1].Value);
            txtCancellation.Text = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells[2].Value);
            txtCity.Text = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells[4].Value);
            using (var dbContext = new tickettailor_dbEntities())
            {
                var attractionAdultprice = (from list in dbContext.attractionprice
                                            where list.AttractName.Contains(txtAttractionName.Text) && list.Visitor.Contains("Adult")
                                            select list).FirstOrDefault();
                var attractionChildprice = (from list in dbContext.attractionprice
                                            where list.AttractName.Contains(txtAttractionName.Text) && list.Visitor.Contains("Child")
                                            select list).FirstOrDefault();
                txtAdultPrice.Text = Convert.ToString(attractionAdultprice.Price);
                txtChildPrice.Text = Convert.ToString(attractionChildprice.Price);
            }

            if (dgvAttraction.Rows[attrIndex].Cells[0].Value != null)
            {
                btnAttractionUpdate.Enabled = true;
                btnAttractionDelete.Enabled = true;
                btnUploadImage.Enabled = true;
            }
            else
            {
                btnAttractionUpdate.Enabled = false;
                btnAttractionDelete.Enabled = false;
                btnUploadImage.Enabled = false;
            }
        }

        private void btnAttractionInsert_Click(object sender, EventArgs e)
        {
            string name = txtAttractionName.Text;
            string duration = txtDuration.Text;
            string cancellation = txtCancellation.Text;
            string city = txtCity.Text;
            int adultPrice = -999;
            int childPrice = -999;
            Boolean parseadultPrice = Int32.TryParse(txtAdultPrice.Text, out adultPrice);
            Boolean parsechildPrice = Int32.TryParse(txtChildPrice.Text, out childPrice);
            using (var dbContext = new tickettailor_dbEntities())
            {
                var attraction = from list in dbContext.attraction
                                 select list;
                foreach (var a in attraction)
                {
                    if (name == a.AttractName)
                    {
                        MessageBox.Show("The Attraction Name is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (name == "")
                    {
                        MessageBox.Show("Please input the attraction name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                attraction newAttraction = new attraction();
                attractionprice newAttractionPrice1 = new attractionprice();
                attractionprice newAttractionPrice2 = new attractionprice();

                newAttraction.AttractName = name;
                newAttraction.Duration = (duration != "") ? duration : null;
                newAttraction.Cancellation = (cancellation != "") ? cancellation : null;
                newAttraction.City = (city != "") ? city : null;
                newAttractionPrice1.AttractName = name;
                newAttractionPrice1.Visitor = "Adult";
                newAttractionPrice1.Price = (adultPrice != -999) ? adultPrice : 0;
                newAttractionPrice2.AttractName = name;
                newAttractionPrice2.Visitor = "Child";
                newAttractionPrice2.Price = (childPrice != -999) ? childPrice : 0;

                DialogResult result = MessageBox.Show("Attraction Name:   " + newAttraction.AttractName +
                                                        "\n\nDuration:\n" + newAttraction.Duration +
                                                        "\n\nCancellation:\n" + newAttraction.Cancellation +
                                                        "\n\nCity:\n" + newAttraction.City +
                                                        "\n\nAdult Price:\n" + newAttractionPrice1.Price +
                                                        "\n\nChild Price:\n" + newAttractionPrice2.Price, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.attraction.Add(newAttraction);
                    dbContext.attractionprice.Add(newAttractionPrice1);
                    dbContext.attractionprice.Add(newAttractionPrice2);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAttraction();
                }
            }
        }

        private void btnAttractionUpdate_Click(object sender, EventArgs e)
        {
            string name = txtAttractionName.Text;
            string duration = (txtDuration.Text != "") ? txtDuration.Text : null;
            string cancellation = (txtCancellation.Text != "") ? txtCancellation.Text : null;
            string city = (txtCity.Text != "") ? txtCity.Text : null;
            int adultPrice = -999;
            int childPrice = -999;
            Boolean parseadultPrice = Int32.TryParse(txtAdultPrice.Text, out adultPrice);
            Boolean parsechildPrice = Int32.TryParse(txtChildPrice.Text, out childPrice);

            if (adultPrice == -999 || childPrice == -999)
            {
                MessageBox.Show("Please input a valid price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToString(dgvAttraction.Rows[attrIndex].Cells["AttractName"].Value) != txtAttractionName.Text)
                {
                    MessageBox.Show("The Attraction Name should not be changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAttractionName.Text = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells["AttractName"].Value);
                    name = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells["AttractName"].Value);
                }

                DialogResult result = MessageBox.Show("Attraction Name:   " + name +
                                                        "\n\nDuration:\n" + duration +
                                                        "\n\nCancellation:\n" + cancellation +
                                                        "\n\nCity:\n" + city +
                                                        "\n\nAdult Price:\n" + adultPrice +
                                                        "\n\nChild Price:\n" + childPrice, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var attraction = (from list in dbContext.attraction
                                      where list.AttractName.Contains(name)
                                      select list).FirstOrDefault();
                    var attractionAdultprice = (from list in dbContext.attractionprice
                                                where list.AttractName.Contains(name) && list.Visitor.Contains("Adult")
                                                select list).FirstOrDefault();
                    var attractionChildprice = (from list in dbContext.attractionprice
                                                where list.AttractName.Contains(name) && list.Visitor.Contains("Child")
                                                select list).FirstOrDefault();

                    attraction.Duration = duration;
                    attraction.Cancellation = cancellation;
                    attraction.City = city;
                    attractionAdultprice.Price = adultPrice;
                    attractionChildprice.Price = childPrice;
                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAttraction();
                }
            }
        }

        private void btnAttractionDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttraction.Rows[attrIndex] != null)
            {
                string name = Convert.ToString(dgvAttraction.Rows[attrIndex].Cells["AttractName"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "Attraction Name:  " + dgvAttraction.Rows[attrIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem1 = (from list in dbContext.attraction
                                           where list.AttractName.Contains(name)
                                           select list).FirstOrDefault();
                        var deleteItem2 = from list in dbContext.attractionprice
                                          where list.AttractName.Contains(name)
                                          select list;
                        dbContext.attraction.Remove(deleteItem1);
                        foreach (var item in deleteItem2.ToList())
                        {
                            dbContext.attractionprice.Remove(item);
                        }
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadAttraction();
                    }
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = false;
            openFD.ShowDialog();
            if (openFD.CheckFileExists == true)
            {
                if (Path.GetExtension(openFD.FileName) == ".png" || Path.GetExtension(openFD.FileName) == ".jpg")
                {
                    string[] Name;
                    Name = openFD.FileName.Split('\\');
                    DataGridViewCell cell = null;

                    foreach (DataGridViewCell selectedCell in dgvAttraction.SelectedCells)
                    {
                        cell = selectedCell;
                        break;
                    }
                    DataGridViewRow row = cell.OwningRow;
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        string name = Convert.ToString(row.Cells[0].Value);
                        var attraction = (from list in dbContext.attraction
                                          where list.AttractName.Contains(name)
                                          select list).FirstOrDefault();
                        attraction.AttractPhoto = Name[Name.Length - 1];
                        dbContext.SaveChanges();
                        MessageBox.Show("The image upload success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadAttraction();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a png or jpg file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /* #################### - - - - - - - - - - VEHICLE - - - - - - - - - - #################### */

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicleIndex = e.RowIndex;
            txtVehicleID.Text = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells[0].Value);
            txtVehicleName.Text = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells[1].Value);
            txtVehiclePrice.Text = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells[2].Value);
            cmbVehicleType.SelectedItem = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells[3].Value);
            nudCapacity.Value = Convert.ToInt32(dgvVehicle.Rows[vehicleIndex].Cells[4].Value);
            cmbGear.SelectedItem = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells[5].Value);
            txtColor.Text = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells[6].Value);


            if (dgvVehicle.Rows[vehicleIndex].Cells[0].Value != null)
            {
                btnVehicleUpdate.Enabled = true;
                btnVehicleDelete.Enabled = true;
                btnVehicleUpload.Enabled = true;
            }
            else
            {
                btnVehicleUpdate.Enabled = false;
                btnVehicleDelete.Enabled = false;
                btnVehicleUpload.Enabled = false;
            }
        }

        private void btnVehicleUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = false;
            openFD.ShowDialog();
            if (openFD.CheckFileExists == true)
            {
                if (Path.GetExtension(openFD.FileName) == ".png" || Path.GetExtension(openFD.FileName) == ".jpg")
                {
                    string[] Name;
                    Name = openFD.FileName.Split('\\');
                    DataGridViewCell cell = null;

                    foreach (DataGridViewCell selectedCell in dgvVehicle.SelectedCells)
                    {
                        cell = selectedCell;
                        break;
                    }
                    DataGridViewRow row = cell.OwningRow;
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        string id = Convert.ToString(row.Cells[0].Value);
                        var vehicle = (from list in dbContext.vehicle
                                       where list.VehicleID.Contains(id)
                                       select list).FirstOrDefault();
                        vehicle.VehiclePhoto = id + Path.GetExtension(openFD.FileName);
                        dbContext.SaveChanges();
                        MessageBox.Show("The image upload success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadVehicle();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a png or jpg file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnVehicleInsert_Click(object sender, EventArgs e)
        {
            string id = txtVehicleID.Text;
            string name = txtVehicleName.Text;
            double price = -999;
            string type = Convert.ToString(cmbVehicleType.SelectedItem);
            int capacity = (int)nudCapacity.Value;
            string gear = Convert.ToString(cmbGear.SelectedItem);
            string color = txtColor.Text;
            Boolean parsePrice = Double.TryParse(txtVehiclePrice.Text, out price);

            using (var dbContext = new tickettailor_dbEntities())
            {
                var vehicle = from list in dbContext.vehicle
                              select list;

                foreach (var v in vehicle)
                {
                    if (id == v.VehicleID)
                    {
                        MessageBox.Show("The Vehicle ID is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (id.Count() != 5 || !(id.Substring(0, 3).Contains("car")))
                    {
                        MessageBox.Show("Please follow the format ( car01 - car99 ).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (id == "")
                    {
                        MessageBox.Show("Please input the vehicle ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (name == "")
                    {
                        MessageBox.Show("Please input the vehicle Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (price < 0 || price == -999)
                    {
                        MessageBox.Show("Please input a valid number in Price box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                vehicle newVehicle = new vehicle();

                newVehicle.VehicleID = id;
                newVehicle.VehicleName = name;
                newVehicle.Price = (price != -999) ? (decimal)price : (decimal)0.0;
                newVehicle.VehicleType = (type != null) ? type : null;
                newVehicle.Capacity = capacity;
                newVehicle.Gear = (gear != null) ? gear : null;
                newVehicle.Color = (color != "") ? color : null;
                newVehicle.VehiclePhoto = null;

                DialogResult result = MessageBox.Show("Vehicle ID:   " + newVehicle.VehicleID +
                                                        "\n\nVehicleName:\n" + newVehicle.VehicleName +
                                                        "\n\nPrice:\n" + newVehicle.Price +
                                                        "\n\nVehicleType:\n" + newVehicle.VehicleType +
                                                        "\n\nCapacity:\n" + newVehicle.Capacity +
                                                        "\n\nGear:\n" + newVehicle.Gear +
                                                        "\n\nColor:\n" + newVehicle.Color, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.vehicle.Add(newVehicle);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadVehicle();
                }
            }
        }

        private void btnVehicleUpdate_Click(object sender, EventArgs e)
        {
            string id = txtVehicleID.Text;
            string name = txtVehicleName.Text;
            double price = -999;
            string type = Convert.ToString(cmbVehicleType.SelectedItem);
            int capacity = (int)nudCapacity.Value;
            string gear = Convert.ToString(cmbGear.SelectedItem);
            string color = txtColor.Text;
            Boolean parsePrice = Double.TryParse(txtVehiclePrice.Text, out price);

            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells["VehicleID"].Value) != txtVehicleID.Text)
                {
                    MessageBox.Show("The Vehicle ID should not be changed.");
                    txtVehicleID.Text = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells["VehicleID"].Value);
                    id = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells["VehicleID"].Value);
                }
                else if (name == "")
                {
                    MessageBox.Show("Please input the vehicle Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (price < 0 || price == -999)
                {
                    MessageBox.Show("Please input a valid number in Price box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Vehicle ID:   " + id +
                                                        "\n\nVehicleName:\n" + name +
                                                        "\n\nPrice:\n" + price +
                                                        "\n\nVehicleType:\n" + type +
                                                        "\n\nCapacity:\n" + capacity +
                                                        "\n\nGear:\n" + gear +
                                                        "\n\nColor:\n" + color, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var vehicle = (from list in dbContext.vehicle
                                   where list.VehicleID.Contains(id)
                                   select list).FirstOrDefault();

                    vehicle.VehicleName = name;
                    vehicle.Price = (price != -999) ? (decimal)price : (decimal)0.0;
                    vehicle.VehicleType = (type != null) ? type : null;
                    vehicle.Capacity = capacity;
                    vehicle.Gear = (gear != null) ? gear : null;
                    vehicle.Color = (color != "") ? color : null;

                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadVehicle();
                }
            }
        }

        private void btnVehicleDelete_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.Rows[vehicleIndex] != null)
            {
                string id = Convert.ToString(dgvVehicle.Rows[vehicleIndex].Cells["VehicleID"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "Vehicle ID:  " + dgvVehicle.Rows[vehicleIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem = (from list in dbContext.vehicle
                                          where list.VehicleID.Contains(id)
                                          select list).FirstOrDefault();

                        dbContext.vehicle.Remove(deleteItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadVehicle();
                    }
                }
            }
        }

        /* #################### - - - - - - - - - - EQUIPMENT - - - - - - - - - - #################### */
        private void dgvEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            equipIndex = e.RowIndex;
            txtEquipID.Text = Convert.ToString(dgvEquip.Rows[equipIndex].Cells[0].Value);
            txtEquipName.Text = Convert.ToString(dgvEquip.Rows[equipIndex].Cells[1].Value);
            cmbSuitable.SelectedItem = Convert.ToString(dgvEquip.Rows[equipIndex].Cells[2].Value);
            txtEquipPrice.Text = Convert.ToString(dgvEquip.Rows[equipIndex].Cells[3].Value);


            if (dgvEquip.Rows[equipIndex].Cells[0].Value != null)
            {
                btnEquipUpdate.Enabled = true;
                btnEquipDelete.Enabled = true;
                btnEquipUpload.Enabled = true;
            }
            else
            {
                btnEquipUpdate.Enabled = false;
                btnEquipDelete.Enabled = false;
                btnEquipUpload.Enabled = false;
            }
        }

        private void btnEquipUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = false;
            openFD.ShowDialog();
            if (openFD.CheckFileExists == true)
            {
                if (Path.GetExtension(openFD.FileName) == ".png" || Path.GetExtension(openFD.FileName) == ".jpg")
                {
                    string[] Name;
                    Name = openFD.FileName.Split('\\');
                    DataGridViewCell cell = null;

                    foreach (DataGridViewCell selectedCell in dgvEquip.SelectedCells)
                    {
                        cell = selectedCell;
                        break;
                    }
                    DataGridViewRow row = cell.OwningRow;
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        string id = Convert.ToString(row.Cells[0].Value);
                        var vehicle = (from list in dbContext.equipment
                                       where list.EquipID.Contains(id)
                                       select list).FirstOrDefault();
                        vehicle.EquipPhoto = id + Path.GetExtension(openFD.FileName);
                        dbContext.SaveChanges();
                        MessageBox.Show("The image upload success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadEquipment();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a png or jpg file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEquipInsert_Click(object sender, EventArgs e)
        {
            string id = txtEquipID.Text;
            string name = txtEquipName.Text;
            string suitable = Convert.ToString(cmbSuitable.SelectedItem);
            double price = -999;
            Boolean parsePrice = Double.TryParse(txtEquipPrice.Text, out price);

            using (var dbContext = new tickettailor_dbEntities())
            {
                var equip = from list in dbContext.equipment
                            select list;

                foreach (var eq in equip)
                {
                    if (id == eq.EquipID)
                    {
                        MessageBox.Show("The Equipment ID is existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (id.Count() != 3 || !(id.Substring(0, 1).Contains("e")))
                    {
                        MessageBox.Show("Please follow the format ( e01 - e99 ).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (id == "")
                    {
                        MessageBox.Show("Please input the equipment ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (name == "")
                    {
                        MessageBox.Show("Please input the equipment Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (price < 0 || price == -999)
                    {
                        MessageBox.Show("Please input a valid number in Price box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                equipment newEquipment = new equipment();

                newEquipment.EquipID = id;
                newEquipment.Equipment1 = name;
                newEquipment.Suitable = (suitable != null) ? suitable : null;
                newEquipment.Price = (price != -999) ? (decimal)price : (decimal)0.0;
                newEquipment.EquipPhoto = null;

                DialogResult result = MessageBox.Show("Equipment ID:   " + newEquipment.EquipID +
                                                        "\n\nEquipment Name:\n" + newEquipment.Equipment1 +
                                                        "\n\nSuitable:\n" + newEquipment.Suitable +
                                                        "\n\nPrice:\n" + newEquipment.Price, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbContext.equipment.Add(newEquipment);
                    dbContext.SaveChanges();
                    MessageBox.Show("The product insert success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEquipment();
                }
            }
        }

        private void btnEquipUpdate_Click(object sender, EventArgs e)
        {
            string id = txtEquipID.Text;
            string name = txtEquipName.Text;
            string suitable = Convert.ToString(cmbSuitable.SelectedItem);
            double price = -999;
            Boolean parsePrice = Double.TryParse(txtEquipPrice.Text, out price);

            using (var dbContext = new tickettailor_dbEntities())
            {
                if (Convert.ToString(dgvEquip.Rows[equipIndex].Cells["Equipment_ID"].Value) != txtEquipID.Text)
                {
                    MessageBox.Show("The Equipment ID should not be changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEquipID.Text = Convert.ToString(dgvEquip.Rows[equipIndex].Cells["Equipment_ID"].Value);
                    id = Convert.ToString(dgvEquip.Rows[equipIndex].Cells["Equipment_ID"].Value);
                }
                else if (name == "")
                {
                    MessageBox.Show("Please input the equipment Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (price < 0 || price == -999)
                {
                    MessageBox.Show("Please input a valid number in Price box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Equipment ID:   " + id +
                                                        "\n\nEquipment Name:\n" + name +
                                                        "\n\nSuitable:\n" + suitable +
                                                        "\n\nPrice:\n" + price, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var equipment = (from list in dbContext.equipment
                                     where list.EquipID.Contains(id)
                                     select list).FirstOrDefault();

                    equipment.Equipment1 = name;
                    equipment.Suitable = suitable;
                    equipment.Price = (price != -999) ? (decimal)price : (decimal)0.0;

                    dbContext.SaveChanges();
                    MessageBox.Show("The product update success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEquipment();
                }
            }
        }

        private void btnEquipDelete_Click(object sender, EventArgs e)
        {
            if (dgvEquip.Rows[equipIndex] != null)
            {
                string id = Convert.ToString(dgvEquip.Rows[equipIndex].Cells["Equipment_ID"].Value);
                DialogResult result = MessageBox.Show("Do you sure delete the item?\n\n" +
                                                        "Equipment ID:  " + dgvEquip.Rows[equipIndex].Cells[0].Value, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var dbContext = new tickettailor_dbEntities())
                    {
                        var deleteItem = (from list in dbContext.equipment
                                          where list.EquipID.Contains(id)
                                          select list).FirstOrDefault();

                        dbContext.equipment.Remove(deleteItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("The product delete success.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadEquipment();
                    }
                }
            }
        }
    }
}
