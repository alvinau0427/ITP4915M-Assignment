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
    public partial class frmHotelSche : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmNumberTag frmNumberTag;

        public frmHotelSche(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmNumberTag = new frmNumberTag(frmModuleSelection);
        }

        private void frmHotelSche_Load(object sender, EventArgs e)
        {
            // Hints in txtKeyword
            txtKeyword.GotFocus += new EventHandler(this.textGotFocus);
            txtKeyword.LostFocus += new EventHandler(this.textLostFocus);

            using (var dbContext = new tickettailor_dbEntities())
            {
                var hotels = from list in dbContext.hotel
                             select list;
                foreach (var h in hotels.ToList())
                {
                    dgvHotel.Rows.Add(h.HotelID, h.Hotel_chi_name, h.Hotel_en_name, h.Star, calulateRating((double)h.Rating), h.Region, h.Address, h.Tel);
                }

                var hotel = dbContext.hotel.Select(i => i.Region).Distinct();

                foreach (var h in hotel.ToList())
                {
                    cmbDest.Items.Add(h);
                }

                cmbDest.SelectedIndex = 0;
                dgvHotelRoom.Enabled = false;
                btnOrder.Enabled = false;

                var keyword = (from list in dbContext.hotel
                               select new { list.Hotel_chi_name, list.Hotel_en_name });
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                foreach (var k in keyword.ToList())
                {
                    source.Add(k.Hotel_chi_name);
                    source.Add(k.Hotel_en_name);
                }

                txtKeyword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtKeyword.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtKeyword.AutoCompleteCustomSource = source;
            }
        }

        private string calulateRating(double i)
        {
            string rating;

            if (i <= 3.5)
                rating = "Satisfactory";
            else if (i <= 4.0)
                rating = "Good";
            else if (i <= 4.7)
                rating = "Fine Good";
            else
                rating = "Excellent";
            return rating;
        }

        public void textGotFocus(object sender, EventArgs e)
        {
            // Textbox hints function
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Please enter keywords for search ...")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void textLostFocus(object sender, EventArgs e)
        {
            // Textbox hints function
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Please enter keywords for search ...";
                tb.ForeColor = Color.Gray;
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dgvHotel.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            DataGridViewRow row = cell.OwningRow;
            if (row.Cells[0].Value != null)
            {
                String temp = Convert.ToString(row.Cells[2].Value);
                StringBuilder add = new StringBuilder("https://www.google.com.hk/maps?q=");
                add.Append(Uri.EscapeDataString(temp));

                Form newForm = new Form();
                newForm.Show();
                newForm.Name = "frmMap";
                newForm.Text = "Ticket Tailor Ltd.'s Integrated Tourism Management System - Hotel Location";
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;
                newForm.Size = new Size(1000, 800);
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowser.Location = new System.Drawing.Point(0, 0);
                webBrowser.Name = "webBrowser";
                newForm.Controls.Add(webBrowser);
                webBrowser.Visible = true;
                webBrowser.Navigate(add.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Eliminate hints in textbox
            if(txtKeyword.Text == "Please enter keywords for search ...")
            {
                txtKeyword.Text = "";
            }
            
            dgvHotel.Rows.Clear();
            dgvHotelRoom.Rows.Clear();
            btnOrder.Enabled = false;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var hotel = from list in dbContext.hotel
                            where (list.Region.Contains((string)(cmbDest.SelectedItem)) || ((string)(cmbDest.SelectedItem)).Contains("All")) &&
                                    (list.Hotel_chi_name.Contains(txtKeyword.Text) || list.Hotel_en_name.Contains(txtKeyword.Text) || txtKeyword.Text.Contains("Please enter keywords for search ..."))
                            select list;
                if (hotel.Count() != 0)
                {
                    foreach (var h in hotel.ToList())
                    {

                        dgvHotel.Rows.Add(h.HotelID, h.Hotel_chi_name, h.Hotel_en_name, h.Star, calulateRating((double)h.Rating), h.Region, h.Address, h.Tel);
                        btnMap.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Do not have any available hotel. Please search again!!");
                    btnMap.Enabled = false;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbDest.SelectedIndex = 0;
            txtKeyword.Text = "";
            dtpEDA.Value = DateTime.Now;
            dtpEDD.Value = DateTime.Now;
            dgvHotelRoom.Enabled = false;
            btnOrder.Enabled = false;
            dgvHotel.Rows.Clear();
            dgvHotelRoom.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var hotels = from list in dbContext.hotel
                             select list;
                foreach (var h in hotels.ToList())
                {
                    dgvHotel.Rows.Add(h.HotelID, h.Hotel_chi_name, h.Hotel_en_name, h.Star, calulateRating((double)h.Rating), h.Region, h.Address, h.Tel);
                }
            }
        }

        private void dgvHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHotelRoom.Enabled = true;
            dgvHotelRoom.Rows.Clear();
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dgvHotel.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            DataGridViewRow row = cell.OwningRow;
            if (row.Cells[0].Value != null)
            {
                int hotelID = (int)row.Cells[0].Value;
                using (var dbContext = new tickettailor_dbEntities())
                {
                    var hotelRoom = from list in dbContext.hotel_room
                                    where list.HotelID == hotelID
                                    select list;
                    foreach (var hr in hotelRoom.ToList())
                    {
                        dgvHotelRoom.Rows.Add(hr.Hotel_roomID, hr.Hotel_room_name, hr.Hotel_room_size, hr.Max_adult, hr.Max_child, hr.Hotel_room_description, hr.Fare);
                    }
                }
                btnOrder.Enabled = true;
            }
        }

        private void dgvHotelRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dgvHotelRoom.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            DataGridViewRow row = cell.OwningRow;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int num = 0;
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dgvHotel.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            string allName = "Hotel Name:\n" + cell.OwningRow.Cells[1].Value + "\n\nHotel Room:\n";

            DataGridViewRow[] hotelArray = new DataGridViewRow[dgvHotelRoom.SelectedCells.Count];
            int i = 0;
            foreach (DataGridViewCell selectedCell in dgvHotelRoom.SelectedCells)
            {
                num++;
                hotelArray[i++] = selectedCell.OwningRow;
                allName += Convert.ToString(selectedCell.OwningRow.Cells[1].Value) + "\n";
            }
            DialogResult result = MessageBox.Show(allName + "\nYou selected " + num + " hotel room(s).\n\nDo you confirm your choice?", "Confirm Arrangement", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).setTagArray(hotelArray, "Hotel");

                DialogResult question = MessageBox.Show("Do you have other booking?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    frmNumberTag.Show();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
