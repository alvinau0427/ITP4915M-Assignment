namespace Integrated_Tourism_Management_System
{
    partial class frmTransportBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransportBooking));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grbTBooking = new System.Windows.Forms.GroupBox();
            this.dgvEquip = new System.Windows.Forms.DataGridView();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suitable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.EquipNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Subtract = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDriver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPickup = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpDropoff = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblECharges = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTCharges = new System.Windows.Forms.Label();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBookDay = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grbTBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(18, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(375, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 94;
            this.picLogo.TabStop = false;
            // 
            // grbTBooking
            // 
            this.grbTBooking.Controls.Add(this.dgvEquip);
            this.grbTBooking.Controls.Add(this.btnDriver);
            this.grbTBooking.Controls.Add(this.label1);
            this.grbTBooking.Controls.Add(this.dtpPickup);
            this.grbTBooking.Controls.Add(this.lblTotal);
            this.grbTBooking.Controls.Add(this.dtpDropoff);
            this.grbTBooking.Controls.Add(this.label17);
            this.grbTBooking.Controls.Add(this.label2);
            this.grbTBooking.Controls.Add(this.lblECharges);
            this.grbTBooking.Controls.Add(this.label15);
            this.grbTBooking.Controls.Add(this.lblTCharges);
            this.grbTBooking.Controls.Add(this.picVehicle);
            this.grbTBooking.Controls.Add(this.label13);
            this.grbTBooking.Controls.Add(this.label5);
            this.grbTBooking.Controls.Add(this.lblBookDay);
            this.grbTBooking.Controls.Add(this.lblType);
            this.grbTBooking.Controls.Add(this.label11);
            this.grbTBooking.Controls.Add(this.label7);
            this.grbTBooking.Controls.Add(this.lblCapacity);
            this.grbTBooking.Controls.Add(this.label9);
            this.grbTBooking.Controls.Add(this.lblStatus);
            this.grbTBooking.Controls.Add(this.label3);
            this.grbTBooking.Controls.Add(this.lblVehicle);
            this.grbTBooking.Font = new System.Drawing.Font("Calibri", 12F);
            this.grbTBooking.Location = new System.Drawing.Point(18, 131);
            this.grbTBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grbTBooking.Name = "grbTBooking";
            this.grbTBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grbTBooking.Size = new System.Drawing.Size(1304, 709);
            this.grbTBooking.TabIndex = 95;
            this.grbTBooking.TabStop = false;
            this.grbTBooking.Text = "Transportation Booking";
            // 
            // dgvEquip
            // 
            this.dgvEquip.AllowUserToAddRows = false;
            this.dgvEquip.AllowUserToDeleteRows = false;
            this.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipID,
            this.Equipment,
            this.Suitable,
            this.EquipPrice,
            this.EquipPhoto,
            this.EquipNum,
            this.Add,
            this.Subtract});
            this.dgvEquip.Location = new System.Drawing.Point(63, 117);
            this.dgvEquip.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEquip.Name = "dgvEquip";
            this.dgvEquip.ReadOnly = true;
            this.dgvEquip.Size = new System.Drawing.Size(1197, 201);
            this.dgvEquip.TabIndex = 30;
            this.dgvEquip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquip_CellClick);
            // 
            // EquipID
            // 
            this.EquipID.HeaderText = "Equip ID";
            this.EquipID.Name = "EquipID";
            this.EquipID.ReadOnly = true;
            // 
            // Equipment
            // 
            this.Equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Equipment.HeaderText = "Equipment";
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            // 
            // Suitable
            // 
            this.Suitable.HeaderText = "Suitable";
            this.Suitable.Name = "Suitable";
            this.Suitable.ReadOnly = true;
            // 
            // EquipPrice
            // 
            this.EquipPrice.HeaderText = "Price";
            this.EquipPrice.Name = "EquipPrice";
            this.EquipPrice.ReadOnly = true;
            // 
            // EquipPhoto
            // 
            this.EquipPhoto.HeaderText = "Equip Photo";
            this.EquipPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EquipPhoto.Name = "EquipPhoto";
            this.EquipPhoto.ReadOnly = true;
            this.EquipPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EquipPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EquipPhoto.Width = 150;
            // 
            // EquipNum
            // 
            this.EquipNum.HeaderText = "Num";
            this.EquipNum.Name = "EquipNum";
            this.EquipNum.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.HeaderText = "+";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Text = "+";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 40;
            // 
            // Subtract
            // 
            this.Subtract.HeaderText = "-";
            this.Subtract.Name = "Subtract";
            this.Subtract.ReadOnly = true;
            this.Subtract.Text = "-";
            this.Subtract.UseColumnTextForButtonValue = true;
            this.Subtract.Width = 40;
            // 
            // btnDriver
            // 
            this.btnDriver.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDriver.Location = new System.Drawing.Point(1079, 41);
            this.btnDriver.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(181, 48);
            this.btnDriver.TabIndex = 50;
            this.btnDriver.Text = "Book Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Visible = false;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pickup Date : ";
            // 
            // dtpPickup
            // 
            this.dtpPickup.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpPickup.Location = new System.Drawing.Point(206, 46);
            this.dtpPickup.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPickup.Name = "dtpPickup";
            this.dtpPickup.Size = new System.Drawing.Size(256, 37);
            this.dtpPickup.TabIndex = 25;
            this.dtpPickup.ValueChanged += new System.EventHandler(this.dtpPickup_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTotal.Location = new System.Drawing.Point(1131, 619);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 29);
            this.lblTotal.TabIndex = 49;
            this.lblTotal.Text = "label18";
            // 
            // dtpDropoff
            // 
            this.dtpDropoff.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpDropoff.Location = new System.Drawing.Point(733, 46);
            this.dtpDropoff.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDropoff.Name = "dtpDropoff";
            this.dtpDropoff.Size = new System.Drawing.Size(256, 37);
            this.dtpDropoff.TabIndex = 26;
            this.dtpDropoff.ValueChanged += new System.EventHandler(this.dtpDropoff_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F);
            this.label17.Location = new System.Drawing.Point(852, 619);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 29);
            this.label17.TabIndex = 48;
            this.label17.Text = "Grand Total : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(564, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Drop-off Date : ";
            // 
            // lblECharges
            // 
            this.lblECharges.AutoSize = true;
            this.lblECharges.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblECharges.Location = new System.Drawing.Point(1131, 529);
            this.lblECharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblECharges.Name = "lblECharges";
            this.lblECharges.Size = new System.Drawing.Size(86, 29);
            this.lblECharges.TabIndex = 47;
            this.lblECharges.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F);
            this.label15.Location = new System.Drawing.Point(852, 529);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 29);
            this.label15.TabIndex = 46;
            this.label15.Text = "Equipment Charges : ";
            // 
            // lblTCharges
            // 
            this.lblTCharges.AutoSize = true;
            this.lblTCharges.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTCharges.Location = new System.Drawing.Point(1131, 439);
            this.lblTCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTCharges.Name = "lblTCharges";
            this.lblTCharges.Size = new System.Drawing.Size(86, 29);
            this.lblTCharges.TabIndex = 45;
            this.lblTCharges.Text = "label14";
            // 
            // picVehicle
            // 
            this.picVehicle.Location = new System.Drawing.Point(63, 439);
            this.picVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(386, 238);
            this.picVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVehicle.TabIndex = 32;
            this.picVehicle.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F);
            this.label13.Location = new System.Drawing.Point(852, 439);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 29);
            this.label13.TabIndex = 44;
            this.label13.Text = "Transportation Charges : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(453, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Type : ";
            // 
            // lblBookDay
            // 
            this.lblBookDay.AutoSize = true;
            this.lblBookDay.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblBookDay.Location = new System.Drawing.Point(661, 439);
            this.lblBookDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookDay.Name = "lblBookDay";
            this.lblBookDay.Size = new System.Drawing.Size(86, 29);
            this.lblBookDay.TabIndex = 43;
            this.lblBookDay.Text = "label12";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblType.Location = new System.Drawing.Point(534, 354);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 29);
            this.lblType.TabIndex = 34;
            this.lblType.Text = "label6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.Location = new System.Drawing.Point(534, 439);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 29);
            this.label11.TabIndex = 42;
            this.label11.Text = "Book Day : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(741, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Capacity : ";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(859, 354);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(74, 29);
            this.lblCapacity.TabIndex = 36;
            this.lblCapacity.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(1036, 354);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblStatus.Location = new System.Drawing.Point(1131, 354);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 29);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "label10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(59, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Vehicle : ";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblVehicle.Location = new System.Drawing.Point(163, 354);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(74, 29);
            this.lblVehicle.TabIndex = 31;
            this.lblVehicle.Text = "label4";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(935, 880);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 48);
            this.btnConfirm.TabIndex = 98;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOK.Location = new System.Drawing.Point(1075, 880);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 48);
            this.btnOK.TabIndex = 97;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCancel.Location = new System.Drawing.Point(1213, 880);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 48);
            this.btnCancel.TabIndex = 96;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTransportBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1416, 964);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbTBooking);
            this.Controls.Add(this.picLogo);
            this.Name = "frmTransportBooking";
            this.Load += new System.EventHandler(this.frmTransportBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grbTBooking.ResumeLayout(false);
            this.grbTBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grbTBooking;
        private System.Windows.Forms.DataGridView dgvEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suitable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipPrice;
        private System.Windows.Forms.DataGridViewImageColumn EquipPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipNum;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Subtract;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPickup;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpDropoff;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblECharges;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTCharges;
        private System.Windows.Forms.PictureBox picVehicle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookDay;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}