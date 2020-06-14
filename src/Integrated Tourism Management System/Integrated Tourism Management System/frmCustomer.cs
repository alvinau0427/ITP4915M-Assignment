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
    public partial class frmCustomer : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;
        string customerID;
        string[] nationality = {"Afghans","Albanians","Algerians","Americans","Andorrans","Angolans","Argentines","Armenians","Aromanians","Arubans","Australians","Austrians","Azerbaijanis","Bahamians","Bahrainis","Bangladeshis","Barbadians","Belarusians","Belgians","Belizeans","Bermudians","Boers","Bosniaks","Brazilians","Bretons","British","British Virgin Islanders","Bulgarians","Macedonian Bulgarians","Burkinabès","Burundians","Cambodians","Cameroonians","Canadians",
                                "Catalans","Cape Verdeans","Chadians","Chileans","Chinese","Colombians","Comorians","Congolese","Croatians","Cubans","Cypriots","Turkish Cypriots","Czechs","Danes","Dominicans (Republic)","Dominicans (Commonwealth)","Dutch","East Timorese","Ecuadorians","Egyptians","Emiratis","English","Eritreans","Estonians","Ethiopians","Faroese","Finns","Finnish Swedish","Fijians","Filipinos","French citizens","Georgians","Germans","Baltic Germans",
                                "Ghanaians","Gibraltar","Greeks","Greek Macedonians","Grenadians","Guatemalans","Guianese (French)","Guineans","Guinea-Bissau nationals","Guyanese","Haitians","Hondurans","Hong Kong","Hungarians","Icelanders","I-Kiribati","Indians","Indonesians","Iranians (Persians)","Iraqis","Irish","Israelis","Italians","Ivoirians","Jamaicans","Japanese","Jordanians","Kazakhs","Kenyans","Koreans","Kosovars","Kurds","Kuwaitis","Kyrgyzs","Lao","Latvians",
                                "Lebanese","Liberians","Libyans","Liechtensteiners","Lithuanians","Luxembourgers","Macedonians","Malagasy","Malaysians","Malawians","Maldivians","Malians","Maltese","Manx","Mauritians","Mexicans","Moldovans","Moroccans","Mongolians","Montenegrins","Namibians","Nepalese","New Zealanders","Nicaraguans","Nigeriens","Nigerians","Norwegians","Pakistanis","Palauans","Palestinians","Panamanians","Papua New Guineans","Paraguayans","Peruvians",
                                "Poles","Portuguese","Puerto Ricans","Quebecers","Réunionnais","Romanians","Russians","Baltic Russians","Rwandans","Salvadorans","São Tomé and Príncipe","Saudis","Scots","Senegalese","Serbs","Sierra Leoneans","Singaporeans","Sindhian","Slovaks","Slovenes","Somalis","South Africans","Spaniards","Sri Lankans","St Lucians","Sudanese","Surinamese","Swedes","Swiss","Syriacs","Syrians","Taiwanese","Tajik","Tanzanians","Thais","Tibetans",
                                "Tobagonians","Trinidadians","Tunisians","Turks","Tuvaluans","Ugandans","Ukrainians","Uruguayans","Uzbeks","Vanuatuans","Venezuelans","Vietnamese","Welsh","Yemenis","Zambians","Zimbabweans"};
        public frmCustomer(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // Start the beginning process
            using (var dbContext = new tickettailor_dbEntities())
            {
                string lastCust = dbContext.customer.Select(i => i.CustID).OrderByDescending(i => i).FirstOrDefault();
                string id = Convert.ToString(Int32.Parse(lastCust.Substring(1)) + 1);
                if (id.Length == 1)
                    customerID = "C00" + id;
                else if (id.Length == 2)
                    customerID = "C0" + id;
                else
                    customerID = "C" + id;
                txtUserID.Text = customerID;
                cboGender.Items.Add("M");
                cboGender.Items.Add("F");
                cboGender.SelectedIndex = 0;
                cboNationality.DataSource = nationality.ToList();
                cboNationality.SelectedIndex = 0;

                cboCustomer.DataSource = dbContext.customer.Select(i => i.CustID).ToList();
                cboCustomer.SelectedIndex = 0;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Please enter the surname.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter the given name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtPassport.Text == "" || txtPassport.Text.Length < 8)
            {
                MessageBox.Show("Please enter the valid passport.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtContact.Text == "" || txtContact.Text.Length != 8)
            {
                MessageBox.Show("Please enter the valid contact number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MessageBox.Show("Do you confirm the above arrangement?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string lastName = txtLastname.Text; // Surname
                string firstName = txtFirstName.Text; // GivenName
                string passport = txtPassport.Text;
                string contact = txtContact.Text;

                using (var dbContext = new tickettailor_dbEntities())
                {
                    customer customer = new customer();

                    customer.CustID = txtUserID.Text;
                    customer.Surname = lastName;
                    customer.GivenName = firstName;
                    customer.DateOfBirth = dtpDob.Value;
                    customer.Gender = cboGender.Text;
                    customer.Passport = passport;
                    customer.Contact = contact;
                    customer.Nationality = cboNationality.Text;
                    dbContext.customer.Add(customer);
                    dbContext.SaveChanges();
                }
                saveData();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustConfirm_Click(object sender, EventArgs e)
        {
            customerID = ((string)cboCustomer.SelectedItem);
            saveData();
        }

        private void saveData()
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                int checkChange = 0; 
                if (((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).flightBooking != null)
                {
                    checkChange++;
                    foreach (var data in ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).flightBooking.ToList())
                    {
                        int id = data.Value.FlightOrderID;
                        flightbooking flightbooking = (from list in dbContext.flightbooking
                                                       where list.FlightOrderID == id
                                                       select list).FirstOrDefault();
                        flightbooking.CustID = customerID;
                    }
					((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).flightBooking = null;
                }

                if (((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).hotelBooking != null)
                {
                    checkChange++;
                    foreach (var data in ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).hotelBooking.ToList())
                    {
                        hotelbooking hotelbooking = data.Value;
                        hotelbooking.CustID = customerID;
                        dbContext.hotelbooking.Add(hotelbooking);
                    }
					((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).hotelBooking = null;
                }

                if (((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).attractionBooking != null)
                {
                    checkChange++;
                    int id = ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).attractionBooking.AttractionBookingID;
                    attractionbooking attractionBooking = (from list in dbContext.attractionbooking
                                                           where list.AttractionBookingID == id
                                                           select list).FirstOrDefault();
                    attractionBooking.CustID = customerID;
					((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).attractionBooking = null;
                }


                if (((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).cruiseBooking != null)
                {
                    checkChange++;
                    int id = ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).cruiseBooking.CruiseBookingID;
                    cruisebooking cruiseBooking = (from list in dbContext.cruisebooking
                                                   where list.CruiseBookingID == id
                                                   select list).FirstOrDefault();
                    cruiseBooking.CustID = customerID;
					((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).cruiseBooking = null;
                }

                if (((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).driverbooking != null)
                {
                    checkChange++;
                    foreach (var data in ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).driverbooking.ToList())
                    {
                        int id = data.Value.DriverRosterID;
                        DateTime date = data.Value.BookingDate;
                        driverbooking driverBooking = (from list in dbContext.driverbooking
                                                       where list.DriverRosterID == id && list.BookingDate == date
                                                       select list).FirstOrDefault();
                        driverBooking.CustID = customerID;
                    }
                    ((frmModuleSelection)Application.OpenForms["frmModuleSelection"]).driverbooking = null;
                }

                if (checkChange > 0)
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Confirmation Successful.", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You do not book anything, please check your bookings again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Dispose();
            }
        }
    }
}
