using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    internal class SalesRepository
    {

        string connectionString = ConfigurationManager.ConnectionStrings["BookStoreDb"]?.ConnectionString;

        public List<Sales> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            List<Sales> report = new List<Sales>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            SELECT 
                s.ord_num,
                s.title_id,
                t.title,
                s.qty,
                s.ord_date,
                (s.qty * t.price) AS total_value
            FROM sales s
            INNER JOIN titles t ON s.title_id = t.title_id
            WHERE s.ord_date BETWEEN @startDate AND @endDate
            ORDER BY s.ord_date ASC;
        ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report.Add(new Sales
                            {
                                OrdNum = reader.GetString(0),
                                TitleId = reader["title_id"].ToString(),
                                Title = reader.GetString(2),
                                Qty = reader.GetInt16(3),
                                OrdDate = reader.GetDateTime(4),
                                TotalValue = reader.GetDecimal(5)
                            });
                        }
                    }
                }
            }

            return report;
        }


        public string GetNextOrderNumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT MAX(ord_num) FROM sales";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                        return "1";  // First order

                    int last = int.Parse(result.ToString());
                    return (last + 1).ToString();
                }
            }
        }

        public void InsertSale(Sales sale)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            INSERT INTO sales (stor_id, ord_num, ord_date, qty, payterms, title_id)
            VALUES (@stor_id, @ord_num, @ord_date, @qty, @payterms, @title_id)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@stor_id", sale.StorId);
                    cmd.Parameters.AddWithValue("@ord_num", sale.OrdNum);
                    cmd.Parameters.AddWithValue("@ord_date", sale.OrdDate);
                    cmd.Parameters.AddWithValue("@qty", sale.Qty);
                    cmd.Parameters.AddWithValue("@payterms", sale.PayTerms);
                    cmd.Parameters.AddWithValue("@title_id", sale.TitleId);

                    cmd.ExecuteNonQuery();
                }
            }
        }






    }
}
