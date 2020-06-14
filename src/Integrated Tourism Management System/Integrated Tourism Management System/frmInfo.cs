using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Integrated_Tourism_Management_System
{
    public partial class frmInfo : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private frmAir frmAir;
        private frmHotelSche frmHotelSche;
        private frmNumberTag frmNumberTag;

        public frmInfo(frmModuleSelection frm)
        {
            // Form Connection
            InitializeComponent();
            btnConfirm.Enabled = false;
            this.frmModuleSelection = frm;
            frmAir = new frmAir(frmModuleSelection);
            frmHotelSche = new frmHotelSche(frmModuleSelection);
            frmNumberTag = new frmNumberTag(frmModuleSelection);
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }

        private void picAir_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmAir.MdiParent = frmModuleSelection;
            frmAir.Dock = DockStyle.Fill;
            frmAir.Show();
        }

        private void picHotel_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmHotelSche.MdiParent = frmModuleSelection;
            frmHotelSche.Dock = DockStyle.Fill;
            frmHotelSche.Show();
        }

        private void reOpenInfo()
        {
            // Reload the information form to turn off the youtube video
            this.Close();
            var temp = new frmInfo(frmModuleSelection);
            temp.btnConfirm.Enabled = true;
            temp.MdiParent = frmModuleSelection;
            temp.Dock = DockStyle.Fill;
            temp.Show();
            Dispose();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Contact us by E-mail?", "E-mail", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string mailInfo = string.Format("mailto:{0}?Subject={1}&Body={2}", "hi@tickettailor.com", "Customer FeedBack: 'Please enter the subject of feedback'", "'Please enter the content of feedback'");
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = mailInfo.ToString();
                myProcess.Start();
                myProcess.Dispose();
            }
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Open browser to browse the above page?", "Web Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.tickettailor.com/");
            }
        }

        private void txtYoutubePage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Open browser to browse the above page?", "Web Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCAncCn2s-hcSuvW2NbX8uBQ");
            }
        }

        private void btnFacebookPage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Open browser to browse the above page?", "Web Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/tickettailor/");
            }
        }

        private void btnTwitterPage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Open browser to browse the above page?", "Web Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://twitter.com/tickettailor");
            }
        }

        private void btnGooglePage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Open browser to browse the above page?", "Web Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://plus.google.com/+Tickettailorhq");
            }
        }

        private void picBanner_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Open browser to browse the above page to get more details?", "Web Browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.tickettailor.com/help-and-support/collecting-ticket-payments-with-stripe-or-paypal/");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            frmNumberTag.Show();
            this.btnConfirm.Enabled = false;
        }
    }
}
