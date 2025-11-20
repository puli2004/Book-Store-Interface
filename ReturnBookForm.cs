using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class ReturnBookForm : Form
    {
        private Label lblTitle;
        private Label lblBookID;
        private TextBox txtBookID;
        private Button btnReturn;
        private Button btnBackToMenu;
        private TextBox txtStatus;

        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Return a Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookID
            // 
            this.lblBookID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(34, 77);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(116, 23);
            this.lblBookID.TabIndex = 7;
            this.lblBookID.Text = "Enter Book ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(156, 73);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(232, 27);
            this.txtBookID.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Blue;
            this.btnReturn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(156, 113);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 30);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Blue;
            this.btnBackToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMenu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(268, 113);
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
            this.txtStatus.Location = new System.Drawing.Point(38, 159);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(350, 40);
            this.txtStatus.TabIndex = 15;
            // 
            // ReturnBookForm
            // 
            this.AcceptButton = this.btnReturn;
            this.CancelButton = this.btnBackToMenu;
            this.ClientSize = new System.Drawing.Size(434, 228);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.txtStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBookForm";
            this.Text = "Return Book";
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook(txtBookID.Text);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
