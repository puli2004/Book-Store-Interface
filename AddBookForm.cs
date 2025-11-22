using System;
using System.Drawing;
using System.Runtime.Remoting.Lifetime;
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

        //Validate ISBN formats
        private bool isValidISBN(String isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return false;
            }

            //Strip hypens or spaces for easier validation
            isbn = isbn.Replace("-", "").Replace(" ", "");

            //Handle ISBN-10
            if (isbn.Length == 10)
            {
                //Validate first 9 characters are digits 0-9, last character can be a digit or 'X'
                if (!Regex.IsMatch(isbn, @"^\d{9}(\d|X)$"))
                {
                    return false;
                }

                int sum = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    //If last digit is X (which represents 10)
                    if (isbn[i] == 'X')
                    {
                        sum += 10 * (i + 1);
                    }
                    else sum += (isbn[i] - '0') * (i + 1);
                }

                return sum % 11 == 0;
            }

            //Handle ISBN-13
            if (isbn.Length == 13)
            {
                //Validate all characters are digits 0-9
                if (!Regex.IsMatch(isbn, @"^\d{13}$"))
                {
                    return false;
                }

                int sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    int digit = isbn[i] - '0';
                    sum += (i % 2 == 0) ? digit : digit * 3;
                }

                int check = (10 - (sum % 10)) % 10;
                return check == (isbn[12] - '0');
            }

            return false;

        }

        //Validate input before saving
        private bool validateInput(out StringBuilder errors)
        {
            errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errors.Append("•Please specify a title for the book.\n");
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                errors.Append("•Please specify an author for the book.\n");
            }

            if (string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                errors.Append("•Please specify a genre for the book.\n");
            }

            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                errors.Append("•Please specify a year for the book.\n");
            }
            else if (int.TryParse(txtYear.Text, out int year))
            {
                //Range can be changed later if needed
                if (year < 1500 || year > 2025)
                {
                    errors.Append("•Please enter a valid range for the year (1500-2025).\n");
                }
            }
            //If invalid year format
            else
            {
                errors.Append("•Please enter a valid year for the book.\n");
            }

            if (!isValidISBN(txtISBN.Text))
            {
                errors.Append("•Please specify a valid ISBN-10 or ISBN-13 for the book.");
            }

            return errors.Length == 0;
        }

        // Save button click handler
        private void SaveBook_Click(object sender, EventArgs e)
        {
            /* TESTING PURPOSES
             * Here are some valid ISBN values to test
             * ISBN-10: 1-234-56789-X
             * ISBN-13: 9780306406157
             */
            StringBuilder errors;
            if (!validateInput(out errors))
            {
                MessageBox.Show(errors.ToString(), "Error");
            }
            else MessageBox.Show("Book Saved!");
        }

        // Back to menu button click handler
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
