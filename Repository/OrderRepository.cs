using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    internal class OrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public List<Order> GetAll()
        {
            var orders = new List<Order>();

            string sql = @"
            SELECT 
                orderID,
                customerID,
                OrderDate,
                TotalAmount,
                Status,
                PaymentMethod
            FROM OrderTable";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderID = Convert.ToInt32(reader["orderID"]),
                        CustomerID = Convert.ToInt32(reader["customerID"]),
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString()
                    });
                }
            }

            return orders;
        }

       
        public Order GetById(int id)
        {
            Order order = null;

            string sql = @"
            SELECT 
                orderID,
                customerID,
                OrderDate,
                TotalAmount,
                Status,
                PaymentMethod
            FROM OrderTable
            WHERE orderID = @orderID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@orderID", id);

                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    order = new Order
                    {
                        OrderID = Convert.ToInt32(reader["orderID"]),
                        CustomerID = Convert.ToInt32(reader["customerID"]),
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        Status = reader["Status"].ToString(),
                        PaymentMethod = reader["PaymentMethod"].ToString()
                    };
                }
            }

            return order;
        }

       
        public void Add(Order order)
        {
            string sql = @"
            INSERT INTO OrderTable 
            (orderID, customerID, OrderDate, TotalAmount, Status, PaymentMethod)
            VALUES 
            (@OrderID, @CustomerID, @OrderDate, @TotalAmount, @Status, @PaymentMethod)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                cmd.Parameters.AddWithValue("@Status", order.Status);
                cmd.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public void Update(Order order)
        {
            string sql = @"
            UPDATE OrderTable
            SET 
                customerID = @CustomerID,
                OrderDate = @OrderDate,
                TotalAmount = @TotalAmount,
                Status = @Status,
                PaymentMethod = @PaymentMethod
            WHERE orderID = @OrderID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                cmd.Parameters.AddWithValue("@Status", order.Status);
                cmd.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
   
        public void Delete(int id)
        {
            string sql = @"DELETE FROM OrderTable WHERE orderID = @OrderID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
