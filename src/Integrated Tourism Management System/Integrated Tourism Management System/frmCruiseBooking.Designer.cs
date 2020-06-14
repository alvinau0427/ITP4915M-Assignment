namespace Integrated_Tourism_Management_System
{
    partial class frmCruiseBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruiseBooking));
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.txtTicketTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChildFare = new System.Windows.Forms.TextBox();
            this.txtAdultFare = new System.Windows.Forms.TextBox();
            this.txtCruiseName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtCruiseNo = new System.Windows.Forms.TextBox();
            this.txtTourDay = new System.Windows.Forms.TextBox();
            this.txtChildTotal = new System.Windows.Forms.TextBox();
            this.txtAdultTotal = new System.Windows.Forms.TextBox();
            this.lblChildTotal = new System.Windows.Forms.Label();
            this.lblAdultTotal = new System.Windows.Forms.Label();
            this.lblChildFare = new System.Windows.Forms.Label();
            this.lblTourDay = new System.Windows.Forms.Label();
            this.lblCruiseName = new System.Windows.Forms.Label();
            this.nudChildNum = new System.Windows.Forms.NumericUpDown();
            this.nudAdultNum = new System.Windows.Forms.NumericUpDown();
            this.lblChildPerson = new System.Windows.Forms.Label();
            this.lblAdultNum = new System.Windows.Forms.Label();
            this.lblAdultFare = new System.Windows.Forms.Label();
            this.lblCruiseNo = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtTicketTotal);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.txtChildFare);
            this.grpOrder.Controls.Add(this.txtAdultFare);
            this.grpOrder.Controls.Add(this.txtCruiseName);
            this.grpOrder.Controls.Add(this.txtStartDate);
            this.grpOrder.Controls.Add(this.txtCruiseNo);
            this.grpOrder.Controls.Add(this.txtTourDay);
            this.grpOrder.Controls.Add(this.txtChildTotal);
            this.grpOrder.Controls.Add(this.txtAdultTotal);
            this.grpOrder.Controls.Add(this.lblChildTotal);
            this.grpOrder.Controls.Add(this.lblAdultTotal);
            this.grpOrder.Controls.Add(this.lblChildFare);
            this.grpOrder.Controls.Add(this.lblTourDay);
            this.grpOrder.Controls.Add(this.lblCruiseName);
            this.grpOrder.Controls.Add(this.nudChildNum);
            this.grpOrder.Controls.Add(this.nudAdultNum);
            this.grpOrder.Controls.Add(this.lblChildPerson);
            this.grpOrder.Controls.Add(this.lblAdultNum);
            this.grpOrder.Controls.Add(this.lblAdultFare);
            this.grpOrder.Controls.Add(this.lblCruiseNo);
            this.grpOrder.Controls.Add(this.lblStartDate);
            this.grpOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.Location = new System.Drawing.Point(12, 88);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(919, 529);
            this.grpOrder.TabIndex = 84;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Console";
            // 
            // txtTicketTotal
            // 
            this.txtTicketTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTicketTotal.Enabled = false;
            this.txtTicketTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketTotal.Location = new System.Drawing.Point(811, 496);
            this.txtTicketTotal.Name = "txtTicketTotal";
            this.txtTicketTotal.ReadOnly = true;
            this.txtTicketTotal.Size = new System.Drawing.Size(102, 27);
            this.txtTicketTotal.TabIndex = 68;
            this.txtTicketTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "Grand total = ";
            // 
            // txtChildFare
            // 
            this.txtChildFare.Enabled = false;
            this.txtChildFare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildFare.Location = new System.Drawing.Point(438, 311);
            this.txtChildFare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChildFare.Name = "txtChildFare";
            this.txtChildFare.ReadOnly = true;
            this.txtChildFare.Size = new System.Drawing.Size(102, 27);
            this.txtChildFare.TabIndex = 109;
            this.txtChildFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdultFare
            // 
            this.txtAdultFare.Enabled = false;
            this.txtAdultFare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdultFare.Location = new System.Drawing.Point(438, 253);
            this.txtAdultFare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdultFare.Name = "txtAdultFare";
            this.txtAdultFare.ReadOnly = true;
            this.txtAdultFare.Size = new System.Drawing.Size(102, 27);
            this.txtAdultFare.TabIndex = 108;
            this.txtAdultFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCruiseName
            // 
            this.txtCruiseName.Enabled = false;
            this.txtCruiseName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCruiseName.Location = new System.Drawing.Point(202, 170);
            this.txtCruiseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCruiseName.Multiline = true;
            this.txtCruiseName.Name = "txtCruiseName";
            this.txtCruiseName.ReadOnly = true;
            this.txtCruiseName.Size = new System.Drawing.Size(630, 52);
            this.txtCruiseName.TabIndex = 107;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(674, 114);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(152, 27);
            this.txtStartDate.TabIndex = 106;
            // 
            // txtCruiseNo
            // 
            this.txtCruiseNo.Enabled = false;
            this.txtCruiseNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCruiseNo.Location = new System.Drawing.Point(201, 114);
            this.txtCruiseNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCruiseNo.Name = "txtCruiseNo";
            this.txtCruiseNo.ReadOnly = true;
            this.txtCruiseNo.Size = new System.Drawing.Size(157, 27);
            this.txtCruiseNo.TabIndex = 105;
            // 
            // txtTourDay
            // 
            this.txtTourDay.Enabled = false;
            this.txtTourDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTourDay.Location = new System.Drawing.Point(476, 114);
            this.txtTourDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTourDay.Name = "txtTourDay";
            this.txtTourDay.ReadOnly = true;
            this.txtTourDay.Size = new System.Drawing.Size(68, 27);
            this.txtTourDay.TabIndex = 104;
            // 
            // txtChildTotal
            // 
            this.txtChildTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtChildTotal.Enabled = false;
            this.txtChildTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildTotal.Location = new System.Drawing.Point(698, 311);
            this.txtChildTotal.Name = "txtChildTotal";
            this.txtChildTotal.ReadOnly = true;
            this.txtChildTotal.Size = new System.Drawing.Size(102, 27);
            this.txtChildTotal.TabIndex = 103;
            this.txtChildTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdultTotal
            // 
            this.txtAdultTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAdultTotal.Enabled = false;
            this.txtAdultTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdultTotal.Location = new System.Drawing.Point(698, 253);
            this.txtAdultTotal.Name = "txtAdultTotal";
            this.txtAdultTotal.ReadOnly = true;
            this.txtAdultTotal.Size = new System.Drawing.Size(102, 27);
            this.txtAdultTotal.TabIndex = 102;
            this.txtAdultTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblChildTotal
            // 
            this.lblChildTotal.AutoSize = true;
            this.lblChildTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildTotal.Location = new System.Drawing.Point(558, 315);
            this.lblChildTotal.Name = "lblChildTotal";
            this.lblChildTotal.Size = new System.Drawing.Size(126, 19);
            this.lblChildTotal.TabIndex = 101;
            this.lblChildTotal.Text = "SubTotal of Child :";
            // 
            // lblAdultTotal
            // 
            this.lblAdultTotal.AutoSize = true;
            this.lblAdultTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultTotal.Location = new System.Drawing.Point(557, 257);
            this.lblAdultTotal.Name = "lblAdultTotal";
            this.lblAdultTotal.Size = new System.Drawing.Size(127, 19);
            this.lblAdultTotal.TabIndex = 100;
            this.lblAdultTotal.Text = "SubTotal of Adult :";
            // 
            // lblChildFare
            // 
            this.lblChildFare.AutoSize = true;
            this.lblChildFare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildFare.Location = new System.Drawing.Point(348, 315);
            this.lblChildFare.Name = "lblChildFare";
            this.lblChildFare.Size = new System.Drawing.Size(77, 19);
            this.lblChildFare.TabIndex = 99;
            this.lblChildFare.Text = "Tour Fare :";
            // 
            // lblTourDay
            // 
            this.lblTourDay.AutoSize = true;
            this.lblTourDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourDay.Location = new System.Drawing.Point(381, 118);
            this.lblTourDay.Name = "lblTourDay";
            this.lblTourDay.Size = new System.Drawing.Size(74, 19);
            this.lblTourDay.TabIndex = 98;
            this.lblTourDay.Text = "Tour Day :";
            // 
            // lblCruiseName
            // 
            this.lblCruiseName.AutoSize = true;
            this.lblCruiseName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCruiseName.Location = new System.Drawing.Point(96, 173);
            this.lblCruiseName.Name = "lblCruiseName";
            this.lblCruiseName.Size = new System.Drawing.Size(100, 19);
            this.lblCruiseName.TabIndex = 97;
            this.lblCruiseName.Text = "Cruise Name :";
            // 
            // nudChildNum
            // 
            this.nudChildNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudChildNum.Location = new System.Drawing.Point(232, 311);
            this.nudChildNum.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudChildNum.Name = "nudChildNum";
            this.nudChildNum.Size = new System.Drawing.Size(102, 27);
            this.nudChildNum.TabIndex = 95;
            this.nudChildNum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nudChildNum_MouseUp);
            // 
            // nudAdultNum
            // 
            this.nudAdultNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdultNum.Location = new System.Drawing.Point(232, 253);
            this.nudAdultNum.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAdultNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultNum.Name = "nudAdultNum";
            this.nudAdultNum.Size = new System.Drawing.Size(102, 27);
            this.nudAdultNum.TabIndex = 94;
            this.nudAdultNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultNum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nudAdultNum_MouseUp);
            // 
            // lblChildPerson
            // 
            this.lblChildPerson.AutoSize = true;
            this.lblChildPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildPerson.Location = new System.Drawing.Point(96, 315);
            this.lblChildPerson.Name = "lblChildPerson";
            this.lblChildPerson.Size = new System.Drawing.Size(122, 19);
            this.lblChildPerson.TabIndex = 93;
            this.lblChildPerson.Text = "Number of Child :";
            // 
            // lblAdultNum
            // 
            this.lblAdultNum.AutoSize = true;
            this.lblAdultNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultNum.Location = new System.Drawing.Point(96, 257);
            this.lblAdultNum.Name = "lblAdultNum";
            this.lblAdultNum.Size = new System.Drawing.Size(123, 19);
            this.lblAdultNum.TabIndex = 92;
            this.lblAdultNum.Text = "Number of Adult :";
            // 
            // lblAdultFare
            // 
            this.lblAdultFare.AutoSize = true;
            this.lblAdultFare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultFare.Location = new System.Drawing.Point(348, 257);
            this.lblAdultFare.Name = "lblAdultFare";
            this.lblAdultFare.Size = new System.Drawing.Size(77, 19);
            this.lblAdultFare.TabIndex = 91;
            this.lblAdultFare.Text = "Tour Fare :";
            // 
            // lblCruiseNo
            // 
            this.lblCruiseNo.AutoSize = true;
            this.lblCruiseNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCruiseNo.Location = new System.Drawing.Point(96, 118);
            this.lblCruiseNo.Name = "lblCruiseNo";
            this.lblCruiseNo.Size = new System.Drawing.Size(84, 19);
            this.lblCruiseNo.TabIndex = 90;
            this.lblCruiseNo.Text = "Cruise No. :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(571, 118);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 19);
            this.lblStartDate.TabIndex = 89;
            this.lblStartDate.Text = "Start Date :";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(822, 623);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 39);
            this.btnCancel.TabIndex = 111;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(702, 623);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 39);
            this.btnConfirm.TabIndex = 110;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 85;
            this.picLogo.TabStop = false;
            // 
            // frmCruiseBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCruiseBooking";
            this.Load += new System.EventHandler(this.frmCruiseBooking_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtChildFare;
        private System.Windows.Forms.TextBox txtAdultFare;
        private System.Windows.Forms.TextBox txtCruiseName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtCruiseNo;
        private System.Windows.Forms.TextBox txtTourDay;
        private System.Windows.Forms.TextBox txtChildTotal;
        private System.Windows.Forms.TextBox txtAdultTotal;
        private System.Windows.Forms.Label lblChildTotal;
        private System.Windows.Forms.Label lblAdultTotal;
        private System.Windows.Forms.Label lblChildFare;
        private System.Windows.Forms.Label lblTourDay;
        private System.Windows.Forms.Label lblCruiseName;
        private System.Windows.Forms.TextBox txtTicketTotal;
        private System.Windows.Forms.NumericUpDown nudChildNum;
        private System.Windows.Forms.NumericUpDown nudAdultNum;
        private System.Windows.Forms.Label lblChildPerson;
        private System.Windows.Forms.Label lblAdultNum;
        private System.Windows.Forms.Label lblAdultFare;
        private System.Windows.Forms.Label lblCruiseNo;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
    }
}