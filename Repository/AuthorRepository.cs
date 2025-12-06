using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Repository
{
    internal class AuthorRepository
    {
        private readonly string _connectionstring;

        public AuthorRepository()
        {
            _connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Data\\BookStore.MDF;Integrated Security=True;Connect Timeout=30";
        }

        public bool addAuthor(Author author)
        {
            string query = "INSERT INTO AUTHORS (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                "VALUES (@AuthorId, @Lname, @Fname, @PhoneNumber, @Address, @City, @State, @ZipCode, @Contract)";

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AuthorId", author.AuthorId);
                    command.Parameters.AddWithValue("@Lname", author.Lname);
                    command.Parameters.AddWithValue("@Fname", author.Fname);
                    command.Parameters.AddWithValue("@PhoneNumber", author.PhoneNumber);
                    command.Parameters.AddWithValue("@Contract", author.IsContract);

                    // Handle nullable fields in database
                    command.Parameters.AddWithValue("@Address",
                        string.IsNullOrEmpty(author.Address) ? (object)DBNull.Value : author.Address);

                    command.Parameters.AddWithValue("@City",
                        string.IsNullOrEmpty(author.City) ? (object)DBNull.Value : author.City);

                    command.Parameters.AddWithValue("@State",
                        string.IsNullOrEmpty(author.State) ? (object)DBNull.Value : author.State);

                    if (author.ZipCode.HasValue)
                    {
                        command.Parameters.AddWithValue("@ZipCode", author.ZipCode.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ZipCode", DBNull.Value);
                    }

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                            return true;
                        }
                        return false;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Database Error: {ex.Message}");
                        throw;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"General Error: {ex.Message}");
                        throw;
                    }
                }
            }
        }
    }
}
