using Book_Store_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class TitleRepository
{
    private readonly string _connectionString;

    public TitleRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Title> GetAll()
    {
        List<Title> titles = new List<Title>();

        string query = @"
            SELECT 
                TitleID,
                TitleName,
                AuthorID,
                PublisherID,
                Price,
                InventoryCount
            FROM titles";   

        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                titles.Add(new Title
                {
                    TitleID = Convert.ToInt32(reader["TitleID"]),
                    TitleName = reader["TitleName"].ToString(),
                    AuthorID = Convert.ToInt32(reader["AuthorID"]),
                    PublisherID = Convert.ToInt32(reader["PublisherID"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    InventoryCount = Convert.ToInt32(reader["InventoryCount"])
                });
            }
        }

        return titles;
    }

    public Title GetById(int id)
    {
        Title title = null;

        string query = @"
            SELECT 
                TitleID,
                TitleName,
                AuthorID,
                PublisherID,
                Price,
                InventoryCount
            FROM Title
            WHERE TitleID = @id";

        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                title = new Title
                {
                    TitleID = Convert.ToInt32(reader["TitleID"]),
                    TitleName = reader["TitleName"].ToString(),
                    AuthorID = Convert.ToInt32(reader["AuthorID"]),
                    PublisherID = Convert.ToInt32(reader["PublisherID"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    InventoryCount = Convert.ToInt32(reader["InventoryCount"])
                };
            }
        }

        return title;
    }

    public void Add(Title title)
    {
        string query = @"
            INSERT INTO Title (TitleName, AuthorID, PublisherID, Price, InventoryCount)
            VALUES (@TitleName, @AuthorID, @PublisherID, @Price, @InventoryCount)";

        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@TitleName", title.TitleName);
            cmd.Parameters.AddWithValue("@AuthorID", title.AuthorID);
            cmd.Parameters.AddWithValue("@PublisherID", title.PublisherID);
            cmd.Parameters.AddWithValue("@Price", title.Price);
            cmd.Parameters.AddWithValue("@InventoryCount", title.InventoryCount);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void Update(Title title)
    {
        string query = @"
            UPDATE Title
            SET 
                TitleName = @TitleName,
                AuthorID = @AuthorID,
                PublisherID = @PublisherID,
                Price = @Price,
                InventoryCount = @InventoryCount
            WHERE TitleID = @TitleID";

        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@TitleID", title.TitleID);
            cmd.Parameters.AddWithValue("@TitleName", title.TitleName);
            cmd.Parameters.AddWithValue("@AuthorID", title.AuthorID);
            cmd.Parameters.AddWithValue("@PublisherID", title.PublisherID);
            cmd.Parameters.AddWithValue("@Price", title.Price);
            cmd.Parameters.AddWithValue("@InventoryCount", title.InventoryCount);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void Delete(int id)
    {
        string query = "DELETE FROM Title WHERE TitleID = @id";

        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
