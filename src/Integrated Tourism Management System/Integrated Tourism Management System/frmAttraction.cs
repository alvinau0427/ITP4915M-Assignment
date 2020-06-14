using Integrated_Tourism_Management_System.Properties;
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
    public partial class frmAttraction : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmTransport frmTransport;
        private frmAttractionBooking frmAttractionBooking;

        public frmAttraction(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmTransport = new frmTransport(frmModuleSelection);
            frmAttractionBooking = new frmAttractionBooking(frmModuleSelection);
            cboCity.Items.Add("All");
            cboCity.SelectedIndex = 0;

            using (var dbContext = new tickettailor_dbEntities())
            {
                var attCity = (from list in dbContext.attraction
                               select list.City).Distinct().OrderBy(i => i);

                foreach (var i in attCity)
                {
                    cboCity.Items.Add(i);
                }

                var attraction = (from list in dbContext.attraction
                                  select list);

                foreach (var att in attraction.ToList())
                {
                    ucAttraction uc = new ucAttraction(att);
                    flowLayoutPanel.Controls.Add(uc);
                }

                //get suggested search keyword in database
                var keyword = (from list in dbContext.attraction
                               select list.AttractName).Distinct();
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                foreach (var i in keyword.ToList())
                {
                    source.Add(i);
                }

                txtKeyword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtKeyword.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtKeyword.AutoCompleteCustomSource = source;
            }
        }

        private void frmAttraction_Load(object sender, EventArgs e)
        {
            // Hints in txtKeyword
            txtKeyword.GotFocus += new EventHandler(this.textGotFocus);
            txtKeyword.LostFocus += new EventHandler(this.textLostFocus);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Eliminate hints in textbox
            if (txtKeyword.Text == "Please enter keywords for search ...")
            {
                txtKeyword.Text = "";
            }

            flowLayoutPanel.Controls.Clear();
            string keyword = txtKeyword.Text;
            string city = cboCity.SelectedItem.ToString();

            using (var context = new tickettailor_dbEntities())
            {
                var attraction = from list in context.attraction
                                 where (list.City.Contains(city) || cboCity.SelectedIndex == 0) && list.AttractName.Contains(keyword)
                                 select list;

                foreach (var att in attraction.ToList())
                {
                    ucAttraction uc = new ucAttraction(att);
                    flowLayoutPanel.Controls.Add(uc);
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (frmModuleSelection.chosenAttraction == null)
            {
                MessageBox.Show("Please select a attraction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAttractionBooking.MdiParent = frmModuleSelection;
            frmAttractionBooking.Dock = DockStyle.Fill;
            frmAttractionBooking.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
