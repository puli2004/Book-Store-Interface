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
            this.SuspendLayout();

            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.Location = new System.Drawing.Point(42, 39);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new System.Drawing.Size(200, 40);
            btnAddBook.Text = "Add Book";
            btnAddBook.Click += new EventHandler(OpenAddBookForm);
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchBook.Location = new System.Drawing.Point(42, 85);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new System.Drawing.Size(200, 40);
            btnSearchBook.Text = "Search Book";
            btnSearchBook.Click += new EventHandler(OpenSearchBookForm);
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.Location = new System.Drawing.Point(42, 131);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new System.Drawing.Size(200, 40);
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.Click += new EventHandler(btnAddEmployee_Click);
            // 
            // btnShop
            // 
            btnShop.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShop.Location = new System.Drawing.Point(42, 177);
            btnShop.Name = "btnShop";
            btnShop.Size = new System.Drawing.Size(200, 40);
            btnShop.Text = "Shop";
            btnShop.Click += new EventHandler(btnShop_Click);
            // 
            // btnGeneratePurchaseReport
            // 
            btnGeneratePurchaseReport.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGeneratePurchaseReport.Location = new System.Drawing.Point(42, 223);
            btnGeneratePurchaseReport.Name = "btnGeneratePurchaseReport";
            btnGeneratePurchaseReport.Size = new System.Drawing.Size(200, 40);
            btnGeneratePurchaseReport.Text = "Generate Purchase Report";
            btnGeneratePurchaseReport.Click += new EventHandler(btnGeneratePurchaseReport_Click);
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new System.Drawing.Point(42, 269);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(200, 40);
            btnLogout.Text = "Logout";
            btnLogout.Click += new EventHandler(Logout);
            // 
            // MainMenuForm
            // 
            this.AcceptButton = this.btnSearchBook;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(284, 345);
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
    }
}
