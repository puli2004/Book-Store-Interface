namespace Book_Store_Interface
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtbxSubTotal = new System.Windows.Forms.TextBox();
            this.txtCartList = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtbxTax = new System.Windows.Forms.TextBox();
            this.lblPurchaseReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Blue;
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(431, 250);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(100, 40);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Cancel";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmPurchase
            // 
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmPurchase.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPurchase.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPurchase.Location = new System.Drawing.Point(9, 252);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(140, 40);
            this.btnConfirmPurchase.TabIndex = 0;
            this.btnConfirmPurchase.Text = "Confirm Purchase";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            this.btnConfirmPurchase.Click += new System.EventHandler(this.btnConfirmPurchase_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(365, 201);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 23);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total:";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotal.Location = new System.Drawing.Point(421, 198);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.ReadOnly = true;
            this.txtbxTotal.Size = new System.Drawing.Size(100, 31);
            this.txtbxTotal.TabIndex = 32;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(172, 204);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(82, 23);
            this.lblSubTotal.TabIndex = 31;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // txtbxSubTotal
            // 
            this.txtbxSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxSubTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSubTotal.Location = new System.Drawing.Point(257, 198);
            this.txtbxSubTotal.Name = "txtbxSubTotal";
            this.txtbxSubTotal.ReadOnly = true;
            this.txtbxSubTotal.Size = new System.Drawing.Size(100, 31);
            this.txtbxSubTotal.TabIndex = 30;
            // 
            // txtCartList
            // 
            this.txtCartList.BackColor = System.Drawing.Color.LightGreen;
            this.txtCartList.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartList.Location = new System.Drawing.Point(9, 30);
            this.txtCartList.Multiline = true;
            this.txtCartList.Name = "txtCartList";
            this.txtCartList.ReadOnly = true;
            this.txtCartList.Size = new System.Drawing.Size(522, 162);
            this.txtCartList.TabIndex = 29;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(11, 206);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(43, 23);
            this.lblTax.TabIndex = 27;
            this.lblTax.Text = "Tax:";
            // 
            // txtbxTax
            // 
            this.txtbxTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxTax.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTax.Location = new System.Drawing.Point(60, 198);
            this.txtbxTax.Name = "txtbxTax";
            this.txtbxTax.ReadOnly = true;
            this.txtbxTax.Size = new System.Drawing.Size(100, 31);
            this.txtbxTax.TabIndex = 26;
            // 
            // lblPurchaseReport
            // 
            this.lblPurchaseReport.AutoSize = true;
            this.lblPurchaseReport.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseReport.Location = new System.Drawing.Point(13, 12);
            this.lblPurchaseReport.Name = "lblPurchaseReport";
            this.lblPurchaseReport.Size = new System.Drawing.Size(95, 15);
            this.lblPurchaseReport.TabIndex = 34;
            this.lblPurchaseReport.Text = "Purchase Report";
            // 
            // SummaryForm
            // 
            this.AcceptButton = this.btnConfirmPurchase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGoBack;
            this.ClientSize = new System.Drawing.Size(544, 304);
            this.Controls.Add(this.lblPurchaseReport);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnConfirmPurchase);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtbxSubTotal);
            this.Controls.Add(this.txtCartList);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtbxTax);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummaryForm";
            this.Text = "Purchase Summary";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnConfirmPurchase;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtbxSubTotal;
        private System.Windows.Forms.TextBox txtCartList;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtbxTax;
        private System.Windows.Forms.Label lblPurchaseReport;
    }
}