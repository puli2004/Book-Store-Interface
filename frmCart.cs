using Book_Store_Interface.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class frmCart : Form
    {
        public frmCart()
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

                        cboTitles.Items.Add(new
                        {
                            TitleID = reader["title_id"],
                            Title = reader["title"].ToString(),
                            Price = price,
                            Display = $"{reader["title"]} — ${price:F2}"
                        });
                    }
                }
            }

            cboTitles.DisplayMember = "Display";

            cboTitles.ValueMember = "TitleID";

        }

        private List<ShoppingCartItem> shoppingCart = new List<ShoppingCartItem>();

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cboTitles.SelectedIndex == -1)
            {
                return;
            }

            dynamic selected = cboTitles.SelectedItem;
            int quantity = (int)nudQuantity.Value;

            shoppingCart.Add(new ShoppingCartItem()
            {
                TitleID = selected.TitleID,
                Title = selected.Title,
                UnitPrice = selected.UnitPrice,
                Quantity = quantity,

            });

            updateTotal();

        }

        private void updateTotal()
        {
            decimal subtotal = 0;

            subtotal = shoppingCart.Sum(item => item.linetotal);
            decimal tax = subtotal * 0.07m;
            decimal total = subtotal + tax;

            txtTotal.Text = total.ToString("C");
        }
    }
}
