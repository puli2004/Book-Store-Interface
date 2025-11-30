using Book_Store_Interface.Models;
using BookStoreApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class SummaryForm : Form
    {
        List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();
        string subtotal, tax, total;
        public SummaryForm(List<ShoppingCartItem> _shoppingCartItems, string _tax, string _total, string _subtotal)
        {
            shoppingCartItems = _shoppingCartItems;
            tax = _tax;
            total = _total;
            subtotal = _subtotal;
            InitializeComponent();
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            // ADD CONFIRM LOGIC
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            // Load purchase report
            txtCartList.Text = "Confirm purchase of:\n";
            foreach (var item in shoppingCartItems)
            {
                decimal totalBookPrice = item.UnitPrice * item.Quantity;
                txtCartList.AppendText($"${item.UnitPrice:F2} - {item.Title} | Total: ${totalBookPrice:F2}");
            }
            txtbxTax.Text = tax.ToString();
            txtbxSubTotal.Text = subtotal.ToString();
            txtbxTotal.Text = total.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        
    }
}
