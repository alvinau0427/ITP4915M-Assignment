namespace Integrated_Tourism_Management_System
{
    partial class frmPerformance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerformance));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnClose = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpPerformance = new System.Windows.Forms.GroupBox();
            this.tabPerformance = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.gpbReport = new System.Windows.Forms.GroupBox();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpPerformance.SuspendLayout();
            this.tabPerformance.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.gpbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1286, 934);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 44);
            this.btnClose.TabIndex = 91;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(18, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(375, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 92;
            this.picLogo.TabStop = false;
            // 
            // grpPerformance
            // 
            this.grpPerformance.Controls.Add(this.tabPerformance);
            this.grpPerformance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerformance.Location = new System.Drawing.Point(18, 132);
            this.grpPerformance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPerformance.Name = "grpPerformance";
            this.grpPerformance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPerformance.Size = new System.Drawing.Size(1380, 794);
            this.grpPerformance.TabIndex = 93;
            this.grpPerformance.TabStop = false;
            this.grpPerformance.Text = "Company Business Performance";
            // 
            // tabPerformance
            // 
            this.tabPerformance.Controls.Add(this.tabReport);
            this.tabPerformance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPerformance.Location = new System.Drawing.Point(9, 45);
            this.tabPerformance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.SelectedIndex = 0;
            this.tabPerformance.Size = new System.Drawing.Size(1362, 740);
            this.tabPerformance.TabIndex = 10;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.gpbReport);
            this.tabReport.Controls.Add(this.chart);
            this.tabReport.Location = new System.Drawing.Point(4, 38);
            this.tabReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReport.Size = new System.Drawing.Size(1354, 698);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "Graphic Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // gpbReport
            // 
            this.gpbReport.Controls.Add(this.rdoSalary);
            this.gpbReport.Location = new System.Drawing.Point(30, 40);
            this.gpbReport.Name = "gpbReport";
            this.gpbReport.Size = new System.Drawing.Size(1293, 90);
            this.gpbReport.TabIndex = 3;
            this.gpbReport.TabStop = false;
            this.gpbReport.Text = "Data Report";
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.Location = new System.Drawing.Point(28, 45);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(311, 33);
            this.rdoSalary.TabIndex = 1;
            this.rdoSalary.TabStop = true;
            this.rdoSalary.Text = "Salary and Retirement Fund";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // chart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(30, 136);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart.Size = new System.Drawing.Size(1293, 538);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // frmPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1416, 996);
            this.ControlBox = false;
            this.Controls.Add(this.grpPerformance);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerformance";
            this.Load += new System.EventHandler(this.frmPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpPerformance.ResumeLayout(false);
            this.tabPerformance.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.gpbReport.ResumeLayout(false);
            this.gpbReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpPerformance;
        private System.Windows.Forms.TabControl tabPerformance;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.GroupBox gpbReport;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}