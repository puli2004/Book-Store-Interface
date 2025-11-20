using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class BorrowBookForm : Form
    {
        private Label lblTitle;
        private Label lblBookID;
        private TextBox txtBookID;
        private Button btnBorrow;
        private Button btnBackToMenu;
        private TextBox txtStatus;

        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 30);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Borrow a Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookID
            // 
            this.lblBookID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(33, 88);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(108, 23);
            this.lblBookID.TabIndex = 9;
            this.lblBookID.Text = "Enter Book ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(147, 85);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(255, 27);
            this.txtBookID.TabIndex = 0;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Blue;
            this.btnBorrow.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(147, 128);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(100, 30);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Blue;
            this.btnBackToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMenu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(282, 128);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(120, 30);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.LightGreen;
            this.txtStatus.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(37, 188);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(365, 40);
            this.txtStatus.TabIndex = 15;
            // 
            // BorrowBookForm
            // 
            this.AcceptButton = this.btnBorrow;
            this.CancelButton = this.btnBackToMenu;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.txtStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowBookForm";
            this.Text = "Borrow Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BorrowBook(string bookID)
        {
            // Simulate borrowing the book
            if (string.IsNullOrWhiteSpace(bookID))
            {
                DisplayStatusMessage("Error: Book ID cannot be empty.", Color.Red); // Error message in red
            }
            else
            {
                // Here, you can replace this check with a database query or an actual check for the Book ID.
                bool isValidBook = ValidateBookID(bookID);

                if (isValidBook)
                {
                    MessageBox.Show($"Book with ID {bookID} borrowed successfully!");
                    DisplayStatusMessage("Book Borrowed Successfully", Color.Green);
                }
                else
                {
                    DisplayStatusMessage("Error: Book ID not found.", Color.Red); // Error message in red
                }
            }
        }

        private bool ValidateBookID(string bookID)
        {

            // Replace this with actual validation logic such as checking a database or a list of books
            return bookID == "12345";  // Let's assume 12345 is a valid Book ID
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

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBook(txtBookID.Text);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
