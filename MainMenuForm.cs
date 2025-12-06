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
            this.SuspendLayout();
<<<<<<< HEAD

=======
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
            this.btnLogout.Location = new System.Drawing.Point(42, 315);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.Logout);
>>>>>>> 4469348417cd9fcc3ff3b19d39aef0960026ba51
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
<<<<<<< HEAD
            btnSearchBook.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchBook.Location = new System.Drawing.Point(42, 85);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new System.Drawing.Size(200, 40);
            btnSearchBook.Text = "Search Book";
            btnSearchBook.Click += new EventHandler(OpenSearchBookForm);
=======
            this.btnShop.BackColor = System.Drawing.Color.Blue;
            this.btnShop.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(42, 223);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(200, 40);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
>>>>>>> 4469348417cd9fcc3ff3b19d39aef0960026ba51
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
<<<<<<< HEAD
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
=======
            this.btnGeneratePurchaseReport.BackColor = System.Drawing.Color.Blue;
            this.btnGeneratePurchaseReport.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePurchaseReport.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePurchaseReport.Location = new System.Drawing.Point(42, 269);
            this.btnGeneratePurchaseReport.Name = "btnGeneratePurchaseReport";
            this.btnGeneratePurchaseReport.Size = new System.Drawing.Size(200, 40);
            this.btnGeneratePurchaseReport.TabIndex = 4;
            this.btnGeneratePurchaseReport.Text = "Generate Purchase Report";
            this.btnGeneratePurchaseReport.UseVisualStyleBackColor = false;
            this.btnGeneratePurchaseReport.Click += new System.EventHandler(this.btnGeneratePurchaseReport_Click);
>>>>>>> 4469348417cd9fcc3ff3b19d39aef0960026ba51
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Blue;
            this.btnAddAuthor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(42, 177);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(200, 40);
            this.btnAddAuthor.TabIndex = 6;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // MainMenuForm
            // 
            this.AcceptButton = this.btnSearchBook;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(284, 398);
            this.Controls.Add(this.btnAddAuthor);
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

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            addAuthorForm.Show();
            this.Hide();
        }
    }
}
