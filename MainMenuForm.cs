using Book_Store_Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class MainMenuForm : Form
    {
        // Declare buttons for the Main Menu
        private Button btnSearchBook;
        private Button btnLogout;
        private Button btnShop;
        private Button btnAddEmployee;
        private Button btnGeneratePurchaseReport;
        private Button btnAddAuthor;
        private Button btnAddAuthor_;
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnGeneratePurchaseReport = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(42, 90);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(200, 40);
            this.btnSearchBook.TabIndex = 4;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.Click += new System.EventHandler(this.OpenSearchBookForm);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(42, 320);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.Logout);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(42, 44);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(200, 40);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new System.EventHandler(this.OpenAddBookForm);
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(42, 228);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(200, 40);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(42, 182);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 40);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnGeneratePurchaseReport
            // 
            this.btnGeneratePurchaseReport.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePurchaseReport.Location = new System.Drawing.Point(42, 274);
            this.btnGeneratePurchaseReport.Name = "btnGeneratePurchaseReport";
            this.btnGeneratePurchaseReport.Size = new System.Drawing.Size(200, 40);
            this.btnGeneratePurchaseReport.TabIndex = 0;
            this.btnGeneratePurchaseReport.Text = "Generate Purchase Report";
            this.btnGeneratePurchaseReport.Click += new System.EventHandler(this.btnGeneratePurchaseReport_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(0, 0);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 0;
            // 
            // btnAddAuthor_
            // 
            this.btnAddAuthor_.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor_.Location = new System.Drawing.Point(42, 136);
            this.btnAddAuthor_.Name = "btnAddAuthor_";
            this.btnAddAuthor_.Size = new System.Drawing.Size(200, 40);
            this.btnAddAuthor_.TabIndex = 6;
            this.btnAddAuthor_.Text = "Add Author";
            this.btnAddAuthor_.Click += new System.EventHandler(this.btnAddAuthor__Click);
            // 
            // MainMenuForm
            // 
            this.AcceptButton = this.btnSearchBook;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(284, 390);
            this.Controls.Add(this.btnAddAuthor_);
            this.Controls.Add(this.btnGeneratePurchaseReport);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearchBook);
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

        // Event Handler for Cart Button
        private void btnShop_Click(object sender, EventArgs e)
        {
            CartForm shopForm = new CartForm();
            shopForm.Show();
            this.Hide();
        }

        // Event Handler for Add Employee Button
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
            this.Hide();
        }

        // Event Handler for AGenerate Purchase Report Button
        private void btnGeneratePurchaseReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
            this.Hide();
        }

        private void btnAddAuthor__Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            addAuthorForm.Show();
            this.Hide();
        }
    }
}
