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
            this.btnLogout.Location = new System.Drawing.Point(42, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.Logout);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Blue;
            this.btnAddBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(42, 39);
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
            this.btnShop.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(42, 177);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(200, 40);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Blue;
            this.btnAddEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(42, 131);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 40);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnGeneratePurchaseReport
            // 
            this.btnGeneratePurchaseReport.BackColor = System.Drawing.Color.Blue;
            this.btnGeneratePurchaseReport.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePurchaseReport.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePurchaseReport.Location = new System.Drawing.Point(42, 223);
            this.btnGeneratePurchaseReport.Name = "btnGeneratePurchaseReport";
            this.btnGeneratePurchaseReport.Size = new System.Drawing.Size(200, 40);
            this.btnGeneratePurchaseReport.TabIndex = 4;
            this.btnGeneratePurchaseReport.Text = "Generate Purchase Report";
            this.btnGeneratePurchaseReport.UseVisualStyleBackColor = false;
            this.btnGeneratePurchaseReport.Click += new System.EventHandler(this.btnGeneratePurchaseReport_Click);
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
