using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Title Label
            Label lblTitle = new Label();
            lblTitle.Text = "Return a Book";
            lblTitle.Font = new Font("Arial", 16);
            lblTitle.Location = new Point(120, 10);
            lblTitle.Size = new Size(200, 30);
            this.Controls.Add(lblTitle);

            // Book ID Label and TextBox
            Label lblBookID = new Label();
            lblBookID.Text = "Enter Book ID:";
            lblBookID.Location = new Point(50, 60);
            this.Controls.Add(lblBookID);

            TextBox txtBookID = new TextBox();
            txtBookID.Location = new Point(150, 60);
            txtBookID.Size = new Size(200, 20);
            this.Controls.Add(txtBookID);

            // Return Button
            Button btnReturn = new Button();
            btnReturn.Text = "Return";
            btnReturn.BackColor = Color.Blue;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(50, 100);
            btnReturn.Size = new Size(100, 30);
            btnReturn.Click += (sender, e) => ReturnBook(txtBookID.Text);
            this.Controls.Add(btnReturn);

            // Back to Menu Button
            Button btnBackToMenu = new Button();
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.BackColor = Color.Blue;
            btnBackToMenu.ForeColor = Color.White;
            btnBackToMenu.Location = new Point(200, 100);
            btnBackToMenu.Size = new Size(100, 30);
            btnBackToMenu.Click += (sender, e) => GoBack();
            this.Controls.Add(btnBackToMenu);

            // Status TextBox
            TextBox txtStatus = new TextBox();
            txtStatus.Name = "txtStatus";
            txtStatus.Location = new Point(50, 140);
            txtStatus.Size = new Size(300, 40);
            txtStatus.Multiline = true;
            txtStatus.ReadOnly = true;
            txtStatus.BackColor = Color.LightGreen;
            this.Controls.Add(txtStatus);

            // Form Properties
            this.Text = "Return Book";
            this.Size = new Size(450, 250);
            this.ResumeLayout(false);
        }

        private void ReturnBook(string bookID)
        {
            // Simulate returning the book
            if (string.IsNullOrWhiteSpace(bookID))
            {
                DisplayStatusMessage("Error: Book ID cannot be empty.", Color.Red);
            }
            else
            {
                bool isValidBook = ValidateBookID(bookID);

                if (isValidBook)
                {
                    MessageBox.Show($"Book with ID {bookID} returned successfully!");
                    DisplayStatusMessage("Book Returned Successfully", Color.Green);
                }
                else
                {
                    DisplayStatusMessage("Error: Book ID not found.", Color.Red);
                }
            }
        }

        private bool ValidateBookID(string bookID)
        {
            //  (replace with real validation logic)
            return bookID == "12345";  // Assume "12345" is a valid Book ID
        }

        private void DisplayStatusMessage(string message, Color color)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Name == "txtStatus")
                {
                    ((TextBox)control).Text = message;
                    ((TextBox)control).ForeColor = color;
                    break;
                }
            }
        }

        private void GoBack()
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
