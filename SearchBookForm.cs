using BookStoreApp;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class SearchBookForm : Form
    {
        private int currentBookId = -1; // store selected book ID

        public SearchBookForm()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                currentBookId = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a book title to search.");
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["BookStoreDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT Id, Title FROM Books WHERE Title LIKE @Title";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", "%" + searchQuery + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentBookId = reader.GetInt32(0);
                            txtSearchResults.Text = "Book Available: " + reader.GetString(1);
                        }
                        else
                        {
                            currentBookId = -1;
                            txtSearchResults.Text = "Book Not Available";
                        }
                    }
                }
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (currentBookId == -1)
            {
                MessageBox.Show("No book selected.");
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["BookStoreDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT Title, Author, Genre, Price, PublishedYear, ISBN FROM Books WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", currentBookId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Title: " + reader.GetString(0));
                            sb.AppendLine("Author: " + reader.GetString(1));
                            sb.AppendLine("Genre: " + reader.GetString(2));
                            sb.AppendLine("Price: $" + reader.GetDecimal(3).ToString("F2"));
                            sb.AppendLine("Published Year: " + reader.GetInt32(4));
                            sb.AppendLine("ISBN: " + reader.GetString(5));

                            txtSearchResults.Text = sb.ToString();
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
        }
    }
}
