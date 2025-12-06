using System;
using System.Drawing;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    partial class CartForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.cboBookTitles = new ComboBox();
            this.nudQuantity = new NumericUpDown();
            this.btnAddToCart = new Button();
            this.txtbxTax = new TextBox();
            this.lblTax = new Label();
            this.lblTitle = new Label();
            this.txtCartList = new TextBox();
            this.lblSubTotal = new Label();
            this.txtbxSubTotal = new TextBox();
            this.lblTotal = new Label();
            this.txtbxTotal = new TextBox();
            this.btnCheckout = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBookTitles
            // 
            this.cboBookTitles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboBookTitles.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cboBookTitles.Font = new Font("Corbel", 9.75F);
            this.cboBookTitles.FormattingEnabled = true;
            this.cboBookTitles.Location = new Point(29, 70);
            this.cboBookTitles.Name = "cboBookTitles";
            this.cboBookTitles.Size = new Size(367, 23);
            this.cboBookTitles.TabIndex = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new Font("Corbel", 9.75F);
            this.nudQuantity.Location = new Point(402, 70);
            this.nudQuantity.Maximum = 99;
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new Size(44, 23);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.Value = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new Font("Corbel", 12F);
            this.btnAddToCart.Location = new Point(452, 59);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new Size(120, 40);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new EventHandler(this.btnAddToCart_Click);
            // 
            // txtbxTax
            // 
            this.txtbxTax.BackColor = SystemColors.Window;
            this.txtbxTax.Font = new Font("Corbel", 14.25F);
            this.txtbxTax.Location = new Point(472, 115);
            this.txtbxTax.Name = "txtbxTax";
            this.txtbxTax.ReadOnly = true;
            this.txtbxTax.Size = new Size(100, 31);
            this.txtbxTax.TabIndex = 3;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new Font("Corbel", 14.25F);
            this.lblTax.Location = new Point(423, 123);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new Size(43, 23);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Corbel", 20.25F);
            this.lblTitle.Location = new Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(450, 44);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Checkout";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCartList
            // 
            this.txtCartList.BackColor = Color.LightGreen;
            this.txtCartList.Font = new Font("Corbel", 9.75F);
            this.txtCartList.Location = new Point(12, 111);
            this.txtCartList.Multiline = true;
            this.txtCartList.Name = "txtCartList";
            this.txtCartList.ReadOnly = true;
            this.txtCartList.Size = new Size(368, 162);
            this.txtCartList.TabIndex = 16;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new Font("Corbel", 14.25F);
            this.lblSubTotal.Location = new Point(387, 158);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new Size(82, 23);
            this.lblSubTotal.TabIndex = 18;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // txtbxSubTotal
            // 
            this.txtbxSubTotal.BackColor = SystemColors.Window;
            this.txtbxSubTotal.Font = new Font("Corbel", 14.25F);
            this.txtbxSubTotal.Location = new Point(472, 152);
            this.txtbxSubTotal.Name = "txtbxSubTotal";
            this.txtbxSubTotal.ReadOnly = true;
            this.txtbxSubTotal.Size = new Size(100, 31);
            this.txtbxSubTotal.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Corbel", 14.25F);
            this.lblTotal.Location = new Point(416, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(55, 23);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.BackColor = SystemColors.Window;
            this.txtbxTotal.Font = new Font("Corbel", 14.25F);
            this.txtbxTotal.Location = new Point(472, 189);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.ReadOnly = true;
            this.txtbxTotal.Size = new Size(100, 31);
            this.txtbxTotal.TabIndex = 19;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new Font("Corbel", 12F);
            this.btnCheckout.Location = new Point(452, 232);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new Size(120, 40);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Font = new Font("Corbel", 12F);
            this.btnCancel.Location = new Point(472, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            // 
            // CartForm
            // 
            this.AcceptButton = this.btnAddToCart;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new Size(592, 292);
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
            this.Name = "CartForm";
            this.Text = "Shopping Cart";
            this.Load += new EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private ComboBox cboBookTitles;
        private NumericUpDown nudQuantity;
        private Button btnAddToCart;
        private TextBox txtbxTax;
        private Label lblTax;
        private Label lblTitle;
        private TextBox txtCartList;
        private Label lblSubTotal;
        private TextBox txtbxSubTotal;
        private Label lblTotal;
        private TextBox txtbxTotal;
        private Button btnCheckout;
        private Button btnCancel;
    }
}
