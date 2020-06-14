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
    public partial class frmPerformance : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;

        public frmPerformance(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
            rdoSalary.Checked = true;
        }

        private void frmPerformance_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadChart(int index)
        {
            using (var dbcontent = new tickettailor_dbEntities())
            {
                if (index == 1)
                {
                    chart.Titles.Clear();
                    chart.Series.Clear();
                    chart.Titles.Add("Salary and Retirement Fund Chart");
                    chart.Series.Add("Salary");
                    chart.Series.Add("Retirement Fund Deduction");
                    chart.Series["Salary"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                    chart.Series["Retirement Fund Deduction"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;

                    var staff = from list in dbcontent.staff
                                select new { list.StaffName, salary = (double)list.Salary.Value * 0.995, retirement = (double)list.Salary * 0.005 };

                    chart.DataSource = staff.ToList();
                    chart.Series["Salary"].XValueMember = "StaffName";
                    chart.Series["Salary"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chart.Series["Salary"].YValueMembers = "salary";
                    chart.Series["Salary"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart.Series["Salary"].Label = "#VAL";

                    chart.Series["Retirement Fund Deduction"].XValueMember = "StaffName";
                    chart.Series["Retirement Fund Deduction"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chart.Series["Retirement Fund Deduction"].YValueMembers = "retirement";
                    chart.Series["Retirement Fund Deduction"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart.Series["Retirement Fund Deduction"].Label = "#VAL";
                }
            }
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {
            loadChart(1);
        }
    }
}
