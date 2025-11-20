using System;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class MainMenuForm : Form
    {
        // Declare buttons for the Main Menu
        private Button btnSearchBook;
        private Button btnLogout;
        private Button btnBorrowBook;
        private Button btnReturnBook;
        private Button btnAddBook;

        public MainMenuForm()
        {
            InitializeComponent();  // Initializes controls defined in the Designer
        }

        private void InitializeComponent()
        {
            // Initialize buttons
            this.btnSearchBook = new Button();
            this.btnLogout = new Button();
            this.btnBorrowBook = new Button();
            this.btnReturnBook = new Button();
            this.btnAddBook = new Button();

            this.SuspendLayout();

            // Add Book Button
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.BackColor = System.Drawing.Color.Blue;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(50, 50);
            this.btnAddBook.Size = new System.Drawing.Size(200, 40);
            this.btnAddBook.Click += new EventHandler(this.OpenAddBookForm); // Handle Add Book button click
            this.Controls.Add(this.btnAddBook);

            // Search Book Button
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.BackColor = System.Drawing.Color.Blue;
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(50, 100);
            this.btnSearchBook.Size = new System.Drawing.Size(200, 40);
            this.btnSearchBook.Click += new EventHandler(this.OpenSearchBookForm); // Handle Search button click
            this.Controls.Add(this.btnSearchBook);

            // Borrow Book Button
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.BackColor = System.Drawing.Color.Blue;
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.Location = new System.Drawing.Point(50, 150);
            this.btnBorrowBook.Size = new System.Drawing.Size(200, 40);
            this.btnBorrowBook.Click += new EventHandler(this.OpenBorrowBookForm); // Handle Borrow button click
            this.Controls.Add(this.btnBorrowBook);

            // Return Book Button
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.BackColor = System.Drawing.Color.Blue;
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(50, 200);
            this.btnReturnBook.Size = new System.Drawing.Size(200, 40);
            this.btnReturnBook.Click += new EventHandler(this.OpenReturnBookForm); // Handle Return button click
            this.Controls.Add(this.btnReturnBook);

            // Logout Button
            this.btnLogout.Text = "Logout";
            this.btnLogout.BackColor = System.Drawing.Color.Blue;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(50, 250);
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.Click += new EventHandler(this.Logout); // Handle Logout button click
            this.Controls.Add(this.btnLogout);

            // Main Menu Form Properties
            this.Text = "Main Menu";
            this.Size = new System.Drawing.Size(300, 350);

            this.ResumeLayout(false);
        }

        // Event Handler for Add Book Button
        private void OpenAddBookForm(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(); // Open AddBookForm
            addBookForm.Show();
            this.Hide(); // Hide MainMenuForm
        }

        // Event Handler for Search Book Button
        private void OpenSearchBookForm(object sender, EventArgs e)
        {
            SearchBookForm searchBookForm = new SearchBookForm(); // Open SearchBookForm
            searchBookForm.Show();
            this.Hide(); // Hide MainMenuForm
        }

        // Event Handler for Borrow Book Button
        private void OpenBorrowBookForm(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm(); // Open BorrowBookForm
            borrowBookForm.Show();
            this.Hide(); // Hide MainMenuForm
        }

        // Event Handler for Return Book Button
        private void OpenReturnBookForm(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm(); // Open ReturnBookForm
            returnBookForm.Show();
            this.Hide(); // Hide MainMenuForm
        }

        // Event Handler for Logout Button
        private void Logout(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Open LoginForm
            loginForm.Show();
            this.Hide(); // Hide MainMenuForm
        }
    }
}
