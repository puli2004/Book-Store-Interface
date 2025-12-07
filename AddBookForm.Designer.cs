using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    partial class AddBookForm
    {
        private Button btnSaveBook;
        private Button btnBackToMenu;
        private TextBox txtTitle, txtAuthor, txtGenre, txtYear, txtISBN, txtPrice;
        private Label lblTitle, lblBookTitle, lblAuthor, lblGenre, lblYear, lblISBN, lblPrice;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 24F);
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblBookTitle.Location = new System.Drawing.Point(45, 92);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(48, 23);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Title:";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtTitle.Location = new System.Drawing.Point(99, 92);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(246, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblAuthor.Location = new System.Drawing.Point(45, 132);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(48, 23);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtAuthor.Location = new System.Drawing.Point(99, 132);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(246, 21);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblGenre.Location = new System.Drawing.Point(45, 172);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 23);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtGenre.Location = new System.Drawing.Point(99, 172);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(246, 21);
            this.txtGenre.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblYear.Location = new System.Drawing.Point(3, 212);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(90, 23);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Published Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtYear.Location = new System.Drawing.Point(99, 212);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(246, 21);
            this.txtYear.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblPrice.Location = new System.Drawing.Point(45, 252);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 23);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtPrice.Location = new System.Drawing.Point(99, 252);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(246, 21);
            this.txtPrice.TabIndex = 4;
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblISBN.Location = new System.Drawing.Point(45, 292);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 23);
            this.lblISBN.TabIndex = 11;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtISBN.Location = new System.Drawing.Point(99, 292);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(246, 21);
            this.txtISBN.TabIndex = 5;
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnSaveBook.Location = new System.Drawing.Point(82, 335);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(120, 40);
            this.btnSaveBook.TabIndex = 6;
            this.btnSaveBook.Text = "Save Book";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.SaveBook_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMenu.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnBackToMenu.Location = new System.Drawing.Point(208, 335);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(120, 40);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AddBookForm
            // 
            this.AcceptButton = this.btnSaveBook;
            this.CancelButton = this.btnBackToMenu;
            this.ClientSize = new System.Drawing.Size(404, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnSaveBook);
            this.Controls.Add(this.btnBackToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
