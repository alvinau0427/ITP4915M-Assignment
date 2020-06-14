namespace Integrated_Tourism_Management_System
{
    partial class frmAllBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllBookings));
            this.grpGenerate = new System.Windows.Forms.GroupBox();
            this.btnGenAttraction = new System.Windows.Forms.Button();
            this.btnGenCruise = new System.Windows.Forms.Button();
            this.btnGenHotel = new System.Windows.Forms.Button();
            this.btnGenFlight = new System.Windows.Forms.Button();
            this.tabRecord = new System.Windows.Forms.TabControl();
            this.tabFlight = new System.Windows.Forms.TabPage();
            this.dgvFlight = new System.Windows.Forms.DataGridView();
            this.FlightOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightAdultNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightChildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightInfantNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightAdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightInfantPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFlight = new System.Windows.Forms.TextBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.tabHotel = new System.Windows.Forms.TabPage();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.HotelRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.tabCurise = new System.Windows.Forms.TabPage();
            this.dgvCruise = new System.Windows.Forms.DataGridView();
            this.CruiseBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseAdultNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseChildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseAdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCruise = new System.Windows.Forms.TextBox();
            this.lblCruise = new System.Windows.Forms.Label();
            this.tabAttraction = new System.Windows.Forms.TabPage();
            this.dgvAttraction = new System.Windows.Forms.DataGridView();
            this.AttractionBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionAdultNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionChildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionAdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAttraction = new System.Windows.Forms.TextBox();
            this.lblAttraction = new System.Windows.Forms.Label();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.VehicleBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleBookDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehiclePickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleDropoffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverRosterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.tabEquipment = new System.Windows.Forms.TabPage();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.VehicleBookingsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.lblEquipmentTotal = new System.Windows.Forms.Label();
            this.txtTicketTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbCust = new System.Windows.Forms.ComboBox();
            this.lblCustNo = new System.Windows.Forms.Label();
            this.btnGenAll = new System.Windows.Forms.Button();
            this.grpGenerate.SuspendLayout();
            this.tabRecord.SuspendLayout();
            this.tabFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).BeginInit();
            this.tabHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.tabCurise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruise)).BeginInit();
            this.tabAttraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttraction)).BeginInit();
            this.tabVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.tabEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGenerate
            // 
            this.grpGenerate.Controls.Add(this.btnGenAll);
            this.grpGenerate.Controls.Add(this.btnGenAttraction);
            this.grpGenerate.Controls.Add(this.btnGenCruise);
            this.grpGenerate.Controls.Add(this.btnGenHotel);
            this.grpGenerate.Controls.Add(this.btnGenFlight);
            this.grpGenerate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenerate.Location = new System.Drawing.Point(12, 88);
            this.grpGenerate.Name = "grpGenerate";
            this.grpGenerate.Size = new System.Drawing.Size(920, 82);
            this.grpGenerate.TabIndex = 7;
            this.grpGenerate.TabStop = false;
            this.grpGenerate.Text = "Generate PDF report for the reservation records";
            // 
            // btnGenAttraction
            // 
            this.btnGenAttraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenAttraction.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnGenAttraction.Location = new System.Drawing.Point(571, 30);
            this.btnGenAttraction.Name = "btnGenAttraction";
            this.btnGenAttraction.Size = new System.Drawing.Size(146, 41);
            this.btnGenAttraction.TabIndex = 28;
            this.btnGenAttraction.Text = "Attraction Booking";
            this.btnGenAttraction.UseVisualStyleBackColor = true;
            this.btnGenAttraction.Click += new System.EventHandler(this.btnGenAttraction_Click);
            // 
            // btnGenCruise
            // 
            this.btnGenCruise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenCruise.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnGenCruise.Location = new System.Drawing.Point(387, 30);
            this.btnGenCruise.Name = "btnGenCruise";
            this.btnGenCruise.Size = new System.Drawing.Size(146, 41);
            this.btnGenCruise.TabIndex = 27;
            this.btnGenCruise.Text = "Cruise Booking";
            this.btnGenCruise.UseVisualStyleBackColor = true;
            this.btnGenCruise.Click += new System.EventHandler(this.btnGenCruise_Click);
            // 
            // btnGenHotel
            // 
            this.btnGenHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenHotel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnGenHotel.Location = new System.Drawing.Point(203, 30);
            this.btnGenHotel.Name = "btnGenHotel";
            this.btnGenHotel.Size = new System.Drawing.Size(146, 41);
            this.btnGenHotel.TabIndex = 26;
            this.btnGenHotel.Text = "Hotel Reservation";
            this.btnGenHotel.UseVisualStyleBackColor = true;
            this.btnGenHotel.Click += new System.EventHandler(this.btnGenHotel_Click);
            // 
            // btnGenFlight
            // 
            this.btnGenFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenFlight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenFlight.Location = new System.Drawing.Point(19, 30);
            this.btnGenFlight.Name = "btnGenFlight";
            this.btnGenFlight.Size = new System.Drawing.Size(146, 41);
            this.btnGenFlight.TabIndex = 25;
            this.btnGenFlight.Text = "Flight Order";
            this.btnGenFlight.UseVisualStyleBackColor = true;
            this.btnGenFlight.Click += new System.EventHandler(this.btnGenFlight_Click);
            // 
            // tabRecord
            // 
            this.tabRecord.Controls.Add(this.tabFlight);
            this.tabRecord.Controls.Add(this.tabHotel);
            this.tabRecord.Controls.Add(this.tabCurise);
            this.tabRecord.Controls.Add(this.tabAttraction);
            this.tabRecord.Controls.Add(this.tabVehicle);
            this.tabRecord.Controls.Add(this.tabEquipment);
            this.tabRecord.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabRecord.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecord.Location = new System.Drawing.Point(12, 176);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.SelectedIndex = 0;
            this.tabRecord.Size = new System.Drawing.Size(920, 441);
            this.tabRecord.TabIndex = 8;
            // 
            // tabFlight
            // 
            this.tabFlight.BackColor = System.Drawing.Color.LightGray;
            this.tabFlight.Controls.Add(this.dgvFlight);
            this.tabFlight.Controls.Add(this.txtFlight);
            this.tabFlight.Controls.Add(this.lblFlight);
            this.tabFlight.Location = new System.Drawing.Point(4, 27);
            this.tabFlight.Name = "tabFlight";
            this.tabFlight.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlight.Size = new System.Drawing.Size(912, 410);
            this.tabFlight.TabIndex = 0;
            this.tabFlight.Text = "Flight Booking Details";
            // 
            // dgvFlight
            // 
            this.dgvFlight.AllowUserToAddRows = false;
            this.dgvFlight.AllowUserToDeleteRows = false;
            this.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightOrderID,
            this.FlightID,
            this.FlightNo,
            this.FlightClass,
            this.FlightType,
            this.FlightAdultNum,
            this.FlightChildNum,
            this.FlightInfantNum,
            this.FlightAdultPrice,
            this.FlightChildPrice,
            this.FlightInfantPrice,
            this.FlightOrderDate,
            this.FlightOrderBy,
            this.FlightCustID,
            this.FlightTotalPrice});
            this.dgvFlight.Location = new System.Drawing.Point(6, 6);
            this.dgvFlight.Name = "dgvFlight";
            this.dgvFlight.ReadOnly = true;
            this.dgvFlight.RowTemplate.Height = 24;
            this.dgvFlight.Size = new System.Drawing.Size(900, 366);
            this.dgvFlight.TabIndex = 86;
            // 
            // FlightOrderID
            // 
            this.FlightOrderID.HeaderText = "Flight Order ID";
            this.FlightOrderID.Name = "FlightOrderID";
            this.FlightOrderID.ReadOnly = true;
            // 
            // FlightID
            // 
            this.FlightID.HeaderText = "Flight Schedule ID";
            this.FlightID.Name = "FlightID";
            this.FlightID.ReadOnly = true;
            // 
            // FlightNo
            // 
            this.FlightNo.HeaderText = "Flight Class No";
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // FlightClass
            // 
            this.FlightClass.HeaderText = "Flight Class Type";
            this.FlightClass.Name = "FlightClass";
            this.FlightClass.ReadOnly = true;
            // 
            // FlightType
            // 
            this.FlightType.HeaderText = "Flight Type";
            this.FlightType.Name = "FlightType";
            this.FlightType.ReadOnly = true;
            // 
            // FlightAdultNum
            // 
            this.FlightAdultNum.HeaderText = "Adult Num";
            this.FlightAdultNum.Name = "FlightAdultNum";
            this.FlightAdultNum.ReadOnly = true;
            // 
            // FlightChildNum
            // 
            this.FlightChildNum.HeaderText = "Child Num";
            this.FlightChildNum.Name = "FlightChildNum";
            this.FlightChildNum.ReadOnly = true;
            // 
            // FlightInfantNum
            // 
            this.FlightInfantNum.HeaderText = "Infant Num";
            this.FlightInfantNum.Name = "FlightInfantNum";
            this.FlightInfantNum.ReadOnly = true;
            // 
            // FlightAdultPrice
            // 
            this.FlightAdultPrice.HeaderText = "Adult Total Price";
            this.FlightAdultPrice.Name = "FlightAdultPrice";
            this.FlightAdultPrice.ReadOnly = true;
            // 
            // FlightChildPrice
            // 
            this.FlightChildPrice.HeaderText = "Child Total Price";
            this.FlightChildPrice.Name = "FlightChildPrice";
            this.FlightChildPrice.ReadOnly = true;
            // 
            // FlightInfantPrice
            // 
            this.FlightInfantPrice.HeaderText = "Infant Total Price";
            this.FlightInfantPrice.Name = "FlightInfantPrice";
            this.FlightInfantPrice.ReadOnly = true;
            // 
            // FlightOrderDate
            // 
            this.FlightOrderDate.HeaderText = "Order Date";
            this.FlightOrderDate.Name = "FlightOrderDate";
            this.FlightOrderDate.ReadOnly = true;
            // 
            // FlightOrderBy
            // 
            this.FlightOrderBy.HeaderText = "Order By";
            this.FlightOrderBy.Name = "FlightOrderBy";
            this.FlightOrderBy.ReadOnly = true;
            // 
            // FlightCustID
            // 
            this.FlightCustID.HeaderText = "Cust ID";
            this.FlightCustID.Name = "FlightCustID";
            this.FlightCustID.ReadOnly = true;
            // 
            // FlightTotalPrice
            // 
            this.FlightTotalPrice.HeaderText = "Total Price";
            this.FlightTotalPrice.Name = "FlightTotalPrice";
            this.FlightTotalPrice.ReadOnly = true;
            // 
            // txtFlight
            // 
            this.txtFlight.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFlight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlight.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtFlight.Location = new System.Drawing.Point(728, 377);
            this.txtFlight.Name = "txtFlight";
            this.txtFlight.ReadOnly = true;
            this.txtFlight.Size = new System.Drawing.Size(178, 27);
            this.txtFlight.TabIndex = 84;
            this.txtFlight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.Location = new System.Drawing.Point(556, 385);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(166, 19);
            this.lblFlight.TabIndex = 83;
            this.lblFlight.Text = "Flight Booking Subtotal :";
            // 
            // tabHotel
            // 
            this.tabHotel.BackColor = System.Drawing.Color.LightGray;
            this.tabHotel.Controls.Add(this.dgvHotel);
            this.tabHotel.Controls.Add(this.txtHotel);
            this.tabHotel.Controls.Add(this.lblHotel);
            this.tabHotel.Location = new System.Drawing.Point(4, 27);
            this.tabHotel.Name = "tabHotel";
            this.tabHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotel.Size = new System.Drawing.Size(912, 410);
            this.tabHotel.TabIndex = 1;
            this.tabHotel.Text = "Hotel Booking Details";
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.AllowUserToDeleteRows = false;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelRoomID,
            this.NumNight,
            this.NumRoom,
            this.Checkin,
            this.Checkout,
            this.HotelOrderDate,
            this.HotelOrderBy,
            this.HotelCustID,
            this.HotelTotalPrice});
            this.dgvHotel.Location = new System.Drawing.Point(6, 6);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.ReadOnly = true;
            this.dgvHotel.RowTemplate.Height = 24;
            this.dgvHotel.Size = new System.Drawing.Size(900, 365);
            this.dgvHotel.TabIndex = 89;
            // 
            // HotelRoomID
            // 
            this.HotelRoomID.HeaderText = "Hotel Room ID";
            this.HotelRoomID.Name = "HotelRoomID";
            this.HotelRoomID.ReadOnly = true;
            // 
            // NumNight
            // 
            this.NumNight.HeaderText = "Num Night";
            this.NumNight.Name = "NumNight";
            this.NumNight.ReadOnly = true;
            // 
            // NumRoom
            // 
            this.NumRoom.HeaderText = "Num Room";
            this.NumRoom.Name = "NumRoom";
            this.NumRoom.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.HeaderText = "Check in Date";
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.HeaderText = "Check out Date";
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // HotelOrderDate
            // 
            this.HotelOrderDate.HeaderText = "Order Date";
            this.HotelOrderDate.Name = "HotelOrderDate";
            this.HotelOrderDate.ReadOnly = true;
            // 
            // HotelOrderBy
            // 
            this.HotelOrderBy.HeaderText = "Order By";
            this.HotelOrderBy.Name = "HotelOrderBy";
            this.HotelOrderBy.ReadOnly = true;
            // 
            // HotelCustID
            // 
            this.HotelCustID.HeaderText = "Cust ID";
            this.HotelCustID.Name = "HotelCustID";
            this.HotelCustID.ReadOnly = true;
            // 
            // HotelTotalPrice
            // 
            this.HotelTotalPrice.HeaderText = "Total Price";
            this.HotelTotalPrice.Name = "HotelTotalPrice";
            this.HotelTotalPrice.ReadOnly = true;
            // 
            // txtHotel
            // 
            this.txtHotel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHotel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotel.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtHotel.Location = new System.Drawing.Point(728, 377);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.ReadOnly = true;
            this.txtHotel.Size = new System.Drawing.Size(178, 27);
            this.txtHotel.TabIndex = 87;
            this.txtHotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline);
            this.lblHotel.Location = new System.Drawing.Point(557, 385);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(165, 19);
            this.lblHotel.TabIndex = 86;
            this.lblHotel.Text = "Hotel Booking Subtotal :";
            // 
            // tabCurise
            // 
            this.tabCurise.BackColor = System.Drawing.Color.LightGray;
            this.tabCurise.Controls.Add(this.dgvCruise);
            this.tabCurise.Controls.Add(this.txtCruise);
            this.tabCurise.Controls.Add(this.lblCruise);
            this.tabCurise.Location = new System.Drawing.Point(4, 27);
            this.tabCurise.Name = "tabCurise";
            this.tabCurise.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurise.Size = new System.Drawing.Size(912, 410);
            this.tabCurise.TabIndex = 2;
            this.tabCurise.Text = "Cruise Booking Details";
            // 
            // dgvCruise
            // 
            this.dgvCruise.AllowUserToAddRows = false;
            this.dgvCruise.AllowUserToDeleteRows = false;
            this.dgvCruise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCruise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CruiseBookingID,
            this.CruiseNo,
            this.CruiseAdultNum,
            this.CruiseChildNum,
            this.CruiseAdultPrice,
            this.CruiseChildPrice,
            this.CruiseOrderDate,
            this.CruiseOrderBy,
            this.CruiseCustID,
            this.CruiseTotalPrice});
            this.dgvCruise.Location = new System.Drawing.Point(6, 6);
            this.dgvCruise.Name = "dgvCruise";
            this.dgvCruise.ReadOnly = true;
            this.dgvCruise.RowTemplate.Height = 24;
            this.dgvCruise.Size = new System.Drawing.Size(900, 365);
            this.dgvCruise.TabIndex = 92;
            // 
            // CruiseBookingID
            // 
            this.CruiseBookingID.HeaderText = "Cruise Booking ID";
            this.CruiseBookingID.Name = "CruiseBookingID";
            this.CruiseBookingID.ReadOnly = true;
            // 
            // CruiseNo
            // 
            this.CruiseNo.HeaderText = "Cruise No";
            this.CruiseNo.Name = "CruiseNo";
            this.CruiseNo.ReadOnly = true;
            // 
            // CruiseAdultNum
            // 
            this.CruiseAdultNum.HeaderText = "Adult Num";
            this.CruiseAdultNum.Name = "CruiseAdultNum";
            this.CruiseAdultNum.ReadOnly = true;
            // 
            // CruiseChildNum
            // 
            this.CruiseChildNum.HeaderText = "Child Num";
            this.CruiseChildNum.Name = "CruiseChildNum";
            this.CruiseChildNum.ReadOnly = true;
            // 
            // CruiseAdultPrice
            // 
            this.CruiseAdultPrice.HeaderText = "Adult Price";
            this.CruiseAdultPrice.Name = "CruiseAdultPrice";
            this.CruiseAdultPrice.ReadOnly = true;
            // 
            // CruiseChildPrice
            // 
            this.CruiseChildPrice.HeaderText = "Child Price";
            this.CruiseChildPrice.Name = "CruiseChildPrice";
            this.CruiseChildPrice.ReadOnly = true;
            // 
            // CruiseOrderDate
            // 
            this.CruiseOrderDate.HeaderText = "Order Date";
            this.CruiseOrderDate.Name = "CruiseOrderDate";
            this.CruiseOrderDate.ReadOnly = true;
            // 
            // CruiseOrderBy
            // 
            this.CruiseOrderBy.HeaderText = "Order By";
            this.CruiseOrderBy.Name = "CruiseOrderBy";
            this.CruiseOrderBy.ReadOnly = true;
            // 
            // CruiseCustID
            // 
            this.CruiseCustID.HeaderText = "Cust ID";
            this.CruiseCustID.Name = "CruiseCustID";
            this.CruiseCustID.ReadOnly = true;
            // 
            // CruiseTotalPrice
            // 
            this.CruiseTotalPrice.HeaderText = "Total Price";
            this.CruiseTotalPrice.Name = "CruiseTotalPrice";
            this.CruiseTotalPrice.ReadOnly = true;
            // 
            // txtCruise
            // 
            this.txtCruise.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCruise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCruise.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCruise.Location = new System.Drawing.Point(728, 377);
            this.txtCruise.Name = "txtCruise";
            this.txtCruise.ReadOnly = true;
            this.txtCruise.Size = new System.Drawing.Size(178, 27);
            this.txtCruise.TabIndex = 90;
            this.txtCruise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCruise
            // 
            this.lblCruise.AutoSize = true;
            this.lblCruise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline);
            this.lblCruise.Location = new System.Drawing.Point(551, 385);
            this.lblCruise.Name = "lblCruise";
            this.lblCruise.Size = new System.Drawing.Size(171, 19);
            this.lblCruise.TabIndex = 89;
            this.lblCruise.Text = "Cruise Booking Subtotal :";
            // 
            // tabAttraction
            // 
            this.tabAttraction.BackColor = System.Drawing.Color.LightGray;
            this.tabAttraction.Controls.Add(this.dgvAttraction);
            this.tabAttraction.Controls.Add(this.txtAttraction);
            this.tabAttraction.Controls.Add(this.lblAttraction);
            this.tabAttraction.Location = new System.Drawing.Point(4, 27);
            this.tabAttraction.Name = "tabAttraction";
            this.tabAttraction.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttraction.Size = new System.Drawing.Size(912, 410);
            this.tabAttraction.TabIndex = 3;
            this.tabAttraction.Text = "Attraction Booking Details";
            // 
            // dgvAttraction
            // 
            this.dgvAttraction.AllowUserToAddRows = false;
            this.dgvAttraction.AllowUserToDeleteRows = false;
            this.dgvAttraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttraction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractionBookingID,
            this.AttractName,
            this.AttractionAdultNum,
            this.AttractionChildNum,
            this.AttractionAdultPrice,
            this.AttractionChildPrice,
            this.Status,
            this.AttractionOrderDate,
            this.AttractionOrderBy,
            this.AttractionCustID,
            this.AttractionTotalPrice});
            this.dgvAttraction.Location = new System.Drawing.Point(6, 6);
            this.dgvAttraction.Name = "dgvAttraction";
            this.dgvAttraction.ReadOnly = true;
            this.dgvAttraction.RowTemplate.Height = 24;
            this.dgvAttraction.Size = new System.Drawing.Size(900, 365);
            this.dgvAttraction.TabIndex = 94;
            // 
            // AttractionBookingID
            // 
            this.AttractionBookingID.HeaderText = "Attraction Booking ID";
            this.AttractionBookingID.Name = "AttractionBookingID";
            this.AttractionBookingID.ReadOnly = true;
            // 
            // AttractName
            // 
            this.AttractName.HeaderText = "Attraction Name";
            this.AttractName.Name = "AttractName";
            this.AttractName.ReadOnly = true;
            // 
            // AttractionAdultNum
            // 
            this.AttractionAdultNum.HeaderText = "Adult Num";
            this.AttractionAdultNum.Name = "AttractionAdultNum";
            this.AttractionAdultNum.ReadOnly = true;
            // 
            // AttractionChildNum
            // 
            this.AttractionChildNum.HeaderText = "Child Num";
            this.AttractionChildNum.Name = "AttractionChildNum";
            this.AttractionChildNum.ReadOnly = true;
            // 
            // AttractionAdultPrice
            // 
            this.AttractionAdultPrice.HeaderText = "Adult Price";
            this.AttractionAdultPrice.Name = "AttractionAdultPrice";
            this.AttractionAdultPrice.ReadOnly = true;
            // 
            // AttractionChildPrice
            // 
            this.AttractionChildPrice.HeaderText = "Child Price";
            this.AttractionChildPrice.Name = "AttractionChildPrice";
            this.AttractionChildPrice.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // AttractionOrderDate
            // 
            this.AttractionOrderDate.HeaderText = "Order Date";
            this.AttractionOrderDate.Name = "AttractionOrderDate";
            this.AttractionOrderDate.ReadOnly = true;
            // 
            // AttractionOrderBy
            // 
            this.AttractionOrderBy.HeaderText = "Order By";
            this.AttractionOrderBy.Name = "AttractionOrderBy";
            this.AttractionOrderBy.ReadOnly = true;
            // 
            // AttractionCustID
            // 
            this.AttractionCustID.HeaderText = "Cust ID";
            this.AttractionCustID.Name = "AttractionCustID";
            this.AttractionCustID.ReadOnly = true;
            // 
            // AttractionTotalPrice
            // 
            this.AttractionTotalPrice.HeaderText = "Total Price";
            this.AttractionTotalPrice.Name = "AttractionTotalPrice";
            this.AttractionTotalPrice.ReadOnly = true;
            // 
            // txtAttraction
            // 
            this.txtAttraction.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAttraction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttraction.ForeColor = System.Drawing.Color.Peru;
            this.txtAttraction.Location = new System.Drawing.Point(728, 377);
            this.txtAttraction.Name = "txtAttraction";
            this.txtAttraction.ReadOnly = true;
            this.txtAttraction.Size = new System.Drawing.Size(178, 27);
            this.txtAttraction.TabIndex = 93;
            this.txtAttraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAttraction
            // 
            this.lblAttraction.AutoSize = true;
            this.lblAttraction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline);
            this.lblAttraction.Location = new System.Drawing.Point(528, 385);
            this.lblAttraction.Name = "lblAttraction";
            this.lblAttraction.Size = new System.Drawing.Size(194, 19);
            this.lblAttraction.TabIndex = 92;
            this.lblAttraction.Text = "Attraction Booking Subtotal :";
            // 
            // tabVehicle
            // 
            this.tabVehicle.BackColor = System.Drawing.Color.LightGray;
            this.tabVehicle.Controls.Add(this.dgvVehicle);
            this.tabVehicle.Controls.Add(this.txtVehicle);
            this.tabVehicle.Controls.Add(this.lblVehicle);
            this.tabVehicle.Location = new System.Drawing.Point(4, 27);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicle.Size = new System.Drawing.Size(912, 410);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle Booking Details";
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToDeleteRows = false;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleBookingID,
            this.VehicleID,
            this.VehicleName,
            this.AttractBookingID,
            this.VehicleBookDay,
            this.VehicleOrderDate,
            this.VehicleOrderBy,
            this.VehiclePickupDate,
            this.VehicleDropoffDate,
            this.DriverRosterID,
            this.DriverCost,
            this.VehicleBookPrice});
            this.dgvVehicle.Location = new System.Drawing.Point(6, 6);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowTemplate.Height = 24;
            this.dgvVehicle.Size = new System.Drawing.Size(900, 365);
            this.dgvVehicle.TabIndex = 97;
            // 
            // VehicleBookingID
            // 
            this.VehicleBookingID.HeaderText = "Vehicle Booking ID";
            this.VehicleBookingID.Name = "VehicleBookingID";
            this.VehicleBookingID.ReadOnly = true;
            // 
            // VehicleID
            // 
            this.VehicleID.HeaderText = "Vehicle ID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            // 
            // VehicleName
            // 
            this.VehicleName.HeaderText = "Vehicle Name";
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.ReadOnly = true;
            // 
            // AttractBookingID
            // 
            this.AttractBookingID.HeaderText = "Attraction Booking ID";
            this.AttractBookingID.Name = "AttractBookingID";
            this.AttractBookingID.ReadOnly = true;
            // 
            // VehicleBookDay
            // 
            this.VehicleBookDay.HeaderText = "Book Day";
            this.VehicleBookDay.Name = "VehicleBookDay";
            this.VehicleBookDay.ReadOnly = true;
            // 
            // VehicleOrderDate
            // 
            this.VehicleOrderDate.HeaderText = "Order Date";
            this.VehicleOrderDate.Name = "VehicleOrderDate";
            this.VehicleOrderDate.ReadOnly = true;
            // 
            // VehicleOrderBy
            // 
            this.VehicleOrderBy.HeaderText = "Order By";
            this.VehicleOrderBy.Name = "VehicleOrderBy";
            this.VehicleOrderBy.ReadOnly = true;
            // 
            // VehiclePickupDate
            // 
            this.VehiclePickupDate.HeaderText = "Pick-up Date";
            this.VehiclePickupDate.Name = "VehiclePickupDate";
            this.VehiclePickupDate.ReadOnly = true;
            // 
            // VehicleDropoffDate
            // 
            this.VehicleDropoffDate.HeaderText = "Drop-off Date";
            this.VehicleDropoffDate.Name = "VehicleDropoffDate";
            this.VehicleDropoffDate.ReadOnly = true;
            // 
            // DriverRosterID
            // 
            this.DriverRosterID.HeaderText = "Driver Roster ID";
            this.DriverRosterID.Name = "DriverRosterID";
            this.DriverRosterID.ReadOnly = true;
            // 
            // DriverCost
            // 
            this.DriverCost.HeaderText = "Driver Cost";
            this.DriverCost.Name = "DriverCost";
            this.DriverCost.ReadOnly = true;
            // 
            // VehicleBookPrice
            // 
            this.VehicleBookPrice.HeaderText = "Vehicle Book Price";
            this.VehicleBookPrice.Name = "VehicleBookPrice";
            this.VehicleBookPrice.ReadOnly = true;
            // 
            // txtVehicle
            // 
            this.txtVehicle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtVehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicle.ForeColor = System.Drawing.Color.Purple;
            this.txtVehicle.Location = new System.Drawing.Point(728, 377);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.ReadOnly = true;
            this.txtVehicle.Size = new System.Drawing.Size(178, 27);
            this.txtVehicle.TabIndex = 96;
            this.txtVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline);
            this.lblVehicle.Location = new System.Drawing.Point(528, 385);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(194, 19);
            this.lblVehicle.TabIndex = 95;
            this.lblVehicle.Text = "Attraction Booking Subtotal :";
            // 
            // tabEquipment
            // 
            this.tabEquipment.BackColor = System.Drawing.Color.LightGray;
            this.tabEquipment.Controls.Add(this.dgvEquipment);
            this.tabEquipment.Controls.Add(this.txtEquipment);
            this.tabEquipment.Controls.Add(this.lblEquipmentTotal);
            this.tabEquipment.Location = new System.Drawing.Point(4, 27);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquipment.Size = new System.Drawing.Size(912, 410);
            this.tabEquipment.TabIndex = 5;
            this.tabEquipment.Text = "Equipment Details";
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleBookingsID,
            this.EquipID,
            this.EquipmentName,
            this.EquipNum,
            this.EquipBookPrice});
            this.dgvEquipment.Location = new System.Drawing.Point(6, 6);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.Size = new System.Drawing.Size(900, 365);
            this.dgvEquipment.TabIndex = 100;
            // 
            // VehicleBookingsID
            // 
            this.VehicleBookingsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VehicleBookingsID.HeaderText = "Vehicle Booking ID";
            this.VehicleBookingsID.Name = "VehicleBookingsID";
            this.VehicleBookingsID.ReadOnly = true;
            // 
            // EquipID
            // 
            this.EquipID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EquipID.HeaderText = "Equipment ID";
            this.EquipID.Name = "EquipID";
            this.EquipID.ReadOnly = true;
            // 
            // EquipmentName
            // 
            this.EquipmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EquipmentName.HeaderText = "Equipment Name";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.ReadOnly = true;
            // 
            // EquipNum
            // 
            this.EquipNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EquipNum.HeaderText = "Equipment Num";
            this.EquipNum.Name = "EquipNum";
            this.EquipNum.ReadOnly = true;
            // 
            // EquipBookPrice
            // 
            this.EquipBookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EquipBookPrice.HeaderText = "Equipment Book Price";
            this.EquipBookPrice.Name = "EquipBookPrice";
            this.EquipBookPrice.ReadOnly = true;
            // 
            // txtEquipment
            // 
            this.txtEquipment.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEquipment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipment.ForeColor = System.Drawing.Color.Yellow;
            this.txtEquipment.Location = new System.Drawing.Point(728, 377);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.ReadOnly = true;
            this.txtEquipment.Size = new System.Drawing.Size(178, 27);
            this.txtEquipment.TabIndex = 99;
            this.txtEquipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEquipmentTotal
            // 
            this.lblEquipmentTotal.AutoSize = true;
            this.lblEquipmentTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline);
            this.lblEquipmentTotal.Location = new System.Drawing.Point(552, 385);
            this.lblEquipmentTotal.Name = "lblEquipmentTotal";
            this.lblEquipmentTotal.Size = new System.Drawing.Size(170, 19);
            this.lblEquipmentTotal.TabIndex = 98;
            this.lblEquipmentTotal.Text = "Equipment List Subtotal :";
            // 
            // txtTicketTotal
            // 
            this.txtTicketTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTicketTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTicketTotal.Location = new System.Drawing.Point(131, 625);
            this.txtTicketTotal.Name = "txtTicketTotal";
            this.txtTicketTotal.ReadOnly = true;
            this.txtTicketTotal.Size = new System.Drawing.Size(178, 27);
            this.txtTicketTotal.TabIndex = 70;
            this.txtTicketTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(8, 629);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 23);
            this.lblTotal.TabIndex = 69;
            this.lblTotal.Text = "Grand total = ";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 72;
            this.picLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(857, 623);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbCust
            // 
            this.cmbCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCust.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCust.FormattingEnabled = true;
            this.cmbCust.Items.AddRange(new object[] {
            "All"});
            this.cmbCust.Location = new System.Drawing.Point(850, 11);
            this.cmbCust.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCust.Name = "cmbCust";
            this.cmbCust.Size = new System.Drawing.Size(82, 27);
            this.cmbCust.TabIndex = 74;
            this.cmbCust.SelectedValueChanged += new System.EventHandler(this.cmbCust_SelectedValueChanged);
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNo.Location = new System.Drawing.Point(711, 14);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(134, 19);
            this.lblCustNo.TabIndex = 99;
            this.lblCustNo.Text = "Customer Number :";
            // 
            // btnGenAll
            // 
            this.btnGenAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenAll.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnGenAll.Location = new System.Drawing.Point(755, 30);
            this.btnGenAll.Name = "btnGenAll";
            this.btnGenAll.Size = new System.Drawing.Size(146, 41);
            this.btnGenAll.TabIndex = 100;
            this.btnGenAll.Text = "All Booking";
            this.btnGenAll.UseVisualStyleBackColor = true;
            this.btnGenAll.Click += new System.EventHandler(this.btnGenAll_Click);
            // 
            // frmAllBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.ControlBox = false;
            this.Controls.Add(this.lblCustNo);
            this.Controls.Add(this.cmbCust);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtTicketTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tabRecord);
            this.Controls.Add(this.grpGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAllBookings";
            this.Load += new System.EventHandler(this.frmAllBookings_Load);
            this.grpGenerate.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            this.tabFlight.ResumeLayout(false);
            this.tabFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).EndInit();
            this.tabHotel.ResumeLayout(false);
            this.tabHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.tabCurise.ResumeLayout(false);
            this.tabCurise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruise)).EndInit();
            this.tabAttraction.ResumeLayout(false);
            this.tabAttraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttraction)).EndInit();
            this.tabVehicle.ResumeLayout(false);
            this.tabVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.tabEquipment.ResumeLayout(false);
            this.tabEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpGenerate;
        private System.Windows.Forms.Button btnGenFlight;
        private System.Windows.Forms.Button btnGenHotel;
        private System.Windows.Forms.Button btnGenAttraction;
        private System.Windows.Forms.Button btnGenCruise;
        private System.Windows.Forms.TabControl tabRecord;
        private System.Windows.Forms.TabPage tabHotel;
        private System.Windows.Forms.TabPage tabFlight;
        private System.Windows.Forms.TextBox txtFlight;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.TabPage tabCurise;
        private System.Windows.Forms.TextBox txtCruise;
        private System.Windows.Forms.Label lblCruise;
        private System.Windows.Forms.TabPage tabAttraction;
        private System.Windows.Forms.TextBox txtAttraction;
        private System.Windows.Forms.Label lblAttraction;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TabPage tabEquipment;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Label lblEquipmentTotal;
        private System.Windows.Forms.TextBox txtTicketTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightAdultNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightChildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightInfantNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightAdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightChildPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightInfantPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightTotalPrice;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelTotalPrice;
        private System.Windows.Forms.DataGridView dgvCruise;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseAdultNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseChildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseAdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseChildPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseTotalPrice;
        private System.Windows.Forms.DataGridView dgvAttraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionAdultNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionChildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionAdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionChildPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionTotalPrice;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBookDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiclePickupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleDropoffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverRosterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBookPrice;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.ComboBox cmbCust;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBookingsID;
        private System.Windows.Forms.Button btnGenAll;
    }
}