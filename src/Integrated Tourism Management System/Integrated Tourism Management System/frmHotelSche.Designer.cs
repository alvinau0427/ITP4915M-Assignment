namespace Integrated_Tourism_Management_System
{
    partial class frmHotelSche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotelSche));
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.cmbDest = new System.Windows.Forms.ComboBox();
            this.dtpEDA = new System.Windows.Forms.DateTimePicker();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.dtpEDD = new System.Windows.Forms.DateTimePicker();
            this.lblDestination = new System.Windows.Forms.Label();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.HotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelEnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.dgvHotelRoom = new System.Windows.Forms.DataGridView();
            this.HotelRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAdult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(857, 623);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtKeyword);
            this.grpSearch.Controls.Add(this.lblKeyword);
            this.grpSearch.Controls.Add(this.cmbDest);
            this.grpSearch.Controls.Add(this.dtpEDA);
            this.grpSearch.Controls.Add(this.lblCheckout);
            this.grpSearch.Controls.Add(this.lblCheckin);
            this.grpSearch.Controls.Add(this.dtpEDD);
            this.grpSearch.Controls.Add(this.lblDestination);
            this.grpSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(12, 88);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(920, 106);
            this.grpSearch.TabIndex = 50;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Console";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(826, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(745, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.Gray;
            this.txtKeyword.Location = new System.Drawing.Point(97, 65);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(556, 27);
            this.txtKeyword.TabIndex = 47;
            this.txtKeyword.Text = "Please enter keywords for search ...";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(19, 68);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(72, 19);
            this.lblKeyword.TabIndex = 46;
            this.lblKeyword.Text = "Keyword :";
            // 
            // cmbDest
            // 
            this.cmbDest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDest.FormattingEnabled = true;
            this.cmbDest.Items.AddRange(new object[] {
            "All"});
            this.cmbDest.Location = new System.Drawing.Point(117, 24);
            this.cmbDest.Name = "cmbDest";
            this.cmbDest.Size = new System.Drawing.Size(193, 27);
            this.cmbDest.TabIndex = 45;
            // 
            // dtpEDA
            // 
            this.dtpEDA.CustomFormat = "dd - MM - yyyy";
            this.dtpEDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDA.Location = new System.Drawing.Point(745, 24);
            this.dtpEDA.Name = "dtpEDA";
            this.dtpEDA.Size = new System.Drawing.Size(132, 27);
            this.dtpEDA.TabIndex = 44;
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(623, 28);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(116, 19);
            this.lblCheckout.TabIndex = 43;
            this.lblCheckout.Text = "Check-out Date :";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(345, 28);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(107, 19);
            this.lblCheckin.TabIndex = 42;
            this.lblCheckin.Text = "Check-in Date :";
            // 
            // dtpEDD
            // 
            this.dtpEDD.CustomFormat = "dd - MM - yyyy";
            this.dtpEDD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDD.Location = new System.Drawing.Point(458, 24);
            this.dtpEDD.Name = "dtpEDD";
            this.dtpEDD.Size = new System.Drawing.Size(132, 27);
            this.dtpEDD.TabIndex = 41;
            this.dtpEDD.Value = new System.DateTime(2016, 5, 24, 22, 37, 49, 0);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(19, 28);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(92, 19);
            this.lblDestination.TabIndex = 39;
            this.lblDestination.Text = "Destination: ";
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.AllowUserToDeleteRows = false;
            this.dgvHotel.AllowUserToResizeColumns = false;
            this.dgvHotel.AllowUserToResizeRows = false;
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
            this.dgvHotel.Location = new System.Drawing.Point(12, 223);
            this.dgvHotel.MultiSelect = false;
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.ReadOnly = true;
            this.dgvHotel.RowHeadersVisible = false;
            this.dgvHotel.RowTemplate.Height = 24;
            this.dgvHotel.Size = new System.Drawing.Size(920, 215);
            this.dgvHotel.TabIndex = 51;
            this.dgvHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellClick);
            // 
            // HotelID
            // 
            this.HotelID.HeaderText = "HotelID";
            this.HotelID.Name = "HotelID";
            this.HotelID.ReadOnly = true;
            this.HotelID.Width = 50;
            // 
            // HotelChineseName
            // 
            this.HotelChineseName.HeaderText = "HotelChineseName";
            this.HotelChineseName.Name = "HotelChineseName";
            this.HotelChineseName.ReadOnly = true;
            this.HotelChineseName.Width = 150;
            // 
            // HotelEnglishName
            // 
            this.HotelEnglishName.HeaderText = "HotelEnglishName";
            this.HotelEnglishName.Name = "HotelEnglishName";
            this.HotelEnglishName.ReadOnly = true;
            this.HotelEnglishName.Width = 220;
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
            this.Region.Width = 160;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(8, 197);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(221, 23);
            this.lblHotel.TabIndex = 52;
            this.lblHotel.Text = "Searching Result - Hotel List";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline);
            this.lblRoom.Location = new System.Drawing.Point(8, 450);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(225, 23);
            this.lblRoom.TabIndex = 53;
            this.lblRoom.Text = "Searching Result - Room List";
            // 
            // btnMap
            // 
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMap.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMap.Location = new System.Drawing.Point(850, 444);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(82, 29);
            this.btnMap.TabIndex = 57;
            this.btnMap.Text = "&Hotel Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // dgvHotelRoom
            // 
            this.dgvHotelRoom.AllowUserToAddRows = false;
            this.dgvHotelRoom.AllowUserToDeleteRows = false;
            this.dgvHotelRoom.AllowUserToResizeColumns = false;
            this.dgvHotelRoom.AllowUserToResizeRows = false;
            this.dgvHotelRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelRoomID,
            this.HotelRoomName,
            this.HotelRoomsize,
            this.MaxAdult,
            this.MaxChild,
            this.HotelRoomDescription,
            this.Fare});
            this.dgvHotelRoom.Location = new System.Drawing.Point(12, 479);
            this.dgvHotelRoom.Name = "dgvHotelRoom";
            this.dgvHotelRoom.ReadOnly = true;
            this.dgvHotelRoom.RowHeadersVisible = false;
            this.dgvHotelRoom.RowTemplate.Height = 24;
            this.dgvHotelRoom.Size = new System.Drawing.Size(920, 141);
            this.dgvHotelRoom.TabIndex = 58;
            this.dgvHotelRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotelRoom_CellClick);
            // 
            // HotelRoomID
            // 
            this.HotelRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotelRoomID.HeaderText = "HotelRoomID";
            this.HotelRoomID.Name = "HotelRoomID";
            this.HotelRoomID.ReadOnly = true;
            // 
            // HotelRoomName
            // 
            this.HotelRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotelRoomName.HeaderText = "HotelRoomName";
            this.HotelRoomName.Name = "HotelRoomName";
            this.HotelRoomName.ReadOnly = true;
            // 
            // HotelRoomsize
            // 
            this.HotelRoomsize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotelRoomsize.HeaderText = "HotelRoomSize";
            this.HotelRoomsize.Name = "HotelRoomsize";
            this.HotelRoomsize.ReadOnly = true;
            // 
            // MaxAdult
            // 
            this.MaxAdult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxAdult.HeaderText = "MaxAdult";
            this.MaxAdult.Name = "MaxAdult";
            this.MaxAdult.ReadOnly = true;
            // 
            // MaxChild
            // 
            this.MaxChild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxChild.HeaderText = "MaxChild";
            this.MaxChild.Name = "MaxChild";
            this.MaxChild.ReadOnly = true;
            // 
            // HotelRoomDescription
            // 
            this.HotelRoomDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotelRoomDescription.HeaderText = "HotelRoomDescription";
            this.HotelRoomDescription.Name = "HotelRoomDescription";
            this.HotelRoomDescription.ReadOnly = true;
            // 
            // Fare
            // 
            this.Fare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            this.Fare.ReadOnly = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOrder.Location = new System.Drawing.Point(776, 623);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 29);
            this.btnOrder.TabIndex = 61;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 87;
            this.picLogo.TabStop = false;
            // 
            // frmHotelSche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.ControlBox = false;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvHotelRoom);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvHotel);
            this.Controls.Add(this.grpSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHotelSche";
            this.Load += new System.EventHandler(this.frmHotelSche_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cmbDest;
        private System.Windows.Forms.DateTimePicker dtpEDA;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.DateTimePicker dtpEDD;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.DataGridView dgvHotelRoom;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelEnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Star;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.PictureBox picLogo;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAdult;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxChild;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
    }
}