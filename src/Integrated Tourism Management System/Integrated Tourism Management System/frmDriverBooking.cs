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
    public partial class frmDriverBooking : Form
    {
        public Dictionary<string, Dictionary<int, ComboboxItem>> dateDriver = new Dictionary<string, Dictionary<int, ComboboxItem>>();
        CheckBox[] ch = new CheckBox[3];
        ComboBox[] cb = new ComboBox[3];
        Label[] lbl = new Label[3];

        public frmDriverBooking()
        {
            InitializeComponent();
        }

        public frmDriverBooking(DateTime pickup, DateTime dropoff, Dictionary<string, Dictionary<int, ComboboxItem>> dD, vehicle ve)
        {
            InitializeComponent();
            //find reference
            ch[0] = chk1;
            ch[1] = chk2;
            ch[2] = chk3;

            cb[0] = cbo1;
            cb[1] = cbo2;
            cb[2] = cbo3;

            lbl[0] = lblNoDriver1;
            lbl[1] = lblNoDriver2;
            lbl[2] = lblNoDriver3;
            lbl[0].Visible = false;
            lbl[1].Visible = false;
            lbl[2].Visible = false;

            this.dateDriver = dD;

            picVehicle.Image = Image.FromFile("../Image/VehiclePhotos/" + ve.VehiclePhoto);

            DateTime day = pickup;
            int numOfDay = (dropoff - pickup).Days + 1;
            for (int i = 0; i < numOfDay; i++)
            {
                string strDay = day.ToString("yyyy-MM-dd");
                day = day.AddDays(1);
                lstDate.Items.Add(strDay);

                if (!dateDriver.ContainsKey(strDay))
                    dateDriver.Add(strDay, new Dictionary<int, ComboboxItem>());
            }
            if (lstDate.Items.Count == 0)
                return;
            else
                lstDate.SelectedIndex = 0;

        }

        private void lstDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDate.SelectedIndex < 0)
                return;

            Dictionary<int, ComboboxItem> aDay = dateDriver[lstDate.Text.ToString()];

            if (aDay.Count == 0)
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    ch[i].Checked = false;
                    loadDriver(i);
                }
                return;
            }
            else
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (aDay.ContainsKey(i))
                        ch[i].Checked = true;
                    else
                        ch[i].Checked = false;
                    loadDriver(i);
                }
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            chkExamine(0);
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            chkExamine(1);
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            chkExamine(2);
        }

        private void chkExamine(int index)
        {
            if (ch[index].Checked)
            {
                selectDriver(index);
            }
            else
            {
                try
                {
                    dateDriver[lstDate.Text].Remove(index);
                }
                catch (Exception) { }
            }
        }

        private void loadDriver(int index)
        {
            //load available driver
            cb[index].Items.Clear();
            int timeslot = index + 1;
            try
            {
                DateTime selecteddate = DateTime.ParseExact(lstDate.SelectedItem.ToString(), "yyyy-MM-dd", null);

                string available;
                if (selecteddate.DayOfWeek == DayOfWeek.Sunday || selecteddate.DayOfWeek == DayOfWeek.Saturday)
                    available = "Weekend";
                else
                    available = "Weekday";
                using (var dbContext = new tickettailor_dbEntities())
                {
                    var driver = (from i in dbContext.driverroster
                                  where i.Available == available && i.TimeSlot == timeslot
                                  select i);

                    var bookedDriver = (from k in dbContext.driverbooking
                                        where k.BookingDate == selecteddate
                                        select k);
                    var ad = new List<int> { };
                    var bd = new List<int> { };
                    foreach (var i in driver.ToList())
                    {
                        ad.Add(i.DriverRosterID);

                    }
                    foreach (var i in bookedDriver.ToList())
                    {
                        bd.Add(i.DriverRosterID);
                    }

                    var result = ad.Except(bd);

                    var availableDriver = (from i in dbContext.driverroster
                                           where result.Contains(i.DriverRosterID)
                                           select i);

                    if (availableDriver.Count() == 0)
                    {
                        ch[index].Visible = false;
                        cb[index].Visible = false;
                        lbl[index].Visible = true;
                        return;
                    }
                    else
                    {
                        ch[index].Visible = true;
                        cb[index].Visible = true;
                        lbl[index].Visible = false;
                    }

                    foreach (var i in availableDriver.ToList())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.DriverName = i.driver.StaffName;
                        item.RosterID = i.DriverRosterID;
                        if (i.Available == "Weekend")
                            item.DriverCost = (decimal)Math.Round(i.driver.Salary * 1.5, 2);
                        else
                            item.DriverCost = i.driver.Salary;
                        cb[index].Items.Add(item);
                    }
                }
                if (dateDriver[lstDate.Text].ContainsKey(index))
                {
                    string driverName = dateDriver[lstDate.Text][index].DriverName;
                    cb[index].SelectedIndex = cb[index].FindStringExact(driverName);
                }
                else
                {
                    cb[index].SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDriver(0);
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDriver(1);
        }

        private void cbo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDriver(2);
        }

        private void selectDriver(int index)
        {
            if (cb[index].SelectedIndex < 0 || !ch[index].Checked)
                return;
            if (dateDriver[lstDate.Text].ContainsKey(index))
                dateDriver[lstDate.Text][index] = (ComboboxItem)cb[index].SelectedItem;
            else
                dateDriver[lstDate.Text].Add(index, (ComboboxItem)cb[index].SelectedItem);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (var i in dateDriver.ToList())
            {
                if (dateDriver[i.Key].Count == 0)
                {
                    dateDriver.Remove(i.Key);
                }
            }
            btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }   
    }
    public class ComboboxItem
    {
        public string DriverName { get; set; }
        public int RosterID { get; set; }
        public decimal DriverCost { get; set; }

        public override string ToString()
        {
            return DriverName;
        }
    }
}
