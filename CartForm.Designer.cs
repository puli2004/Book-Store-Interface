namespace Book_Store_Interface
{
    partial class CartForm
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
            this.cboBookTitles = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtbxTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCartList = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtbxSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBookTitles
            // 
            this.cboBookTitles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBookTitles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBookTitles.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBookTitles.FormattingEnabled = true;
            this.cboBookTitles.Location = new System.Drawing.Point(92, 199);
            this.cboBookTitles.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cboBookTitles.Name = "cboBookTitles";
            this.cboBookTitles.Size = new System.Drawing.Size(1154, 23);
            this.cboBookTitles.TabIndex = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(1273, 199);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(139, 23);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Blue;
            this.btnAddToCart.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(1431, 168);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(380, 114);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtbxTax
            // 
            this.txtbxTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxTax.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTax.Location = new System.Drawing.Point(1495, 327);
            this.txtbxTax.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtbxTax.Name = "txtbxTax";
            this.txtbxTax.ReadOnly = true;
            this.txtbxTax.Size = new System.Drawing.Size(308, 31);
            this.txtbxTax.TabIndex = 3;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(1340, 350);
            this.lblTax.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(43, 23);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(51, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1425, 125);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Checkout";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCartList
            // 
            this.txtCartList.BackColor = System.Drawing.Color.LightGreen;
            this.txtCartList.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartList.Location = new System.Drawing.Point(38, 316);
            this.txtCartList.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCartList.Multiline = true;
            this.txtCartList.Name = "txtCartList";
            this.txtCartList.ReadOnly = true;
            this.txtCartList.Size = new System.Drawing.Size(1157, 454);
            this.txtCartList.TabIndex = 16;
            this.txtCartList.TextChanged += new System.EventHandler(this.txtCartList_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(1226, 450);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(82, 23);
            this.lblSubTotal.TabIndex = 18;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // txtbxSubTotal
            // 
            this.txtbxSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxSubTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSubTotal.Location = new System.Drawing.Point(1495, 433);
            this.txtbxSubTotal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtbxSubTotal.Name = "txtbxSubTotal";
            this.txtbxSubTotal.ReadOnly = true;
            this.txtbxSubTotal.Size = new System.Drawing.Size(308, 31);
            this.txtbxSubTotal.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1317, 546);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 23);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxTotal.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotal.Location = new System.Drawing.Point(1495, 538);
            this.txtbxTotal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.ReadOnly = true;
            this.txtbxTotal.Size = new System.Drawing.Size(308, 31);
            this.txtbxTotal.TabIndex = 19;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Blue;
            this.btnCheckout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(1431, 660);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(380, 114);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Chekout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Blue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1495, 65);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(317, 85);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CartForm
            // 
            this.AcceptButton = this.btnAddToCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1875, 831);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtbxSubTotal);
            this.Controls.Add(this.txtCartList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtbxTax);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cboBookTitles);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CartForm";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBookTitles;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtbxTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCartList;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtbxSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
    }
}