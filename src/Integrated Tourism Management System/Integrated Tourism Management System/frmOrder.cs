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
    public partial class frmOrder : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmCruiseTour frmCruiseTour;
        private frmCustomer frmCustomer;

        // Define variable of the value
        string id;
        int iid;
        int index;
        double[] airPrice;
        double[,] airPerson;
        double[] hotelPrice;
        DataGridViewRow flightbooking;
        DataGridViewRow hotelbooking;
        Dictionary<flightbooking, flightbooking> flightDictionary = new Dictionary<flightbooking, flightbooking>();
        Dictionary<int, hotelbooking> hotelDictionary = new Dictionary<int, hotelbooking>();

        public frmOrder(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmCruiseTour = new frmCruiseTour(frmModuleSelection);
            frmCustomer = new frmCustomer(frmModuleSelection);
    }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            // Start the beginning process
            txtNumberTag.Text = frmModuleSelection.tag;
            btnConfirm.Enabled = false;
        }

        private void initial(string tag)
        {
            using (var context = new tickettailor_dbEntities())
            {
                id = "";
                index = 0;
                dgvTicket.Rows.Clear();
                cmoClass.Items.Clear();
                txtAdultPrice.Text = "";
                txtChildPrice.Text = "";
                txtInfantPrice.Text = "";
                txtAdultTax.Text = "";
                txtChildTax.Text = "";
                txtInfantTax.Text = "";
                nudAdultPerson.Value = 1;
                nudChildPerson.Value = 0;
                nudInfantPerson.Value = 0;
                txtTicketTotal.Text = "0";
                btnTicketOk.Enabled = false;

                iid = 0;
                dgvHotel.Rows.Clear();
                txthotelRoomPrice.Text = "0";
                dtpCheckin.Value = DateTime.Now;
                dtpCheckout.Value = DateTime.Now.AddDays(1);
                txtHotelTotal.Text = "0";
                txtTotal.Text = "0";
                btnHotelOk.Enabled = false;

                if (txtNumberTag.Text != "")
                {
                    int i = 0;
                    Boolean intParse = Int32.TryParse(txtNumberTag.Text, out i);
                    if (i != 0)
                    {
                        //airticket
                        var tagAir = from list in context.tag
                                     where i == list.Tag
                                     && list.TagType.Contains("Ticket")
                                     select list;

                        foreach (var list in tagAir.ToList())
                        {
                            var flight = from l in context.flightschedule
                                         where l.FlightID == list.TagTypeID
                                         select l;

                            foreach (var l in flight.ToList())
                            {
                                int rowIndex = dgvTicket.Rows.Add(l.FlightID,
                                                                  l.FlightNo,
                                                                  l.FlightType,
                                                                  ((DateTime)l.EDA).ToString("yyyy-MM-dd"),
                                                                  ((DateTime)l.EDD).ToString("yyyy-MM-dd"),
                                                                  l.ETA,
                                                                  l.ETD,
                                                                  l.carrier1.CarrierName,
                                                                  l.Origin,
                                                                  l.Dest,
                                                                  l.Aircraft);
                                dgvTicket.Rows[rowIndex].Tag = l.FlightNo;
                            }

                        }
                        if (dgvTicket.Rows.Count != 0)
                        {
                            btnTicketOk.Enabled = true;
                            airPerson = new double[dgvTicket.RowCount, 3];
                            airPrice = new double[dgvTicket.RowCount];
                            id = dgvTicket.Rows[0].Tag.ToString();

                            var Class = (from list in context.flightclass
                                         where list.FlightNo.Contains(id)
                                         select list.Class).Distinct();
                            foreach (var c in Class.ToList())
                            {
                                cmoClass.Items.Add(c);
                            }
                            cmoClass.SelectedIndex = 0;
                            changeAirPrice();
                        }
                        else
                        {
                            btnTicketOk.Enabled = false;
                        }


                        //hotel
                        var tagHotel = from list in context.tag
                                       where i == list.Tag
                                       && list.TagType.Contains("Hotel")
                                       select list;

                        foreach (var list in tagHotel.ToList())
                        {
                            var Hotel = from l in context.hotel_room
                                        where l.Hotel_roomID == list.TagTypeID
                                        select l;
                            foreach (var l in Hotel.ToList())
                            {
                                int rowIndex = dgvHotel.Rows.Add(l.hotel.HotelID,
                                                                 l.hotel.Hotel_chi_name,
                                                                 l.hotel.Hotel_en_name,
                                                                 l.Hotel_roomID,
                                                                 l.Hotel_room_name,
                                                                 l.Hotel_room_size,
                                                                 l.Hotel_room_description,
                                                                 l.Max_adult,
                                                                 l.Max_child,
                                                                 l.Fare);
                                dgvHotel.Rows[rowIndex].Tag = l.Hotel_roomID;
                            }
                        }
                        if (dgvHotel.Rows.Count != 0)
                        {
                            btnHotelOk.Enabled = true;
                            hotelPrice = new double[dgvHotel.RowCount];
                            iid = (int)dgvHotel.Rows[0].Tag;


                            var price = (from list in context.hotel_room
                                         where list.Hotel_roomID == iid
                                         select list).FirstOrDefault();
                            txthotelRoomPrice.Text = Convert.ToString((double)price.Fare);
                            changeHotelPrice();
                        }
                        else
                        {
                            btnHotelOk.Enabled = false;
                        }

                        //discount
                        if (dgvTicket.RowCount > 0 && dgvHotel.RowCount > 0)
                            chkDiscount.Checked = true;
                        else
                            chkDiscount.Checked = false;
                    }
                }
            }
        }

        private void cmoClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new tickettailor_dbEntities())
            {
                var flightClass = (from list in context.flightclass
                                   where ((string)cmoClass.SelectedItem).Contains(list.Class)
                                   && list.FlightNo.Contains(id)
                                   select list).FirstOrDefault();

                double adultPrice = (double)flightClass.Price_Adult;
                double childPrice = (double)flightClass.Price_Children;
                double infantPrice = (double)flightClass.Price_Infant;
                txtAdultPrice.Text = Convert.ToString(adultPrice);
                txtChildPrice.Text = Convert.ToString(childPrice);
                txtInfantPrice.Text = Convert.ToString(infantPrice);
                txtAdultTax.Text = Convert.ToString(Math.Round((double)flightClass.Tax / 100 * adultPrice, 2));
                txtChildTax.Text = Convert.ToString(Math.Round((double)flightClass.Tax / 100 * childPrice, 2));
                txtInfantTax.Text = Convert.ToString(Math.Round((double)flightClass.Tax / 100 * infantPrice, 2));
            }
        }

        private void nudAdultPerson_MouseUp(object sender, MouseEventArgs e)
        {
            changeAirPrice();
        }

        private void nudChildPerson_MouseUp(object sender, MouseEventArgs e)
        {
            changeAirPrice();
        }

        private void nudInfantPerson_MouseUp(object sender, MouseEventArgs e)
        {
            changeAirPrice();
        }

        private void changeAirPrice()
        {
            if (dgvTicket.RowCount != 0)
            {
                double adultPrice = Convert.ToDouble(txtAdultPrice.Text);
                double childPrice = Convert.ToDouble(txtChildPrice.Text);
                double infantPrice = Convert.ToDouble(txtInfantPrice.Text);
                int adultPerson = Convert.ToInt32(nudAdultPerson.Value);
                int childPerson = Convert.ToInt32(nudChildPerson.Value);
                int infantPerson = Convert.ToInt32(nudInfantPerson.Value);
                double adultTax = Convert.ToDouble(txtAdultTax.Text) * adultPerson;
                double childTax = Convert.ToDouble(txtChildTax.Text) * childPerson;
                double infantTax = Convert.ToDouble(txtInfantTax.Text) * infantPerson;
                airPrice[index] = adultPrice * adultPerson + childPrice * childPerson + infantPrice * infantPerson + adultTax + childTax + infantTax;
            }
        }

        private void changeHotelPrice()
        {
            if (dgvHotel.RowCount != 0)
            {
                double HotelRoomPrice = Convert.ToDouble(txthotelRoomPrice.Text);
                int checkout = dtpCheckout.Value.DayOfYear;
                int checkin = dtpCheckin.Value.DayOfYear;
                int day = checkout - checkin;

                if (day < 1)
                {
                    MessageBox.Show("The checkout date must be later than checkin date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpCheckout.Value = dtpCheckin.Value.AddDays(1);
                    day = 1;
                    
                }
                txtNight.Text = day.ToString();
                hotelPrice[index] = HotelRoomPrice * day;
            }
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirm.Enabled = true;
            if (e.RowIndex == -1)
                return;
            cmoClass.Items.Clear();
            id = dgvTicket.Rows[e.RowIndex].Tag.ToString();
            flightbooking = dgvTicket.Rows[e.RowIndex];
            index = e.RowIndex;
            using (var context = new tickettailor_dbEntities())
            {
                var Class = (from list in context.flightclass
                             where list.FlightNo.Contains(id)
                             select list.Class).Distinct();
                foreach (var c in Class.ToList())
                {
                    cmoClass.Items.Add(c);
                }
                cmoClass.SelectedIndex = 0;
            }
            nudAdultPerson.Value = (airPerson[index, 0] != 0) ? Convert.ToInt32(airPerson[index, 0]) : 1;
            nudChildPerson.Value = Convert.ToInt32(airPerson[index, 1]);
            nudInfantPerson.Value = Convert.ToInt32(airPerson[index, 2]);
            changeAirPrice();
        }

        private void btnTicketOk_Click(object sender, EventArgs e)
        {
            double ticketTotelPrice = 0;
            for (int i = 0; i < airPrice.Length; i++)
            {
                ticketTotelPrice += airPrice[i];
            }
            airPerson[index, 0] = Convert.ToInt32(nudAdultPerson.Value);
            airPerson[index, 1] = Convert.ToInt32(nudChildPerson.Value);
            airPerson[index, 2] = Convert.ToInt32(nudInfantPerson.Value);
            txtTicketTotal.Text = Convert.ToString(ticketTotelPrice);
            int discount = (txtTicketTotal.Text != "0" && txtHotelTotal.Text != "0") ? 150 : 0;
            txtTotal.Text = (Convert.ToDouble(txtTicketTotal.Text) + Convert.ToDouble(txtHotelTotal.Text) - discount).ToString("C2");
        }

        private void dgvHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirm.Enabled = true;
            if (e.RowIndex == -1)
                return;
            iid = (int)dgvHotel.Rows[e.RowIndex].Tag;
            hotelbooking = dgvHotel.Rows[e.RowIndex];
            index = e.RowIndex;
            using (var context = new tickettailor_dbEntities())
            {
                var price = (from list in context.hotel_room
                             where list.Hotel_roomID == iid
                             select list).FirstOrDefault();
                txthotelRoomPrice.Text = Convert.ToString((double)price.Fare);
            }
            changeHotelPrice();
        }

        private void btnHotelOk_Click(object sender, EventArgs e)
        {
            double hotelTotelPrice = 0;
            foreach(DataGridViewCell cell in dgvHotel.SelectedCells)
            {
                hotelTotelPrice += hotelPrice[cell.OwningRow.Index];
            }

            txtHotelTotal.Text = Convert.ToString(hotelTotelPrice);
            int discount = (txtTicketTotal.Text != "0" && txtHotelTotal.Text != "0") ? 150 : 0;
            txtTotal.Text = (Convert.ToDouble(txtTicketTotal.Text) + Convert.ToDouble(txtHotelTotal.Text) - discount).ToString("C2");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                MessageBox.Show("Please choose at least one item.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Do you Confirm the above reservation?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new tickettailor_dbEntities())
                {
                    //book hotel
                    if (hotelbooking != null)
                    {
                        //check hotel validation
                        var data = (from list in context.hotelbooking
                                   where list.HotelRoomID == iid
                                   && !((list.Checkin.CompareTo(dtpCheckin.Value) > 0
                                        && list.Checkin.CompareTo(dtpCheckout.Value) > 0)
                                        ||
                                        (list.Checkout.CompareTo(dtpCheckin.Value) < 0
                                        && list.Checkout.CompareTo(dtpCheckout.Value) < 0))
                                   select list).FirstOrDefault();
                        if (data != null)
                        {
                            MessageBox.Show("The hotel has been booked.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        hotelbooking hotel = new hotelbooking();
                        int id;
                        foreach (DataGridViewCell cell in dgvHotel.SelectedCells)
                        {
                            id = Convert.ToInt32(cell.OwningRow.Cells[3].Value);
                            hotel.HotelRoomID = id;
                            hotel.CustID = null;
                            hotel.NumNight = Int32.Parse(txtNight.Text);
                            hotel.NumRoom = 1;
                            hotel.Price = (decimal)(Convert.ToDouble(cell.OwningRow.Cells[9].Value.ToString()) * Int32.Parse(txtNight.Text));
                            hotel.OrderDate = DateTime.Now.Date;
                            hotel.OrderBy = frmModuleSelection.staff.StaffID;
                            hotel.Checkin = dtpCheckin.Value;
                            hotel.Checkout = dtpCheckout.Value;
                            hotelDictionary.Add(id, hotel);
                        }
                        
                        ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).hotelBooking = hotelDictionary;
                    }

                    //book flight
                    if (flightbooking != null)
                    {
                        flightbooking flight = new flightbooking();
                        flight.FlightOrderID = context.flightbooking.Select(i => i.FlightOrderID).OrderByDescending(i => i).FirstOrDefault() + 1;
                        flight.FlightID = (int)flightbooking.Cells[0].Value;
                        flight.FlightNo = (string)flightbooking.Cells[1].Value;
                        flight.FlightClass = (string)cmoClass.SelectedItem;
                        flight.FlightType = (string)flightbooking.Cells[2].Value;
                        flight.AdultNum = (int)nudAdultPerson.Value;
                        flight.ChildNum = (int)nudChildPerson.Value;
                        flight.InfantNum = (int)nudInfantPerson.Value;
                        flight.AdultPrice = (decimal)(Convert.ToDouble(txtAdultPrice.Text) * (int)nudAdultPerson.Value + Convert.ToDouble(txtAdultTax.Text));
                        flight.ChildPrice = (decimal)(Convert.ToDouble(txtChildPrice.Text) * (int)nudChildPerson.Value + Convert.ToDouble(txtChildTax.Text));
                        flight.InfantPrice = (decimal)(Convert.ToDouble(txtInfantPrice.Text) * (int)nudInfantPerson.Value + Convert.ToDouble(txtInfantTax.Text));
                        flight.OrderDate = DateTime.Now.Date;
                        flight.OrderBy = frmModuleSelection.staff.StaffID;
                        flight.CustID = null;
                        context.flightbooking.Add(flight);

                        flightDictionary.Add(flight, flight);
                        ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).flightBooking = flightDictionary;
                    }

                    int t = Int32.Parse(txtNumberTag.Text);

                    var tag = from list in context.tag
                                  where list.Tag == t
                                  select list;

                    foreach (var record in tag.ToList())
                        context.tag.Remove(record);

                    context.SaveChanges();
                    MessageBox.Show("Successful", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you cancel the above reservation?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int tag = 0;
                Boolean tagparse = Int32.TryParse(txtNumberTag.Text, out tag);
                if (tag == 0)
                {
                    MessageBox.Show("Please input a valid tag number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new tickettailor_dbEntities())
                {
                    var target = from list in context.tag
                                 where list.Tag == tag
                                 select list;
                    if (target == null)
                    {
                        MessageBox.Show("Do not have the tag number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        foreach(var t in target.ToList())
                        {
                            context.tag.Remove(t);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Cancel Successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                }
            }
        }

        private void txtNumberTag_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberTag.Text != "")
            {
                initial(txtNumberTag.Text);
            }
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDiscount.Checked)
            {
                lblShowDiscount.Text = "150";
            }else
            {
                lblShowDiscount.Text = "0";
            }
            
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            changeHotelPrice();
        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            changeHotelPrice();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}