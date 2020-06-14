namespace Integrated_Tourism_Management_System
{
    partial class frmConsole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsole));
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtNumberTag = new System.Windows.Forms.TextBox();
            this.lblNumberTag = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.GroupBox();
            this.btnHandle = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.picCompany = new System.Windows.Forms.PictureBox();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.lblLate = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.lblCenter = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpReminder = new System.Windows.Forms.GroupBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.grpDriverRoster = new System.Windows.Forms.GroupBox();
            this.lblComingSoon1 = new System.Windows.Forms.Label();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.lblComingSoon2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPaymentMessage = new System.Windows.Forms.Label();
            this.lblIgMessage = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.group.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpReminder.SuspendLayout();
            this.grpDriverRoster.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.ErrorImage = null;
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(441, 45);
            this.picIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(150, 150);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 25;
            this.picIcon.TabStop = false;
            // 
            // txtNumberTag
            // 
            this.txtNumberTag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumberTag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberTag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumberTag.Location = new System.Drawing.Point(152, 34);
            this.txtNumberTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberTag.Name = "txtNumberTag";
            this.txtNumberTag.Size = new System.Drawing.Size(214, 35);
            this.txtNumberTag.TabIndex = 84;
            // 
            // lblNumberTag
            // 
            this.lblNumberTag.AutoSize = true;
            this.lblNumberTag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTag.Location = new System.Drawing.Point(9, 39);
            this.lblNumberTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberTag.Name = "lblNumberTag";
            this.lblNumberTag.Size = new System.Drawing.Size(135, 28);
            this.lblNumberTag.TabIndex = 83;
            this.lblNumberTag.Text = "Number Tag :";
            // 
            // group
            // 
            this.group.Controls.Add(this.btnHandle);
            this.group.Controls.Add(this.txtNumberTag);
            this.group.Controls.Add(this.lblNumberTag);
            this.group.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(897, 18);
            this.group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group.Size = new System.Drawing.Size(501, 90);
            this.group.TabIndex = 85;
            this.group.TabStop = false;
            this.group.Text = "Number Tag Confirmation";
            // 
            // btnHandle
            // 
            this.btnHandle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHandle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandle.Location = new System.Drawing.Point(376, 30);
            this.btnHandle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(112, 44);
            this.btnHandle.TabIndex = 87;
            this.btnHandle.Text = "&Handle";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.Location = new System.Drawing.Point(1274, 915);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(124, 44);
            this.btnSignout.TabIndex = 86;
            this.btnSignout.Text = "&Sign Out";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.picCompany);
            this.grpInfo.Controls.Add(this.txtLate);
            this.grpInfo.Controls.Add(this.lblLate);
            this.grpInfo.Controls.Add(this.txtPosition);
            this.grpInfo.Controls.Add(this.lblPosition);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.txtCenter);
            this.grpInfo.Controls.Add(this.lblCenter);
            this.grpInfo.Controls.Add(this.txtGender);
            this.grpInfo.Controls.Add(this.lblGender);
            this.grpInfo.Controls.Add(this.txtFullName);
            this.grpInfo.Controls.Add(this.lblFullName);
            this.grpInfo.Controls.Add(this.txtStaffID);
            this.grpInfo.Controls.Add(this.lblStaffID);
            this.grpInfo.Controls.Add(this.picIcon);
            this.grpInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(18, 564);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Size = new System.Drawing.Size(600, 394);
            this.grpInfo.TabIndex = 89;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Personal Information";
            // 
            // picCompany
            // 
            this.picCompany.ErrorImage = null;
            this.picCompany.Image = ((System.Drawing.Image)(resources.GetObject("picCompany.Image")));
            this.picCompany.InitialImage = null;
            this.picCompany.Location = new System.Drawing.Point(441, 232);
            this.picCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCompany.Name = "picCompany";
            this.picCompany.Size = new System.Drawing.Size(150, 150);
            this.picCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompany.TabIndex = 103;
            this.picCompany.TabStop = false;
            // 
            // txtLate
            // 
            this.txtLate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLate.Enabled = false;
            this.txtLate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLate.Location = new System.Drawing.Point(342, 45);
            this.txtLate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLate.Name = "txtLate";
            this.txtLate.ReadOnly = true;
            this.txtLate.Size = new System.Drawing.Size(64, 37);
            this.txtLate.TabIndex = 102;
            this.txtLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLate.Location = new System.Drawing.Point(266, 57);
            this.lblLate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(66, 29);
            this.lblLate.TabIndex = 101;
            this.lblLate.Text = "Late :";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPosition.Enabled = false;
            this.txtPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(116, 342);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(290, 37);
            this.txtPosition.TabIndex = 100;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(10, 354);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(103, 29);
            this.lblPosition.TabIndex = 99;
            this.lblPosition.Text = "Position :";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(116, 243);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(290, 37);
            this.txtEmail.TabIndex = 98;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 255);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 29);
            this.lblEmail.TabIndex = 97;
            this.lblEmail.Text = "E-mail :";
            // 
            // txtCenter
            // 
            this.txtCenter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCenter.Enabled = false;
            this.txtCenter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenter.Location = new System.Drawing.Point(116, 292);
            this.txtCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.ReadOnly = true;
            this.txtCenter.Size = new System.Drawing.Size(290, 37);
            this.txtCenter.TabIndex = 96;
            this.txtCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.Location = new System.Drawing.Point(10, 304);
            this.lblCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(90, 29);
            this.lblCenter.TabIndex = 95;
            this.lblCenter.Text = "Center :";
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(116, 194);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(290, 37);
            this.txtGender.TabIndex = 94;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(10, 206);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(97, 29);
            this.lblGender.TabIndex = 93;
            this.lblGender.Text = "Gender :";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(116, 144);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(290, 37);
            this.txtFullName.TabIndex = 92;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(10, 156);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(83, 29);
            this.lblFullName.TabIndex = 91;
            this.lblFullName.Text = "Name :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(116, 94);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(290, 37);
            this.txtStaffID.TabIndex = 90;
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(10, 106);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(95, 29);
            this.lblStaffID.TabIndex = 89;
            this.lblStaffID.Text = "Staff ID :";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip.Location = new System.Drawing.Point(0, 968);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1416, 28);
            this.statusStrip.TabIndex = 90;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 23);
            this.toolStripStatusLabel1.Text = "Clock";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 23);
            this.toolStripStatusLabel2.Text = "Timer";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 23);
            this.toolStripStatusLabel3.Text = "Status";
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(18, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(206, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 91;
            this.picLogo.TabStop = false;
            // 
            // grpReminder
            // 
            this.grpReminder.Controls.Add(this.lblTip);
            this.grpReminder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReminder.Location = new System.Drawing.Point(627, 856);
            this.grpReminder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReminder.Name = "grpReminder";
            this.grpReminder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReminder.Size = new System.Drawing.Size(482, 102);
            this.grpReminder.TabIndex = 93;
            this.grpReminder.TabStop = false;
            this.grpReminder.Text = "Kindly Reminder";
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Image = ((System.Drawing.Image)(resources.GetObject("lblTip.Image")));
            this.lblTip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTip.Location = new System.Drawing.Point(28, 40);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(450, 57);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Good attitude will provide good service.";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDriverRoster
            // 
            this.grpDriverRoster.Controls.Add(this.lblComingSoon1);
            this.grpDriverRoster.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDriverRoster.Location = new System.Drawing.Point(662, 117);
            this.grpDriverRoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDriverRoster.Name = "grpDriverRoster";
            this.grpDriverRoster.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDriverRoster.Size = new System.Drawing.Size(736, 424);
            this.grpDriverRoster.TabIndex = 94;
            this.grpDriverRoster.TabStop = false;
            this.grpDriverRoster.Text = "Driver Roster";
            // 
            // lblComingSoon1
            // 
            this.lblComingSoon1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon1.Image = ((System.Drawing.Image)(resources.GetObject("lblComingSoon1.Image")));
            this.lblComingSoon1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblComingSoon1.Location = new System.Drawing.Point(250, 188);
            this.lblComingSoon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComingSoon1.Name = "lblComingSoon1";
            this.lblComingSoon1.Size = new System.Drawing.Size(219, 57);
            this.lblComingSoon1.TabIndex = 0;
            this.lblComingSoon1.Text = "Coming Soon";
            this.lblComingSoon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSchedule
            // 
            this.grpSchedule.Controls.Add(this.lblComingSoon2);
            this.grpSchedule.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSchedule.Location = new System.Drawing.Point(18, 117);
            this.grpSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSchedule.Size = new System.Drawing.Size(634, 424);
            this.grpSchedule.TabIndex = 95;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Personal Schedule";
            // 
            // lblComingSoon2
            // 
            this.lblComingSoon2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon2.Image = ((System.Drawing.Image)(resources.GetObject("lblComingSoon2.Image")));
            this.lblComingSoon2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblComingSoon2.Location = new System.Drawing.Point(159, 188);
            this.lblComingSoon2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComingSoon2.Name = "lblComingSoon2";
            this.lblComingSoon2.Size = new System.Drawing.Size(219, 57);
            this.lblComingSoon2.TabIndex = 0;
            this.lblComingSoon2.Text = "Coming Soon";
            this.lblComingSoon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPaymentMessage);
            this.groupBox1.Controls.Add(this.lblIgMessage);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(630, 550);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(768, 297);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Message";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please rember the new yacht service will provide in this November.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentMessage
            // 
            this.lblPaymentMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblPaymentMessage.Image")));
            this.lblPaymentMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPaymentMessage.Location = new System.Drawing.Point(9, 117);
            this.lblPaymentMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMessage.Name = "lblPaymentMessage";
            this.lblPaymentMessage.Size = new System.Drawing.Size(747, 75);
            this.lblPaymentMessage.TabIndex = 2;
            this.lblPaymentMessage.Text = "Payment method pause operation for recover the huge data volume. ";
            this.lblPaymentMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIgMessage
            // 
            this.lblIgMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblIgMessage.Image")));
            this.lblIgMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIgMessage.Location = new System.Drawing.Point(9, 42);
            this.lblIgMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIgMessage.Name = "lblIgMessage";
            this.lblIgMessage.Size = new System.Drawing.Size(759, 75);
            this.lblIgMessage.TabIndex = 1;
            this.lblIgMessage.Text = "The portable system application will joint cooperation with Instagram.\r\n";
            this.lblIgMessage.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(627, 43);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(230, 51);
            this.btnConfirm.TabIndex = 97;
            this.btnConfirm.Text = "&Confirm Reservation";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 996);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.grpDriverRoster);
            this.Controls.Add(this.grpReminder);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.group);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsole";
            this.Load += new System.EventHandler(this.frmConsole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpReminder.ResumeLayout(false);
            this.grpDriverRoster.ResumeLayout(false);
            this.grpSchedule.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtNumberTag;
        private System.Windows.Forms.Label lblNumberTag;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.PictureBox picCompany;
        private System.Windows.Forms.GroupBox grpReminder;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox grpDriverRoster;
        private System.Windows.Forms.Label lblComingSoon1;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.Label lblComingSoon2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIgMessage;
        private System.Windows.Forms.Label lblPaymentMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
    }
}