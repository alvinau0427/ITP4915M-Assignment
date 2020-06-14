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
    public partial class frmNumberTag : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        private int tagNum;

        public frmNumberTag(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmNumberTag_Load(object sender, EventArgs e)
        {
            using (var context = new tickettailor_dbEntities())
            {
                var taglastOne = (from list in context.tag
                                  select list.Tag).OrderByDescending(j => j).FirstOrDefault();
                tagNum = taglastOne + 1;
                tag tag = new tag();

                if (frmModuleSelection.getAirClassTagArray() != null)
                {
                    DataGridViewRow airScheduleArray = frmModuleSelection.getAirScheduleTagArray().First();
                    DataGridViewRow[] airClassArray = frmModuleSelection.getAirClassTagArray();
                    
                    for (int j = 0; j < airClassArray.Length; j++)
                    {
                        tag.Tag = tagNum;
                        tag.TagTypeID = Convert.ToInt32(airScheduleArray.Cells[0].Value);
                        tag.TagType = "Ticket-" + airClassArray[j].Cells[0].Value + "-" + airClassArray[j].Cells[1].Value + "-" + airClassArray[j].Cells[2].Value;
                        context.tag.Add(tag);
                        context.SaveChanges();
                        tag = new tag();
                    }
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).setTagArray(null, "Schedule");
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).setTagArray(null, "Class");
                }
                if (frmModuleSelection.getHotelTagArray() != null)
                {
                    DataGridViewRow[] hotelArray = frmModuleSelection.getHotelTagArray();

                    for (int j = 0; j < hotelArray.Length; j++)
                    {
                        tag.Tag = tagNum;
                        tag.TagTypeID = Convert.ToInt32(hotelArray[j].Cells[0].Value);
                        tag.TagType = "Hotel";
                        context.tag.Add(tag);
                        context.SaveChanges();
                        tag = new tag();
                    }
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).setTagArray(null, "Hotel");
                }
            }
            txtTag.Text = Convert.ToString(tagNum);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Printer action
            this.Close();
        }
    }
}