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
    public partial class frmRecord : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;

        public frmRecord(frmModuleSelection frm)
        {

            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            loadTag();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Confirm the change?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dbContext = new tickettailor_dbEntities())
                {
                    foreach (DataGridViewCell cell in dgvTag.SelectedCells)
                    {
                        int id = Convert.ToInt32(cell.OwningRow.Cells[0].Value);
                        string type = Convert.ToString(cell.OwningRow.Cells[1].Value);
                        string detail = Convert.ToString(cell.OwningRow.Cells[2].Value);
                        var deleteItem = (from list in dbContext.tag
                                          where list.Tag == id
                                          && (type + "-" + detail).Contains(list.TagType)
                                          select list).FirstOrDefault();
                        dbContext.tag.Remove(deleteItem);
                    }
                    dbContext.SaveChanges();
                    loadTag();
                }
            }
        }  

        private void loadTag()
        {
            dgvTag.Rows.Clear();
            using (var dbContext = new tickettailor_dbEntities())
            {
                var tag = from list in dbContext.tag
                          select list;
                foreach (var t in tag.ToList())
                {
                    if (t.TagType.Contains("Ticket"))
                        dgvTag.Rows.Add(t.Tag, t.TagType.Substring(0, t.TagType.IndexOf("-")), t.TagType.Substring(t.TagType.IndexOf("-") + 1));
                    else
                        dgvTag.Rows.Add(t.Tag, t.TagType, dbContext.hotel_room.Find(t.TagTypeID).Hotel_room_name);
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you delete all the tag data?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dbContext = new tickettailor_dbEntities())
                {
                    var deleteItem = (from list in dbContext.tag
                                        select list);

                    foreach(var d in deleteItem.ToList())
                    {
                        dbContext.tag.Remove(d);
                    }
                    dbContext.SaveChanges();
                    loadTag();
                }
            }
        }
    }
}
