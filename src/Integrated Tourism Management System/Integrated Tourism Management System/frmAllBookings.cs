using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Integrated_Tourism_Management_System
{
    public partial class frmAllBookings : Form
    {
        // Form connection
        private frmModuleSelection frmModuleSelection;

        // Define the variable of the values
        double allFlightTotal;
        double allHotelTotal;
        double allCruiseTotal;
        double allAttractionTotal;
        double allVehicleTotal;
        double allEquipmentTotal;

        public frmAllBookings(frmModuleSelection frm)
        {
            // Form connection
            InitializeComponent();
            this.frmModuleSelection = frm;
        }

        private void frmAllBookings_Load(object sender, EventArgs e)
        {
            using (var dbContext = new tickettailor_dbEntities())
            {
                var cust = from list in dbContext.customer
                           select list.CustID;
                foreach (var customer in cust.ToList())
                {
                    cmbCust.Items.Add(customer);
                }
                cmbCust.SelectedIndex = 0;
            }
            showFlightBookings();
            showHotelBookings();
            showCruiseBookings();
            showAttractionBookings();
            showVehicleBookings();
            showEquipmentBookings();
        }

        private void cmbCust_SelectedValueChanged(object sender, EventArgs e)
        {
            showFlightBookings();
            showHotelBookings();
            showCruiseBookings();
            showAttractionBookings();
            showVehicleBookings();
            showEquipmentBookings();
        }

        private void showFlightBookings()
        {
            dgvFlight.Rows.Clear();
            allFlightTotal = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                double bookingTotal;
                var booking = from list in dbContext.flightbooking
                              where list.CustID.Contains((string)(cmbCust.SelectedItem)) || cmbCust.SelectedIndex == 0
                              select list;
                if (booking != null)
                {
                    foreach (var b in booking.ToList())
                    {
                        bookingTotal = (double)(b.AdultPrice + b.ChildPrice + b.InfantPrice);
                        allFlightTotal += bookingTotal;
                        dgvFlight.Rows.Add(b.FlightOrderID,
                                           b.FlightID,
                                           b.FlightNo,
                                           b.FlightClass,
                                           b.FlightType,
                                           b.AdultNum,
                                           b.ChildNum,
                                           b.InfantNum,
                                           ((double)b.AdultPrice).ToString("C2"),
                                           ((double)b.ChildPrice).ToString("C2"),
                                           ((double)b.InfantPrice).ToString("C2"),
                                           ((DateTime)b.OrderDate).ToString("yyyy-MM-dd"),
                                           b.OrderBy,
                                           b.CustID,
                                           bookingTotal.ToString("C2"));
                    }
                }
                txtFlight.Text = allFlightTotal.ToString("C2");
                showAllTotal();
            }
        }

        private void showHotelBookings()
        {
            dgvHotel.Rows.Clear();
            allHotelTotal = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var booking = from list in dbContext.hotelbooking
                              where list.CustID.Contains((string)(cmbCust.SelectedItem)) || cmbCust.SelectedIndex == 0
                              select list;
                if (booking != null)
                {
                    foreach (var b in booking.ToList())
                    {
                        allHotelTotal += (double)b.Price;
                        dgvHotel.Rows.Add(b.HotelRoomID,
                                          b.NumNight,
                                          b.NumRoom,
                                          ((DateTime)b.Checkin).ToString("yyyy-MM-dd"),
                                          ((DateTime)b.Checkout).ToString("yyyy-MM-dd"),
                                          ((DateTime)b.OrderDate).ToString("yyyy-MM-dd"),
                                          b.OrderBy,
                                          b.CustID,
                                          ((double)b.Price).ToString("C2"));
                    }
                }
                txtHotel.Text = allHotelTotal.ToString("C2");
                showAllTotal();
            }
        }

        private void showCruiseBookings()
        {
            dgvCruise.Rows.Clear();
            allCruiseTotal = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                double bookingTotal;
                var booking = from list in dbContext.cruisebooking
                              where list.CustID.Contains((string)(cmbCust.SelectedItem)) || cmbCust.SelectedIndex == 0
                              select list;
                if (booking != null)
                {
                    foreach (var b in booking.ToList())
                    {
                        bookingTotal = (double)(b.AdultPrice + b.ChildPrice);
                        allCruiseTotal += bookingTotal;
                        dgvCruise.Rows.Add(b.CruiseBookingID,
                                           b.CruiseNo,
                                           b.AdultNum,
                                           b.ChildNum,
                                           ((int)b.AdultPrice).ToString("C0"),
                                           ((int)b.ChildPrice).ToString("C0"),
                                           ((DateTime)b.OrderDate).ToString("yyyy-MM-dd"),
                                           b.OrderBy,
                                           b.CustID,
                                           bookingTotal.ToString("C2"));
                    }
                }
                txtCruise.Text = allCruiseTotal.ToString("C2");
                showAllTotal();
            }
        }

        private void showAttractionBookings()
        {
            dgvAttraction.Rows.Clear();
            allAttractionTotal = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                double bookingTotal;
                var booking = from list in dbContext.attractionbooking
                              where list.CustID.Contains((string)(cmbCust.SelectedItem)) || cmbCust.SelectedIndex == 0
                              select list;
                if (booking != null)
                {
                    foreach (var b in booking.ToList())
                    {
                        bookingTotal = (double)(b.AdultPrice + b.ChildPrice);
                        allAttractionTotal += bookingTotal;
                        dgvAttraction.Rows.Add(b.AttractionBookingID,
                                               b.AttractName,
                                               b.AdultNum,
                                               b.ChildNum,
                                               ((int)b.AdultPrice).ToString("C0"),
                                               ((int)b.ChildPrice).ToString("c0"),
                                               b.Status,
                                               ((DateTime)b.OrderDate).ToString("yyyy-MM-dd"),
                                               b.OrderBy,
                                               b.CustID,
                                               ((int)b.AdultPrice + (int)b.ChildPrice).ToString("C0"));
                    }
                }
                txtAttraction.Text = allAttractionTotal.ToString("C2");
                showAllTotal();
            }
        }

        private void showVehicleBookings()
        {
            dgvVehicle.Rows.Clear();
            allVehicleTotal = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var booking = from list in dbContext.vehiclebooking
                              where list.attractionbooking.CustID.Contains((string)(cmbCust.SelectedItem)) || cmbCust.SelectedIndex == 0
                              select list;
                if (booking != null)
                {
                    foreach (var b in booking.ToList())
                    {
                        allVehicleTotal += (double)b.VehicleBookPrice;
                        dgvVehicle.Rows.Add(b.VehicleBookingID,
                                            b.VehicleID,
                                            b.vehicle.VehicleName,
                                            b.AttractionBookingID,
                                            b.BookDay,
                                            ((DateTime)b.OrderDate).ToString("yyyy-MM-dd"),
                                            b.OrderBy,
                                            ((DateTime)b.PickupDate).ToString("yyyy-MM-dd"),
                                            ((DateTime)b.DropoffDate).ToString("yyyy-MM-dd"),
                                            b.DriverCost,
                                            ((double)b.VehicleBookPrice).ToString("C2"));
                    }
                }
                txtVehicle.Text = allVehicleTotal.ToString("C2");
                showAllTotal();
            }
        }

        private void showEquipmentBookings()
        {
            dgvEquipment.Rows.Clear();
            allEquipmentTotal = 0;
            using (var dbContext = new tickettailor_dbEntities())
            {
                var booking = from list in dbContext.equipmentlist
                              where list.vehiclebooking.attractionbooking.CustID.Contains((string)(cmbCust.SelectedItem)) || cmbCust.SelectedIndex == 0
                              select list;
                if (booking != null)
                {
                    foreach (var b in booking.ToList())
                    {
                        allEquipmentTotal += (double)b.EquipBookPrice;
                        dgvEquipment.Rows.Add(b.VehicleBookingID,
                                              b.EquipID,
                                              b.equipment.Equipment1,
                                              b.EquipNum,
                                              ((double)b.EquipBookPrice).ToString("C2"));
                    }
                }
                txtEquipment.Text = allEquipmentTotal.ToString("C2");
                showAllTotal();
            }
        }

        private void showAllTotal()
        {
            txtTicketTotal.Text = (allFlightTotal + allHotelTotal + allCruiseTotal + allAttractionTotal + allVehicleTotal + allEquipmentTotal).ToString("C2");
        }

        private void btnGenFlight_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm the above arrangement?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(@"..\Report\Flight_Booking_Confirmation_Report.pdf", FileMode.Create));
                doc.Open(); // Open document to write

                // Write some content
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("../Image/logo/logo_company.png");
                PNG.ScalePercent(25f);
                doc.Add(PNG);

                PdfPTable tableCustomer = new PdfPTable(1);
                tableCustomer.WidthPercentage = 100f;
                tableCustomer.SpacingBefore = 20f;
                PdfPCell cell = new PdfPCell(new Phrase("Customer ID: " + cmbCust.SelectedItem.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell title = new PdfPCell(new Phrase("Flight Booking Confirmation", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell info = new PdfPCell(new Phrase("Flight Booking Information including booking fees:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                cell.HorizontalAlignment = 2; // 0=Left, 1=Centre, 2=Right
                title.HorizontalAlignment = 0;
                title.BackgroundColor = new iTextSharp.text.BaseColor(169, 169, 169);
                info.HorizontalAlignment = 0;
                tableCustomer.AddCell(cell);
                tableCustomer.AddCell(title);
                tableCustomer.AddCell(info);
                doc.Add(tableCustomer);

                PdfPTable table = new PdfPTable(dgvFlight.Columns.Count);
                table.WidthPercentage = 100f;
                // Add the headers from the DGV to the table
                for (int i = 0; i < dgvFlight.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgvFlight.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                // Flag the first row as a header
                table.HeaderRows = 0;
                table.SpacingBefore = 5f;
                table.SpacingAfter = 5f;

                // Add the actual rows from the DGV to the table
                showFlightBookings();
                for (int j = 0; j < dgvFlight.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvFlight.Columns.Count; k++)
                    {
                        if (dgvFlight[k, j].Value != null)
                        {
                            table.AddCell(new Phrase(dgvFlight[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table);

                PdfPTable tableFee = new PdfPTable(1);
                tableFee.WidthPercentage = 100f;
                PdfPCell fee = new PdfPCell(new Phrase("Total fee of the Bookings: " + txtFlight.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.GREEN)));
                fee.HorizontalAlignment = 2;
                fee.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableFee.AddCell(fee);
                doc.Add(tableFee);

                // Add the above created text using different class object to pdf document
                doc.Close(); // Close document

                // Browse the pdf and show the successful message
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.WindowsDefaultBounds;
                newForm.Show();
                newForm.Name = "PDF";
                newForm.Text = "Flight Booking Confirmation Report";
                newForm.Size = new Size(600, 600);
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;

                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                pdf.Location = new System.Drawing.Point(0, 0);
                pdf.Name = "pdf";
                pdf.TabIndex = 1;
                newForm.Controls.Add(pdf);

                pdf.LoadFile(@"..\Report\Flight_Booking_Confirmation_Report.pdf");
                pdf.setView("Fit");
                pdf.Visible = true;

                MessageBox.Show("Generate PDF successful. \n Location: /Integrated Tourism Management System/bin/Report", "Generate Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenHotel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm the above arrangement?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(@"..\Report\Hotel_Booking_Confirmation_Report.pdf", FileMode.Create));
                doc.Open(); // Open document to write

                // Write some content
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("../Image/logo/logo_company.png");
                PNG.ScalePercent(25f);
                doc.Add(PNG);

                PdfPTable tableCustomer = new PdfPTable(1);
                tableCustomer.WidthPercentage = 100f;
                tableCustomer.SpacingBefore = 20f;
                PdfPCell cell = new PdfPCell(new Phrase("Customer ID: " + cmbCust.SelectedItem.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell title = new PdfPCell(new Phrase("Hotel Booking Confirmation", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell info = new PdfPCell(new Phrase("Hotel Booking Information including booking fees:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                cell.HorizontalAlignment = 2; // 0=Left, 1=Centre, 2=Right
                title.HorizontalAlignment = 0;
                title.BackgroundColor = new iTextSharp.text.BaseColor(169, 169, 169);
                info.HorizontalAlignment = 0;
                tableCustomer.AddCell(cell);
                tableCustomer.AddCell(title);
                tableCustomer.AddCell(info);
                doc.Add(tableCustomer);

                PdfPTable table = new PdfPTable(dgvHotel.Columns.Count);
                table.WidthPercentage = 100f;
                // Add the headers from the DGV to the table
                for (int i = 0; i < dgvHotel.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgvHotel.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                // Flag the first row as a header
                table.HeaderRows = 0;
                table.SpacingBefore = 5f;
                table.SpacingAfter = 5f;

                // Add the actual rows from the DGV to the table
                showHotelBookings();
                for (int j = 0; j < dgvHotel.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvHotel.Columns.Count; k++)
                    {
                        if (dgvHotel[k, j].Value != null)
                        {
                            table.AddCell(new Phrase(dgvHotel[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table);

                PdfPTable tableFee = new PdfPTable(1);
                tableFee.WidthPercentage = 100f;
                PdfPCell fee = new PdfPCell(new Phrase("Total fee of the Bookings: " + txtHotel.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.CYAN)));
                fee.HorizontalAlignment = 2;
                fee.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableFee.AddCell(fee);
                doc.Add(tableFee);

                // Add the above created text using different class object to pdf document
                doc.Close(); // Close document

                // Browse the pdf and show the successful message
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.WindowsDefaultBounds;
                newForm.Show();
                newForm.Name = "PDF";
                newForm.Text = "Hotel Booking Confirmation Report";
                newForm.Size = new Size(600, 600);
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;

                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                pdf.Location = new System.Drawing.Point(0, 0);
                pdf.Name = "pdf";
                pdf.TabIndex = 1;
                newForm.Controls.Add(pdf);

                pdf.LoadFile(@"..\Report\Hotel_Booking_Confirmation_Report.pdf");
                pdf.setView("Fit");
                pdf.Visible = true;

                MessageBox.Show("Generate PDF successful. \n Location: /Integrated Tourism Management System/bin/Report", "Generate Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenCruise_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm the above arrangement?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(@"..\Report\Cruise_Booking_Confirmation_Report.pdf", FileMode.Create));
                doc.Open(); // Open document to write

                // Write some content
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("../Image/logo/logo_company.png");
                PNG.ScalePercent(25f);
                doc.Add(PNG);

                PdfPTable tableCustomer = new PdfPTable(1);
                tableCustomer.WidthPercentage = 100f;
                tableCustomer.SpacingBefore = 20f;
                PdfPCell cell = new PdfPCell(new Phrase("Customer ID: " + cmbCust.SelectedItem.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell title = new PdfPCell(new Phrase("Cruise Booking Confirmation", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell info = new PdfPCell(new Phrase("Cruise Booking Information including booking fees:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                cell.HorizontalAlignment = 2; // 0=Left, 1=Centre, 2=Right
                title.HorizontalAlignment = 0;
                title.BackgroundColor = new iTextSharp.text.BaseColor(169, 169, 169);
                info.HorizontalAlignment = 0;
                tableCustomer.AddCell(cell);
                tableCustomer.AddCell(title);
                tableCustomer.AddCell(info);
                doc.Add(tableCustomer);

                PdfPTable table = new PdfPTable(dgvCruise.Columns.Count);
                table.WidthPercentage = 100f;
                // Add the headers from the DGV to the table
                for (int i = 0; i < dgvCruise.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgvCruise.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                // Flag the first row as a header
                table.HeaderRows = 0;
                table.SpacingBefore = 5f;
                table.SpacingAfter = 5f;

                // Add the actual rows from the DGV to the table
                showCruiseBookings();
                for (int j = 0; j < dgvCruise.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvCruise.Columns.Count; k++)
                    {
                        if (dgvCruise[k, j].Value != null)
                        {
                            table.AddCell(new Phrase(dgvCruise[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table);

                PdfPTable tableFee = new PdfPTable(1);
                tableFee.WidthPercentage = 100f;
                PdfPCell fee = new PdfPCell(new Phrase("Total fee of the Bookings: " + txtCruise.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE)));
                fee.HorizontalAlignment = 2;
                fee.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableFee.AddCell(fee);
                doc.Add(tableFee);

                // Add the above created text using different class object to pdf document
                doc.Close(); // Close document

                // Browse the pdf and show the successful message
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.WindowsDefaultBounds;
                newForm.Show();
                newForm.Name = "PDF";
                newForm.Text = "Cruise Booking Confirmation Report";
                newForm.Size = new Size(600, 600);
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;

                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                pdf.Location = new System.Drawing.Point(0, 0);
                pdf.Name = "pdf";
                pdf.TabIndex = 1;
                newForm.Controls.Add(pdf);

                pdf.LoadFile(@"..\Report\Cruise_Booking_Confirmation_Report.pdf");
                pdf.setView("Fit");
                pdf.Visible = true;

                MessageBox.Show("Generate PDF successful. \n Location: /Integrated Tourism Management System/bin/Report", "Generate Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenAttraction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm the above arrangement?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(@"..\Report\Attraction_Booking_Confirmation_Report.pdf", FileMode.Create));
                doc.Open(); // Open document to write

                // Write some content
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("../Image/logo/logo_company.png");
                PNG.ScalePercent(25f);
                doc.Add(PNG);

                PdfPTable tableCustomer = new PdfPTable(1);
                tableCustomer.WidthPercentage = 100f;
                tableCustomer.SpacingBefore = 20f;
                tableCustomer.SpacingAfter = 10f;
                PdfPCell cell = new PdfPCell(new Phrase("Customer ID: " + cmbCust.SelectedItem.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell title = new PdfPCell(new Phrase("Attraction Booking Confirmation", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell info = new PdfPCell(new Phrase("Attraction Booking Information including booking fees:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                cell.HorizontalAlignment = 2; // 0=Left, 1=Centre, 2=Right
                title.HorizontalAlignment = 0;
                title.BackgroundColor = new iTextSharp.text.BaseColor(169, 169, 169);
                info.HorizontalAlignment = 0;
                tableCustomer.AddCell(cell);
                tableCustomer.AddCell(title);
                tableCustomer.AddCell(info);
                doc.Add(tableCustomer);

                PdfPTable context1 = new PdfPTable(1);
                context1.WidthPercentage = 100f;
                PdfPCell content1 = new PdfPCell(new Phrase("Attraction booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content1.HorizontalAlignment = 0;
                context1.AddCell(content1);
                doc.Add(context1);

                PdfPTable table1 = new PdfPTable(dgvAttraction.Columns.Count);
                table1.WidthPercentage = 100f;
                // Add the headers from the DGV to the table
                for (int i = 0; i < dgvAttraction.Columns.Count; i++)
                {
                    table1.AddCell(new Phrase(dgvAttraction.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                // Flag the first row as a header
                table1.HeaderRows = 0;

                // Add the actual rows from the DGV to the table
                showAttractionBookings();
                for (int j = 0; j < dgvAttraction.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvAttraction.Columns.Count; k++)
                    {
                        if (dgvAttraction[k, j].Value != null)
                        {
                            table1.AddCell(new Phrase(dgvAttraction[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table1);

                PdfPTable tableSub1 = new PdfPTable(1);
                tableSub1.WidthPercentage = 100f;
                tableSub1.SpacingAfter = 10f;
                PdfPCell sub1 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtAttraction.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.ORANGE)));
                sub1.HorizontalAlignment = 2;
                sub1.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub1.AddCell(sub1);
                doc.Add(tableSub1);

                /* ------------------------------ Vehicle ------------------------------ */

                PdfPTable context2 = new PdfPTable(1);
                context2.WidthPercentage = 100f;
                PdfPCell content2 = new PdfPCell(new Phrase("Vehicle booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content2.HorizontalAlignment = 0;
                context2.AddCell(content2);
                doc.Add(context2);

                PdfPTable table2 = new PdfPTable(dgvVehicle.Columns.Count);
                table2.WidthPercentage = 100f;
                // Add the headers from the DGV to the table
                for (int i = 0; i < dgvVehicle.Columns.Count; i++)
                {
                    table2.AddCell(new Phrase(dgvVehicle.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }

                // Flag the first row as a header
                table2.HeaderRows = 0;

                // Add the actual rows from the DGV to the table
                showVehicleBookings();
                for (int j = 0; j < dgvVehicle.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvVehicle.Columns.Count; k++)
                    {
                        if (dgvVehicle[k, j].Value != null)
                        {
                            table2.AddCell(new Phrase(dgvVehicle[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table2);

                PdfPTable tableSub2 = new PdfPTable(1);
                tableSub2.WidthPercentage = 100f;
                tableSub2.SpacingAfter = 10f;
                PdfPCell sub2 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtVehicle.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE)));
                sub2.HorizontalAlignment = 2;
                sub2.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub2.AddCell(sub2);
                doc.Add(tableSub2);

                /* ------------------------------ Equipment ------------------------------ */

                PdfPTable context3 = new PdfPTable(1);
                context3.WidthPercentage = 100f;
                PdfPCell content3 = new PdfPCell(new Phrase("Equipment booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content3.HorizontalAlignment = 0;
                context3.AddCell(content3);
                doc.Add(context3);

                PdfPTable table3 = new PdfPTable(dgvEquipment.Columns.Count);
                table3.WidthPercentage = 100f;
                // Add the headers from the DGV to the table
                for (int i = 0; i < dgvEquipment.Columns.Count; i++)
                {
                    table3.AddCell(new Phrase(dgvEquipment.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                // Flag the first row as a header
                table3.HeaderRows = 0;

                // Add the actual rows from the DGV to the table
                showEquipmentBookings();
                for (int j = 0; j < dgvEquipment.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvEquipment.Columns.Count; k++)
                    {
                        if (dgvEquipment[k, j].Value != null)
                        {
                            table3.AddCell(new Phrase(dgvEquipment[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table3);

                PdfPTable tableSub3 = new PdfPTable(1);
                tableSub3.WidthPercentage = 100f;
                tableSub3.SpacingAfter = 10f;
                PdfPCell sub3 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtEquipment.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.YELLOW)));
                sub3.HorizontalAlignment = 2;
                sub3.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub3.AddCell(sub3);
                doc.Add(tableSub3);

                /* ------------------------------ Total ------------------------------ */

                PdfPTable tableFee = new PdfPTable(1);
                tableFee.WidthPercentage = 100f;
                tableFee.SpacingBefore = 5f;
                double priceAttraction = double.Parse(txtAttraction.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceVehicle = double.Parse(txtVehicle.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceEquipment = double.Parse(txtEquipment.Text.ToString(), System.Globalization.NumberStyles.Currency);
                PdfPCell fee = new PdfPCell(new Phrase("Total fee of the Bookings: " + (priceAttraction + priceVehicle + priceEquipment).ToString("C2"), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.PINK)));
                fee.HorizontalAlignment = 2;
                fee.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableFee.AddCell(fee);
                doc.Add(tableFee);

                // Add the above created text using different class object to pdf document
                doc.Close(); // Close document

                // Browse the pdf and show the successful message
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.WindowsDefaultBounds;
                newForm.Show();
                newForm.Name = "PDF";
                newForm.Text = "Attraction Booking Confirmation Report";
                newForm.Size = new Size(600, 600);
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;

                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                pdf.Location = new System.Drawing.Point(0, 0);
                pdf.Name = "pdf";
                pdf.TabIndex = 1;
                newForm.Controls.Add(pdf);

                pdf.LoadFile(@"..\Report\Attraction_Booking_Confirmation_Report.pdf");
                pdf.setView("Fit");
                pdf.Visible = true;

                MessageBox.Show("Generate PDF successful. \n Location: /Integrated Tourism Management System/bin/Report", "Generate Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you confirm the above arrangement?", "Confirm Arrangement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(@"..\Report\All_Booking_Confirmation_Report.pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("../Image/logo/logo_company.png");
                PNG.ScalePercent(25f);
                doc.Add(PNG);

                PdfPTable tableCustomer = new PdfPTable(1);
                tableCustomer.WidthPercentage = 100f;
                tableCustomer.SpacingBefore = 20f;
                tableCustomer.SpacingAfter = 10f;
                PdfPCell cell = new PdfPCell(new Phrase("Customer ID: " + cmbCust.SelectedItem.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell title = new PdfPCell(new Phrase("All Booking Confirmation", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                PdfPCell info = new PdfPCell(new Phrase("All Booking Information including booking fees:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                cell.HorizontalAlignment = 2;
                title.HorizontalAlignment = 0;
                title.BackgroundColor = new iTextSharp.text.BaseColor(169, 169, 169);
                info.HorizontalAlignment = 0;
                tableCustomer.AddCell(cell);
                tableCustomer.AddCell(title);
                tableCustomer.AddCell(info);
                doc.Add(tableCustomer);

                /* ------------------------------ Flight ------------------------------ */

                PdfPTable context1 = new PdfPTable(1);
                context1.WidthPercentage = 100f;
                PdfPCell content1 = new PdfPCell(new Phrase("Flight booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content1.HorizontalAlignment = 0;
                context1.AddCell(content1);
                doc.Add(context1);

                PdfPTable table1 = new PdfPTable(dgvFlight.Columns.Count);
                table1.WidthPercentage = 100f;
                for (int i = 0; i < dgvFlight.Columns.Count; i++)
                {
                    table1.AddCell(new Phrase(dgvFlight.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                table1.HeaderRows = 0;

                showFlightBookings();
                for (int j = 0; j < dgvFlight.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvFlight.Columns.Count; k++)
                    {
                        if (dgvFlight[k, j].Value != null)
                        {
                            table1.AddCell(new Phrase(dgvFlight[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table1);

                PdfPTable tableSub1 = new PdfPTable(1);
                tableSub1.WidthPercentage = 100f;
                tableSub1.SpacingAfter = 10f;
                PdfPCell sub1 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtFlight.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.GREEN)));
                sub1.HorizontalAlignment = 2;
                sub1.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub1.AddCell(sub1);
                doc.Add(tableSub1);

                /* ------------------------------ Hotel ------------------------------ */

                PdfPTable context2 = new PdfPTable(1);
                context2.WidthPercentage = 100f;
                PdfPCell content2 = new PdfPCell(new Phrase("Hotel booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content2.HorizontalAlignment = 0;
                context2.AddCell(content2);
                doc.Add(context2);

                PdfPTable table2 = new PdfPTable(dgvHotel.Columns.Count);
                table2.WidthPercentage = 100f;
                for (int i = 0; i < dgvHotel.Columns.Count; i++)
                {
                    table2.AddCell(new Phrase(dgvHotel.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                table2.HeaderRows = 0;

                showHotelBookings();
                for (int j = 0; j < dgvHotel.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvHotel.Columns.Count; k++)
                    {
                        if (dgvHotel[k, j].Value != null)
                        {
                            table2.AddCell(new Phrase(dgvHotel[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table2);

                PdfPTable tableSub2 = new PdfPTable(1);
                tableSub2.WidthPercentage = 100f;
                tableSub2.SpacingAfter = 10f;
                PdfPCell sub2 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtHotel.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.CYAN)));
                sub2.HorizontalAlignment = 2;
                sub2.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub2.AddCell(sub2);
                doc.Add(tableSub2);

                /* ------------------------------ Cruise ------------------------------ */

                PdfPTable context3 = new PdfPTable(1);
                context3.WidthPercentage = 100f;
                PdfPCell content3 = new PdfPCell(new Phrase("Cruise booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content3.HorizontalAlignment = 0;
                context3.AddCell(content3);
                doc.Add(context3);

                PdfPTable table3 = new PdfPTable(dgvCruise.Columns.Count);
                table3.WidthPercentage = 100f;
                for (int i = 0; i < dgvCruise.Columns.Count; i++)
                {
                    table3.AddCell(new Phrase(dgvCruise.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                table3.HeaderRows = 0;

                showCruiseBookings();
                for (int j = 0; j < dgvCruise.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvCruise.Columns.Count; k++)
                    {
                        if (dgvCruise[k, j].Value != null)
                        {
                            table3.AddCell(new Phrase(dgvCruise[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table3);

                PdfPTable tableSub3 = new PdfPTable(1);
                tableSub3.WidthPercentage = 100f;
                tableSub3.SpacingAfter = 10f;
                PdfPCell sub3 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtCruise.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE)));
                sub3.HorizontalAlignment = 2;
                sub3.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub3.AddCell(sub3);
                doc.Add(tableSub3);

                /* ------------------------------ Attraction ------------------------------ */

                PdfPTable context4 = new PdfPTable(1);
                context4.WidthPercentage = 100f;
                PdfPCell content4 = new PdfPCell(new Phrase("Attraction booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content4.HorizontalAlignment = 0;
                context4.AddCell(content4);
                doc.Add(context4);

                PdfPTable table4 = new PdfPTable(dgvAttraction.Columns.Count);
                table4.WidthPercentage = 100f;
                for (int i = 0; i < dgvAttraction.Columns.Count; i++)
                {
                    table4.AddCell(new Phrase(dgvAttraction.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                table4.HeaderRows = 0;

                showAttractionBookings();
                for (int j = 0; j < dgvAttraction.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvAttraction.Columns.Count; k++)
                    {
                        if (dgvAttraction[k, j].Value != null)
                        {
                            table4.AddCell(new Phrase(dgvAttraction[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table4);

                PdfPTable tableSub4 = new PdfPTable(1);
                tableSub4.WidthPercentage = 100f;
                tableSub4.SpacingAfter = 10f;
                PdfPCell sub4 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtAttraction.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.ORANGE)));
                sub4.HorizontalAlignment = 2;
                sub4.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub4.AddCell(sub4);
                doc.Add(tableSub4);

                /* ------------------------------ Vehicle ------------------------------ */

                PdfPTable context5 = new PdfPTable(1);
                context5.WidthPercentage = 100f;
                PdfPCell content5 = new PdfPCell(new Phrase("Vehicle booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content5.HorizontalAlignment = 0;
                context5.AddCell(content5);
                doc.Add(context5);

                PdfPTable table5 = new PdfPTable(dgvVehicle.Columns.Count);
                table5.WidthPercentage = 100f;
                for (int i = 0; i < dgvVehicle.Columns.Count; i++)
                {
                    table5.AddCell(new Phrase(dgvVehicle.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                table5.HeaderRows = 0;

                showVehicleBookings();
                for (int j = 0; j < dgvVehicle.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvVehicle.Columns.Count; k++)
                    {
                        if (dgvVehicle[k, j].Value != null)
                        {
                            table5.AddCell(new Phrase(dgvVehicle[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table5);

                PdfPTable tableSub5 = new PdfPTable(1);
                tableSub5.WidthPercentage = 100f;
                tableSub5.SpacingAfter = 10f;
                PdfPCell sub5 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtVehicle.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE)));
                sub5.HorizontalAlignment = 2;
                sub5.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub5.AddCell(sub5);
                doc.Add(tableSub5);

                /* ------------------------------ Equipment ------------------------------ */

                PdfPTable context6 = new PdfPTable(1);
                context6.WidthPercentage = 100f;
                PdfPCell content6 = new PdfPCell(new Phrase("Equipment booking payment:", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                content6.HorizontalAlignment = 0;
                context6.AddCell(content3);
                doc.Add(context6);

                PdfPTable table6 = new PdfPTable(dgvEquipment.Columns.Count);
                table6.WidthPercentage = 100f;
                for (int i = 0; i < dgvEquipment.Columns.Count; i++)
                {
                    table6.AddCell(new Phrase(dgvEquipment.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                }
                table6.HeaderRows = 0;

                showEquipmentBookings();
                for (int j = 0; j < dgvEquipment.Rows.Count; j++)
                {
                    for (int k = 0; k < dgvEquipment.Columns.Count; k++)
                    {
                        if (dgvEquipment[k, j].Value != null)
                        {
                            table6.AddCell(new Phrase(dgvEquipment[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        }
                    }
                }
                doc.Add(table6);

                PdfPTable tableSub6 = new PdfPTable(1);
                tableSub6.WidthPercentage = 100f;
                tableSub6.SpacingAfter = 10f;
                PdfPCell sub6 = new PdfPCell(new Phrase("SubTotal of the bookings: " + txtEquipment.Text.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.YELLOW)));
                sub6.HorizontalAlignment = 2;
                sub6.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableSub6.AddCell(sub6);
                doc.Add(tableSub6);

                /* ------------------------------ Total ------------------------------ */

                PdfPTable tableFee = new PdfPTable(1);
                tableFee.WidthPercentage = 100f;
                tableFee.SpacingBefore = 5f;
                double priceFlight = double.Parse(txtFlight.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceHotel = double.Parse(txtHotel.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceCruise = double.Parse(txtCruise.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceAttraction = double.Parse(txtAttraction.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceVehicle = double.Parse(txtVehicle.Text.ToString(), System.Globalization.NumberStyles.Currency);
                double priceEquipment = double.Parse(txtEquipment.Text.ToString(), System.Globalization.NumberStyles.Currency);
                PdfPCell fee = new PdfPCell(new Phrase("Total fee of the Bookings: " + (priceFlight + priceHotel + priceCruise + priceAttraction + priceVehicle + priceEquipment).ToString("C2"), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.PINK)));
                fee.HorizontalAlignment = 2;
                fee.BackgroundColor = new iTextSharp.text.BaseColor(105, 105, 105);
                tableFee.AddCell(fee);
                doc.Add(tableFee);

                doc.Close();
                Form newForm = new Form();
                newForm.StartPosition = FormStartPosition.WindowsDefaultBounds;
                newForm.Show();
                newForm.Name = "PDF";
                newForm.Text = "All Booking Confirmation Report";
                newForm.Size = new Size(600, 600);
                Icon icon = new Icon(@"..\Image\icon\icon_tt.ico");
                newForm.Icon = icon;
                newForm.ShowIcon = true;

                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                pdf.Location = new System.Drawing.Point(0, 0);
                pdf.Name = "pdf";
                pdf.TabIndex = 1;
                newForm.Controls.Add(pdf);

                pdf.LoadFile(@"..\Report\All_Booking_Confirmation_Report.pdf");
                pdf.setView("Fit");
                pdf.Visible = true;

                MessageBox.Show("Generate PDF successful. \n Location: /Integrated Tourism Management System/bin/Report", "Generate Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
