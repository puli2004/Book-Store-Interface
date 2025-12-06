using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    partial class AddBookForm
    {
        private Button btnSaveBook;
        private Button btnBackToMenu;
        private TextBox txtTitle, txtAuthor, txtGenre, txtYear, txtISBN;
        private Label lblTitle, lblBookTitle, lblAuthor, lblGenre, lblYear, lblISBN;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.lblTitle = new Label();
            this.lblBookTitle = new Label();
            this.txtTitle = new TextBox();
            this.lblAuthor = new Label();
            this.txtAuthor = new TextBox();
            this.lblGenre = new Label();
            this.txtGenre = new TextBox();
            this.lblYear = new Label();
            this.txtYear = new TextBox();
            this.lblISBN = new Label();
            this.txtISBN = new TextBox();
            this.btnSaveBook = new Button();
            this.btnBackToMenu = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Corbel", 24F, FontStyle.Regular);
            this.lblTitle.Location = new Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(380, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Book";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Font = new Font("Corbel", 9.75F);
            this.lblBookTitle.Location = new Point(45, 92);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new Size(48, 23);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Title:";
            this.lblBookTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new Font("Corbel", 8.25F);
            this.txtTitle.Location = new Point(99, 92);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new Size(246, 21);
            this.txtTitle.TabIndex = 2;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new Font("Corbel", 9.75F);
            this.lblAuthor.Location = new Point(45, 132);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new Size(48, 23);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new Font("Corbel", 8.25F);
            this.txtAuthor.Location = new Point(99, 132);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new Size(246, 21);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new Font("Corbel", 9.75F);
            this.lblGenre.Location = new Point(45, 172);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new Size(48, 23);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new Font("Corbel", 8.25F);
            this.txtGenre.Location = new Point(99, 172);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new Size(246, 21);
            this.txtGenre.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.Font = new Font("Corbel", 9.75F);
            this.lblYear.Location = new Point(45, 212);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new Size(48, 23);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            this.lblYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            this.txtYear.Font = new Font("Corbel", 8.25F);
            this.txtYear.Location = new Point(99, 212);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new Size(246, 21);
            this.txtYear.TabIndex = 8;
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new Font("Corbel", 9.75F);
            this.lblISBN.Location = new Point(45, 252);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new Size(48, 23);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new Font("Corbel", 8.25F);
            this.txtISBN.Location = new Point(99, 252);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new Size(246, 21);
            this.txtISBN.TabIndex = 10;
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Font = new Font("Corbel", 12F);
            this.btnSaveBook.Location = new Point(82, 305);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new Size(120, 40);
            this.btnSaveBook.TabIndex = 11;
            this.btnSaveBook.Text = "Save Book";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new EventHandler(this.SaveBook_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.DialogResult = DialogResult.Cancel;
            this.btnBackToMenu.Font = new Font("Corbel", 12F);
            this.btnBackToMenu.Location = new Point(208, 305);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new Size(120, 40);
            this.btnBackToMenu.TabIndex = 12;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new EventHandler(this.BackToMenu_Click);
            // 
            // AddBookForm
            // 
            this.AcceptButton = this.btnSaveBook;
            this.CancelButton = this.btnBackToMenu;
            this.ClientSize = new Size(404, 381);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
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
