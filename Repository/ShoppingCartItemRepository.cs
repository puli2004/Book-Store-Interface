using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    internal class ShoppingCartItemRepository
    {
        private readonly string _connectionString;

        public ShoppingCartItemRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void AddCartItem(ShoppingCartItem item)
        {
            string query = @"
            INSERT INTO cartitems (Id, cartID, productID, quantity, unitPrice)
            VALUES (@Id, @CartID, @ProductID, @Quantity, @UnitPrice);
        ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", item.CartItemID);
                cmd.Parameters.AddWithValue("@CartID", item.CartID);
                cmd.Parameters.AddWithValue("@ProductID", item.TitleID);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public ShoppingCartItem GetCartItemById(int itemId)
        {
            string query = @"
            SELECT Id, cartID, productID, quantity, unitPrice
            FROM cartitems
            WHERE Id = @Id;
        ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", itemId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ShoppingCartItem
                        {
                            CartItemID = (int)reader["Id"],
                            CartID = (int)reader["cartID"],
                            TitleID = (int)reader["productID"],
                            Quantity = (int)reader["quantity"],
                            UnitPrice = (decimal)reader["unitPrice"]
                        };
                    }
                }
            }

            return null;
        }


        public List<ShoppingCartItem> GetItemsByCartId(int cartId)
        {
            List<ShoppingCartItem> items = new List<ShoppingCartItem>();

            string query = @"
            SELECT Id, cartID, productID, quantity, unitPrice
            FROM cartitems
            WHERE cartID = @CartID;
        ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CartID", cartId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new ShoppingCartItem
                        {
                            CartItemID = (int)reader["Id"],
                            CartID = (int)reader["cartID"],
                            TitleID = (int)reader["productID"],
                            Quantity = (int)reader["quantity"],
                            UnitPrice = (decimal)reader["unitPrice"]
                        });
                    }
                }
            }

            return items;
        }


        public void UpdateQuantity(int cartItemId, int newQuantity)
        {
            string query = "UPDATE cartitems SET quantity = @Quantity WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                cmd.Parameters.AddWithValue("@Id", cartItemId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateUnitPrice(int cartItemId, decimal price)
        {
            string query = "UPDATE cartitems SET unitPrice = @UnitPrice WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UnitPrice", price);
                cmd.Parameters.AddWithValue("@Id", cartItemId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCartItem(int cartItemId)
        {
            string query = "DELETE FROM cartitems WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", cartItemId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
