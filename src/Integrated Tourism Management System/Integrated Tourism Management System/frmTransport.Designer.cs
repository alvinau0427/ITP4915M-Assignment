namespace Integrated_Tourism_Management_System
{
    partial class frmTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransport));
            this.btnClose = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AttractionBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBooking = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(845, 685);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 93;
            this.picLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cboBooking);
            this.groupBox1.Location = new System.Drawing.Point(8, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 246);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attraction Booking";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractionBookingID,
            this.AttractName,
            this.AdultNum,
            this.ChildNum,
            this.AdultPrice,
            this.ChildPrice,
            this.Status,
            this.OrderDate,
            this.OrderBy});
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(900, 195);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AttractionBookingID
            // 
            this.AttractionBookingID.HeaderText = "Attraction Booking ID";
            this.AttractionBookingID.Name = "AttractionBookingID";
            this.AttractionBookingID.ReadOnly = true;
            this.AttractionBookingID.Width = 60;
            // 
            // AttractName
            // 
            this.AttractName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AttractName.HeaderText = "Attract Name";
            this.AttractName.MinimumWidth = 150;
            this.AttractName.Name = "AttractName";
            this.AttractName.ReadOnly = true;
            // 
            // AdultNum
            // 
            this.AdultNum.HeaderText = "Adult Num";
            this.AdultNum.Name = "AdultNum";
            this.AdultNum.ReadOnly = true;
            this.AdultNum.Width = 60;
            // 
            // ChildNum
            // 
            this.ChildNum.HeaderText = "Child Num";
            this.ChildNum.Name = "ChildNum";
            this.ChildNum.ReadOnly = true;
            this.ChildNum.Width = 60;
            // 
            // AdultPrice
            // 
            this.AdultPrice.HeaderText = "Adult Price";
            this.AdultPrice.Name = "AdultPrice";
            this.AdultPrice.ReadOnly = true;
            this.AdultPrice.Width = 60;
            // 
            // ChildPrice
            // 
            this.ChildPrice.HeaderText = "Child Price";
            this.ChildPrice.Name = "ChildPrice";
            this.ChildPrice.ReadOnly = true;
            this.ChildPrice.Width = 60;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderBy
            // 
            this.OrderBy.HeaderText = "Order By";
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.ReadOnly = true;
            // 
            // cboBooking
            // 
            this.cboBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooking.FormattingEnabled = true;
            this.cboBooking.Items.AddRange(new object[] {
            ""});
            this.cboBooking.Location = new System.Drawing.Point(6, 17);
            this.cboBooking.Name = "cboBooking";
            this.cboBooking.Size = new System.Drawing.Size(199, 21);
            this.cboBooking.TabIndex = 3;
            this.cboBooking.SelectedIndexChanged += new System.EventHandler(this.cboBooking_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.cboVehicle);
            this.groupBox2.Location = new System.Drawing.Point(8, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 332);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transportation";
            this.groupBox2.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 267);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(6, 22);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(199, 21);
            this.cboVehicle.TabIndex = 2;
            this.cboVehicle.SelectedIndexChanged += new System.EventHandler(this.cboVehicle_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(280, 516);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(384, 33);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Please select a attraction booking.";
            // 
            // frmTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 719);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTransport";
            this.Load += new System.EventHandler(this.frmTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.ComboBox cboBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderBy;
        private System.Windows.Forms.Label lblMessage;
    }
}