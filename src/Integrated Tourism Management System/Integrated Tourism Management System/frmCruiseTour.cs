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
    public partial class frmCruiseTour : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmCruiseBooking frmCruiseBooking;

        // Set value
        int numOfDay = 0;
        DateTime dateTime;

        public frmCruiseTour(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            frmCruiseBooking = new frmCruiseBooking(frmModuleSelection);
        }

        private void frmCruiseTour_Load(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = false;
            nudTourDay.Enabled = false;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var corganizer = from list in dbContext.corganizer
                                 select list;
                foreach (var cor in corganizer)
                {
                    cboOrganizer.Items.Add(cor.OrganizerE);
                }

                cboOrganizer.SelectedIndex = 0;
                btnBook.Enabled = false;
                btnInfo.Enabled = false;
            }

            using (var dbContext = new tickettailor_dbEntities())
            {
                var cruise = (from list in dbContext.cruise
                              select list).OrderBy(i => i.TourDay);

                foreach (var c in cruise.ToList())
                {
                    dgvDay.Rows.Add(c.CruiseNo, c.CruiseName, c.RefPrice, c.TourDay, c.corganizer.OrganizerE, c.Info, c.StartDate.Value.ToString("dd-MM-yyyy"));
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();
            numOfDay = Convert.ToInt32(nudTourDay.Value);

            dateTime = DateTime.Parse(dtpStartDate.Value.ToString());

            using (var dbContext = new tickettailor_dbEntities())
            {
                var cruise = (from list in dbContext.cruise
                             where (list.TourDay <= numOfDay || !chkTourDay.Checked) && (list.StartDate.Value > dateTime.Date || !chkStartDay.Checked) && (list.corganizer.OrganizerE.Contains((string)(cboOrganizer.SelectedItem)) || ((string)(cboOrganizer.SelectedItem)).Contains("All"))
                             select list).OrderBy(i => i.TourDay);

                foreach (var c in cruise.ToList())
                {
                    dgvDay.Rows.Add(c.CruiseNo, c.CruiseName, c.RefPrice, c.TourDay, c.corganizer.OrganizerE, c.Info, c.StartDate.Value.ToString("dd-MM-yyyy"));
                }
            }
        }

        private void dgvDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            txtResult.Text = Convert.ToString(dgvDay.Rows[e.RowIndex].Cells[1].Value);
            btnBook.Enabled = true;
            btnInfo.Enabled = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvDay.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please do not select more than one items.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dgvDay.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell.Value != null)
            {
                DataGridViewRow row = cell.OwningRow;
                Form newForm = new Form();
                newForm.Show();
                newForm.Name = "PDF";
                newForm.Text = "Cruise Information - PDF";
                newForm.Size = new Size(600, 600);
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;

                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                pdf.Location = new System.Drawing.Point(0, 0);
                pdf.Name = "pdf";
                pdf.OcxState = ((System.Windows.Forms.AxHost.State)(new System.ComponentModel.ComponentResourceManager(typeof(frmCruiseTour)).GetObject("pdf.OcxState")));
                pdf.TabIndex = 1;
                newForm.Controls.Add(pdf);

                pdf.LoadFile(@"..\CruiseInfo\" + row.Cells["Info"].Value.ToString());
                pdf.setView("Fit");
                pdf.Visible = true;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvDay.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please do not select more than one items.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dgvDay.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            DataGridViewRow row = cell.OwningRow;
            
            ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).chosenCruise = row;

            frmCruiseBooking.MdiParent = frmModuleSelection;
            frmCruiseBooking.Dock = DockStyle.Fill;
            frmCruiseBooking.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();
            nudTourDay.Text = "0";
            dtpStartDate.ResetText();
            cboOrganizer.Text = "All";
            txtResult.Text = "";
            btnBook.Enabled = false;
            btnInfo.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkStartDay_Click(object sender, EventArgs e)
        {
            if (chkStartDay.Checked)
                dtpStartDate.Enabled = true;
            else
                dtpStartDate.Enabled = false;
        }

        private void chkTourDay_Click(object sender, EventArgs e)
        {
            if (chkTourDay.Checked)
                nudTourDay.Enabled = true;
            else
                nudTourDay.Enabled = false;
        }
    }
}