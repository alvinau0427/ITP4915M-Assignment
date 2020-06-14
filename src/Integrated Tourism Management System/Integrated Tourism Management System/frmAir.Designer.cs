namespace Integrated_Tourism_Management_System
{
    partial class frmAir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAir));
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cboAircraft = new System.Windows.Forms.ComboBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.cboOrigin = new System.Windows.Forms.ComboBox();
            this.cboCarrier = new System.Windows.Forms.ComboBox();
            this.cboFightID = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.lblFightID = new System.Windows.Forms.Label();
            this.nudTravelTimeM = new System.Windows.Forms.NumericUpDown();
            this.nudTravelTimeH = new System.Windows.Forms.NumericUpDown();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFlightType = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblFlightType = new System.Windows.Forms.Label();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.cboFlightNo = new System.Windows.Forms.ComboBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpETA = new System.Windows.Forms.DateTimePicker();
            this.dtpETD = new System.Windows.Forms.DateTimePicker();
            this.lblETA = new System.Windows.Forms.Label();
            this.lblETD = new System.Windows.Forms.Label();
            this.dtpEDA = new System.Windows.Forms.DateTimePicker();
            this.lblEDA = new System.Windows.Forms.Label();
            this.dtpEDD = new System.Windows.Forms.DateTimePicker();
            this.lblEDD = new System.Windows.Forms.Label();
            this.dgvDefault = new System.Windows.Forms.DataGridView();
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
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.fno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grpReminder = new System.Windows.Forms.GroupBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravelTimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravelTimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.cboAircraft);
            this.grpSearch.Controls.Add(this.cboDestination);
            this.grpSearch.Controls.Add(this.cboOrigin);
            this.grpSearch.Controls.Add(this.cboCarrier);
            this.grpSearch.Controls.Add(this.cboFightID);
            this.grpSearch.Controls.Add(this.m);
            this.grpSearch.Controls.Add(this.h);
            this.grpSearch.Controls.Add(this.lblFightID);
            this.grpSearch.Controls.Add(this.nudTravelTimeM);
            this.grpSearch.Controls.Add(this.nudTravelTimeH);
            this.grpSearch.Controls.Add(this.lblAircraft);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.cboFlightType);
            this.grpSearch.Controls.Add(this.lblDestination);
            this.grpSearch.Controls.Add(this.lblFlightType);
            this.grpSearch.Controls.Add(this.lblFlightNo);
            this.grpSearch.Controls.Add(this.cboFlightNo);
            this.grpSearch.Controls.Add(this.lblOrigin);
            this.grpSearch.Controls.Add(this.lblCarrier);
            this.grpSearch.Controls.Add(this.txtKeyword);
            this.grpSearch.Controls.Add(this.lblKeyword);
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.dtpETA);
            this.grpSearch.Controls.Add(this.dtpETD);
            this.grpSearch.Controls.Add(this.lblETA);
            this.grpSearch.Controls.Add(this.lblETD);
            this.grpSearch.Controls.Add(this.dtpEDA);
            this.grpSearch.Controls.Add(this.lblEDA);
            this.grpSearch.Controls.Add(this.dtpEDD);
            this.grpSearch.Controls.Add(this.lblEDD);
            this.grpSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(12, 88);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(908, 221);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Console";
            // 
            // cboAircraft
            // 
            this.cboAircraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAircraft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAircraft.FormattingEnabled = true;
            this.cboAircraft.Items.AddRange(new object[] {
            "All"});
            this.cboAircraft.Location = new System.Drawing.Point(811, 23);
            this.cboAircraft.Name = "cboAircraft";
            this.cboAircraft.Size = new System.Drawing.Size(96, 27);
            this.cboAircraft.TabIndex = 67;
            // 
            // cboDestination
            // 
            this.cboDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Items.AddRange(new object[] {
            "All"});
            this.cboDestination.Location = new System.Drawing.Point(634, 23);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(96, 27);
            this.cboDestination.TabIndex = 66;
            // 
            // cboOrigin
            // 
            this.cboOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigin.FormattingEnabled = true;
            this.cboOrigin.Items.AddRange(new object[] {
            "All"});
            this.cboOrigin.Location = new System.Drawing.Point(443, 23);
            this.cboOrigin.Name = "cboOrigin";
            this.cboOrigin.Size = new System.Drawing.Size(83, 27);
            this.cboOrigin.TabIndex = 65;
            // 
            // cboCarrier
            // 
            this.cboCarrier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarrier.FormattingEnabled = true;
            this.cboCarrier.Items.AddRange(new object[] {
            "All"});
            this.cboCarrier.Location = new System.Drawing.Point(261, 23);
            this.cboCarrier.Name = "cboCarrier";
            this.cboCarrier.Size = new System.Drawing.Size(116, 27);
            this.cboCarrier.TabIndex = 64;
            // 
            // cboFightID
            // 
            this.cboFightID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFightID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFightID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFightID.FormattingEnabled = true;
            this.cboFightID.Items.AddRange(new object[] {
            "All"});
            this.cboFightID.Location = new System.Drawing.Point(88, 23);
            this.cboFightID.Name = "cboFightID";
            this.cboFightID.Size = new System.Drawing.Size(96, 27);
            this.cboFightID.TabIndex = 63;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.Location = new System.Drawing.Point(707, 109);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(21, 19);
            this.m.TabIndex = 62;
            this.m.Text = "m";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(600, 109);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(17, 19);
            this.h.TabIndex = 61;
            this.h.Text = "h";
            // 
            // lblFightID
            // 
            this.lblFightID.AutoSize = true;
            this.lblFightID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFightID.Location = new System.Drawing.Point(13, 27);
            this.lblFightID.Name = "lblFightID";
            this.lblFightID.Size = new System.Drawing.Size(67, 19);
            this.lblFightID.TabIndex = 39;
            this.lblFightID.Text = "Fight ID :";
            // 
            // nudTravelTimeM
            // 
            this.nudTravelTimeM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTravelTimeM.Location = new System.Drawing.Point(624, 105);
            this.nudTravelTimeM.Name = "nudTravelTimeM";
            this.nudTravelTimeM.Size = new System.Drawing.Size(77, 27);
            this.nudTravelTimeM.TabIndex = 60;
            // 
            // nudTravelTimeH
            // 
            this.nudTravelTimeH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTravelTimeH.Location = new System.Drawing.Point(517, 105);
            this.nudTravelTimeH.Name = "nudTravelTimeH";
            this.nudTravelTimeH.Size = new System.Drawing.Size(77, 27);
            this.nudTravelTimeH.TabIndex = 59;
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraft.Location = new System.Drawing.Point(738, 27);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(65, 19);
            this.lblAircraft.TabIndex = 37;
            this.lblAircraft.Text = "Aircraft :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Travel Time :";
            // 
            // cboFlightType
            // 
            this.cboFlightType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFlightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlightType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFlightType.FormattingEnabled = true;
            this.cboFlightType.Items.AddRange(new object[] {
            "All"});
            this.cboFlightType.Location = new System.Drawing.Point(758, 63);
            this.cboFlightType.Name = "cboFlightType";
            this.cboFlightType.Size = new System.Drawing.Size(136, 27);
            this.cboFlightType.TabIndex = 24;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(534, 27);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(92, 19);
            this.lblDestination.TabIndex = 34;
            this.lblDestination.Text = "Destination :";
            // 
            // lblFlightType
            // 
            this.lblFlightType.AutoSize = true;
            this.lblFlightType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightType.Location = new System.Drawing.Point(663, 67);
            this.lblFlightType.Name = "lblFlightType";
            this.lblFlightType.Size = new System.Drawing.Size(87, 19);
            this.lblFlightType.TabIndex = 23;
            this.lblFlightType.Text = "Flight Type :";
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.lblFlightNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNo.Location = new System.Drawing.Point(425, 67);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(79, 19);
            this.lblFlightNo.TabIndex = 21;
            this.lblFlightNo.Text = "Flight No. :";
            // 
            // cboFlightNo
            // 
            this.cboFlightNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFlightNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlightNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFlightNo.FormattingEnabled = true;
            this.cboFlightNo.Items.AddRange(new object[] {
            "All"});
            this.cboFlightNo.Location = new System.Drawing.Point(505, 63);
            this.cboFlightNo.Name = "cboFlightNo";
            this.cboFlightNo.Size = new System.Drawing.Size(136, 27);
            this.cboFlightNo.TabIndex = 22;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(381, 27);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(57, 19);
            this.lblOrigin.TabIndex = 33;
            this.lblOrigin.Text = "Origin :";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.Location = new System.Drawing.Point(192, 27);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(61, 19);
            this.lblCarrier.TabIndex = 31;
            this.lblCarrier.Text = "Carrier :";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.Gray;
            this.txtKeyword.Location = new System.Drawing.Point(505, 148);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(402, 27);
            this.txtKeyword.TabIndex = 27;
            this.txtKeyword.Text = "Please enter keywords for search ...";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(426, 153);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(79, 19);
            this.lblKeyword.TabIndex = 26;
            this.lblKeyword.Text = "Keywords :";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(819, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(738, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpETA
            // 
            this.dtpETA.CustomFormat = "hh:mm";
            this.dtpETA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETA.Location = new System.Drawing.Point(261, 185);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.ShowUpDown = true;
            this.dtpETA.Size = new System.Drawing.Size(132, 27);
            this.dtpETA.TabIndex = 12;
            // 
            // dtpETD
            // 
            this.dtpETD.CustomFormat = "hh:mm";
            this.dtpETD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpETD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETD.Location = new System.Drawing.Point(261, 145);
            this.dtpETD.Name = "dtpETD";
            this.dtpETD.ShowUpDown = true;
            this.dtpETD.Size = new System.Drawing.Size(132, 27);
            this.dtpETD.TabIndex = 11;
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETA.Location = new System.Drawing.Point(8, 191);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(222, 19);
            this.lblETA.TabIndex = 9;
            this.lblETA.Text = "Estimated Time Of Arrival (ETA) :";
            // 
            // lblETD
            // 
            this.lblETD.AutoSize = true;
            this.lblETD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETD.Location = new System.Drawing.Point(8, 151);
            this.lblETD.Name = "lblETD";
            this.lblETD.Size = new System.Drawing.Size(247, 19);
            this.lblETD.TabIndex = 8;
            this.lblETD.Text = "Estimated Time Of Departure (ETD) :";
            // 
            // dtpEDA
            // 
            this.dtpEDA.CustomFormat = "dd - MM - yyyy";
            this.dtpEDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDA.Location = new System.Drawing.Point(261, 105);
            this.dtpEDA.Name = "dtpEDA";
            this.dtpEDA.Size = new System.Drawing.Size(132, 27);
            this.dtpEDA.TabIndex = 5;
            // 
            // lblEDA
            // 
            this.lblEDA.AutoSize = true;
            this.lblEDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDA.Location = new System.Drawing.Point(8, 71);
            this.lblEDA.Name = "lblEDA";
            this.lblEDA.Size = new System.Drawing.Size(224, 19);
            this.lblEDA.TabIndex = 4;
            this.lblEDA.Text = "Estimated Date Of Arrival (EDA) :";
            // 
            // dtpEDD
            // 
            this.dtpEDD.CustomFormat = "dd - MM - yyyy";
            this.dtpEDD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDD.Location = new System.Drawing.Point(261, 65);
            this.dtpEDD.Name = "dtpEDD";
            this.dtpEDD.Size = new System.Drawing.Size(132, 27);
            this.dtpEDD.TabIndex = 3;
            this.dtpEDD.Value = new System.DateTime(2016, 5, 24, 22, 37, 49, 0);
            // 
            // lblEDD
            // 
            this.lblEDD.AutoSize = true;
            this.lblEDD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDD.Location = new System.Drawing.Point(8, 111);
            this.lblEDD.Name = "lblEDD";
            this.lblEDD.Size = new System.Drawing.Size(248, 19);
            this.lblEDD.TabIndex = 2;
            this.lblEDD.Text = "Estimated Date Of Departure (EDD) :";
            // 
            // dgvDefault
            // 
            this.dgvDefault.AllowUserToAddRows = false;
            this.dgvDefault.AllowUserToDeleteRows = false;
            this.dgvDefault.AllowUserToResizeColumns = false;
            this.dgvDefault.AllowUserToResizeRows = false;
            this.dgvDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvDefault.Location = new System.Drawing.Point(12, 315);
            this.dgvDefault.MultiSelect = false;
            this.dgvDefault.Name = "dgvDefault";
            this.dgvDefault.ReadOnly = true;
            this.dgvDefault.RowHeadersVisible = false;
            this.dgvDefault.RowTemplate.Height = 24;
            this.dgvDefault.Size = new System.Drawing.Size(908, 300);
            this.dgvDefault.TabIndex = 48;
            this.dgvDefault.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefault_CellClick);
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
            this.dgvClass.Location = new System.Drawing.Point(12, 621);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(908, 70);
            this.dgvClass.TabIndex = 49;
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
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 53;
            this.picLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(845, 747);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(765, 747);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 29);
            this.btnOrder.TabIndex = 56;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // grpReminder
            // 
            this.grpReminder.Controls.Add(this.lblTip);
            this.grpReminder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReminder.Location = new System.Drawing.Point(12, 697);
            this.grpReminder.Name = "grpReminder";
            this.grpReminder.Size = new System.Drawing.Size(492, 79);
            this.grpReminder.TabIndex = 72;
            this.grpReminder.TabStop = false;
            this.grpReminder.Text = "Kindly Reminder";
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Image = ((System.Drawing.Image)(resources.GetObject("lblTip.Image")));
            this.lblTip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTip.Location = new System.Drawing.Point(19, 27);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(467, 38);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "You shound select the choice of air ticket before choosing hotel.";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 715);
            this.ControlBox = false;
            this.Controls.Add(this.grpReminder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.dgvDefault);
            this.Controls.Add(this.grpSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAir";
            this.Load += new System.EventHandler(this.frmAir_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravelTimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravelTimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpReminder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.Label lblETD;
        private System.Windows.Forms.DateTimePicker dtpEDA;
        private System.Windows.Forms.Label lblEDA;
        private System.Windows.Forms.DateTimePicker dtpEDD;
        private System.Windows.Forms.Label lblEDD;
        private System.Windows.Forms.DateTimePicker dtpETD;
        private System.Windows.Forms.DateTimePicker dtpETA;
        private System.Windows.Forms.ComboBox cboFlightType;
        private System.Windows.Forms.Label lblFlightType;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.ComboBox cboFlightNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.NumericUpDown nudTravelTimeM;
        private System.Windows.Forms.NumericUpDown nudTravelTimeH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDefault;
        private System.Windows.Forms.ComboBox cboFightID;
        private System.Windows.Forms.Label lblFightID;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.ComboBox cboCarrier;
        private System.Windows.Forms.ComboBox cboOrigin;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.ComboBox cboAircraft;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox grpReminder;
        private System.Windows.Forms.Label lblTip;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
    }
}