namespace Book_Store_Interface
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtReportList = new System.Windows.Forms.TextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(48, 71);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(625, 44);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(38, 26);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(161, 37);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(690, 26);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(150, 37);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(700, 71);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(625, 44);
            this.dtpEndDate.TabIndex = 1;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Blue;
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(1016, 623);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(317, 114);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtReportList
            // 
            this.txtReportList.BackColor = System.Drawing.Color.LightGreen;
            this.txtReportList.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportList.Location = new System.Drawing.Point(38, 145);
            this.txtReportList.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtReportList.Multiline = true;
            this.txtReportList.Name = "txtReportList";
            this.txtReportList.ReadOnly = true;
            this.txtReportList.Size = new System.Drawing.Size(1286, 454);
            this.txtReportList.TabIndex = 31;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Blue;
            this.btnGenerateReport.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(48, 623);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(475, 114);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // ReportForm
            // 
            this.AcceptButton = this.btnGenerateReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGoBack;
            this.ClientSize = new System.Drawing.Size(1371, 771);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtReportList);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "ReportForm";
            this.Text = "Purchase Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtReportList;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}