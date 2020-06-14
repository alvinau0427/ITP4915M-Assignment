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
    public partial class frmAir : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmNumberTag frmNumberTag;
        private frmOrder frmOrder;

        public frmAir(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmNumberTag = new frmNumberTag(frmModuleSelection);
            frmOrder = new frmOrder(frmModuleSelection);
        }

        private void frmAir_Load(object sender, EventArgs e)
        {
            // Hints in txtKeyword
            txtKeyword.GotFocus += new EventHandler(this.textGotFocus);
            txtKeyword.LostFocus += new EventHandler(this.textLostFocus);

            // Button enable
            btnOrder.Enabled = false;
            cboFightID.SelectedIndex = 0;
            cboCarrier.SelectedIndex = 0;
            cboOrigin.SelectedIndex = 0;
            cboDestination.SelectedIndex = 0;
            cboAircraft.SelectedIndex = 0;
            cboFlightNo.SelectedIndex = 0;
            cboFlightType.SelectedIndex = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {

                // cboFlightID
                var flightIDData = from list in dbContext.flightschedule
                                   select list;
                foreach (var fl in flightIDData)
                {
                    cboFightID.Items.Add(fl.FlightID);
                }

                // cboCarrier
                var carrierIDData = from list in dbContext.carrier
                                    select list;
                foreach (var ca in carrierIDData.ToList())
                {
                    cboCarrier.Items.Add(ca.IATA);
                }

                // cboOrigin 
                var flightOriginData = dbContext.flightschedule.Select(i => i.Origin).Distinct();
                foreach (var fl in flightOriginData.ToList())
                {
                    cboOrigin.Items.Add(fl);
                }

                // cboDestination
                var flightDestData = dbContext.flightschedule.Select(i => i.Dest).Distinct();
                foreach (var fl in flightDestData.ToList())
                {
                    cboDestination.Items.Add(fl);
                }

                // cboAircraft
                var flightAircraftData = dbContext.flightschedule.Select(i => i.Aircraft).Distinct();
                foreach (var fl in flightAircraftData.ToList())
                {
                    cboAircraft.Items.Add(fl);
                }

                // cboFlightNo 
                var flightFlightNoData = dbContext.flightschedule.Select(i => i.FlightNo).Distinct();
                foreach (var fl in flightFlightNoData.ToList())
                {
                    cboFlightNo.Items.Add(fl);
                }

                // cboFlightType
                cboFlightType.Items.Add("Direct");
                cboFlightType.Items.Add("Indirect");

                var result = from list in dbContext.flightschedule
                             select list;

                foreach (var data in result.ToList())
                {
                    dgvDefault.Rows.Add(data.FlightID,
                                        data.carrier1.IATA,
                                        data.Origin,
                                        data.Dest,
                                        data.Aircraft,
                                        data.EDD,
                                        data.ETD,
                                        data.EDA,
                                        data.ETA,
                                        data.FlightNo,
                                        data.FlightType);
                }
            }
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

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOrder.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Eliminate hints in textbox
            if (txtKeyword.Text == "Please enter keywords for search ...")
            {
                txtKeyword.Text = "";
            }

            dgvClass.Rows.Clear();
            dgvDefault.Rows.Clear();
            int id = 0;
            Boolean parseID = Int32.TryParse(Convert.ToString(cboFightID.SelectedItem), out id);
            DateTime eda = DateTime.Parse(dtpEDA.Value.ToString());
            DateTime edd = DateTime.Parse(dtpEDD.Value.ToString());
            int trT = Convert.ToInt32(nudTravelTimeH.Value) * 60 + Convert.ToInt32(nudTravelTimeM.Value);

            using (var dbContext = new tickettailor_dbEntities())
            {
                var result = from list in dbContext.flightschedule
                             where (list.FlightID == id || id == 0)
                             && (list.carrier1.IATA.Contains((string)(cboCarrier.SelectedItem)) || cboCarrier.SelectedIndex == 0)
                             && (list.Origin.Contains((string)(cboOrigin.SelectedItem)) || cboOrigin.SelectedIndex == 0)
                             && (list.Dest.Contains((string)(cboDestination.SelectedItem)) || cboDestination.SelectedIndex == 0)
                             && (list.Aircraft.Contains((string)(cboAircraft.SelectedItem)) || cboAircraft.SelectedIndex == 0)
                             && (list.TravelTime <= trT || (int)(nudTravelTimeH.Value) == 0 || (int)(nudTravelTimeH.Value) == 0) // Already changed the data type
                             && (list.EDD <= edd)
                             && (list.EDA <= eda)
                             && (list.FlightNo.Contains((string)(cboFlightNo.SelectedItem)) || cboFlightNo.SelectedIndex == 0)
                             && (list.FlightType.Contains((string)(cboFlightType.SelectedItem)) || cboFlightType.SelectedIndex == 0)
                             && (list.FlightType.Contains(txtKeyword.Text) 
                                    || list.Origin.Contains(txtKeyword.Text)
                                    || list.Dest.Contains(txtKeyword.Text)
                                    || list.Aircraft.Contains(txtKeyword.Text)
                                    || list.FlightNo.Contains(txtKeyword.Text)
                                    || list.carrier1.IATA.Contains(txtKeyword.Text))
                             select list;

                foreach (var data in result.ToList())
                {
                    dgvDefault.Rows.Add(data.FlightID,
                                        data.carrier1.IATA,
                                        data.Origin,
                                        data.Dest,
                                        data.Aircraft,
                                        data.EDD,
                                        data.ETD,
                                        data.EDA,
                                        data.ETA,
                                        data.FlightNo,
                                        data.FlightType);
                }
            }
            if (txtKeyword.Text == "")
                txtKeyword.Text = "Please enter keywords for search ...";
        }

        private void dgvDefault_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClass.Rows.Clear();
            String flightNo = Convert.ToString(dgvDefault.Rows[e.RowIndex].Cells[9].Value);

            using (var dbContext = new tickettailor_dbEntities())
            {
                var result = from list in dbContext.flightclass
                             where list.FlightNo.Equals(flightNo)
                             select list;

                foreach (var data in result)
                {
                    dgvClass.Rows.Add(data.FlightNo,
                                      data.Class,
                                      data.FlightType,
                                      data.Price_Adult,
                                      data.Price_Children,
                                      data.Price_Infant,
                                      data.Tax);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboFightID.SelectedIndex = 0;
            cboCarrier.SelectedIndex = 0;
            cboOrigin.SelectedIndex = 0;
            cboDestination.SelectedIndex = 0;
            cboAircraft.SelectedIndex = 0;
            nudTravelTimeH.Value = 0;
            nudTravelTimeM.Value = 0;
            dtpEDA.Value = DateTime.Now;
            dtpEDD.Value = DateTime.Now;
            dtpETD.Value = DateTime.Now;
            dtpETA.Value = DateTime.Now;
            cboFlightNo.SelectedIndex = 0;
            cboFlightType.SelectedIndex = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var result = from list in dbContext.flightschedule
                             select list;

                foreach (var data in result.ToList())
                {
                    dgvDefault.Rows.Add(data.FlightID, data.carrier1.IATA, data.Origin, data.Dest, data.Aircraft, data.EDD, data.ETD, data.EDA, data.ETA, data.FlightNo, data.FlightType);
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] scheduleArray = new DataGridViewRow[dgvDefault.SelectedCells.Count];
            int i = 0;
            foreach (DataGridViewCell selectedCell in dgvDefault.SelectedCells)
            {
                scheduleArray[i++] = selectedCell.OwningRow;
            }

            DataGridViewRow[] classArray = new DataGridViewRow[dgvClass.SelectedCells.Count];
            i = 0;
            foreach (DataGridViewCell selectedCell in dgvClass.SelectedCells)
            {
                classArray[i++] = selectedCell.OwningRow;
            }

            DialogResult result = MessageBox.Show("Do you confirm your choice?", "Confirm Arrangement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).setTagArray(scheduleArray, "Schedule");
                ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).setTagArray(classArray, "Class");

                DialogResult question = MessageBox.Show("Do you have other booking?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    frmNumberTag.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
