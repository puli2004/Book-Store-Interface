using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    public class EmployeeRepository
    {
        private string connectionString;
        public EmployeeRepository(string conn) 
        {
            connectionString = conn;  
        }

        public Employee ValidateLogin(string employeeId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();

                string query = @"
                SELECT emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date
                FROM employee
                WHERE RTRIM(emp_id) = RTRIM(@emp_id)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@emp_id", employeeId.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Employee
                            {
                                EmpId = reader["emp_id"].ToString(),
                                Fname = reader["fname"].ToString(),
                                Minit = reader["minit"] as char?,
                                Lname = reader["lname"].ToString(),
                                JobId = Convert.ToInt16(reader["job_id"]),
                                JobLevel = reader["job_lvl"] as byte?,
                                PubId = reader["pub_id"].ToString(),
                                HireDate = Convert.ToDateTime(reader["hire_date"])
                            };
                        }
                    }
                }
            }
               

            return null; 
        }

    }
}
