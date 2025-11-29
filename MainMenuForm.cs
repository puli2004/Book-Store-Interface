using Book_Store_Interface;
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
        private Button btnShop;
        private Button btnAddBook;

        public MainMenuForm()
        {
            InitializeComponent();  // Initializes controls defined in the Designer
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.Blue;
            this.btnSearchBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(42, 85);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(200, 40);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.OpenSearchBookForm);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Blue;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(42, 235);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.Logout);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.Blue;
            this.btnBorrowBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.Location = new System.Drawing.Point(42, 135);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(200, 40);
            this.btnBorrowBook.TabIndex = 2;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.OpenBorrowBookForm);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.Blue;
            this.btnReturnBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(42, 185);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(200, 40);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.OpenReturnBookForm);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Blue;
            this.btnAddBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(42, 35);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(200, 40);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.OpenAddBookForm);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Blue;
            this.btnShop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShop.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(42, 281);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(200, 40);
            this.btnShop.TabIndex = 5;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // MainMenuForm
            // 
            this.AcceptButton = this.btnSearchBook;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(284, 353);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
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

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmCart shopForm = new frmCart();
            shopForm.Show();
            this.Hide();
        }
    }
}
