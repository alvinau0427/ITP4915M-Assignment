namespace Integrated_Tourism_Management_System
{
    partial class frmCruiseTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruiseTour));
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.chkTourDay = new System.Windows.Forms.CheckBox();
            this.chkStartDay = new System.Windows.Forms.CheckBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboOrganizer = new System.Windows.Forms.ComboBox();
            this.lblOrganizer = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.nudTourDay = new System.Windows.Forms.NumericUpDown();
            this.lblTourDay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.CruiseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTourDay)).BeginInit();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.chkTourDay);
            this.grpSearch.Controls.Add(this.chkStartDay);
            this.grpSearch.Controls.Add(this.lblHint);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.cboOrganizer);
            this.grpSearch.Controls.Add(this.lblOrganizer);
            this.grpSearch.Controls.Add(this.lblStartDay);
            this.grpSearch.Controls.Add(this.dtpStartDate);
            this.grpSearch.Controls.Add(this.nudTourDay);
            this.grpSearch.Controls.Add(this.lblTourDay);
            this.grpSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(13, 88);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(920, 96);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Console";
            // 
            // chkTourDay
            // 
            this.chkTourDay.AutoSize = true;
            this.chkTourDay.Location = new System.Drawing.Point(221, 37);
            this.chkTourDay.Name = "chkTourDay";
            this.chkTourDay.Size = new System.Drawing.Size(15, 14);
            this.chkTourDay.TabIndex = 54;
            this.chkTourDay.UseVisualStyleBackColor = true;
            this.chkTourDay.Click += new System.EventHandler(this.chkTourDay_Click);
            // 
            // chkStartDay
            // 
            this.chkStartDay.AutoSize = true;
            this.chkStartDay.Location = new System.Drawing.Point(485, 37);
            this.chkStartDay.Name = "chkStartDay";
            this.chkStartDay.Size = new System.Drawing.Size(15, 14);
            this.chkStartDay.TabIndex = 53;
            this.chkStartDay.UseVisualStyleBackColor = true;
            this.chkStartDay.Click += new System.EventHandler(this.chkStartDay_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(6, 71);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(236, 19);
            this.lblHint.TabIndex = 52;
            this.lblHint.Text = "Select the tour days within the trip.";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(758, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(839, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboOrganizer
            // 
            this.cboOrganizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboOrganizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganizer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrganizer.FormattingEnabled = true;
            this.cboOrganizer.Items.AddRange(new object[] {
            "All"});
            this.cboOrganizer.Location = new System.Drawing.Point(609, 31);
            this.cboOrganizer.Margin = new System.Windows.Forms.Padding(2);
            this.cboOrganizer.Name = "cboOrganizer";
            this.cboOrganizer.Size = new System.Drawing.Size(120, 27);
            this.cboOrganizer.TabIndex = 35;
            // 
            // lblOrganizer
            // 
            this.lblOrganizer.AutoSize = true;
            this.lblOrganizer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizer.Location = new System.Drawing.Point(524, 35);
            this.lblOrganizer.Name = "lblOrganizer";
            this.lblOrganizer.Size = new System.Drawing.Size(80, 19);
            this.lblOrganizer.TabIndex = 34;
            this.lblOrganizer.Text = "Organizer :";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(277, 35);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(76, 19);
            this.lblStartDay.TabIndex = 33;
            this.lblStartDay.Text = "Start Day :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(359, 31);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 27);
            this.dtpStartDate.TabIndex = 32;
            this.dtpStartDate.Value = new System.DateTime(2016, 5, 24, 22, 37, 49, 0);
            // 
            // nudTourDay
            // 
            this.nudTourDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTourDay.Location = new System.Drawing.Point(96, 31);
            this.nudTourDay.Margin = new System.Windows.Forms.Padding(2);
            this.nudTourDay.Name = "nudTourDay";
            this.nudTourDay.Size = new System.Drawing.Size(120, 27);
            this.nudTourDay.TabIndex = 31;
            // 
            // lblTourDay
            // 
            this.lblTourDay.AutoSize = true;
            this.lblTourDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourDay.Location = new System.Drawing.Point(17, 35);
            this.lblTourDay.Name = "lblTourDay";
            this.lblTourDay.Size = new System.Drawing.Size(74, 19);
            this.lblTourDay.TabIndex = 0;
            this.lblTourDay.Text = "Tour Day :";
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
            // grpResult
            // 
            this.grpResult.Controls.Add(this.btnInfo);
            this.grpResult.Controls.Add(this.btnBook);
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResult.Location = new System.Drawing.Point(13, 536);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(920, 60);
            this.grpResult.TabIndex = 50;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Searching Result";
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(714, 20);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(119, 29);
            this.btnInfo.TabIndex = 52;
            this.btnInfo.Text = "&Get Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBook
            // 
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnBook.Location = new System.Drawing.Point(839, 20);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 29);
            this.btnBook.TabIndex = 51;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(6, 23);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(702, 26);
            this.txtResult.TabIndex = 36;
            // 
            // dgvDay
            // 
            this.dgvDay.AllowUserToAddRows = false;
            this.dgvDay.AllowUserToDeleteRows = false;
            this.dgvDay.AllowUserToResizeColumns = false;
            this.dgvDay.AllowUserToResizeRows = false;
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CruiseNo,
            this.CruiseName,
            this.Price,
            this.TourDay,
            this.Organizer,
            this.Info,
            this.StartDate});
            this.dgvDay.Location = new System.Drawing.Point(12, 204);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.ReadOnly = true;
            this.dgvDay.RowHeadersVisible = false;
            this.dgvDay.RowTemplate.Height = 24;
            this.dgvDay.Size = new System.Drawing.Size(921, 310);
            this.dgvDay.TabIndex = 4;
            this.dgvDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDay_CellClick);
            // 
            // CruiseNo
            // 
            this.CruiseNo.HeaderText = "CruiseNo";
            this.CruiseNo.Name = "CruiseNo";
            this.CruiseNo.ReadOnly = true;
            // 
            // CruiseName
            // 
            this.CruiseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 80;
            this.picLogo.TabStop = false;
            // 
            // frmCruiseTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.ControlBox = false;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dgvDay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCruiseTour";
            this.Load += new System.EventHandler(this.frmCruiseTour_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTourDay)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblTourDay;
        private System.Windows.Forms.ComboBox cboOrganizer;
        private System.Windows.Forms.Label lblOrganizer;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown nudTourDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.CheckBox chkStartDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseNo;
        private System.Windows.Forms.CheckBox chkTourDay;
    }
}