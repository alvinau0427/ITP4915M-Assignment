namespace Integrated_Tourism_Management_System
{
    partial class frmProductManagement
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabManagement = new System.Windows.Forms.TabControl();
            this.tabFlight = new System.Windows.Forms.TabPage();
            this.lblT = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblClassFlightNo = new System.Windows.Forms.Label();
            this.txtClassFlightNo = new System.Windows.Forms.TextBox();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            this.cboFlightNo = new System.Windows.Forms.ComboBox();
            this.cboAircraft = new System.Windows.Forms.ComboBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.cboFlightType = new System.Windows.Forms.ComboBox();
            this.cboOrigin = new System.Windows.Forms.ComboBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassInsert = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.fno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtInfact = new System.Windows.Forms.TextBox();
            this.lblInfact = new System.Windows.Forms.Label();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.txtAdult = new System.Windows.Forms.TextBox();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.dgvFlight = new System.Windows.Forms.DataGridView();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedDataOfDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedTimeOfDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedDataOfArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedTimeOfArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.lblFlightType = new System.Windows.Forms.Label();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.dtpETA = new System.Windows.Forms.DateTimePicker();
            this.dtpETD = new System.Windows.Forms.DateTimePicker();
            this.lblETA = new System.Windows.Forms.Label();
            this.lblETD = new System.Windows.Forms.Label();
            this.dtpEDA = new System.Windows.Forms.DateTimePicker();
            this.lblEDA = new System.Windows.Forms.Label();
            this.dtpEDD = new System.Windows.Forms.DateTimePicker();
            this.lblEDD = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.lblFlightID = new System.Windows.Forms.Label();
            this.btnFlightUpdate = new System.Windows.Forms.Button();
            this.btnFlightDelete = new System.Windows.Forms.Button();
            this.btnFlightInsert = new System.Windows.Forms.Button();
            this.tabHotel = new System.Windows.Forms.TabPage();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.nudMaxChild = new System.Windows.Forms.NumericUpDown();
            this.nudMaxAdult = new System.Windows.Forms.NumericUpDown();
            this.lblHotel = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFare = new System.Windows.Forms.Label();
            this.lblMaxChild = new System.Windows.Forms.Label();
            this.lblMaxAduct = new System.Windows.Forms.Label();
            this.txtRoomSize = new System.Windows.Forms.TextBox();
            this.lblRoomSize = new System.Windows.Forms.Label();
            this.txtHotelRoomName = new System.Windows.Forms.TextBox();
            this.lblHotelRoomName = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.lblHotelChineseName = new System.Windows.Forms.Label();
            this.txtHotelRoomID = new System.Windows.Forms.TextBox();
            this.lblHotelRoomID = new System.Windows.Forms.Label();
            this.btnHotelRoomUpdate = new System.Windows.Forms.Button();
            this.btnHotelRoomDelete = new System.Windows.Forms.Button();
            this.btnHotelRoomInsert = new System.Windows.Forms.Button();
            this.dgvHotelRoom = new System.Windows.Forms.DataGridView();
            this.Hotel_room_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelChiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max_Adult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max_Child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Room_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHotelUpdate = new System.Windows.Forms.Button();
            this.btnHotelDelete = new System.Windows.Forms.Button();
            this.btnHotelInsert = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.lblEnglishName = new System.Windows.Forms.Label();
            this.txtChineseName = new System.Windows.Forms.TextBox();
            this.lblChineseName = new System.Windows.Forms.Label();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.HotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCruise = new System.Windows.Forms.TabPage();
            this.btnOrganUpdate = new System.Windows.Forms.Button();
            this.btnOrganDelete = new System.Windows.Forms.Button();
            this.btnOrganInsert = new System.Windows.Forms.Button();
            this.txtOrganEng = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.txtOrganChi = new System.Windows.Forms.TextBox();
            this.lblChinese = new System.Windows.Forms.Label();
            this.txtOrganID = new System.Windows.Forms.TextBox();
            this.lblOrganID = new System.Windows.Forms.Label();
            this.dgvOrgan = new System.Windows.Forms.DataGridView();
            this.OrganID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCruiseUpdate = new System.Windows.Forms.Button();
            this.txtCruiseCount = new System.Windows.Forms.TextBox();
            this.btnCruiseDelete = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCruiseInsert = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.numDayC = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerC = new System.Windows.Forms.DateTimePicker();
            this.comBoxOrganC = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblOrganizer = new System.Windows.Forms.Label();
            this.lblTourDay = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCruiseName = new System.Windows.Forms.TextBox();
            this.lblCruiseName = new System.Windows.Forms.Label();
            this.txtCruiseNo = new System.Windows.Forms.TextBox();
            this.lblCruiseNo = new System.Windows.Forms.Label();
            this.dgvCruise = new System.Windows.Forms.DataGridView();
            this.CruiseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAttraction = new System.Windows.Forms.TabPage();
            this.txtChildPrice = new System.Windows.Forms.TextBox();
            this.lblChildPrice = new System.Windows.Forms.Label();
            this.txtAdultPrice = new System.Windows.Forms.TextBox();
            this.lblAdultPrice = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCancellation = new System.Windows.Forms.TextBox();
            this.lblCancellation = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtAttractionName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAttractionUpdate = new System.Windows.Forms.Button();
            this.btnAttractionDelete = new System.Windows.Forms.Button();
            this.btnAttractionInsert = new System.Windows.Forms.Button();
            this.dgvAttraction = new System.Windows.Forms.DataGridView();
            this.AttractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancellation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.cmbSuitable = new System.Windows.Forms.ComboBox();
            this.lblSuitable = new System.Windows.Forms.Label();
            this.txtEquipPrice = new System.Windows.Forms.TextBox();
            this.lblEquipmentPrice = new System.Windows.Forms.Label();
            this.txtEquipName = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.txtEquipID = new System.Windows.Forms.TextBox();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.btnEquipUpload = new System.Windows.Forms.Button();
            this.btnEquipUpdate = new System.Windows.Forms.Button();
            this.btnEquipDelete = new System.Windows.Forms.Button();
            this.btnEquipInsert = new System.Windows.Forms.Button();
            this.dgvEquip = new System.Windows.Forms.DataGridView();
            this.Equipment_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suitable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGear = new System.Windows.Forms.ComboBox();
            this.btnVehicleUpload = new System.Windows.Forms.Button();
            this.btnVehicleUpdate = new System.Windows.Forms.Button();
            this.btnVehicleDelete = new System.Windows.Forms.Button();
            this.btnVehicleInsert = new System.Windows.Forms.Button();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGear = new System.Windows.Forms.Label();
            this.txtVehiclePrice = new System.Windows.Forms.TextBox();
            this.lblVehiclePrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehiclePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehiclePhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabManagement.SuspendLayout();
            this.tabFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).BeginInit();
            this.tabHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.tabCruise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruise)).BeginInit();
            this.tabAttraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttraction)).BeginInit();
            this.tabVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(857, 632);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 90;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabManagement
            // 
            this.tabManagement.Controls.Add(this.tabFlight);
            this.tabManagement.Controls.Add(this.tabHotel);
            this.tabManagement.Controls.Add(this.tabCruise);
            this.tabManagement.Controls.Add(this.tabAttraction);
            this.tabManagement.Controls.Add(this.tabVehicle);
            this.tabManagement.Location = new System.Drawing.Point(12, 31);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.SelectedIndex = 0;
            this.tabManagement.Size = new System.Drawing.Size(920, 599);
            this.tabManagement.TabIndex = 91;
            // 
            // tabFlight
            // 
            this.tabFlight.Controls.Add(this.lblT);
            this.tabFlight.Controls.Add(this.cboType);
            this.tabFlight.Controls.Add(this.lblClassFlightNo);
            this.tabFlight.Controls.Add(this.txtClassFlightNo);
            this.tabFlight.Controls.Add(this.txtCarrier);
            this.tabFlight.Controls.Add(this.cboFlightNo);
            this.tabFlight.Controls.Add(this.cboAircraft);
            this.tabFlight.Controls.Add(this.cboDestination);
            this.tabFlight.Controls.Add(this.cboFlightType);
            this.tabFlight.Controls.Add(this.cboOrigin);
            this.tabFlight.Controls.Add(this.cboClass);
            this.tabFlight.Controls.Add(this.btnClassUpdate);
            this.tabFlight.Controls.Add(this.btnClassDelete);
            this.tabFlight.Controls.Add(this.btnClassInsert);
            this.tabFlight.Controls.Add(this.dgvClass);
            this.tabFlight.Controls.Add(this.txtTax);
            this.tabFlight.Controls.Add(this.lblTax);
            this.tabFlight.Controls.Add(this.txtInfact);
            this.tabFlight.Controls.Add(this.lblInfact);
            this.tabFlight.Controls.Add(this.txtChildren);
            this.tabFlight.Controls.Add(this.lblChildren);
            this.tabFlight.Controls.Add(this.txtAdult);
            this.tabFlight.Controls.Add(this.lblAdult);
            this.tabFlight.Controls.Add(this.lblClass);
            this.tabFlight.Controls.Add(this.dgvFlight);
            this.tabFlight.Controls.Add(this.lblFlightNo);
            this.tabFlight.Controls.Add(this.lblFlightType);
            this.tabFlight.Controls.Add(this.lblAircraft);
            this.tabFlight.Controls.Add(this.lblDestination);
            this.tabFlight.Controls.Add(this.lblOrigin);
            this.tabFlight.Controls.Add(this.dtpETA);
            this.tabFlight.Controls.Add(this.dtpETD);
            this.tabFlight.Controls.Add(this.lblETA);
            this.tabFlight.Controls.Add(this.lblETD);
            this.tabFlight.Controls.Add(this.dtpEDA);
            this.tabFlight.Controls.Add(this.lblEDA);
            this.tabFlight.Controls.Add(this.dtpEDD);
            this.tabFlight.Controls.Add(this.lblEDD);
            this.tabFlight.Controls.Add(this.lblCarrier);
            this.tabFlight.Controls.Add(this.txtFlightID);
            this.tabFlight.Controls.Add(this.lblFlightID);
            this.tabFlight.Controls.Add(this.btnFlightUpdate);
            this.tabFlight.Controls.Add(this.btnFlightDelete);
            this.tabFlight.Controls.Add(this.btnFlightInsert);
            this.tabFlight.Location = new System.Drawing.Point(4, 22);
            this.tabFlight.Name = "tabFlight";
            this.tabFlight.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabFlight.Size = new System.Drawing.Size(912, 573);
            this.tabFlight.TabIndex = 0;
            this.tabFlight.Text = "Flight Product Maintain";
            this.tabFlight.UseVisualStyleBackColor = true;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(316, 363);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(41, 18);
            this.lblT.TabIndex = 207;
            this.lblT.Text = "Type:";
            // 
            // cboType
            // 
            this.cboType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(363, 360);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(87, 27);
            this.cboType.TabIndex = 206;
            // 
            // lblClassFlightNo
            // 
            this.lblClassFlightNo.AutoSize = true;
            this.lblClassFlightNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassFlightNo.Location = new System.Drawing.Point(27, 363);
            this.lblClassFlightNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassFlightNo.Name = "lblClassFlightNo";
            this.lblClassFlightNo.Size = new System.Drawing.Size(65, 18);
            this.lblClassFlightNo.TabIndex = 205;
            this.lblClassFlightNo.Text = "FlightNo:";
            // 
            // txtClassFlightNo
            // 
            this.txtClassFlightNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassFlightNo.Location = new System.Drawing.Point(96, 361);
            this.txtClassFlightNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassFlightNo.Name = "txtClassFlightNo";
            this.txtClassFlightNo.Size = new System.Drawing.Size(73, 26);
            this.txtClassFlightNo.TabIndex = 204;
            // 
            // txtCarrier
            // 
            this.txtCarrier.Enabled = false;
            this.txtCarrier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrier.Location = new System.Drawing.Point(267, 15);
            this.txtCarrier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(68, 26);
            this.txtCarrier.TabIndex = 203;
            // 
            // cboFlightNo
            // 
            this.cboFlightNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFlightNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlightNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFlightNo.FormattingEnabled = true;
            this.cboFlightNo.Items.AddRange(new object[] {
            "All"});
            this.cboFlightNo.Location = new System.Drawing.Point(145, 124);
            this.cboFlightNo.Name = "cboFlightNo";
            this.cboFlightNo.Size = new System.Drawing.Size(96, 27);
            this.cboFlightNo.TabIndex = 202;
            this.cboFlightNo.SelectedIndexChanged += new System.EventHandler(this.cboFlightNo_SelectedIndexChanged);
            // 
            // cboAircraft
            // 
            this.cboAircraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAircraft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAircraft.FormattingEnabled = true;
            this.cboAircraft.Items.AddRange(new object[] {
            "All"});
            this.cboAircraft.Location = new System.Drawing.Point(763, 12);
            this.cboAircraft.Name = "cboAircraft";
            this.cboAircraft.Size = new System.Drawing.Size(83, 27);
            this.cboAircraft.TabIndex = 201;
            // 
            // cboDestination
            // 
            this.cboDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Items.AddRange(new object[] {
            "All"});
            this.cboDestination.Location = new System.Drawing.Point(591, 12);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(83, 27);
            this.cboDestination.TabIndex = 200;
            // 
            // cboFlightType
            // 
            this.cboFlightType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFlightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlightType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFlightType.FormattingEnabled = true;
            this.cboFlightType.Items.AddRange(new object[] {
            "All"});
            this.cboFlightType.Location = new System.Drawing.Point(331, 124);
            this.cboFlightType.Name = "cboFlightType";
            this.cboFlightType.Size = new System.Drawing.Size(120, 27);
            this.cboFlightType.TabIndex = 199;
            // 
            // cboOrigin
            // 
            this.cboOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigin.FormattingEnabled = true;
            this.cboOrigin.Items.AddRange(new object[] {
            "All"});
            this.cboOrigin.Location = new System.Drawing.Point(408, 12);
            this.cboOrigin.Name = "cboOrigin";
            this.cboOrigin.Size = new System.Drawing.Size(73, 27);
            this.cboOrigin.TabIndex = 198;
            // 
            // cboClass
            // 
            this.cboClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "All"});
            this.cboClass.Location = new System.Drawing.Point(219, 360);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(87, 27);
            this.cboClass.TabIndex = 196;
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClassUpdate.Location = new System.Drawing.Point(768, 539);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnClassUpdate.TabIndex = 195;
            this.btnClassUpdate.Text = "Update";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassDelete.Location = new System.Drawing.Point(843, 539);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(65, 27);
            this.btnClassDelete.TabIndex = 194;
            this.btnClassDelete.Text = "Delete";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassInsert
            // 
            this.btnClassInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassInsert.Location = new System.Drawing.Point(697, 539);
            this.btnClassInsert.Name = "btnClassInsert";
            this.btnClassInsert.Size = new System.Drawing.Size(65, 27);
            this.btnClassInsert.TabIndex = 193;
            this.btnClassInsert.Text = "Insert";
            this.btnClassInsert.UseVisualStyleBackColor = true;
            this.btnClassInsert.Click += new System.EventHandler(this.btnClassInsert_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeColumns = false;
            this.dgvClass.AllowUserToResizeRows = false;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fno,
            this.cla,
            this.Fty,
            this.pa,
            this.pc,
            this.pi,
            this.tax});
            this.dgvClass.Location = new System.Drawing.Point(7, 421);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(900, 112);
            this.dgvClass.TabIndex = 192;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // fno
            // 
            this.fno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fno.HeaderText = "FlightNo";
            this.fno.MinimumWidth = 125;
            this.fno.Name = "fno";
            this.fno.ReadOnly = true;
            // 
            // cla
            // 
            this.cla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cla.HeaderText = "Class";
            this.cla.MinimumWidth = 125;
            this.cla.Name = "cla";
            this.cla.ReadOnly = true;
            // 
            // Fty
            // 
            this.Fty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fty.HeaderText = "FlightType";
            this.Fty.MinimumWidth = 125;
            this.Fty.Name = "Fty";
            this.Fty.ReadOnly = true;
            // 
            // pa
            // 
            this.pa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pa.HeaderText = "Adult Price";
            this.pa.MinimumWidth = 125;
            this.pa.Name = "pa";
            this.pa.ReadOnly = true;
            // 
            // pc
            // 
            this.pc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pc.HeaderText = "Children Price";
            this.pc.MinimumWidth = 125;
            this.pc.Name = "pc";
            this.pc.ReadOnly = true;
            // 
            // pi
            // 
            this.pi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pi.HeaderText = "Infant Price";
            this.pi.MinimumWidth = 125;
            this.pi.Name = "pi";
            this.pi.ReadOnly = true;
            this.pi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tax
            // 
            this.tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tax.HeaderText = "Tax";
            this.tax.MinimumWidth = 125;
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(573, 391);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(73, 26);
            this.txtTax.TabIndex = 191;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(537, 393);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(32, 18);
            this.lblTax.TabIndex = 190;
            this.lblTax.Text = "Tax:";
            // 
            // txtInfact
            // 
            this.txtInfact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfact.Location = new System.Drawing.Point(461, 391);
            this.txtInfact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInfact.Name = "txtInfact";
            this.txtInfact.Size = new System.Drawing.Size(73, 26);
            this.txtInfact.TabIndex = 189;
            // 
            // lblInfact
            // 
            this.lblInfact.AutoSize = true;
            this.lblInfact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfact.Location = new System.Drawing.Point(375, 393);
            this.lblInfact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfact.Name = "lblInfact";
            this.lblInfact.Size = new System.Drawing.Size(81, 18);
            this.lblInfact.TabIndex = 188;
            this.lblInfact.Text = "Infact Price:";
            // 
            // txtChildren
            // 
            this.txtChildren.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(285, 391);
            this.txtChildren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(73, 26);
            this.txtChildren.TabIndex = 187;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(184, 393);
            this.lblChildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(99, 18);
            this.lblChildren.TabIndex = 186;
            this.lblChildren.Text = "Children Price:";
            // 
            // txtAdult
            // 
            this.txtAdult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdult.Location = new System.Drawing.Point(96, 391);
            this.txtAdult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdult.Name = "txtAdult";
            this.txtAdult.Size = new System.Drawing.Size(73, 26);
            this.txtAdult.TabIndex = 185;
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(13, 393);
            this.lblAdult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(80, 18);
            this.lblAdult.TabIndex = 184;
            this.lblAdult.Text = "Adult Price:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(171, 362);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(43, 18);
            this.lblClass.TabIndex = 183;
            this.lblClass.Text = "Class:";
            // 
            // dgvFlight
            // 
            this.dgvFlight.AllowUserToAddRows = false;
            this.dgvFlight.AllowUserToDeleteRows = false;
            this.dgvFlight.AllowUserToResizeColumns = false;
            this.dgvFlight.AllowUserToResizeRows = false;
            this.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightID,
            this.IATA,
            this.Origin,
            this.Destination,
            this.Aircraft,
            this.EstimatedDataOfDeparture,
            this.EstimatedTimeOfDeparture,
            this.EstimatedDataOfArrival,
            this.EstimatedTimeOfArrival,
            this.FlightNo,
            this.FlightType});
            this.dgvFlight.Location = new System.Drawing.Point(7, 157);
            this.dgvFlight.MultiSelect = false;
            this.dgvFlight.Name = "dgvFlight";
            this.dgvFlight.ReadOnly = true;
            this.dgvFlight.RowHeadersVisible = false;
            this.dgvFlight.RowTemplate.Height = 24;
            this.dgvFlight.Size = new System.Drawing.Size(900, 195);
            this.dgvFlight.TabIndex = 182;
            this.dgvFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlight_CellClick);
            // 
            // FlightID
            // 
            this.FlightID.HeaderText = "Flight ID";
            this.FlightID.Name = "FlightID";
            this.FlightID.ReadOnly = true;
            // 
            // IATA
            // 
            this.IATA.HeaderText = "IATA";
            this.IATA.Name = "IATA";
            this.IATA.ReadOnly = true;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // Aircraft
            // 
            this.Aircraft.HeaderText = "Aircraft";
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.ReadOnly = true;
            // 
            // EstimatedDataOfDeparture
            // 
            this.EstimatedDataOfDeparture.HeaderText = "Estimated Data Of Departure";
            this.EstimatedDataOfDeparture.Name = "EstimatedDataOfDeparture";
            this.EstimatedDataOfDeparture.ReadOnly = true;
            // 
            // EstimatedTimeOfDeparture
            // 
            this.EstimatedTimeOfDeparture.HeaderText = "Estimated Time Of Departure";
            this.EstimatedTimeOfDeparture.Name = "EstimatedTimeOfDeparture";
            this.EstimatedTimeOfDeparture.ReadOnly = true;
            // 
            // EstimatedDataOfArrival
            // 
            this.EstimatedDataOfArrival.HeaderText = "Estimated Data Of Arrival";
            this.EstimatedDataOfArrival.Name = "EstimatedDataOfArrival";
            this.EstimatedDataOfArrival.ReadOnly = true;
            // 
            // EstimatedTimeOfArrival
            // 
            this.EstimatedTimeOfArrival.HeaderText = "Estimated Time Of Arrival";
            this.EstimatedTimeOfArrival.Name = "EstimatedTimeOfArrival";
            this.EstimatedTimeOfArrival.ReadOnly = true;
            // 
            // FlightNo
            // 
            this.FlightNo.HeaderText = "Flight No";
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // FlightType
            // 
            this.FlightType.HeaderText = "Flight Type";
            this.FlightType.Name = "FlightType";
            this.FlightType.ReadOnly = true;
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.lblFlightNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNo.Location = new System.Drawing.Point(68, 128);
            this.lblFlightNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(72, 18);
            this.lblFlightNo.TabIndex = 176;
            this.lblFlightNo.Text = "Flight No.:";
            // 
            // lblFlightType
            // 
            this.lblFlightType.AutoSize = true;
            this.lblFlightType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightType.Location = new System.Drawing.Point(247, 128);
            this.lblFlightType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlightType.Name = "lblFlightType";
            this.lblFlightType.Size = new System.Drawing.Size(79, 18);
            this.lblFlightType.TabIndex = 175;
            this.lblFlightType.Text = "Flight Type:";
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraft.Location = new System.Drawing.Point(700, 17);
            this.lblAircraft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(57, 18);
            this.lblAircraft.TabIndex = 174;
            this.lblAircraft.Text = "Aircraft:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(503, 17);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(82, 18);
            this.lblDestination.TabIndex = 173;
            this.lblDestination.Text = "Destination:";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(353, 17);
            this.lblOrigin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(50, 18);
            this.lblOrigin.TabIndex = 172;
            this.lblOrigin.Text = "Origin:";
            // 
            // dtpETA
            // 
            this.dtpETA.CustomFormat = "HH:mm";
            this.dtpETA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETA.Location = new System.Drawing.Point(738, 47);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.ShowUpDown = true;
            this.dtpETA.Size = new System.Drawing.Size(132, 27);
            this.dtpETA.TabIndex = 171;
            // 
            // dtpETD
            // 
            this.dtpETD.CustomFormat = "HH:mm";
            this.dtpETD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpETD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETD.Location = new System.Drawing.Point(738, 87);
            this.dtpETD.Name = "dtpETD";
            this.dtpETD.ShowUpDown = true;
            this.dtpETD.Size = new System.Drawing.Size(132, 27);
            this.dtpETD.TabIndex = 170;
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETA.Location = new System.Drawing.Point(485, 52);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(222, 19);
            this.lblETA.TabIndex = 169;
            this.lblETA.Text = "Estimated Time Of Arrival (ETA) :";
            // 
            // lblETD
            // 
            this.lblETD.AutoSize = true;
            this.lblETD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETD.Location = new System.Drawing.Point(485, 92);
            this.lblETD.Name = "lblETD";
            this.lblETD.Size = new System.Drawing.Size(247, 19);
            this.lblETD.TabIndex = 168;
            this.lblETD.Text = "Estimated Time Of Departure (ETD) :";
            // 
            // dtpEDA
            // 
            this.dtpEDA.CustomFormat = "dd - MM - yyyy";
            this.dtpEDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDA.Location = new System.Drawing.Point(319, 85);
            this.dtpEDA.Name = "dtpEDA";
            this.dtpEDA.Size = new System.Drawing.Size(132, 27);
            this.dtpEDA.TabIndex = 167;
            // 
            // lblEDA
            // 
            this.lblEDA.AutoSize = true;
            this.lblEDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDA.Location = new System.Drawing.Point(65, 52);
            this.lblEDA.Name = "lblEDA";
            this.lblEDA.Size = new System.Drawing.Size(224, 19);
            this.lblEDA.TabIndex = 166;
            this.lblEDA.Text = "Estimated Date Of Arrival (EDA) :";
            // 
            // dtpEDD
            // 
            this.dtpEDD.CustomFormat = "dd - MM - yyyy";
            this.dtpEDD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDD.Location = new System.Drawing.Point(319, 45);
            this.dtpEDD.Name = "dtpEDD";
            this.dtpEDD.Size = new System.Drawing.Size(132, 27);
            this.dtpEDD.TabIndex = 165;
            this.dtpEDD.Value = new System.DateTime(2016, 5, 24, 22, 37, 49, 0);
            // 
            // lblEDD
            // 
            this.lblEDD.AutoSize = true;
            this.lblEDD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDD.Location = new System.Drawing.Point(65, 92);
            this.lblEDD.Name = "lblEDD";
            this.lblEDD.Size = new System.Drawing.Size(248, 19);
            this.lblEDD.TabIndex = 164;
            this.lblEDD.Text = "Estimated Date Of Departure (EDD) :";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.Location = new System.Drawing.Point(209, 17);
            this.lblCarrier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(54, 18);
            this.lblCarrier.TabIndex = 163;
            this.lblCarrier.Text = "Carrier:";
            // 
            // txtFlightID
            // 
            this.txtFlightID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightID.Location = new System.Drawing.Point(127, 13);
            this.txtFlightID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(68, 26);
            this.txtFlightID.TabIndex = 162;
            // 
            // lblFlightID
            // 
            this.lblFlightID.AutoSize = true;
            this.lblFlightID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightID.Location = new System.Drawing.Point(53, 17);
            this.lblFlightID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlightID.Name = "lblFlightID";
            this.lblFlightID.Size = new System.Drawing.Size(70, 18);
            this.lblFlightID.TabIndex = 161;
            this.lblFlightID.Text = "* FlightID:";
            // 
            // btnFlightUpdate
            // 
            this.btnFlightUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlightUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnFlightUpdate.Location = new System.Drawing.Point(767, 357);
            this.btnFlightUpdate.Name = "btnFlightUpdate";
            this.btnFlightUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnFlightUpdate.TabIndex = 160;
            this.btnFlightUpdate.Text = "Update";
            this.btnFlightUpdate.UseVisualStyleBackColor = true;
            this.btnFlightUpdate.Click += new System.EventHandler(this.btnFlightUpdate_Click);
            // 
            // btnFlightDelete
            // 
            this.btnFlightDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlightDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightDelete.Location = new System.Drawing.Point(842, 357);
            this.btnFlightDelete.Name = "btnFlightDelete";
            this.btnFlightDelete.Size = new System.Drawing.Size(65, 27);
            this.btnFlightDelete.TabIndex = 159;
            this.btnFlightDelete.Text = "Delete";
            this.btnFlightDelete.UseVisualStyleBackColor = true;
            this.btnFlightDelete.Click += new System.EventHandler(this.btnFlightDelete_Click);
            // 
            // btnFlightInsert
            // 
            this.btnFlightInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlightInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightInsert.Location = new System.Drawing.Point(697, 357);
            this.btnFlightInsert.Name = "btnFlightInsert";
            this.btnFlightInsert.Size = new System.Drawing.Size(65, 27);
            this.btnFlightInsert.TabIndex = 158;
            this.btnFlightInsert.Text = "Insert";
            this.btnFlightInsert.UseVisualStyleBackColor = true;
            this.btnFlightInsert.Click += new System.EventHandler(this.btnFlightInsert_Click);
            // 
            // tabHotel
            // 
            this.tabHotel.Controls.Add(this.cmbHotel);
            this.tabHotel.Controls.Add(this.nudMaxChild);
            this.tabHotel.Controls.Add(this.nudMaxAdult);
            this.tabHotel.Controls.Add(this.lblHotel);
            this.tabHotel.Controls.Add(this.txtFare);
            this.tabHotel.Controls.Add(this.lblDescription);
            this.tabHotel.Controls.Add(this.txtDescription);
            this.tabHotel.Controls.Add(this.lblFare);
            this.tabHotel.Controls.Add(this.lblMaxChild);
            this.tabHotel.Controls.Add(this.lblMaxAduct);
            this.tabHotel.Controls.Add(this.txtRoomSize);
            this.tabHotel.Controls.Add(this.lblRoomSize);
            this.tabHotel.Controls.Add(this.txtHotelRoomName);
            this.tabHotel.Controls.Add(this.lblHotelRoomName);
            this.tabHotel.Controls.Add(this.txtHotelName);
            this.tabHotel.Controls.Add(this.lblHotelChineseName);
            this.tabHotel.Controls.Add(this.txtHotelRoomID);
            this.tabHotel.Controls.Add(this.lblHotelRoomID);
            this.tabHotel.Controls.Add(this.btnHotelRoomUpdate);
            this.tabHotel.Controls.Add(this.btnHotelRoomDelete);
            this.tabHotel.Controls.Add(this.btnHotelRoomInsert);
            this.tabHotel.Controls.Add(this.dgvHotelRoom);
            this.tabHotel.Controls.Add(this.btnHotelUpdate);
            this.tabHotel.Controls.Add(this.btnHotelDelete);
            this.tabHotel.Controls.Add(this.btnHotelInsert);
            this.tabHotel.Controls.Add(this.txtAddress);
            this.tabHotel.Controls.Add(this.lblTelephone);
            this.tabHotel.Controls.Add(this.txtTel);
            this.tabHotel.Controls.Add(this.lblAddress);
            this.tabHotel.Controls.Add(this.txtRegion);
            this.tabHotel.Controls.Add(this.lblRegion);
            this.tabHotel.Controls.Add(this.txtRating);
            this.tabHotel.Controls.Add(this.lblRating);
            this.tabHotel.Controls.Add(this.txtStar);
            this.tabHotel.Controls.Add(this.lblStar);
            this.tabHotel.Controls.Add(this.txtEnglishName);
            this.tabHotel.Controls.Add(this.lblEnglishName);
            this.tabHotel.Controls.Add(this.txtChineseName);
            this.tabHotel.Controls.Add(this.lblChineseName);
            this.tabHotel.Controls.Add(this.txtHotelID);
            this.tabHotel.Controls.Add(this.lblHotelID);
            this.tabHotel.Controls.Add(this.dgvHotel);
            this.tabHotel.Location = new System.Drawing.Point(4, 22);
            this.tabHotel.Name = "tabHotel";
            this.tabHotel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHotel.Size = new System.Drawing.Size(912, 573);
            this.tabHotel.TabIndex = 1;
            this.tabHotel.Text = "Hotel Product Maintain";
            this.tabHotel.UseVisualStyleBackColor = true;
            // 
            // cmbHotel
            // 
            this.cmbHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotel.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(384, 367);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(69, 26);
            this.cmbHotel.TabIndex = 118;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // nudMaxChild
            // 
            this.nudMaxChild.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.nudMaxChild.Location = new System.Drawing.Point(776, 335);
            this.nudMaxChild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudMaxChild.Name = "nudMaxChild";
            this.nudMaxChild.Size = new System.Drawing.Size(59, 26);
            this.nudMaxChild.TabIndex = 117;
            // 
            // nudMaxAdult
            // 
            this.nudMaxAdult.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.nudMaxAdult.Location = new System.Drawing.Point(617, 335);
            this.nudMaxAdult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudMaxAdult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxAdult.Name = "nudMaxAdult";
            this.nudMaxAdult.Size = new System.Drawing.Size(59, 26);
            this.nudMaxAdult.TabIndex = 116;
            this.nudMaxAdult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblHotel.Location = new System.Drawing.Point(302, 371);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(62, 18);
            this.lblHotel.TabIndex = 114;
            this.lblHotel.Text = "Hotel ID:";
            // 
            // txtFare
            // 
            this.txtFare.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtFare.Location = new System.Drawing.Point(134, 367);
            this.txtFare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(140, 26);
            this.txtFare.TabIndex = 113;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblDescription.Location = new System.Drawing.Point(476, 371);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 18);
            this.lblDescription.TabIndex = 112;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDescription.Location = new System.Drawing.Point(578, 367);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(257, 26);
            this.txtDescription.TabIndex = 111;
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblFare.Location = new System.Drawing.Point(91, 371);
            this.lblFare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(39, 18);
            this.lblFare.TabIndex = 110;
            this.lblFare.Text = "Fare:";
            // 
            // lblMaxChild
            // 
            this.lblMaxChild.AutoSize = true;
            this.lblMaxChild.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblMaxChild.Location = new System.Drawing.Point(683, 339);
            this.lblMaxChild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxChild.Name = "lblMaxChild";
            this.lblMaxChild.Size = new System.Drawing.Size(73, 18);
            this.lblMaxChild.TabIndex = 108;
            this.lblMaxChild.Text = "Max Child:";
            // 
            // lblMaxAduct
            // 
            this.lblMaxAduct.AutoSize = true;
            this.lblMaxAduct.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblMaxAduct.Location = new System.Drawing.Point(522, 339);
            this.lblMaxAduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxAduct.Name = "lblMaxAduct";
            this.lblMaxAduct.Size = new System.Drawing.Size(75, 18);
            this.lblMaxAduct.TabIndex = 106;
            this.lblMaxAduct.Text = "Max Adult:";
            // 
            // txtRoomSize
            // 
            this.txtRoomSize.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtRoomSize.Location = new System.Drawing.Point(422, 335);
            this.txtRoomSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoomSize.Name = "txtRoomSize";
            this.txtRoomSize.Size = new System.Drawing.Size(77, 26);
            this.txtRoomSize.TabIndex = 105;
            // 
            // lblRoomSize
            // 
            this.lblRoomSize.AutoSize = true;
            this.lblRoomSize.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblRoomSize.Location = new System.Drawing.Point(326, 339);
            this.lblRoomSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomSize.Name = "lblRoomSize";
            this.lblRoomSize.Size = new System.Drawing.Size(76, 18);
            this.lblRoomSize.TabIndex = 104;
            this.lblRoomSize.Text = "Room Size:";
            // 
            // txtHotelRoomName
            // 
            this.txtHotelRoomName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtHotelRoomName.Location = new System.Drawing.Point(211, 335);
            this.txtHotelRoomName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHotelRoomName.Name = "txtHotelRoomName";
            this.txtHotelRoomName.Size = new System.Drawing.Size(75, 26);
            this.txtHotelRoomName.TabIndex = 103;
            // 
            // lblHotelRoomName
            // 
            this.lblHotelRoomName.AutoSize = true;
            this.lblHotelRoomName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblHotelRoomName.Location = new System.Drawing.Point(86, 339);
            this.lblHotelRoomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotelRoomName.Name = "lblHotelRoomName";
            this.lblHotelRoomName.Size = new System.Drawing.Size(88, 18);
            this.lblHotelRoomName.TabIndex = 102;
            this.lblHotelRoomName.Text = "Room Name:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Enabled = false;
            this.txtHotelName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtHotelName.Location = new System.Drawing.Point(522, 305);
            this.txtHotelName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(313, 26);
            this.txtHotelName.TabIndex = 101;
            // 
            // lblHotelChineseName
            // 
            this.lblHotelChineseName.AutoSize = true;
            this.lblHotelChineseName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblHotelChineseName.Location = new System.Drawing.Point(347, 309);
            this.lblHotelChineseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotelChineseName.Name = "lblHotelChineseName";
            this.lblHotelChineseName.Size = new System.Drawing.Size(139, 18);
            this.lblHotelChineseName.TabIndex = 100;
            this.lblHotelChineseName.Text = "Hotel Chinese Name:";
            // 
            // txtHotelRoomID
            // 
            this.txtHotelRoomID.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtHotelRoomID.Location = new System.Drawing.Point(225, 305);
            this.txtHotelRoomID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHotelRoomID.Name = "txtHotelRoomID";
            this.txtHotelRoomID.Size = new System.Drawing.Size(75, 26);
            this.txtHotelRoomID.TabIndex = 99;
            // 
            // lblHotelRoomID
            // 
            this.lblHotelRoomID.AutoSize = true;
            this.lblHotelRoomID.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblHotelRoomID.Location = new System.Drawing.Point(78, 309);
            this.lblHotelRoomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotelRoomID.Name = "lblHotelRoomID";
            this.lblHotelRoomID.Size = new System.Drawing.Size(111, 18);
            this.lblHotelRoomID.TabIndex = 98;
            this.lblHotelRoomID.Text = "* Hotel Room ID:";
            // 
            // btnHotelRoomUpdate
            // 
            this.btnHotelRoomUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelRoomUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHotelRoomUpdate.Location = new System.Drawing.Point(767, 543);
            this.btnHotelRoomUpdate.Name = "btnHotelRoomUpdate";
            this.btnHotelRoomUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnHotelRoomUpdate.TabIndex = 97;
            this.btnHotelRoomUpdate.Text = "Update";
            this.btnHotelRoomUpdate.UseVisualStyleBackColor = true;
            this.btnHotelRoomUpdate.Click += new System.EventHandler(this.btnHotelRoomUpdate_Click);
            // 
            // btnHotelRoomDelete
            // 
            this.btnHotelRoomDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelRoomDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHotelRoomDelete.Location = new System.Drawing.Point(841, 543);
            this.btnHotelRoomDelete.Name = "btnHotelRoomDelete";
            this.btnHotelRoomDelete.Size = new System.Drawing.Size(65, 27);
            this.btnHotelRoomDelete.TabIndex = 96;
            this.btnHotelRoomDelete.Text = "Delete";
            this.btnHotelRoomDelete.UseVisualStyleBackColor = true;
            this.btnHotelRoomDelete.Click += new System.EventHandler(this.btnHotelRoomDelete_Click);
            // 
            // btnHotelRoomInsert
            // 
            this.btnHotelRoomInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelRoomInsert.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHotelRoomInsert.Location = new System.Drawing.Point(696, 543);
            this.btnHotelRoomInsert.Name = "btnHotelRoomInsert";
            this.btnHotelRoomInsert.Size = new System.Drawing.Size(65, 27);
            this.btnHotelRoomInsert.TabIndex = 95;
            this.btnHotelRoomInsert.Text = "Insert";
            this.btnHotelRoomInsert.UseVisualStyleBackColor = true;
            this.btnHotelRoomInsert.Click += new System.EventHandler(this.btnHotelRoomInsert_Click);
            // 
            // dgvHotelRoom
            // 
            this.dgvHotelRoom.AllowUserToAddRows = false;
            this.dgvHotelRoom.AllowUserToDeleteRows = false;
            this.dgvHotelRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel_room_ID,
            this.HotelChiName,
            this.HotelRoomName,
            this.HotelRoomSize,
            this.Max_Adult,
            this.Max_Child,
            this.Hotel_Room_Description,
            this.Fare,
            this.Hotel_ID});
            this.dgvHotelRoom.Location = new System.Drawing.Point(5, 398);
            this.dgvHotelRoom.MultiSelect = false;
            this.dgvHotelRoom.Name = "dgvHotelRoom";
            this.dgvHotelRoom.ReadOnly = true;
            this.dgvHotelRoom.RowHeadersVisible = false;
            this.dgvHotelRoom.RowTemplate.Height = 24;
            this.dgvHotelRoom.Size = new System.Drawing.Size(901, 144);
            this.dgvHotelRoom.TabIndex = 94;
            this.dgvHotelRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotelRoom_CellClick);
            // 
            // Hotel_room_ID
            // 
            this.Hotel_room_ID.HeaderText = "Hotel Room ID";
            this.Hotel_room_ID.Name = "Hotel_room_ID";
            this.Hotel_room_ID.ReadOnly = true;
            // 
            // HotelChiName
            // 
            this.HotelChiName.HeaderText = "Hotel Chinese Name";
            this.HotelChiName.Name = "HotelChiName";
            this.HotelChiName.ReadOnly = true;
            // 
            // HotelRoomName
            // 
            this.HotelRoomName.HeaderText = "Hotel Room Name";
            this.HotelRoomName.Name = "HotelRoomName";
            this.HotelRoomName.ReadOnly = true;
            // 
            // HotelRoomSize
            // 
            this.HotelRoomSize.HeaderText = "Hotel Room Size";
            this.HotelRoomSize.Name = "HotelRoomSize";
            this.HotelRoomSize.ReadOnly = true;
            // 
            // Max_Adult
            // 
            this.Max_Adult.HeaderText = "Max Adult";
            this.Max_Adult.Name = "Max_Adult";
            this.Max_Adult.ReadOnly = true;
            // 
            // Max_Child
            // 
            this.Max_Child.HeaderText = "Max Child";
            this.Max_Child.Name = "Max_Child";
            this.Max_Child.ReadOnly = true;
            // 
            // Hotel_Room_Description
            // 
            this.Hotel_Room_Description.HeaderText = "Description";
            this.Hotel_Room_Description.Name = "Hotel_Room_Description";
            this.Hotel_Room_Description.ReadOnly = true;
            // 
            // Fare
            // 
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            this.Fare.ReadOnly = true;
            // 
            // Hotel_ID
            // 
            this.Hotel_ID.HeaderText = "Hotel ID";
            this.Hotel_ID.Name = "Hotel_ID";
            this.Hotel_ID.ReadOnly = true;
            // 
            // btnHotelUpdate
            // 
            this.btnHotelUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHotelUpdate.Location = new System.Drawing.Point(767, 272);
            this.btnHotelUpdate.Name = "btnHotelUpdate";
            this.btnHotelUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnHotelUpdate.TabIndex = 91;
            this.btnHotelUpdate.Text = "Update";
            this.btnHotelUpdate.UseVisualStyleBackColor = true;
            this.btnHotelUpdate.Click += new System.EventHandler(this.btnHotelUpdate_Click);
            // 
            // btnHotelDelete
            // 
            this.btnHotelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelDelete.Location = new System.Drawing.Point(841, 272);
            this.btnHotelDelete.Name = "btnHotelDelete";
            this.btnHotelDelete.Size = new System.Drawing.Size(65, 27);
            this.btnHotelDelete.TabIndex = 90;
            this.btnHotelDelete.Text = "Delete";
            this.btnHotelDelete.UseVisualStyleBackColor = true;
            this.btnHotelDelete.Click += new System.EventHandler(this.btnHotelDelete_Click);
            // 
            // btnHotelInsert
            // 
            this.btnHotelInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelInsert.Location = new System.Drawing.Point(696, 272);
            this.btnHotelInsert.Name = "btnHotelInsert";
            this.btnHotelInsert.Size = new System.Drawing.Size(65, 27);
            this.btnHotelInsert.TabIndex = 89;
            this.btnHotelInsert.Text = "Insert";
            this.btnHotelInsert.UseVisualStyleBackColor = true;
            this.btnHotelInsert.Click += new System.EventHandler(this.btnHotelInsert_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(188, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(681, 26);
            this.txtAddress.TabIndex = 76;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(614, 56);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(78, 18);
            this.lblTelephone.TabIndex = 75;
            this.lblTelephone.Text = "Telephone:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(696, 52);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(172, 26);
            this.txtTel.TabIndex = 74;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(65, 89);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 18);
            this.lblAddress.TabIndex = 73;
            this.lblAddress.Text = "Address:";
            // 
            // txtRegion
            // 
            this.txtRegion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(444, 52);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(137, 26);
            this.txtRegion.TabIndex = 70;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(385, 56);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(55, 18);
            this.lblRegion.TabIndex = 69;
            this.lblRegion.Text = "Region:";
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(277, 52);
            this.txtRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(68, 26);
            this.txtRating.TabIndex = 68;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(223, 56);
            this.lblRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(50, 18);
            this.lblRating.TabIndex = 67;
            this.lblRating.Text = "Rating:";
            // 
            // txtStar
            // 
            this.txtStar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStar.Location = new System.Drawing.Point(124, 52);
            this.txtStar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(68, 26);
            this.txtStar.TabIndex = 66;
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.Location = new System.Drawing.Point(65, 56);
            this.lblStar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(36, 18);
            this.lblStar.TabIndex = 65;
            this.lblStar.Text = "Star:";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishName.Location = new System.Drawing.Point(697, 22);
            this.txtEnglishName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(172, 26);
            this.txtEnglishName.TabIndex = 64;
            // 
            // lblEnglishName
            // 
            this.lblEnglishName.AutoSize = true;
            this.lblEnglishName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishName.Location = new System.Drawing.Point(597, 26);
            this.lblEnglishName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnglishName.Name = "lblEnglishName";
            this.lblEnglishName.Size = new System.Drawing.Size(96, 18);
            this.lblEnglishName.TabIndex = 63;
            this.lblEnglishName.Text = "English Name:";
            // 
            // txtChineseName
            // 
            this.txtChineseName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChineseName.Location = new System.Drawing.Point(326, 22);
            this.txtChineseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChineseName.Name = "txtChineseName";
            this.txtChineseName.Size = new System.Drawing.Size(255, 26);
            this.txtChineseName.TabIndex = 62;
            // 
            // lblChineseName
            // 
            this.lblChineseName.AutoSize = true;
            this.lblChineseName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChineseName.Location = new System.Drawing.Point(220, 26);
            this.lblChineseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChineseName.Name = "lblChineseName";
            this.lblChineseName.Size = new System.Drawing.Size(102, 18);
            this.lblChineseName.TabIndex = 61;
            this.lblChineseName.Text = "Chinese Name:";
            // 
            // txtHotelID
            // 
            this.txtHotelID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotelID.Location = new System.Drawing.Point(124, 22);
            this.txtHotelID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(68, 26);
            this.txtHotelID.TabIndex = 60;
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelID.Location = new System.Drawing.Point(51, 26);
            this.lblHotelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(69, 18);
            this.lblHotelID.TabIndex = 59;
            this.lblHotelID.Text = "* HotelID:";
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.AllowUserToDeleteRows = false;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelID,
            this.HotelChineseName,
            this.HotelEnglishName,
            this.Star,
            this.Rating,
            this.Region,
            this.Address,
            this.Telephone});
            this.dgvHotel.Location = new System.Drawing.Point(33, 117);
            this.dgvHotel.MultiSelect = false;
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.ReadOnly = true;
            this.dgvHotel.RowHeadersVisible = false;
            this.dgvHotel.RowTemplate.Height = 24;
            this.dgvHotel.Size = new System.Drawing.Size(847, 150);
            this.dgvHotel.TabIndex = 52;
            this.dgvHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellClick);
            // 
            // HotelID
            // 
            this.HotelID.HeaderText = "HotelID";
            this.HotelID.Name = "HotelID";
            this.HotelID.ReadOnly = true;
            // 
            // HotelChineseName
            // 
            this.HotelChineseName.HeaderText = "HotelChineseName";
            this.HotelChineseName.Name = "HotelChineseName";
            this.HotelChineseName.ReadOnly = true;
            // 
            // HotelEnglishName
            // 
            this.HotelEnglishName.HeaderText = "HotelEnglishName";
            this.HotelEnglishName.Name = "HotelEnglishName";
            this.HotelEnglishName.ReadOnly = true;
            // 
            // Star
            // 
            this.Star.HeaderText = "Star";
            this.Star.Name = "Star";
            this.Star.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // tabCruise
            // 
            this.tabCruise.Controls.Add(this.btnOrganUpdate);
            this.tabCruise.Controls.Add(this.btnOrganDelete);
            this.tabCruise.Controls.Add(this.btnOrganInsert);
            this.tabCruise.Controls.Add(this.txtOrganEng);
            this.tabCruise.Controls.Add(this.lblEnglish);
            this.tabCruise.Controls.Add(this.txtOrganChi);
            this.tabCruise.Controls.Add(this.lblChinese);
            this.tabCruise.Controls.Add(this.txtOrganID);
            this.tabCruise.Controls.Add(this.lblOrganID);
            this.tabCruise.Controls.Add(this.dgvOrgan);
            this.tabCruise.Controls.Add(this.btnCruiseUpdate);
            this.tabCruise.Controls.Add(this.txtCruiseCount);
            this.tabCruise.Controls.Add(this.btnCruiseDelete);
            this.tabCruise.Controls.Add(this.lblCount);
            this.tabCruise.Controls.Add(this.btnCruiseInsert);
            this.tabCruise.Controls.Add(this.btnUpload);
            this.tabCruise.Controls.Add(this.numDayC);
            this.tabCruise.Controls.Add(this.dateTimePickerC);
            this.tabCruise.Controls.Add(this.comBoxOrganC);
            this.tabCruise.Controls.Add(this.lblStartDate);
            this.tabCruise.Controls.Add(this.txtInfo);
            this.tabCruise.Controls.Add(this.lblInfo);
            this.tabCruise.Controls.Add(this.lblOrganizer);
            this.tabCruise.Controls.Add(this.lblTourDay);
            this.tabCruise.Controls.Add(this.txtPrice);
            this.tabCruise.Controls.Add(this.lblPrice);
            this.tabCruise.Controls.Add(this.txtCruiseName);
            this.tabCruise.Controls.Add(this.lblCruiseName);
            this.tabCruise.Controls.Add(this.txtCruiseNo);
            this.tabCruise.Controls.Add(this.lblCruiseNo);
            this.tabCruise.Controls.Add(this.dgvCruise);
            this.tabCruise.Location = new System.Drawing.Point(4, 22);
            this.tabCruise.Name = "tabCruise";
            this.tabCruise.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCruise.Size = new System.Drawing.Size(912, 573);
            this.tabCruise.TabIndex = 2;
            this.tabCruise.Text = "Cruise Product Maintain";
            this.tabCruise.UseVisualStyleBackColor = true;
            // 
            // btnOrganUpdate
            // 
            this.btnOrganUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOrganUpdate.Location = new System.Drawing.Point(766, 540);
            this.btnOrganUpdate.Name = "btnOrganUpdate";
            this.btnOrganUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnOrganUpdate.TabIndex = 100;
            this.btnOrganUpdate.Text = "Update";
            this.btnOrganUpdate.UseVisualStyleBackColor = true;
            this.btnOrganUpdate.Click += new System.EventHandler(this.btnOrganUpdate_Click);
            // 
            // btnOrganDelete
            // 
            this.btnOrganDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOrganDelete.Location = new System.Drawing.Point(841, 540);
            this.btnOrganDelete.Name = "btnOrganDelete";
            this.btnOrganDelete.Size = new System.Drawing.Size(65, 27);
            this.btnOrganDelete.TabIndex = 99;
            this.btnOrganDelete.Text = "Delete";
            this.btnOrganDelete.UseVisualStyleBackColor = true;
            this.btnOrganDelete.Click += new System.EventHandler(this.btnOrganDelete_Click);
            // 
            // btnOrganInsert
            // 
            this.btnOrganInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganInsert.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOrganInsert.Location = new System.Drawing.Point(696, 540);
            this.btnOrganInsert.Name = "btnOrganInsert";
            this.btnOrganInsert.Size = new System.Drawing.Size(65, 27);
            this.btnOrganInsert.TabIndex = 98;
            this.btnOrganInsert.Text = "Insert";
            this.btnOrganInsert.UseVisualStyleBackColor = true;
            this.btnOrganInsert.Click += new System.EventHandler(this.btnOrganInsert_Click);
            // 
            // txtOrganEng
            // 
            this.txtOrganEng.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtOrganEng.Location = new System.Drawing.Point(314, 335);
            this.txtOrganEng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrganEng.Name = "txtOrganEng";
            this.txtOrganEng.Size = new System.Drawing.Size(106, 26);
            this.txtOrganEng.TabIndex = 97;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblEnglish.Location = new System.Drawing.Point(188, 339);
            this.lblEnglish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(106, 18);
            this.lblEnglish.TabIndex = 96;
            this.lblEnglish.Text = "* English Name:";
            // 
            // txtOrganChi
            // 
            this.txtOrganChi.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtOrganChi.Location = new System.Drawing.Point(562, 335);
            this.txtOrganChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrganChi.Name = "txtOrganChi";
            this.txtOrganChi.Size = new System.Drawing.Size(343, 26);
            this.txtOrganChi.TabIndex = 95;
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblChinese.Location = new System.Drawing.Point(440, 339);
            this.lblChinese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(102, 18);
            this.lblChinese.TabIndex = 94;
            this.lblChinese.Text = "Chinese Name:";
            // 
            // txtOrganID
            // 
            this.txtOrganID.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtOrganID.Location = new System.Drawing.Point(100, 335);
            this.txtOrganID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrganID.Name = "txtOrganID";
            this.txtOrganID.Size = new System.Drawing.Size(68, 26);
            this.txtOrganID.TabIndex = 93;
            // 
            // lblOrganID
            // 
            this.lblOrganID.AutoSize = true;
            this.lblOrganID.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblOrganID.Location = new System.Drawing.Point(8, 339);
            this.lblOrganID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrganID.Name = "lblOrganID";
            this.lblOrganID.Size = new System.Drawing.Size(72, 18);
            this.lblOrganID.TabIndex = 92;
            this.lblOrganID.Text = "* OrganID:";
            // 
            // dgvOrgan
            // 
            this.dgvOrgan.AllowUserToAddRows = false;
            this.dgvOrgan.AllowUserToDeleteRows = false;
            this.dgvOrgan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrgan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganID,
            this.EnglishName,
            this.ChineseName});
            this.dgvOrgan.Location = new System.Drawing.Point(84, 382);
            this.dgvOrgan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrgan.MultiSelect = false;
            this.dgvOrgan.Name = "dgvOrgan";
            this.dgvOrgan.ReadOnly = true;
            this.dgvOrgan.RowHeadersVisible = false;
            this.dgvOrgan.RowTemplate.Height = 31;
            this.dgvOrgan.Size = new System.Drawing.Size(744, 149);
            this.dgvOrgan.TabIndex = 91;
            this.dgvOrgan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrgan_CellClick);
            // 
            // OrganID
            // 
            this.OrganID.HeaderText = "Organ ID";
            this.OrganID.MinimumWidth = 200;
            this.OrganID.Name = "OrganID";
            this.OrganID.ReadOnly = true;
            this.OrganID.Width = 200;
            // 
            // EnglishName
            // 
            this.EnglishName.HeaderText = "English Name";
            this.EnglishName.MinimumWidth = 200;
            this.EnglishName.Name = "EnglishName";
            this.EnglishName.ReadOnly = true;
            this.EnglishName.Width = 200;
            // 
            // ChineseName
            // 
            this.ChineseName.HeaderText = "Chinese Name";
            this.ChineseName.MinimumWidth = 300;
            this.ChineseName.Name = "ChineseName";
            this.ChineseName.ReadOnly = true;
            this.ChineseName.Width = 300;
            // 
            // btnCruiseUpdate
            // 
            this.btnCruiseUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCruiseUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCruiseUpdate.Location = new System.Drawing.Point(766, 274);
            this.btnCruiseUpdate.Name = "btnCruiseUpdate";
            this.btnCruiseUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnCruiseUpdate.TabIndex = 88;
            this.btnCruiseUpdate.Text = "Update";
            this.btnCruiseUpdate.UseVisualStyleBackColor = true;
            this.btnCruiseUpdate.Click += new System.EventHandler(this.btnCruiseUpdate_Click);
            // 
            // txtCruiseCount
            // 
            this.txtCruiseCount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCruiseCount.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCruiseCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCruiseCount.Location = new System.Drawing.Point(195, 275);
            this.txtCruiseCount.Name = "txtCruiseCount";
            this.txtCruiseCount.Size = new System.Drawing.Size(169, 26);
            this.txtCruiseCount.TabIndex = 90;
            // 
            // btnCruiseDelete
            // 
            this.btnCruiseDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCruiseDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCruiseDelete.Location = new System.Drawing.Point(841, 274);
            this.btnCruiseDelete.Name = "btnCruiseDelete";
            this.btnCruiseDelete.Size = new System.Drawing.Size(65, 27);
            this.btnCruiseDelete.TabIndex = 87;
            this.btnCruiseDelete.Text = "Delete";
            this.btnCruiseDelete.UseVisualStyleBackColor = true;
            this.btnCruiseDelete.Click += new System.EventHandler(this.btnCruiseDelete_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblCount.Location = new System.Drawing.Point(6, 280);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(183, 18);
            this.lblCount.TabIndex = 89;
            this.lblCount.Text = "Product remaining quantity :";
            // 
            // btnCruiseInsert
            // 
            this.btnCruiseInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCruiseInsert.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCruiseInsert.Location = new System.Drawing.Point(696, 274);
            this.btnCruiseInsert.Name = "btnCruiseInsert";
            this.btnCruiseInsert.Size = new System.Drawing.Size(65, 27);
            this.btnCruiseInsert.TabIndex = 86;
            this.btnCruiseInsert.Text = "Insert";
            this.btnCruiseInsert.UseVisualStyleBackColor = true;
            this.btnCruiseInsert.Click += new System.EventHandler(this.btnCruiseInsert_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnUpload.Location = new System.Drawing.Point(560, 73);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(65, 26);
            this.btnUpload.TabIndex = 67;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // numDayC
            // 
            this.numDayC.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.numDayC.Location = new System.Drawing.Point(132, 73);
            this.numDayC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDayC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDayC.Name = "numDayC";
            this.numDayC.Size = new System.Drawing.Size(80, 26);
            this.numDayC.TabIndex = 66;
            this.numDayC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerC
            // 
            this.dateTimePickerC.Checked = false;
            this.dateTimePickerC.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerC.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dateTimePickerC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerC.Location = new System.Drawing.Point(732, 73);
            this.dateTimePickerC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerC.Name = "dateTimePickerC";
            this.dateTimePickerC.Size = new System.Drawing.Size(135, 26);
            this.dateTimePickerC.TabIndex = 65;
            // 
            // comBoxOrganC
            // 
            this.comBoxOrganC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoxOrganC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxOrganC.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.comBoxOrganC.FormattingEnabled = true;
            this.comBoxOrganC.Location = new System.Drawing.Point(318, 73);
            this.comBoxOrganC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comBoxOrganC.Name = "comBoxOrganC";
            this.comBoxOrganC.Size = new System.Drawing.Size(82, 26);
            this.comBoxOrganC.TabIndex = 64;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblStartDate.Location = new System.Drawing.Point(637, 77);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 18);
            this.lblStartDate.TabIndex = 63;
            this.lblStartDate.Text = "* Start Date:";
            // 
            // txtInfo
            // 
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtInfo.Enabled = false;
            this.txtInfo.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtInfo.Location = new System.Drawing.Point(461, 73);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(87, 26);
            this.txtInfo.TabIndex = 62;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblInfo.Location = new System.Drawing.Point(412, 77);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(37, 18);
            this.lblInfo.TabIndex = 61;
            this.lblInfo.Text = "Info:";
            // 
            // lblOrganizer
            // 
            this.lblOrganizer.AutoSize = true;
            this.lblOrganizer.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblOrganizer.Location = new System.Drawing.Point(224, 77);
            this.lblOrganizer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrganizer.Name = "lblOrganizer";
            this.lblOrganizer.Size = new System.Drawing.Size(82, 18);
            this.lblOrganizer.TabIndex = 60;
            this.lblOrganizer.Text = "* Organizer:";
            // 
            // lblTourDay
            // 
            this.lblTourDay.AutoSize = true;
            this.lblTourDay.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblTourDay.Location = new System.Drawing.Point(45, 77);
            this.lblTourDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTourDay.Name = "lblTourDay";
            this.lblTourDay.Size = new System.Drawing.Size(75, 18);
            this.lblTourDay.TabIndex = 59;
            this.lblTourDay.Text = "* Tour Day:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPrice.Location = new System.Drawing.Point(739, 32);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 26);
            this.txtPrice.TabIndex = 58;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblPrice.Location = new System.Drawing.Point(658, 36);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 18);
            this.lblPrice.TabIndex = 57;
            this.lblPrice.Text = "* Price:";
            // 
            // txtCruiseName
            // 
            this.txtCruiseName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCruiseName.Location = new System.Drawing.Point(367, 32);
            this.txtCruiseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCruiseName.Name = "txtCruiseName";
            this.txtCruiseName.Size = new System.Drawing.Size(263, 26);
            this.txtCruiseName.TabIndex = 56;
            // 
            // lblCruiseName
            // 
            this.lblCruiseName.AutoSize = true;
            this.lblCruiseName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblCruiseName.Location = new System.Drawing.Point(248, 36);
            this.lblCruiseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCruiseName.Name = "lblCruiseName";
            this.lblCruiseName.Size = new System.Drawing.Size(91, 18);
            this.lblCruiseName.TabIndex = 55;
            this.lblCruiseName.Text = "Cruise Name:";
            // 
            // txtCruiseNo
            // 
            this.txtCruiseNo.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCruiseNo.Location = new System.Drawing.Point(152, 32);
            this.txtCruiseNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCruiseNo.Name = "txtCruiseNo";
            this.txtCruiseNo.Size = new System.Drawing.Size(68, 26);
            this.txtCruiseNo.TabIndex = 54;
            // 
            // lblCruiseNo
            // 
            this.lblCruiseNo.AutoSize = true;
            this.lblCruiseNo.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblCruiseNo.Location = new System.Drawing.Point(45, 36);
            this.lblCruiseNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCruiseNo.Name = "lblCruiseNo";
            this.lblCruiseNo.Size = new System.Drawing.Size(79, 18);
            this.lblCruiseNo.TabIndex = 53;
            this.lblCruiseNo.Text = "* CruiseNo:";
            // 
            // dgvCruise
            // 
            this.dgvCruise.AllowUserToAddRows = false;
            this.dgvCruise.AllowUserToDeleteRows = false;
            this.dgvCruise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCruise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CruiseNo,
            this.CruiseName,
            this.Price,
            this.TourDay,
            this.Organizer,
            this.Info,
            this.StartDate});
            this.dgvCruise.Location = new System.Drawing.Point(84, 117);
            this.dgvCruise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCruise.MultiSelect = false;
            this.dgvCruise.Name = "dgvCruise";
            this.dgvCruise.ReadOnly = true;
            this.dgvCruise.RowHeadersVisible = false;
            this.dgvCruise.RowTemplate.Height = 31;
            this.dgvCruise.Size = new System.Drawing.Size(744, 149);
            this.dgvCruise.TabIndex = 49;
            this.dgvCruise.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCruise_CellClick);
            // 
            // CruiseNo
            // 
            this.CruiseNo.HeaderText = "CruiseNo";
            this.CruiseNo.Name = "CruiseNo";
            this.CruiseNo.ReadOnly = true;
            // 
            // CruiseName
            // 
            this.CruiseName.HeaderText = "CruiseName";
            this.CruiseName.Name = "CruiseName";
            this.CruiseName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TourDay
            // 
            this.TourDay.HeaderText = "TourDay";
            this.TourDay.Name = "TourDay";
            this.TourDay.ReadOnly = true;
            // 
            // Organizer
            // 
            this.Organizer.HeaderText = "Organizer";
            this.Organizer.Name = "Organizer";
            this.Organizer.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // tabAttraction
            // 
            this.tabAttraction.Controls.Add(this.txtChildPrice);
            this.tabAttraction.Controls.Add(this.lblChildPrice);
            this.tabAttraction.Controls.Add(this.txtAdultPrice);
            this.tabAttraction.Controls.Add(this.lblAdultPrice);
            this.tabAttraction.Controls.Add(this.btnUploadImage);
            this.tabAttraction.Controls.Add(this.txtCity);
            this.tabAttraction.Controls.Add(this.lblCity);
            this.tabAttraction.Controls.Add(this.txtCancellation);
            this.tabAttraction.Controls.Add(this.lblCancellation);
            this.tabAttraction.Controls.Add(this.txtDuration);
            this.tabAttraction.Controls.Add(this.lblDuration);
            this.tabAttraction.Controls.Add(this.txtAttractionName);
            this.tabAttraction.Controls.Add(this.lblName);
            this.tabAttraction.Controls.Add(this.txtQuantity);
            this.tabAttraction.Controls.Add(this.lblQuantity);
            this.tabAttraction.Controls.Add(this.btnAttractionUpdate);
            this.tabAttraction.Controls.Add(this.btnAttractionDelete);
            this.tabAttraction.Controls.Add(this.btnAttractionInsert);
            this.tabAttraction.Controls.Add(this.dgvAttraction);
            this.tabAttraction.Location = new System.Drawing.Point(4, 22);
            this.tabAttraction.Name = "tabAttraction";
            this.tabAttraction.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAttraction.Size = new System.Drawing.Size(912, 573);
            this.tabAttraction.TabIndex = 3;
            this.tabAttraction.Text = "Attraction Product Maintain";
            this.tabAttraction.UseVisualStyleBackColor = true;
            // 
            // txtChildPrice
            // 
            this.txtChildPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtChildPrice.Location = new System.Drawing.Point(727, 61);
            this.txtChildPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChildPrice.Name = "txtChildPrice";
            this.txtChildPrice.Size = new System.Drawing.Size(144, 26);
            this.txtChildPrice.TabIndex = 114;
            // 
            // lblChildPrice
            // 
            this.lblChildPrice.AutoSize = true;
            this.lblChildPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblChildPrice.Location = new System.Drawing.Point(637, 65);
            this.lblChildPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildPrice.Name = "lblChildPrice";
            this.lblChildPrice.Size = new System.Drawing.Size(78, 18);
            this.lblChildPrice.TabIndex = 113;
            this.lblChildPrice.Text = "Child Price:";
            // 
            // txtAdultPrice
            // 
            this.txtAdultPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtAdultPrice.Location = new System.Drawing.Point(727, 21);
            this.txtAdultPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdultPrice.Name = "txtAdultPrice";
            this.txtAdultPrice.Size = new System.Drawing.Size(144, 26);
            this.txtAdultPrice.TabIndex = 112;
            // 
            // lblAdultPrice
            // 
            this.lblAdultPrice.AutoSize = true;
            this.lblAdultPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblAdultPrice.Location = new System.Drawing.Point(635, 25);
            this.lblAdultPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultPrice.Name = "lblAdultPrice";
            this.lblAdultPrice.Size = new System.Drawing.Size(80, 18);
            this.lblAdultPrice.TabIndex = 111;
            this.lblAdultPrice.Text = "Adult Price:";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(565, 542);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(125, 27);
            this.btnUploadImage.TabIndex = 104;
            this.btnUploadImage.Text = "&Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCity.Location = new System.Drawing.Point(107, 62);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(212, 26);
            this.txtCity.TabIndex = 103;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblCity.Location = new System.Drawing.Point(44, 65);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 18);
            this.lblCity.TabIndex = 102;
            this.lblCity.Text = "City:";
            // 
            // txtCancellation
            // 
            this.txtCancellation.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCancellation.Location = new System.Drawing.Point(450, 62);
            this.txtCancellation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCancellation.Name = "txtCancellation";
            this.txtCancellation.Size = new System.Drawing.Size(144, 26);
            this.txtCancellation.TabIndex = 99;
            // 
            // lblCancellation
            // 
            this.lblCancellation.AutoSize = true;
            this.lblCancellation.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblCancellation.Location = new System.Drawing.Point(350, 65);
            this.lblCancellation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancellation.Name = "lblCancellation";
            this.lblCancellation.Size = new System.Drawing.Size(88, 18);
            this.lblCancellation.TabIndex = 98;
            this.lblCancellation.Text = "Cancellation:";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDuration.Location = new System.Drawing.Point(450, 21);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(144, 26);
            this.txtDuration.TabIndex = 97;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblDuration.Location = new System.Drawing.Point(350, 24);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(65, 18);
            this.lblDuration.TabIndex = 96;
            this.lblDuration.Text = "Duration:";
            // 
            // txtAttractionName
            // 
            this.txtAttractionName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtAttractionName.Location = new System.Drawing.Point(107, 21);
            this.txtAttractionName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAttractionName.Name = "txtAttractionName";
            this.txtAttractionName.Size = new System.Drawing.Size(212, 26);
            this.txtAttractionName.TabIndex = 95;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblName.Location = new System.Drawing.Point(35, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 18);
            this.lblName.TabIndex = 94;
            this.lblName.Text = "* Name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantity.Location = new System.Drawing.Point(198, 543);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(169, 26);
            this.txtQuantity.TabIndex = 93;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(9, 547);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(183, 18);
            this.lblQuantity.TabIndex = 92;
            this.lblQuantity.Text = "Product remaining quantity :";
            // 
            // btnAttractionUpdate
            // 
            this.btnAttractionUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttractionUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttractionUpdate.Location = new System.Drawing.Point(767, 542);
            this.btnAttractionUpdate.Name = "btnAttractionUpdate";
            this.btnAttractionUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnAttractionUpdate.TabIndex = 91;
            this.btnAttractionUpdate.Text = "Update";
            this.btnAttractionUpdate.UseVisualStyleBackColor = true;
            this.btnAttractionUpdate.Click += new System.EventHandler(this.btnAttractionUpdate_Click);
            // 
            // btnAttractionDelete
            // 
            this.btnAttractionDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttractionDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttractionDelete.Location = new System.Drawing.Point(841, 542);
            this.btnAttractionDelete.Name = "btnAttractionDelete";
            this.btnAttractionDelete.Size = new System.Drawing.Size(65, 27);
            this.btnAttractionDelete.TabIndex = 90;
            this.btnAttractionDelete.Text = "Delete";
            this.btnAttractionDelete.UseVisualStyleBackColor = true;
            this.btnAttractionDelete.Click += new System.EventHandler(this.btnAttractionDelete_Click);
            // 
            // btnAttractionInsert
            // 
            this.btnAttractionInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttractionInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttractionInsert.Location = new System.Drawing.Point(696, 542);
            this.btnAttractionInsert.Name = "btnAttractionInsert";
            this.btnAttractionInsert.Size = new System.Drawing.Size(65, 27);
            this.btnAttractionInsert.TabIndex = 89;
            this.btnAttractionInsert.Text = "Insert";
            this.btnAttractionInsert.UseVisualStyleBackColor = true;
            this.btnAttractionInsert.Click += new System.EventHandler(this.btnAttractionInsert_Click);
            // 
            // dgvAttraction
            // 
            this.dgvAttraction.AllowUserToAddRows = false;
            this.dgvAttraction.AllowUserToDeleteRows = false;
            this.dgvAttraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttraction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractName,
            this.Duration,
            this.Cancellation,
            this.AttractPhoto,
            this.City,
            this.AdultPrice,
            this.ChildPrice});
            this.dgvAttraction.Location = new System.Drawing.Point(2, 99);
            this.dgvAttraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAttraction.MultiSelect = false;
            this.dgvAttraction.Name = "dgvAttraction";
            this.dgvAttraction.ReadOnly = true;
            this.dgvAttraction.RowHeadersVisible = false;
            this.dgvAttraction.RowTemplate.Height = 31;
            this.dgvAttraction.Size = new System.Drawing.Size(901, 428);
            this.dgvAttraction.TabIndex = 50;
            this.dgvAttraction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttraction_CellClick);
            // 
            // AttractName
            // 
            this.AttractName.FillWeight = 200F;
            this.AttractName.HeaderText = "Name";
            this.AttractName.Name = "AttractName";
            this.AttractName.ReadOnly = true;
            this.AttractName.Width = 200;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Cancellation
            // 
            this.Cancellation.HeaderText = "Cancellation";
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.ReadOnly = true;
            // 
            // AttractPhoto
            // 
            this.AttractPhoto.HeaderText = "Photo";
            this.AttractPhoto.MinimumWidth = 200;
            this.AttractPhoto.Name = "AttractPhoto";
            this.AttractPhoto.ReadOnly = true;
            this.AttractPhoto.Width = 200;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 100;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // AdultPrice
            // 
            this.AdultPrice.HeaderText = "Adult Price";
            this.AdultPrice.Name = "AdultPrice";
            this.AdultPrice.ReadOnly = true;
            // 
            // ChildPrice
            // 
            this.ChildPrice.HeaderText = "Child Price";
            this.ChildPrice.Name = "ChildPrice";
            this.ChildPrice.ReadOnly = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Controls.Add(this.cmbSuitable);
            this.tabVehicle.Controls.Add(this.lblSuitable);
            this.tabVehicle.Controls.Add(this.txtEquipPrice);
            this.tabVehicle.Controls.Add(this.lblEquipmentPrice);
            this.tabVehicle.Controls.Add(this.txtEquipName);
            this.tabVehicle.Controls.Add(this.lblEquipmentName);
            this.tabVehicle.Controls.Add(this.txtEquipID);
            this.tabVehicle.Controls.Add(this.lblEquipmentID);
            this.tabVehicle.Controls.Add(this.btnEquipUpload);
            this.tabVehicle.Controls.Add(this.btnEquipUpdate);
            this.tabVehicle.Controls.Add(this.btnEquipDelete);
            this.tabVehicle.Controls.Add(this.btnEquipInsert);
            this.tabVehicle.Controls.Add(this.dgvEquip);
            this.tabVehicle.Controls.Add(this.cmbGear);
            this.tabVehicle.Controls.Add(this.btnVehicleUpload);
            this.tabVehicle.Controls.Add(this.btnVehicleUpdate);
            this.tabVehicle.Controls.Add(this.btnVehicleDelete);
            this.tabVehicle.Controls.Add(this.btnVehicleInsert);
            this.tabVehicle.Controls.Add(this.nudCapacity);
            this.tabVehicle.Controls.Add(this.cmbVehicleType);
            this.tabVehicle.Controls.Add(this.txtColor);
            this.tabVehicle.Controls.Add(this.lblColor);
            this.tabVehicle.Controls.Add(this.lblGear);
            this.tabVehicle.Controls.Add(this.txtVehiclePrice);
            this.tabVehicle.Controls.Add(this.lblVehiclePrice);
            this.tabVehicle.Controls.Add(this.lblType);
            this.tabVehicle.Controls.Add(this.lblCapacity);
            this.tabVehicle.Controls.Add(this.txtVehicleName);
            this.tabVehicle.Controls.Add(this.lblVehicleName);
            this.tabVehicle.Controls.Add(this.txtVehicleID);
            this.tabVehicle.Controls.Add(this.lblVehicleID);
            this.tabVehicle.Controls.Add(this.dgvVehicle);
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabVehicle.Size = new System.Drawing.Size(912, 573);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle Product Maintain";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // cmbSuitable
            // 
            this.cmbSuitable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuitable.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbSuitable.FormattingEnabled = true;
            this.cmbSuitable.Location = new System.Drawing.Point(343, 343);
            this.cmbSuitable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSuitable.Name = "cmbSuitable";
            this.cmbSuitable.Size = new System.Drawing.Size(107, 26);
            this.cmbSuitable.TabIndex = 180;
            // 
            // lblSuitable
            // 
            this.lblSuitable.AutoSize = true;
            this.lblSuitable.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblSuitable.Location = new System.Drawing.Point(205, 346);
            this.lblSuitable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuitable.Name = "lblSuitable";
            this.lblSuitable.Size = new System.Drawing.Size(63, 18);
            this.lblSuitable.TabIndex = 179;
            this.lblSuitable.Text = "Suitable:";
            // 
            // txtEquipPrice
            // 
            this.txtEquipPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtEquipPrice.Location = new System.Drawing.Point(597, 343);
            this.txtEquipPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEquipPrice.Name = "txtEquipPrice";
            this.txtEquipPrice.Size = new System.Drawing.Size(123, 26);
            this.txtEquipPrice.TabIndex = 178;
            // 
            // lblEquipmentPrice
            // 
            this.lblEquipmentPrice.AutoSize = true;
            this.lblEquipmentPrice.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblEquipmentPrice.Location = new System.Drawing.Point(504, 347);
            this.lblEquipmentPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentPrice.Name = "lblEquipmentPrice";
            this.lblEquipmentPrice.Size = new System.Drawing.Size(43, 18);
            this.lblEquipmentPrice.TabIndex = 177;
            this.lblEquipmentPrice.Text = "Price:";
            // 
            // txtEquipName
            // 
            this.txtEquipName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtEquipName.Location = new System.Drawing.Point(597, 313);
            this.txtEquipName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEquipName.Name = "txtEquipName";
            this.txtEquipName.Size = new System.Drawing.Size(123, 26);
            this.txtEquipName.TabIndex = 176;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblEquipmentName.Location = new System.Drawing.Point(504, 317);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(49, 18);
            this.lblEquipmentName.TabIndex = 175;
            this.lblEquipmentName.Text = "Name:";
            // 
            // txtEquipID
            // 
            this.txtEquipID.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtEquipID.Location = new System.Drawing.Point(343, 313);
            this.txtEquipID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEquipID.Name = "txtEquipID";
            this.txtEquipID.Size = new System.Drawing.Size(107, 26);
            this.txtEquipID.TabIndex = 174;
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblEquipmentID.Location = new System.Drawing.Point(193, 317);
            this.lblEquipmentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(106, 18);
            this.lblEquipmentID.TabIndex = 173;
            this.lblEquipmentID.Text = "* Equipment ID:";
            // 
            // btnEquipUpload
            // 
            this.btnEquipUpload.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEquipUpload.Location = new System.Drawing.Point(567, 540);
            this.btnEquipUpload.Name = "btnEquipUpload";
            this.btnEquipUpload.Size = new System.Drawing.Size(125, 27);
            this.btnEquipUpload.TabIndex = 172;
            this.btnEquipUpload.Text = "&Upload Image";
            this.btnEquipUpload.UseVisualStyleBackColor = true;
            this.btnEquipUpload.Click += new System.EventHandler(this.btnEquipUpload_Click);
            // 
            // btnEquipUpdate
            // 
            this.btnEquipUpdate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEquipUpdate.Location = new System.Drawing.Point(768, 540);
            this.btnEquipUpdate.Name = "btnEquipUpdate";
            this.btnEquipUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnEquipUpdate.TabIndex = 171;
            this.btnEquipUpdate.Text = "Update";
            this.btnEquipUpdate.UseVisualStyleBackColor = true;
            this.btnEquipUpdate.Click += new System.EventHandler(this.btnEquipUpdate_Click);
            // 
            // btnEquipDelete
            // 
            this.btnEquipDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEquipDelete.Location = new System.Drawing.Point(841, 540);
            this.btnEquipDelete.Name = "btnEquipDelete";
            this.btnEquipDelete.Size = new System.Drawing.Size(65, 27);
            this.btnEquipDelete.TabIndex = 170;
            this.btnEquipDelete.Text = "Delete";
            this.btnEquipDelete.UseVisualStyleBackColor = true;
            this.btnEquipDelete.Click += new System.EventHandler(this.btnEquipDelete_Click);
            // 
            // btnEquipInsert
            // 
            this.btnEquipInsert.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEquipInsert.Location = new System.Drawing.Point(697, 540);
            this.btnEquipInsert.Name = "btnEquipInsert";
            this.btnEquipInsert.Size = new System.Drawing.Size(65, 27);
            this.btnEquipInsert.TabIndex = 169;
            this.btnEquipInsert.Text = "Insert";
            this.btnEquipInsert.UseVisualStyleBackColor = true;
            this.btnEquipInsert.Click += new System.EventHandler(this.btnEquipInsert_Click);
            // 
            // dgvEquip
            // 
            this.dgvEquip.AllowUserToAddRows = false;
            this.dgvEquip.AllowUserToDeleteRows = false;
            this.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipment_ID,
            this.EquipName,
            this.Suitable,
            this.EquipPrice,
            this.EquipPhoto});
            this.dgvEquip.Location = new System.Drawing.Point(59, 382);
            this.dgvEquip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEquip.MultiSelect = false;
            this.dgvEquip.Name = "dgvEquip";
            this.dgvEquip.ReadOnly = true;
            this.dgvEquip.RowHeadersVisible = false;
            this.dgvEquip.RowTemplate.Height = 31;
            this.dgvEquip.Size = new System.Drawing.Size(794, 149);
            this.dgvEquip.TabIndex = 168;
            this.dgvEquip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquip_CellClick);
            // 
            // Equipment_ID
            // 
            this.Equipment_ID.HeaderText = "Equipment ID";
            this.Equipment_ID.MinimumWidth = 150;
            this.Equipment_ID.Name = "Equipment_ID";
            this.Equipment_ID.ReadOnly = true;
            this.Equipment_ID.Width = 150;
            // 
            // EquipName
            // 
            this.EquipName.HeaderText = "Name";
            this.EquipName.MinimumWidth = 150;
            this.EquipName.Name = "EquipName";
            this.EquipName.ReadOnly = true;
            this.EquipName.Width = 150;
            // 
            // Suitable
            // 
            this.Suitable.HeaderText = "Suitable";
            this.Suitable.MinimumWidth = 150;
            this.Suitable.Name = "Suitable";
            this.Suitable.ReadOnly = true;
            this.Suitable.Width = 150;
            // 
            // EquipPrice
            // 
            this.EquipPrice.HeaderText = "Price";
            this.EquipPrice.MinimumWidth = 150;
            this.EquipPrice.Name = "EquipPrice";
            this.EquipPrice.ReadOnly = true;
            this.EquipPrice.Width = 150;
            // 
            // EquipPhoto
            // 
            this.EquipPhoto.HeaderText = "Equipment Photo";
            this.EquipPhoto.MinimumWidth = 150;
            this.EquipPhoto.Name = "EquipPhoto";
            this.EquipPhoto.ReadOnly = true;
            this.EquipPhoto.Width = 150;
            // 
            // cmbGear
            // 
            this.cmbGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGear.FormattingEnabled = true;
            this.cmbGear.Location = new System.Drawing.Point(232, 72);
            this.cmbGear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGear.Name = "cmbGear";
            this.cmbGear.Size = new System.Drawing.Size(97, 26);
            this.cmbGear.TabIndex = 167;
            // 
            // btnVehicleUpload
            // 
            this.btnVehicleUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleUpload.Location = new System.Drawing.Point(567, 268);
            this.btnVehicleUpload.Name = "btnVehicleUpload";
            this.btnVehicleUpload.Size = new System.Drawing.Size(125, 27);
            this.btnVehicleUpload.TabIndex = 166;
            this.btnVehicleUpload.Text = "&Upload Image";
            this.btnVehicleUpload.UseVisualStyleBackColor = true;
            this.btnVehicleUpload.Click += new System.EventHandler(this.btnVehicleUpload_Click);
            // 
            // btnVehicleUpdate
            // 
            this.btnVehicleUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleUpdate.Location = new System.Drawing.Point(768, 268);
            this.btnVehicleUpdate.Name = "btnVehicleUpdate";
            this.btnVehicleUpdate.Size = new System.Drawing.Size(68, 27);
            this.btnVehicleUpdate.TabIndex = 165;
            this.btnVehicleUpdate.Text = "Update";
            this.btnVehicleUpdate.UseVisualStyleBackColor = true;
            this.btnVehicleUpdate.Click += new System.EventHandler(this.btnVehicleUpdate_Click);
            // 
            // btnVehicleDelete
            // 
            this.btnVehicleDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleDelete.Location = new System.Drawing.Point(841, 268);
            this.btnVehicleDelete.Name = "btnVehicleDelete";
            this.btnVehicleDelete.Size = new System.Drawing.Size(65, 27);
            this.btnVehicleDelete.TabIndex = 164;
            this.btnVehicleDelete.Text = "Delete";
            this.btnVehicleDelete.UseVisualStyleBackColor = true;
            this.btnVehicleDelete.Click += new System.EventHandler(this.btnVehicleDelete_Click);
            // 
            // btnVehicleInsert
            // 
            this.btnVehicleInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleInsert.Location = new System.Drawing.Point(697, 268);
            this.btnVehicleInsert.Name = "btnVehicleInsert";
            this.btnVehicleInsert.Size = new System.Drawing.Size(65, 27);
            this.btnVehicleInsert.TabIndex = 163;
            this.btnVehicleInsert.Text = "Insert";
            this.btnVehicleInsert.UseVisualStyleBackColor = true;
            this.btnVehicleInsert.Click += new System.EventHandler(this.btnVehicleInsert_Click);
            // 
            // nudCapacity
            // 
            this.nudCapacity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCapacity.Location = new System.Drawing.Point(453, 42);
            this.nudCapacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(71, 26);
            this.nudCapacity.TabIndex = 162;
            this.nudCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(232, 42);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(97, 26);
            this.cmbVehicleType.TabIndex = 161;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(452, 72);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(72, 26);
            this.txtColor.TabIndex = 160;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(361, 76);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 18);
            this.lblColor.TabIndex = 159;
            this.lblColor.Text = "Color:";
            // 
            // lblGear
            // 
            this.lblGear.AutoSize = true;
            this.lblGear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGear.Location = new System.Drawing.Point(115, 76);
            this.lblGear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(41, 18);
            this.lblGear.TabIndex = 158;
            this.lblGear.Text = "Gear:";
            // 
            // txtVehiclePrice
            // 
            this.txtVehiclePrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiclePrice.Location = new System.Drawing.Point(632, 42);
            this.txtVehiclePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVehiclePrice.Name = "txtVehiclePrice";
            this.txtVehiclePrice.Size = new System.Drawing.Size(167, 26);
            this.txtVehiclePrice.TabIndex = 157;
            // 
            // lblVehiclePrice
            // 
            this.lblVehiclePrice.AutoSize = true;
            this.lblVehiclePrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiclePrice.Location = new System.Drawing.Point(561, 46);
            this.lblVehiclePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehiclePrice.Name = "lblVehiclePrice";
            this.lblVehiclePrice.Size = new System.Drawing.Size(43, 18);
            this.lblVehiclePrice.TabIndex = 156;
            this.lblVehiclePrice.Text = "Price:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(115, 46);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(90, 18);
            this.lblType.TabIndex = 155;
            this.lblType.Text = "Vehicle Type:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(361, 46);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(64, 18);
            this.lblCapacity.TabIndex = 154;
            this.lblCapacity.Text = "Capacity:";
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleName.Location = new System.Drawing.Point(632, 12);
            this.txtVehicleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(167, 26);
            this.txtVehicleName.TabIndex = 153;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleName.Location = new System.Drawing.Point(552, 16);
            this.lblVehicleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(49, 18);
            this.lblVehicleName.TabIndex = 152;
            this.lblVehicleName.Text = "Name:";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.Location = new System.Drawing.Point(229, 12);
            this.txtVehicleID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(292, 26);
            this.txtVehicleID.TabIndex = 151;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.Location = new System.Drawing.Point(117, 16);
            this.lblVehicleID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(81, 18);
            this.lblVehicleID.TabIndex = 150;
            this.lblVehicleID.Text = "* VehicleID:";
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToDeleteRows = false;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.VehicleName,
            this.VehiclePrice,
            this.VehicleType,
            this.Capacity,
            this.Gear,
            this.Color,
            this.VehiclePhoto});
            this.dgvVehicle.Location = new System.Drawing.Point(33, 114);
            this.dgvVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVehicle.MultiSelect = false;
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowHeadersVisible = false;
            this.dgvVehicle.RowTemplate.Height = 31;
            this.dgvVehicle.Size = new System.Drawing.Size(846, 149);
            this.dgvVehicle.TabIndex = 149;
            this.dgvVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellClick);
            // 
            // VehicleID
            // 
            this.VehicleID.HeaderText = "Vehicle ID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            // 
            // VehicleName
            // 
            this.VehicleName.HeaderText = "Name";
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.ReadOnly = true;
            // 
            // VehiclePrice
            // 
            this.VehiclePrice.HeaderText = "Price";
            this.VehiclePrice.Name = "VehiclePrice";
            this.VehiclePrice.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Gear
            // 
            this.Gear.HeaderText = "Gear";
            this.Gear.Name = "Gear";
            this.Gear.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // VehiclePhoto
            // 
            this.VehiclePhoto.HeaderText = "Vehicle Photo";
            this.VehiclePhoto.Name = "VehiclePhoto";
            this.VehiclePhoto.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 19);
            this.lblTitle.TabIndex = 92;
            this.lblTitle.Text = "Product Mangement Console";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabManagement);
            this.Controls.Add(this.btnClose);
            this.Name = "frmProductManagement";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            this.tabManagement.ResumeLayout(false);
            this.tabFlight.ResumeLayout(false);
            this.tabFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).EndInit();
            this.tabHotel.ResumeLayout(false);
            this.tabHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.tabCruise.ResumeLayout(false);
            this.tabCruise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruise)).EndInit();
            this.tabAttraction.ResumeLayout(false);
            this.tabAttraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttraction)).EndInit();
            this.tabVehicle.ResumeLayout(false);
            this.tabVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabManagement;
        private System.Windows.Forms.TabPage tabFlight;
        private System.Windows.Forms.TabPage tabHotel;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.NumericUpDown nudMaxChild;
        private System.Windows.Forms.NumericUpDown nudMaxAdult;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label lblMaxChild;
        private System.Windows.Forms.Label lblMaxAduct;
        private System.Windows.Forms.TextBox txtRoomSize;
        private System.Windows.Forms.Label lblRoomSize;
        private System.Windows.Forms.TextBox txtHotelRoomName;
        private System.Windows.Forms.Label lblHotelRoomName;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label lblHotelChineseName;
        private System.Windows.Forms.TextBox txtHotelRoomID;
        private System.Windows.Forms.Label lblHotelRoomID;
        private System.Windows.Forms.Button btnHotelRoomUpdate;
        private System.Windows.Forms.Button btnHotelRoomDelete;
        private System.Windows.Forms.Button btnHotelRoomInsert;
        private System.Windows.Forms.DataGridView dgvHotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_room_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelChiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max_Adult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max_Child;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Room_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_ID;
        private System.Windows.Forms.Button btnHotelUpdate;
        private System.Windows.Forms.Button btnHotelDelete;
        private System.Windows.Forms.Button btnHotelInsert;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.Label lblEnglishName;
        private System.Windows.Forms.TextBox txtChineseName;
        private System.Windows.Forms.Label lblChineseName;
        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Star;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.TabPage tabCruise;
        private System.Windows.Forms.Button btnOrganUpdate;
        private System.Windows.Forms.Button btnOrganDelete;
        private System.Windows.Forms.Button btnOrganInsert;
        private System.Windows.Forms.TextBox txtOrganEng;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.TextBox txtOrganChi;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.TextBox txtOrganID;
        private System.Windows.Forms.Label lblOrganID;
        private System.Windows.Forms.DataGridView dgvOrgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseName;
        private System.Windows.Forms.Button btnCruiseUpdate;
        private System.Windows.Forms.TextBox txtCruiseCount;
        private System.Windows.Forms.Button btnCruiseDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCruiseInsert;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.NumericUpDown numDayC;
        private System.Windows.Forms.DateTimePicker dateTimePickerC;
        private System.Windows.Forms.ComboBox comBoxOrganC;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblOrganizer;
        private System.Windows.Forms.Label lblTourDay;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCruiseName;
        private System.Windows.Forms.Label lblCruiseName;
        private System.Windows.Forms.TextBox txtCruiseNo;
        private System.Windows.Forms.Label lblCruiseNo;
        private System.Windows.Forms.DataGridView dgvCruise;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.TabPage tabAttraction;
        private System.Windows.Forms.TextBox txtChildPrice;
        private System.Windows.Forms.Label lblChildPrice;
        private System.Windows.Forms.TextBox txtAdultPrice;
        private System.Windows.Forms.Label lblAdultPrice;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCancellation;
        private System.Windows.Forms.Label lblCancellation;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtAttractionName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAttractionUpdate;
        private System.Windows.Forms.Button btnAttractionDelete;
        private System.Windows.Forms.Button btnAttractionInsert;
        private System.Windows.Forms.DataGridView dgvAttraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancellation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildPrice;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbSuitable;
        private System.Windows.Forms.Label lblSuitable;
        private System.Windows.Forms.TextBox txtEquipPrice;
        private System.Windows.Forms.Label lblEquipmentPrice;
        private System.Windows.Forms.TextBox txtEquipName;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.TextBox txtEquipID;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Button btnEquipUpload;
        private System.Windows.Forms.Button btnEquipUpdate;
        private System.Windows.Forms.Button btnEquipDelete;
        private System.Windows.Forms.Button btnEquipInsert;
        private System.Windows.Forms.DataGridView dgvEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suitable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipPhoto;
        private System.Windows.Forms.ComboBox cmbGear;
        private System.Windows.Forms.Button btnVehicleUpload;
        private System.Windows.Forms.Button btnVehicleUpdate;
        private System.Windows.Forms.Button btnVehicleDelete;
        private System.Windows.Forms.Button btnVehicleInsert;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.TextBox txtVehiclePrice;
        private System.Windows.Forms.Label lblVehiclePrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiclePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiclePhoto;
        private System.Windows.Forms.ComboBox cboFlightNo;
        private System.Windows.Forms.ComboBox cboAircraft;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.ComboBox cboFlightType;
        private System.Windows.Forms.ComboBox cboOrigin;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassInsert;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn fno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtInfact;
        private System.Windows.Forms.Label lblInfact;
        private System.Windows.Forms.TextBox txtChildren;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.TextBox txtAdult;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DataGridView dgvFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedDataOfDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTimeOfDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedDataOfArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTimeOfArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightType;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.Label lblFlightType;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.DateTimePicker dtpETA;
        private System.Windows.Forms.DateTimePicker dtpETD;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.Label lblETD;
        private System.Windows.Forms.DateTimePicker dtpEDA;
        private System.Windows.Forms.Label lblEDA;
        private System.Windows.Forms.DateTimePicker dtpEDD;
        private System.Windows.Forms.Label lblEDD;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.Label lblFlightID;
        private System.Windows.Forms.Button btnFlightUpdate;
        private System.Windows.Forms.Button btnFlightDelete;
        private System.Windows.Forms.Button btnFlightInsert;
        private System.Windows.Forms.TextBox txtCarrier;
        private System.Windows.Forms.Label lblClassFlightNo;
        private System.Windows.Forms.TextBox txtClassFlightNo;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblT;
    }
}