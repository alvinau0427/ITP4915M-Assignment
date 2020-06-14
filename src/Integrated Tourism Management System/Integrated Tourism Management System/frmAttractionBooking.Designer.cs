namespace Integrated_Tourism_Management_System
{
    partial class frmAttractionBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttractionBooking));
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.picAttPhoto = new System.Windows.Forms.PictureBox();
            this.txtPriceChild = new System.Windows.Forms.TextBox();
            this.txtPriceAdult = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAttName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCancel = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtTotalChild = new System.Windows.Forms.TextBox();
            this.txtTotalAdult = new System.Windows.Forms.TextBox();
            this.lblChildTotal = new System.Windows.Forms.Label();
            this.lblAdultTotal = new System.Windows.Forms.Label();
            this.lblChildPrice = new System.Windows.Forms.Label();
            this.lblCancellation = new System.Windows.Forms.Label();
            this.lblAttraction = new System.Windows.Forms.Label();
            this.nudNumChild = new System.Windows.Forms.NumericUpDown();
            this.nudNumAdult = new System.Windows.Forms.NumericUpDown();
            this.lblChildPerson = new System.Windows.Forms.Label();
            this.lblAdultNum = new System.Windows.Forms.Label();
            this.lblAdultPrice = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.picAttPhoto);
            this.grpBooking.Controls.Add(this.txtPriceChild);
            this.grpBooking.Controls.Add(this.txtPriceAdult);
            this.grpBooking.Controls.Add(this.txtTotal);
            this.grpBooking.Controls.Add(this.label1);
            this.grpBooking.Controls.Add(this.txtAttName);
            this.grpBooking.Controls.Add(this.txtCity);
            this.grpBooking.Controls.Add(this.txtCancel);
            this.grpBooking.Controls.Add(this.txtDuration);
            this.grpBooking.Controls.Add(this.lblPhoto);
            this.grpBooking.Controls.Add(this.txtTotalChild);
            this.grpBooking.Controls.Add(this.txtTotalAdult);
            this.grpBooking.Controls.Add(this.lblChildTotal);
            this.grpBooking.Controls.Add(this.lblAdultTotal);
            this.grpBooking.Controls.Add(this.lblChildPrice);
            this.grpBooking.Controls.Add(this.lblCancellation);
            this.grpBooking.Controls.Add(this.lblAttraction);
            this.grpBooking.Controls.Add(this.nudNumChild);
            this.grpBooking.Controls.Add(this.nudNumAdult);
            this.grpBooking.Controls.Add(this.lblChildPerson);
            this.grpBooking.Controls.Add(this.lblAdultNum);
            this.grpBooking.Controls.Add(this.lblAdultPrice);
            this.grpBooking.Controls.Add(this.lblDuration);
            this.grpBooking.Controls.Add(this.lblCity);
            this.grpBooking.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooking.Location = new System.Drawing.Point(12, 88);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(920, 531);
            this.grpBooking.TabIndex = 10;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking Console";
            // 
            // picAttPhoto
            // 
            this.picAttPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.picAttPhoto.InitialImage = null;
            this.picAttPhoto.Location = new System.Drawing.Point(10, 303);
            this.picAttPhoto.Name = "picAttPhoto";
            this.picAttPhoto.Size = new System.Drawing.Size(360, 200);
            this.picAttPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAttPhoto.TabIndex = 94;
            this.picAttPhoto.TabStop = false;
            // 
            // txtPriceChild
            // 
            this.txtPriceChild.Enabled = false;
            this.txtPriceChild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceChild.Location = new System.Drawing.Point(429, 247);
            this.txtPriceChild.Name = "txtPriceChild";
            this.txtPriceChild.ReadOnly = true;
            this.txtPriceChild.Size = new System.Drawing.Size(99, 27);
            this.txtPriceChild.TabIndex = 93;
            this.txtPriceChild.Text = "0";
            // 
            // txtPriceAdult
            // 
            this.txtPriceAdult.Enabled = false;
            this.txtPriceAdult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAdult.Location = new System.Drawing.Point(428, 193);
            this.txtPriceAdult.Name = "txtPriceAdult";
            this.txtPriceAdult.ReadOnly = true;
            this.txtPriceAdult.Size = new System.Drawing.Size(99, 27);
            this.txtPriceAdult.TabIndex = 92;
            this.txtPriceAdult.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(805, 498);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(109, 27);
            this.txtTotal.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Grand total = ";
            // 
            // txtAttName
            // 
            this.txtAttName.Enabled = false;
            this.txtAttName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttName.Location = new System.Drawing.Point(255, 81);
            this.txtAttName.Name = "txtAttName";
            this.txtAttName.ReadOnly = true;
            this.txtAttName.Size = new System.Drawing.Size(515, 27);
            this.txtAttName.TabIndex = 90;
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(182, 138);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(138, 27);
            this.txtCity.TabIndex = 89;
            // 
            // txtCancel
            // 
            this.txtCancel.Enabled = false;
            this.txtCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancel.Location = new System.Drawing.Point(685, 138);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.ReadOnly = true;
            this.txtCancel.Size = new System.Drawing.Size(85, 27);
            this.txtCancel.TabIndex = 88;
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(421, 138);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(138, 27);
            this.txtDuration.TabIndex = 87;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(6, 506);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(114, 19);
            this.lblPhoto.TabIndex = 85;
            this.lblPhoto.Text = "Attraction Photo";
            // 
            // txtTotalChild
            // 
            this.txtTotalChild.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalChild.Enabled = false;
            this.txtTotalChild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalChild.Location = new System.Drawing.Point(686, 247);
            this.txtTotalChild.Name = "txtTotalChild";
            this.txtTotalChild.ReadOnly = true;
            this.txtTotalChild.Size = new System.Drawing.Size(109, 27);
            this.txtTotalChild.TabIndex = 82;
            // 
            // txtTotalAdult
            // 
            this.txtTotalAdult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalAdult.Enabled = false;
            this.txtTotalAdult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAdult.Location = new System.Drawing.Point(686, 193);
            this.txtTotalAdult.Name = "txtTotalAdult";
            this.txtTotalAdult.ReadOnly = true;
            this.txtTotalAdult.Size = new System.Drawing.Size(109, 27);
            this.txtTotalAdult.TabIndex = 81;
            // 
            // lblChildTotal
            // 
            this.lblChildTotal.AutoSize = true;
            this.lblChildTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildTotal.Location = new System.Drawing.Point(554, 251);
            this.lblChildTotal.Name = "lblChildTotal";
            this.lblChildTotal.Size = new System.Drawing.Size(126, 19);
            this.lblChildTotal.TabIndex = 80;
            this.lblChildTotal.Text = "SubTotal of Child :";
            // 
            // lblAdultTotal
            // 
            this.lblAdultTotal.AutoSize = true;
            this.lblAdultTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultTotal.Location = new System.Drawing.Point(553, 197);
            this.lblAdultTotal.Name = "lblAdultTotal";
            this.lblAdultTotal.Size = new System.Drawing.Size(127, 19);
            this.lblAdultTotal.TabIndex = 79;
            this.lblAdultTotal.Text = "SubTotal of Adult :";
            // 
            // lblChildPrice
            // 
            this.lblChildPrice.AutoSize = true;
            this.lblChildPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildPrice.Location = new System.Drawing.Point(332, 251);
            this.lblChildPrice.Name = "lblChildPrice";
            this.lblChildPrice.Size = new System.Drawing.Size(91, 19);
            this.lblChildPrice.TabIndex = 77;
            this.lblChildPrice.Text = "Ticket Price :";
            // 
            // lblCancellation
            // 
            this.lblCancellation.AutoSize = true;
            this.lblCancellation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancellation.Location = new System.Drawing.Point(573, 142);
            this.lblCancellation.Name = "lblCancellation";
            this.lblCancellation.Size = new System.Drawing.Size(98, 19);
            this.lblCancellation.TabIndex = 75;
            this.lblCancellation.Text = "Cancellation :";
            // 
            // lblAttraction
            // 
            this.lblAttraction.AutoSize = true;
            this.lblAttraction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttraction.Location = new System.Drawing.Point(126, 85);
            this.lblAttraction.Name = "lblAttraction";
            this.lblAttraction.Size = new System.Drawing.Size(123, 19);
            this.lblAttraction.TabIndex = 73;
            this.lblAttraction.Text = "Attraction Name :";
            // 
            // nudNumChild
            // 
            this.nudNumChild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumChild.Location = new System.Drawing.Point(256, 247);
            this.nudNumChild.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNumChild.Name = "nudNumChild";
            this.nudNumChild.Size = new System.Drawing.Size(65, 27);
            this.nudNumChild.TabIndex = 68;
            this.nudNumChild.ValueChanged += new System.EventHandler(this.nudChildNum_ValueChanged);
            // 
            // nudNumAdult
            // 
            this.nudNumAdult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumAdult.Location = new System.Drawing.Point(256, 193);
            this.nudNumAdult.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNumAdult.Name = "nudNumAdult";
            this.nudNumAdult.Size = new System.Drawing.Size(65, 27);
            this.nudNumAdult.TabIndex = 67;
            this.nudNumAdult.ValueChanged += new System.EventHandler(this.nudAdultNum_ValueChanged);
            // 
            // lblChildPerson
            // 
            this.lblChildPerson.AutoSize = true;
            this.lblChildPerson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildPerson.Location = new System.Drawing.Point(128, 251);
            this.lblChildPerson.Name = "lblChildPerson";
            this.lblChildPerson.Size = new System.Drawing.Size(122, 19);
            this.lblChildPerson.TabIndex = 65;
            this.lblChildPerson.Text = "Number of Child :";
            // 
            // lblAdultNum
            // 
            this.lblAdultNum.AutoSize = true;
            this.lblAdultNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultNum.Location = new System.Drawing.Point(127, 197);
            this.lblAdultNum.Name = "lblAdultNum";
            this.lblAdultNum.Size = new System.Drawing.Size(123, 19);
            this.lblAdultNum.TabIndex = 64;
            this.lblAdultNum.Text = "Number of Adult :";
            // 
            // lblAdultPrice
            // 
            this.lblAdultPrice.AutoSize = true;
            this.lblAdultPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultPrice.Location = new System.Drawing.Point(331, 197);
            this.lblAdultPrice.Name = "lblAdultPrice";
            this.lblAdultPrice.Size = new System.Drawing.Size(91, 19);
            this.lblAdultPrice.TabIndex = 52;
            this.lblAdultPrice.Text = "Ticket Price :";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(334, 142);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(73, 19);
            this.lblDuration.TabIndex = 46;
            this.lblDuration.Text = "Duration :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(126, 142);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 19);
            this.lblCity.TabIndex = 44;
            this.lblCity.Text = "City :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(696, 625);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 38);
            this.btnConfirm.TabIndex = 72;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirmTicket_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(817, 625);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 38);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 79;
            this.picLogo.TabStop = false;
            // 
            // frmAttractionBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.ControlBox = false;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAttractionBooking";
            this.Load += new System.EventHandler(this.frmAttractionBooking_Load);
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.TextBox txtTotalChild;
        private System.Windows.Forms.TextBox txtTotalAdult;
        private System.Windows.Forms.Label lblChildTotal;
        private System.Windows.Forms.Label lblAdultTotal;
        private System.Windows.Forms.Label lblChildPrice;
        private System.Windows.Forms.Label lblCancellation;
        private System.Windows.Forms.Label lblAttraction;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown nudNumChild;
        private System.Windows.Forms.NumericUpDown nudNumAdult;
        private System.Windows.Forms.Label lblChildPerson;
        private System.Windows.Forms.Label lblAdultNum;
        private System.Windows.Forms.Label lblAdultPrice;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCancel;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtAttName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceChild;
        private System.Windows.Forms.TextBox txtPriceAdult;
        private System.Windows.Forms.PictureBox picAttPhoto;
    }
}