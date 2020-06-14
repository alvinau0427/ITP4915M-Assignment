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
    public partial class frmModuleSelection : Form
    {
        // Form connection
        private frmInfo frmInfo;
        private frmLogin frmLogin;
        private frmConsole frmConsole;
        private frmRoster frmRoster;

        private frmAir frmAir;
        private frmHotelSche frmHotelSche;
        private frmCruiseTour frmCruiseTour;
        private frmAttraction frmAttraction;

        private frmOrder frmOrder;
        private frmCruiseBooking frmCruiseBooking;
        private frmAttractionBooking frmAttractionBooking;
        private frmTransport frmTransport;

        private frmRegister frmRegister;
        private frmRecord frmRecord;
        private frmAllBookings frmAllBookings;
        private frmPerformance frmPerformance;
        private frmProductManagement frmProductManagement;

        private DataGridViewRow[] airScheduleArray;
        private DataGridViewRow[] airClassArray;
        private DataGridViewRow[] hotelArray;

        public frmModuleSelection()
        {
            InitializeComponent();
        }

        // Value Setter & Getter
        public Dictionary<flightbooking, flightbooking> flightBooking { get; set; }

        public Dictionary<int, hotelbooking> hotelBooking { get; set; }

        public attractionbooking attractionBooking { get; set; }

        public cruisebooking cruiseBooking { get; set; }

        public Dictionary<driverbooking, driverbooking> driverbooking { get; set; }

        public DataGridViewRow chosenCruise { get; set; }

        public attraction chosenAttraction { get; set; }

        public attractionbooking chosenAttractionBooking { get; set; }

        public vehicle vehicle { get; set; }

        public staff staff { get; set; }

        public driver driver { get; set; }

        public string tag { get; set; }

        public void setTagArray(DataGridViewRow[] tagArray, string type)
        {
            if (type == "Schedule")
                this.airScheduleArray = tagArray;
            else if (type == "Class")
                this.airClassArray = tagArray;
            else
                this.hotelArray = tagArray;
        }

        public DataGridViewRow[] getAirScheduleTagArray()
        {
            return airScheduleArray;
        }
        public DataGridViewRow[] getAirClassTagArray()
        {
            return airClassArray;
        }
        public DataGridViewRow[] getHotelTagArray()
        {
            return hotelArray;
        }

        private void reOpenInfo()
        {
            // Reload the information form to turn off the youtube video
            frmInfo.Close();
            frmInfo = new frmInfo(this);
            frmInfo.MdiParent = this;
            frmInfo.Dock = DockStyle.Fill;
            frmInfo.Show();
        }

        private void reOpenConsole()
        {
            // Reload the staff console form
            frmConsole = new frmConsole(this);
            frmConsole.MdiParent = this;
            frmConsole.Dock = DockStyle.Fill;
            frmConsole.Show();
        }

        // Main Control
        private void frmModuleSelection_Load(object sender, EventArgs e)
        {
            // Default index page
            frmInfo = new frmInfo(this);
            frmInfo.MdiParent = this;
            frmInfo.Dock = DockStyle.Fill;
            frmInfo.Show();

            // Setup enable
            staffControlToolStripMenuItem.Enabled = false;
            driverControlToolStripMenuItem.Enabled = false;
            createUserAccountToolStripMenuItem.Enabled = false;
        }

        // Menu strip => Home Page
        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
        }

        // Menu strip => Flight Information
        private void flightInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmAir = new frmAir(this);
            frmAir.MdiParent = this;
            frmAir.Dock = DockStyle.Fill;
            frmAir.Show();
        }

        // Menu strip => Hotel Information
        private void hotelInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmHotelSche = new frmHotelSche(this);
            frmHotelSche.MdiParent = this;
            frmHotelSche.Dock = DockStyle.Fill;
            frmHotelSche.Show();
        }

        // Menu strip => Staff Control
        private void personalConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmConsole = new frmConsole(this);
            frmConsole.MdiParent = this;
            frmConsole.Dock = DockStyle.Fill;
            frmConsole.Show();
        }

        // => Searching Fuction
        private void airTicketEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmAir = new frmAir(this);
            frmAir.MdiParent = this;
            frmAir.Dock = DockStyle.Fill;
            frmAir.Show();
        }

        private void hotelScheduleEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmHotelSche = new frmHotelSche(this);
            frmHotelSche.MdiParent = this;
            frmHotelSche.Dock = DockStyle.Fill;
            frmHotelSche.Show();
        }

        private void cruiseTourEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmCruiseTour = new frmCruiseTour(this);
            frmCruiseTour.MdiParent = this;
            frmCruiseTour.Dock = DockStyle.Fill;
            frmCruiseTour.Show();
        }

        private void attractionEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmAttraction = new frmAttraction(this);
            frmAttraction.MdiParent = this;
            frmAttraction.Dock = DockStyle.Fill;
            frmAttraction.Show();
        }

        private void flightBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmOrder = new frmOrder(this);
            frmOrder.MdiParent = this;
            frmOrder.Dock = DockStyle.Fill;
            frmOrder.Show();
        }

        // Order Confirmation
        private void hotelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmOrder = new frmOrder(this);
            frmOrder.MdiParent = this;
            frmOrder.Dock = DockStyle.Fill;
            frmOrder.Show();
        }

        private void cruiseBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();

            if (chosenCruise != null)
            {
                frmCruiseBooking = new frmCruiseBooking(this);
                frmCruiseBooking.MdiParent = this;
                frmCruiseBooking.Dock = DockStyle.Fill;
                frmCruiseBooking.Show();
            }
            else
            {
                MessageBox.Show("Please search and choose a cruise first.");
            }
            
        }

        private void attractionBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();

            if (chosenAttraction != null)
            {
                frmAttractionBooking = new frmAttractionBooking(this);
                frmAttractionBooking.MdiParent = this;
                frmAttractionBooking.Dock = DockStyle.Fill;
                frmAttractionBooking.Show();
            }
            else
            {
                MessageBox.Show("Please search and choose a attraction first.");
            }
        }

        private void transportationBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmTransport = new frmTransport(this);
            frmTransport.MdiParent = this;
            frmTransport.Dock = DockStyle.Fill;
            frmTransport.Show();
        }

        // => Data Reports
        private void customerBookingRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmAllBookings = new frmAllBookings(this);
            frmAllBookings.MdiParent = this;
            frmAllBookings.Dock = DockStyle.Fill;
            frmAllBookings.Show();
        }

        // Performance
        private void performanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmPerformance = new frmPerformance(this);
            frmPerformance.MdiParent = this;
            frmPerformance.Dock = DockStyle.Fill;
            frmPerformance.Show();
        }

        // Management
        private void createUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmRegister = new frmRegister(this);
            frmRegister.MdiParent = this;
            frmRegister.Dock = DockStyle.Fill;
            frmRegister.Show();
        }

        private void productsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmProductManagement = new frmProductManagement(this);
            frmProductManagement.MdiParent = this;
            frmProductManagement.Dock = DockStyle.Fill;
            frmProductManagement.Show();
        }

        private void kioskRecordsEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            reOpenConsole();
            frmRecord = new frmRecord(this);
            frmRecord.MdiParent = this;
            frmRecord.Dock = DockStyle.Fill;
            frmRecord.Show();
        }

        // Menu strip => Driver Control
        private void driverControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmRoster = new frmRoster(this);
            frmRoster.Show();
        }

        // Menu strip => Login System
        private void loginSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reOpenInfo();
            frmLogin = new frmLogin(this);
            frmLogin.MdiParent = this;
            frmLogin.Dock = DockStyle.Fill;
            frmLogin.Show();
        }

        // Menu strip => Exit System
        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit the system ?", "System Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
