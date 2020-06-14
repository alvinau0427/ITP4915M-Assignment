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
    public partial class ucAttraction : UserControl
    {
        attraction attr;

        public ucAttraction(attraction attr)
        {
            this.attr = attr;
            // Form connection
            InitializeComponent();

            lblShowName.Text = attr.AttractName;
            lblShowDuration.Text = attr.Duration;
            lblShowCancellation.ForeColor = (attr.Cancellation == "Charged") ? ColorTranslator.FromHtml("#9F000F") : ColorTranslator.FromHtml("#008080");
            lblShowCancellation.Text = attr.Cancellation;
            lblShowCity.Text = attr.City;
            try
            {
                Image img = Image.FromFile("../Image/AttractionPhotos/" + attr.AttractPhoto);
                picPhoto.Image = img;
            }
            catch (Exception)
            {
                picPhoto.Image = null;
            }

            using (var dbContext = new tickettailor_dbEntities())
            {
                var price = from l in dbContext.attractionprice
                            where (l.AttractName == attr.AttractName)
                            select l;
                foreach (var p in price.ToList())
                {
                    if (p.Visitor == "Adult")
                    {
                        lblShowPriceAdult.Text = ((double)p.Price).ToString("C0");
                    }
                    else
                    {
                        lblShowPriceChild.Text = ((double)p.Price).ToString("C0");
                    }
                }
            }
        }

        private void ucAttraction_Load(object sender, EventArgs e)
        {
            
        }

        private void ucAttraction_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
            // this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // this.BackColor = Color.Empty;
            // this.BackColor = Color.Gainsboro;
            ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).chosenAttraction = attr;
        }
    }
}
