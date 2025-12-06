using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        // Validate ISBN formats (ISBN-10 or ISBN-13)
        private bool isValidISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
                return false;

            isbn = isbn.Replace("-", "").Replace(" ", "");

            if (isbn.Length == 10)
            {
                if (!Regex.IsMatch(isbn, @"^\d{9}(\d|X)$"))
                    return false;

                int sum = 0;
                for (int i = 0; i < 10; i++)
                    sum += (isbn[i] == 'X' ? 10 : isbn[i] - '0') * (i + 1);

                return sum % 11 == 0;
            }

            if (isbn.Length == 13)
            {
                if (!Regex.IsMatch(isbn, @"^\d{13}$"))
                    return false;

                int sum = 0;
                for (int i = 0; i < 12; i++)
                    sum += (i % 2 == 0 ? 1 : 3) * (isbn[i] - '0');

                int check = (10 - (sum % 10)) % 10;
                return check == (isbn[12] - '0');
            }

            return false;
        }

        // Validate input fields
        private bool validateInput(out StringBuilder errors)
        {
            errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
                errors.Append("• Please enter a book title.\n");
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
                errors.Append("• Please enter an author.\n");
            if (string.IsNullOrWhiteSpace(txtGenre.Text))
                errors.Append("• Please enter a genre.\n");

            if (!int.TryParse(txtYear.Text, out int year) || year < 1500 || year > 2025)
                errors.Append("• Please enter a valid Published Year (1500-2025).\n");

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                errors.Append("• Please enter a valid Price.\n");

            if (!isValidISBN(txtISBN.Text))
                errors.Append("• Please enter a valid ISBN-10 or ISBN-13.\n");

            return errors.Length == 0;
        }

        // Save book to database
        private void SaveBook_Click(object sender, EventArgs e)
        {
            if (!validateInput(out StringBuilder errors))
            {
                MessageBox.Show(errors.ToString(), "Validation Error");
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["BookStoreDb"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Books (Title, Author, Genre, Price, PublishedYear, ISBN)
                                     VALUES (@Title, @Author, @Genre, @Price, @PublishedYear, @ISBN)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@Author", txtAuthor.Text.Trim());
                        cmd.Parameters.AddWithValue("@Genre", txtGenre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@PublishedYear", int.Parse(txtYear.Text.Trim()));
                        cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book saved successfully!", "Success");

                // Clear fields after save
                txtTitle.Clear();
                txtAuthor.Clear();
                txtGenre.Clear();
                txtYear.Clear();
                txtPrice.Clear();
                txtISBN.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving book: " + ex.Message, "Database Error");
            }
        }

        // Back to main menu
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
