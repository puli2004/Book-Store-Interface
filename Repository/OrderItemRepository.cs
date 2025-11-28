using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    internal class OrderItemRepository
    {
        private readonly string _connectionString;

        public OrderItemRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public List<OrderItem> GetAll()
        {
            var items = new List<OrderItem>();

            string sql = @"
            SELECT 
                OrderItemID,
                OrderID,
                TitleID,
                Quantity,
                UnitPrice
            FROM OrderItem";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new OrderItem
                    {
                        OrderItemID = Convert.ToInt32(reader["OrderItemID"]),
                        OrderID = Convert.ToInt32(reader["OrderID"]),
                        TitleID = Convert.ToInt32(reader["TitleID"]),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                    });
                }
            }

            return items;
        }

       
        public List<OrderItem> GetByOrderId(int orderId)
        {
            var items = new List<OrderItem>();

            string sql = @"
            SELECT 
                OrderItemID,
                OrderID,
                TitleID,
                Quantity,
                UnitPrice
            FROM OrderItem
            WHERE OrderID = @OrderID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new OrderItem
                    {
                        OrderItemID = Convert.ToInt32(reader["OrderItemID"]),
                        OrderID = Convert.ToInt32(reader["OrderID"]),
                        TitleID = Convert.ToInt32(reader["TitleID"]),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                    });
                }
            }

            return items;
        }

        
        public void Add(OrderItem item)
        {
            string sql = @"
            INSERT INTO OrderItem
            (OrderID, TitleID, Quantity, UnitPrice)
            VALUES 
            (@OrderID, @TitleID, @Quantity, @UnitPrice)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderID", item.OrderID);
                cmd.Parameters.AddWithValue("@TitleID", item.TitleID);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
        public void Delete(int orderItemId)
        {
            string sql = @"DELETE FROM OrderItem WHERE OrderItemID = @OrderItemID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderItemID", orderItemId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
