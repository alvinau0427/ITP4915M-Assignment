namespace Integrated_Tourism_Management_System
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.grpTicket = new System.Windows.Forms.GroupBox();
            this.txtTicketTotal = new System.Windows.Forms.TextBox();
            this.btnTicketOk = new System.Windows.Forms.Button();
            this.lblTicketTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdultTax = new System.Windows.Forms.TextBox();
            this.txtInfantTax = new System.Windows.Forms.TextBox();
            this.txtInfantPrice = new System.Windows.Forms.TextBox();
            this.lblAdultTax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChildTax = new System.Windows.Forms.TextBox();
            this.txtChildPrice = new System.Windows.Forms.TextBox();
            this.txtAdultPrice = new System.Windows.Forms.TextBox();
            this.nudInfantPerson = new System.Windows.Forms.NumericUpDown();
            this.nudChildPerson = new System.Windows.Forms.NumericUpDown();
            this.nudAdultPerson = new System.Windows.Forms.NumericUpDown();
            this.lblInfantPerson = new System.Windows.Forms.Label();
            this.lblChildPerson = new System.Windows.Forms.Label();
            this.lblAdultPerson = new System.Windows.Forms.Label();
            this.lblInfantPrice = new System.Windows.Forms.Label();
            this.lblChildPrice = new System.Windows.Forms.Label();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmoClass = new System.Windows.Forms.ComboBox();
            this.grpHotel = new System.Windows.Forms.GroupBox();
            this.txtNight = new System.Windows.Forms.TextBox();
            this.lblShowDiscount = new System.Windows.Forms.TextBox();
            this.txtHotelTotal = new System.Windows.Forms.TextBox();
            this.txthotelRoomPrice = new System.Windows.Forms.TextBox();
            this.lblHotelTotal = new System.Windows.Forms.Label();
            this.lblRoom1Night = new System.Windows.Forms.Label();
            this.lblRoom1Price = new System.Windows.Forms.Label();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.btnHotelOk = new System.Windows.Forms.Button();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtNumberTag = new System.Windows.Forms.TextBox();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.HotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_chi_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_en_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max_Adult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max_Child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfantPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultPerson)).BeginInit();
            this.grpHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTicket
            // 
            this.grpTicket.Controls.Add(this.txtTicketTotal);
            this.grpTicket.Controls.Add(this.btnTicketOk);
            this.grpTicket.Controls.Add(this.lblTicketTotal);
            this.grpTicket.Controls.Add(this.label2);
            this.grpTicket.Controls.Add(this.txtAdultTax);
            this.grpTicket.Controls.Add(this.txtInfantTax);
            this.grpTicket.Controls.Add(this.txtInfantPrice);
            this.grpTicket.Controls.Add(this.lblAdultTax);
            this.grpTicket.Controls.Add(this.label1);
            this.grpTicket.Controls.Add(this.txtChildTax);
            this.grpTicket.Controls.Add(this.txtChildPrice);
            this.grpTicket.Controls.Add(this.txtAdultPrice);
            this.grpTicket.Controls.Add(this.nudInfantPerson);
            this.grpTicket.Controls.Add(this.nudChildPerson);
            this.grpTicket.Controls.Add(this.nudAdultPerson);
            this.grpTicket.Controls.Add(this.lblInfantPerson);
            this.grpTicket.Controls.Add(this.lblChildPerson);
            this.grpTicket.Controls.Add(this.lblAdultPerson);
            this.grpTicket.Controls.Add(this.lblInfantPrice);
            this.grpTicket.Controls.Add(this.lblChildPrice);
            this.grpTicket.Controls.Add(this.lblAdult);
            this.grpTicket.Controls.Add(this.lblClass);
            this.grpTicket.Controls.Add(this.cmoClass);
            this.grpTicket.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTicket.Location = new System.Drawing.Point(18, 321);
            this.grpTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTicket.Name = "grpTicket";
            this.grpTicket.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTicket.Size = new System.Drawing.Size(1354, 194);
            this.grpTicket.TabIndex = 8;
            this.grpTicket.TabStop = false;
            this.grpTicket.Text = "Air Ticket";
            // 
            // txtTicketTotal
            // 
            this.txtTicketTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTicketTotal.Enabled = false;
            this.txtTicketTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketTotal.Location = new System.Drawing.Point(1176, 34);
            this.txtTicketTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTicketTotal.Name = "txtTicketTotal";
            this.txtTicketTotal.ReadOnly = true;
            this.txtTicketTotal.Size = new System.Drawing.Size(168, 37);
            this.txtTicketTotal.TabIndex = 68;
            // 
            // btnTicketOk
            // 
            this.btnTicketOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketOk.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnTicketOk.Location = new System.Drawing.Point(1233, 84);
            this.btnTicketOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTicketOk.Name = "btnTicketOk";
            this.btnTicketOk.Size = new System.Drawing.Size(112, 44);
            this.btnTicketOk.TabIndex = 97;
            this.btnTicketOk.Text = "OK";
            this.btnTicketOk.UseVisualStyleBackColor = true;
            this.btnTicketOk.Click += new System.EventHandler(this.btnTicketOk_Click);
            // 
            // lblTicketTotal
            // 
            this.lblTicketTotal.AutoSize = true;
            this.lblTicketTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketTotal.Location = new System.Drawing.Point(1026, 34);
            this.lblTicketTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketTotal.Name = "lblTicketTotal";
            this.lblTicketTotal.Size = new System.Drawing.Size(146, 36);
            this.lblTicketTotal.TabIndex = 67;
            this.lblTicketTotal.Text = "Subtotal = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 96;
            this.label2.Text = "Adult Tax: ";
            // 
            // txtAdultTax
            // 
            this.txtAdultTax.Enabled = false;
            this.txtAdultTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdultTax.Location = new System.Drawing.Point(648, 36);
            this.txtAdultTax.Name = "txtAdultTax";
            this.txtAdultTax.Size = new System.Drawing.Size(114, 37);
            this.txtAdultTax.TabIndex = 95;
            // 
            // txtInfantTax
            // 
            this.txtInfantTax.Enabled = false;
            this.txtInfantTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfantTax.Location = new System.Drawing.Point(646, 134);
            this.txtInfantTax.Name = "txtInfantTax";
            this.txtInfantTax.Size = new System.Drawing.Size(114, 37);
            this.txtInfantTax.TabIndex = 92;
            // 
            // txtInfantPrice
            // 
            this.txtInfantPrice.Enabled = false;
            this.txtInfantPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfantPrice.Location = new System.Drawing.Point(387, 134);
            this.txtInfantPrice.Name = "txtInfantPrice";
            this.txtInfantPrice.Size = new System.Drawing.Size(114, 37);
            this.txtInfantPrice.TabIndex = 91;
            // 
            // lblAdultTax
            // 
            this.lblAdultTax.AutoSize = true;
            this.lblAdultTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultTax.Location = new System.Drawing.Point(518, 140);
            this.lblAdultTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdultTax.Name = "lblAdultTax";
            this.lblAdultTax.Size = new System.Drawing.Size(120, 29);
            this.lblAdultTax.TabIndex = 82;
            this.lblAdultTax.Text = "Infant Tax: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 94;
            this.label1.Text = "Child Tax: ";
            // 
            // txtChildTax
            // 
            this.txtChildTax.Enabled = false;
            this.txtChildTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildTax.Location = new System.Drawing.Point(648, 84);
            this.txtChildTax.Name = "txtChildTax";
            this.txtChildTax.Size = new System.Drawing.Size(112, 37);
            this.txtChildTax.TabIndex = 93;
            // 
            // txtChildPrice
            // 
            this.txtChildPrice.Enabled = false;
            this.txtChildPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildPrice.Location = new System.Drawing.Point(388, 84);
            this.txtChildPrice.Name = "txtChildPrice";
            this.txtChildPrice.Size = new System.Drawing.Size(112, 37);
            this.txtChildPrice.TabIndex = 90;
            // 
            // txtAdultPrice
            // 
            this.txtAdultPrice.Enabled = false;
            this.txtAdultPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdultPrice.Location = new System.Drawing.Point(388, 36);
            this.txtAdultPrice.Name = "txtAdultPrice";
            this.txtAdultPrice.Size = new System.Drawing.Size(114, 37);
            this.txtAdultPrice.TabIndex = 89;
            // 
            // nudInfantPerson
            // 
            this.nudInfantPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInfantPerson.Location = new System.Drawing.Point(878, 134);
            this.nudInfantPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudInfantPerson.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInfantPerson.Name = "nudInfantPerson";
            this.nudInfantPerson.Size = new System.Drawing.Size(116, 37);
            this.nudInfantPerson.TabIndex = 88;
            this.nudInfantPerson.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nudInfantPerson_MouseUp);
            // 
            // nudChildPerson
            // 
            this.nudChildPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudChildPerson.Location = new System.Drawing.Point(879, 84);
            this.nudChildPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudChildPerson.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudChildPerson.Name = "nudChildPerson";
            this.nudChildPerson.Size = new System.Drawing.Size(114, 37);
            this.nudChildPerson.TabIndex = 87;
            this.nudChildPerson.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nudChildPerson_MouseUp);
            // 
            // nudAdultPerson
            // 
            this.nudAdultPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdultPerson.Location = new System.Drawing.Point(878, 36);
            this.nudAdultPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAdultPerson.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAdultPerson.Name = "nudAdultPerson";
            this.nudAdultPerson.Size = new System.Drawing.Size(116, 37);
            this.nudAdultPerson.TabIndex = 86;
            this.nudAdultPerson.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultPerson.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nudAdultPerson_MouseUp);
            // 
            // lblInfantPerson
            // 
            this.lblInfantPerson.AutoSize = true;
            this.lblInfantPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfantPerson.Location = new System.Drawing.Point(777, 140);
            this.lblInfantPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfantPerson.Name = "lblInfantPerson";
            this.lblInfantPerson.Size = new System.Drawing.Size(91, 29);
            this.lblInfantPerson.TabIndex = 85;
            this.lblInfantPerson.Text = "Person :";
            // 
            // lblChildPerson
            // 
            this.lblChildPerson.AutoSize = true;
            this.lblChildPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildPerson.Location = new System.Drawing.Point(777, 90);
            this.lblChildPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildPerson.Name = "lblChildPerson";
            this.lblChildPerson.Size = new System.Drawing.Size(91, 29);
            this.lblChildPerson.TabIndex = 84;
            this.lblChildPerson.Text = "Person :";
            // 
            // lblAdultPerson
            // 
            this.lblAdultPerson.AutoSize = true;
            this.lblAdultPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultPerson.Location = new System.Drawing.Point(777, 42);
            this.lblAdultPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdultPerson.Name = "lblAdultPerson";
            this.lblAdultPerson.Size = new System.Drawing.Size(91, 29);
            this.lblAdultPerson.TabIndex = 83;
            this.lblAdultPerson.Text = "Person :";
            // 
            // lblInfantPrice
            // 
            this.lblInfantPrice.AutoSize = true;
            this.lblInfantPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfantPrice.Location = new System.Drawing.Point(243, 140);
            this.lblInfantPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfantPrice.Name = "lblInfantPrice";
            this.lblInfantPrice.Size = new System.Drawing.Size(136, 29);
            this.lblInfantPrice.TabIndex = 81;
            this.lblInfantPrice.Text = "Infant Price :";
            // 
            // lblChildPrice
            // 
            this.lblChildPrice.AutoSize = true;
            this.lblChildPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildPrice.Location = new System.Drawing.Point(243, 90);
            this.lblChildPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildPrice.Name = "lblChildPrice";
            this.lblChildPrice.Size = new System.Drawing.Size(128, 29);
            this.lblChildPrice.TabIndex = 80;
            this.lblChildPrice.Text = "Child Price :";
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(242, 42);
            this.lblAdult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(131, 29);
            this.lblAdult.TabIndex = 79;
            this.lblAdult.Text = "Adult Price :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(14, 44);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(73, 29);
            this.lblClass.TabIndex = 72;
            this.lblClass.Text = "Class :";
            // 
            // cmoClass
            // 
            this.cmoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmoClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmoClass.FormattingEnabled = true;
            this.cmoClass.Location = new System.Drawing.Point(100, 38);
            this.cmoClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmoClass.Name = "cmoClass";
            this.cmoClass.Size = new System.Drawing.Size(112, 37);
            this.cmoClass.TabIndex = 73;
            this.cmoClass.SelectedIndexChanged += new System.EventHandler(this.cmoClass_SelectedIndexChanged);
            // 
            // grpHotel
            // 
            this.grpHotel.Controls.Add(this.txtNight);
            this.grpHotel.Controls.Add(this.lblShowDiscount);
            this.grpHotel.Controls.Add(this.txtHotelTotal);
            this.grpHotel.Controls.Add(this.txthotelRoomPrice);
            this.grpHotel.Controls.Add(this.lblHotelTotal);
            this.grpHotel.Controls.Add(this.lblRoom1Night);
            this.grpHotel.Controls.Add(this.lblRoom1Price);
            this.grpHotel.Controls.Add(this.dtpCheckout);
            this.grpHotel.Controls.Add(this.lblCheckout);
            this.grpHotel.Controls.Add(this.btnHotelOk);
            this.grpHotel.Controls.Add(this.dtpCheckin);
            this.grpHotel.Controls.Add(this.lblCheckin);
            this.grpHotel.Controls.Add(this.chkDiscount);
            this.grpHotel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHotel.Location = new System.Drawing.Point(18, 712);
            this.grpHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpHotel.Name = "grpHotel";
            this.grpHotel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpHotel.Size = new System.Drawing.Size(1354, 156);
            this.grpHotel.TabIndex = 57;
            this.grpHotel.TabStop = false;
            this.grpHotel.Text = "Hotel";
            // 
            // txtNight
            // 
            this.txtNight.Enabled = false;
            this.txtNight.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtNight.Location = new System.Drawing.Point(410, 102);
            this.txtNight.Name = "txtNight";
            this.txtNight.Size = new System.Drawing.Size(114, 37);
            this.txtNight.TabIndex = 106;
            // 
            // lblShowDiscount
            // 
            this.lblShowDiscount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblShowDiscount.Enabled = false;
            this.lblShowDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDiscount.Location = new System.Drawing.Point(834, 98);
            this.lblShowDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblShowDiscount.Name = "lblShowDiscount";
            this.lblShowDiscount.ReadOnly = true;
            this.lblShowDiscount.Size = new System.Drawing.Size(196, 37);
            this.lblShowDiscount.TabIndex = 105;
            this.lblShowDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHotelTotal
            // 
            this.txtHotelTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHotelTotal.Enabled = false;
            this.txtHotelTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotelTotal.Location = new System.Drawing.Point(1174, 34);
            this.txtHotelTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHotelTotal.Name = "txtHotelTotal";
            this.txtHotelTotal.ReadOnly = true;
            this.txtHotelTotal.Size = new System.Drawing.Size(168, 37);
            this.txtHotelTotal.TabIndex = 68;
            // 
            // txthotelRoomPrice
            // 
            this.txthotelRoomPrice.Enabled = false;
            this.txthotelRoomPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.txthotelRoomPrice.Location = new System.Drawing.Point(130, 99);
            this.txthotelRoomPrice.Name = "txthotelRoomPrice";
            this.txthotelRoomPrice.Size = new System.Drawing.Size(148, 37);
            this.txthotelRoomPrice.TabIndex = 104;
            // 
            // lblHotelTotal
            // 
            this.lblHotelTotal.AutoSize = true;
            this.lblHotelTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelTotal.Location = new System.Drawing.Point(1024, 36);
            this.lblHotelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotelTotal.Name = "lblHotelTotal";
            this.lblHotelTotal.Size = new System.Drawing.Size(146, 36);
            this.lblHotelTotal.TabIndex = 67;
            this.lblHotelTotal.Text = "Subtotal = ";
            // 
            // lblRoom1Night
            // 
            this.lblRoom1Night.AutoSize = true;
            this.lblRoom1Night.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblRoom1Night.Location = new System.Drawing.Point(324, 105);
            this.lblRoom1Night.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom1Night.Name = "lblRoom1Night";
            this.lblRoom1Night.Size = new System.Drawing.Size(78, 29);
            this.lblRoom1Night.TabIndex = 102;
            this.lblRoom1Night.Text = "Night :";
            // 
            // lblRoom1Price
            // 
            this.lblRoom1Price.AutoSize = true;
            this.lblRoom1Price.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblRoom1Price.Location = new System.Drawing.Point(14, 105);
            this.lblRoom1Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom1Price.Name = "lblRoom1Price";
            this.lblRoom1Price.Size = new System.Drawing.Size(72, 29);
            this.lblRoom1Price.TabIndex = 101;
            this.lblRoom1Price.Text = "Price :";
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.CustomFormat = "dd - MM - yyyy";
            this.dtpCheckout.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckout.Location = new System.Drawing.Point(627, 36);
            this.dtpCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(210, 37);
            this.dtpCheckout.TabIndex = 100;
            this.dtpCheckout.Value = new System.DateTime(2016, 5, 24, 22, 37, 49, 0);
            this.dtpCheckout.ValueChanged += new System.EventHandler(this.dtpCheckout_ValueChanged);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCheckout.Location = new System.Drawing.Point(432, 42);
            this.lblCheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(175, 29);
            this.lblCheckout.TabIndex = 99;
            this.lblCheckout.Text = "Check-out Date :";
            // 
            // btnHotelOk
            // 
            this.btnHotelOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelOk.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHotelOk.Location = new System.Drawing.Point(1232, 90);
            this.btnHotelOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHotelOk.Name = "btnHotelOk";
            this.btnHotelOk.Size = new System.Drawing.Size(112, 44);
            this.btnHotelOk.TabIndex = 98;
            this.btnHotelOk.Text = "OK";
            this.btnHotelOk.UseVisualStyleBackColor = true;
            this.btnHotelOk.Click += new System.EventHandler(this.btnHotelOk_Click);
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.CustomFormat = "dd - MM - yyyy";
            this.dtpCheckin.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckin.Location = new System.Drawing.Point(200, 36);
            this.dtpCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(210, 37);
            this.dtpCheckin.TabIndex = 73;
            this.dtpCheckin.Value = new System.DateTime(2016, 5, 24, 22, 37, 49, 0);
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCheckin.Location = new System.Drawing.Point(18, 42);
            this.lblCheckin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(160, 29);
            this.lblCheckin.TabIndex = 72;
            this.lblCheckin.Text = "Check-in Date :";
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Font = new System.Drawing.Font("Calibri", 11F);
            this.chkDiscount.Location = new System.Drawing.Point(578, 102);
            this.chkDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(243, 31);
            this.chkDiscount.TabIndex = 87;
            this.chkDiscount.Text = "Bundle discount($150)";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.chkDiscount_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(18, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(375, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 88;
            this.picLogo.TabStop = false;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTag.Location = new System.Drawing.Point(968, 22);
            this.lblTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(143, 29);
            this.lblTag.TabIndex = 90;
            this.lblTag.Text = "Number Tag :";
            // 
            // txtNumberTag
            // 
            this.txtNumberTag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumberTag.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberTag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumberTag.Location = new System.Drawing.Point(1119, 18);
            this.txtNumberTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberTag.Name = "txtNumberTag";
            this.txtNumberTag.Size = new System.Drawing.Size(252, 37);
            this.txtNumberTag.TabIndex = 89;
            this.txtNumberTag.TextChanged += new System.EventHandler(this.txtNumberTag_TextChanged);
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightID,
            this.FlightNo,
            this.FlightType,
            this.EDA,
            this.EDD,
            this.ETA,
            this.ETD,
            this.Carrier,
            this.Dest,
            this.Aircraft});
            this.dgvTicket.Location = new System.Drawing.Point(18, 132);
            this.dgvTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTicket.MultiSelect = false;
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(1354, 180);
            this.dgvTicket.TabIndex = 91;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // FlightID
            // 
            this.FlightID.HeaderText = "Flight ID";
            this.FlightID.Name = "FlightID";
            this.FlightID.ReadOnly = true;
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
            // EDA
            // 
            this.EDA.HeaderText = "EDA";
            this.EDA.Name = "EDA";
            this.EDA.ReadOnly = true;
            // 
            // EDD
            // 
            this.EDD.HeaderText = "EDD";
            this.EDD.Name = "EDD";
            this.EDD.ReadOnly = true;
            // 
            // ETA
            // 
            this.ETA.HeaderText = "ETA";
            this.ETA.Name = "ETA";
            this.ETA.ReadOnly = true;
            // 
            // ETD
            // 
            this.ETD.HeaderText = "ETD";
            this.ETD.Name = "ETD";
            this.ETD.ReadOnly = true;
            // 
            // Carrier
            // 
            this.Carrier.HeaderText = "Carrier";
            this.Carrier.Name = "Carrier";
            this.Carrier.ReadOnly = true;
            // 
            // Dest
            // 
            this.Dest.HeaderText = "Dest";
            this.Dest.Name = "Dest";
            this.Dest.ReadOnly = true;
            // 
            // Aircraft
            // 
            this.Aircraft.HeaderText = "Aircraft";
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.ReadOnly = true;
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.AllowUserToDeleteRows = false;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelID,
            this.Hotel_chi_Name,
            this.Hotel_en_Name,
            this.HotelRoomID,
            this.HotelRoomName,
            this.HotelRoomSize,
            this.Description,
            this.Max_Adult,
            this.Max_Child,
            this.Fare});
            this.dgvHotel.Location = new System.Drawing.Point(16, 524);
            this.dgvHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.ReadOnly = true;
            this.dgvHotel.RowTemplate.Height = 24;
            this.dgvHotel.Size = new System.Drawing.Size(1354, 180);
            this.dgvHotel.TabIndex = 93;
            this.dgvHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellClick);
            // 
            // HotelID
            // 
            this.HotelID.HeaderText = "Hotel ID";
            this.HotelID.Name = "HotelID";
            this.HotelID.ReadOnly = true;
            // 
            // Hotel_chi_Name
            // 
            this.Hotel_chi_Name.HeaderText = "Hotel Chinese Name";
            this.Hotel_chi_Name.Name = "Hotel_chi_Name";
            this.Hotel_chi_Name.ReadOnly = true;
            // 
            // Hotel_en_Name
            // 
            this.Hotel_en_Name.HeaderText = "Hotel English Name";
            this.Hotel_en_Name.Name = "Hotel_en_Name";
            this.Hotel_en_Name.ReadOnly = true;
            // 
            // HotelRoomID
            // 
            this.HotelRoomID.HeaderText = "Hotel Room ID";
            this.HotelRoomID.Name = "HotelRoomID";
            this.HotelRoomID.ReadOnly = true;
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
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Max_Adult
            // 
            this.Max_Adult.HeaderText = "Max number for Adult";
            this.Max_Adult.Name = "Max_Adult";
            this.Max_Adult.ReadOnly = true;
            // 
            // Max_Child
            // 
            this.Max_Child.HeaderText = "Max number for Child";
            this.Max_Child.Name = "Max_Child";
            this.Max_Child.ReadOnly = true;
            // 
            // Fare
            // 
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            this.Fare.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1104, 878);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(265, 37);
            this.txtTotal.TabIndex = 97;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1034, 936);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 58);
            this.btnCancel.TabIndex = 113;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(854, 936);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(171, 58);
            this.btnConfirm.TabIndex = 112;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(920, 878);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 36);
            this.lblTotal.TabIndex = 114;
            this.lblTotal.Text = "Grand total = ";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1208, 936);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 58);
            this.btnBack.TabIndex = 118;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1416, 996);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvHotel);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtNumberTag);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpHotel);
            this.Controls.Add(this.grpTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpTicket.ResumeLayout(false);
            this.grpTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfantPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultPerson)).EndInit();
            this.grpHotel.ResumeLayout(false);
            this.grpHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTicket;
        private System.Windows.Forms.TextBox txtTicketTotal;
        private System.Windows.Forms.Label lblTicketTotal;
        private System.Windows.Forms.GroupBox grpHotel;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdultTax;
        private System.Windows.Forms.TextBox txtInfantTax;
        private System.Windows.Forms.TextBox txtInfantPrice;
        private System.Windows.Forms.Label lblAdultTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChildTax;
        private System.Windows.Forms.TextBox txtChildPrice;
        private System.Windows.Forms.TextBox txtAdultPrice;
        private System.Windows.Forms.NumericUpDown nudInfantPerson;
        private System.Windows.Forms.NumericUpDown nudChildPerson;
        private System.Windows.Forms.NumericUpDown nudAdultPerson;
        private System.Windows.Forms.Label lblInfantPerson;
        private System.Windows.Forms.Label lblChildPerson;
        private System.Windows.Forms.Label lblAdultPerson;
        private System.Windows.Forms.Label lblInfantPrice;
        private System.Windows.Forms.Label lblChildPrice;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmoClass;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aircraft;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtNumberTag;
        private System.Windows.Forms.Button btnTicketOk;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_chi_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_en_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max_Adult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max_Child;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
        private System.Windows.Forms.TextBox txthotelRoomPrice;
        private System.Windows.Forms.Label lblRoom1Night;
        private System.Windows.Forms.Label lblRoom1Price;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Button btnHotelOk;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.TextBox txtHotelTotal;
        private System.Windows.Forms.Label lblHotelTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox lblShowDiscount;
        private System.Windows.Forms.TextBox txtNight;
        private System.Windows.Forms.Button btnBack;
    }
}