using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    internal class ShoppingCartRepository
    {
        private readonly string _connectionString;

        public ShoppingCartRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

       
        public void AddShoppingCart(ShoppingCart cart)
        {
            string query = @"
            INSERT INTO cart (cart_id, customer_id, status)
            VALUES (@CartID, @CustomerID, @Status);
        ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CartID", cart.CartID);
                cmd.Parameters.AddWithValue("@CustomerID", cart.CustomerID);
                cmd.Parameters.AddWithValue("@Status", "Active");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public ShoppingCart GetCartById(int cartId)
        {
            string query = "SELECT cart_id, customer_id, status FROM cart WHERE cart_id = @CartID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CartID", cartId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ShoppingCart
                        {
                            CartID = (int)reader["cart_id"],
                            CustomerID = (int)reader["customer_id"]
                            // status not part of class → intentionally skipped
                        };
                    }
                }
            }

            return null;
        }

       
        public ShoppingCart GetActiveCartByCustomer(int customerId)
        {
            string query = @"
            SELECT cart_id, customer_id, status
            FROM cart
            WHERE customer_id = @CustomerID AND status = 'Active';
        ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ShoppingCart
                        {
                            CartID = (int)reader["cart_id"],
                            CustomerID = (int)reader["customer_id"]
                        };
                    }
                }
            }

            return null;
        }

        
        public void UpdateStatus(int cartId, string newStatus)
        {
            string query = @"UPDATE cart SET status = @Status WHERE cart_id = @CartID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@CartID", cartId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
        public void DeleteCart(int cartId)
        {
            string query = @"DELETE FROM cart WHERE cart_id = @CartID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CartID", cartId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
