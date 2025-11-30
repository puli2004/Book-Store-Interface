using Book_Store_Interface.Models;
using BookStoreApp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class CartForm : Form
    {
        private List<ShoppingCartItem> shoppingCart = new List<ShoppingCartItem>();
        string strSubtotal, strTax, strTotal;

        public CartForm()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["BookStoreDb"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT title_id, title, price FROM titles ORDER BY title";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal price = reader["price"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["price"]);

                        cboBookTitles.Items.Add(new
                        {
                            TitleID = reader["title_id"],
                            Title = reader["title"].ToString(),
                            Price = price,
                            Display = $"{reader["title"]} — ${price:F2}"
                        });
                    }
                }
            }

            cboBookTitles.DisplayMember = "Display";

            cboBookTitles.ValueMember = "TitleID";

        }
       

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cboBookTitles.SelectedIndex == -1)
            {
                return;
            }

            dynamic selected = cboBookTitles.SelectedItem;
            int quantity = (int)nudQuantity.Value;

            shoppingCart.Add(new ShoppingCartItem()
            {
                TitleID = 0, // Change this from 0 or fix Shopping Cart Item as TitleID in the database shows
                             // up at a string of letters and numbers
                Title = selected.Title,
                UnitPrice = selected.Price,
                Quantity = quantity,

            });
            
            updateTotals();
            updateCartList();
        }

        private void updateTotals()
        {
            decimal subtotal = 0;

            subtotal = shoppingCart.Sum(item => item.linetotal);
            decimal tax = subtotal * 0.07m;
            decimal total = subtotal + tax;

            txtbxTax.Text = tax.ToString("C");
            txtbxSubTotal.Text = subtotal.ToString("C");
            txtbxTotal.Text = total.ToString("C");

            // Set values to send to summary
            strTax = tax.ToString("C");
            strSubtotal = subtotal.ToString("C");
            strTotal = total.ToString("C");
        }

        private void updateCartList()
        {
            txtCartList.Text = "";
            foreach (var item in shoppingCart)
            {
                decimal totalBookPrice = item.UnitPrice * item.Quantity;
                txtCartList.AppendText($"${item.UnitPrice:F2} - {item.Title} | Total: ${totalBookPrice:F2}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm(shoppingCart, strTax, strTotal, strSubtotal);
            summaryForm.Show();
            this.Hide();
        }
    }
}
