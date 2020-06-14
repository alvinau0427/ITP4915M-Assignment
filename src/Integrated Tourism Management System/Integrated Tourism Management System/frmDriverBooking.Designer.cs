namespace Integrated_Tourism_Management_System
{
    partial class frmDriverBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDriverBooking));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbxTimeslots = new System.Windows.Forms.GroupBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.lblNoDriver1 = new System.Windows.Forms.Label();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cbo3 = new System.Windows.Forms.ComboBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.lblNoDriver2 = new System.Windows.Forms.Label();
            this.lblNoDriver3 = new System.Windows.Forms.Label();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.gbxTimeslots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCancel.Location = new System.Drawing.Point(399, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(315, 255);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(70, 31);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbxTimeslots
            // 
            this.gbxTimeslots.Controls.Add(this.chk1);
            this.gbxTimeslots.Controls.Add(this.cbo1);
            this.gbxTimeslots.Controls.Add(this.lblNoDriver1);
            this.gbxTimeslots.Controls.Add(this.chk2);
            this.gbxTimeslots.Controls.Add(this.cbo2);
            this.gbxTimeslots.Controls.Add(this.cbo3);
            this.gbxTimeslots.Controls.Add(this.chk3);
            this.gbxTimeslots.Controls.Add(this.lblNoDriver2);
            this.gbxTimeslots.Controls.Add(this.lblNoDriver3);
            this.gbxTimeslots.Font = new System.Drawing.Font("Calibri", 12F);
            this.gbxTimeslots.Location = new System.Drawing.Point(159, 11);
            this.gbxTimeslots.Name = "gbxTimeslots";
            this.gbxTimeslots.Size = new System.Drawing.Size(309, 237);
            this.gbxTimeslots.TabIndex = 14;
            this.gbxTimeslots.TabStop = false;
            this.gbxTimeslots.Text = "Time Slots";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk1.Font = new System.Drawing.Font("Calibri", 12F);
            this.chk1.Location = new System.Drawing.Point(11, 45);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(97, 23);
            this.chk1.TabIndex = 4;
            this.chk1.Text = "7am-12pm";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // cbo1
            // 
            this.cbo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(146, 45);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(142, 25);
            this.cbo1.TabIndex = 7;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.cbo1_SelectedIndexChanged);
            // 
            // lblNoDriver1
            // 
            this.lblNoDriver1.Location = new System.Drawing.Point(11, 45);
            this.lblNoDriver1.Name = "lblNoDriver1";
            this.lblNoDriver1.Size = new System.Drawing.Size(276, 24);
            this.lblNoDriver1.TabIndex = 11;
            this.lblNoDriver1.Text = "Sorry, there are no driver available!";
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk2.Font = new System.Drawing.Font("Calibri", 12F);
            this.chk2.Location = new System.Drawing.Point(11, 115);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(89, 23);
            this.chk2.TabIndex = 5;
            this.chk2.Text = "1pm-6pm";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // cbo2
            // 
            this.cbo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(146, 115);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(142, 25);
            this.cbo2.TabIndex = 8;
            this.cbo2.SelectedIndexChanged += new System.EventHandler(this.cbo2_SelectedIndexChanged);
            // 
            // cbo3
            // 
            this.cbo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo3.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo3.FormattingEnabled = true;
            this.cbo3.Location = new System.Drawing.Point(146, 186);
            this.cbo3.Name = "cbo3";
            this.cbo3.Size = new System.Drawing.Size(142, 25);
            this.cbo3.TabIndex = 9;
            this.cbo3.SelectedIndexChanged += new System.EventHandler(this.cbo3_SelectedIndexChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk3.Font = new System.Drawing.Font("Calibri", 12F);
            this.chk3.Location = new System.Drawing.Point(11, 186);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(97, 23);
            this.chk3.TabIndex = 6;
            this.chk3.Text = "7pm-11pm";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // lblNoDriver2
            // 
            this.lblNoDriver2.Location = new System.Drawing.Point(11, 115);
            this.lblNoDriver2.Name = "lblNoDriver2";
            this.lblNoDriver2.Size = new System.Drawing.Size(276, 24);
            this.lblNoDriver2.TabIndex = 12;
            this.lblNoDriver2.Text = "Sorry, there are no driver available!";
            // 
            // lblNoDriver3
            // 
            this.lblNoDriver3.Location = new System.Drawing.Point(11, 186);
            this.lblNoDriver3.Name = "lblNoDriver3";
            this.lblNoDriver3.Size = new System.Drawing.Size(276, 24);
            this.lblNoDriver3.TabIndex = 13;
            this.lblNoDriver3.Text = "Sorry, there are no driver available!";
            // 
            // lstDate
            // 
            this.lstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstDate.FormattingEnabled = true;
            this.lstDate.ItemHeight = 17;
            this.lstDate.Location = new System.Drawing.Point(27, 25);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(108, 123);
            this.lstDate.TabIndex = 0;
            this.lstDate.SelectedIndexChanged += new System.EventHandler(this.lstDate_SelectedIndexChanged);
            // 
            // picVehicle
            // 
            this.picVehicle.Location = new System.Drawing.Point(20, 173);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(123, 114);
            this.picVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVehicle.TabIndex = 17;
            this.picVehicle.TabStop = false;
            // 
            // frmDriverBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 297);
            this.Controls.Add(this.picVehicle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxTimeslots);
            this.Controls.Add(this.lstDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDriverBooking";
            this.Text = "Ticket Tailor Ltd.\'s Integrated Tourism Management System";
            this.gbxTimeslots.ResumeLayout(false);
            this.gbxTimeslots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbxTimeslots;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ComboBox cbo3;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.Label lblNoDriver1;
        private System.Windows.Forms.Label lblNoDriver2;
        private System.Windows.Forms.Label lblNoDriver3;
        private System.Windows.Forms.PictureBox picVehicle;
    }
}