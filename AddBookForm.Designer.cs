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
            this.SuspendLayout();

            // Title Label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "Add Book";
            this.lblTitle.Font = new Font("Arial", 16);
            this.lblTitle.Location = new Point(120, 10);
            this.lblTitle.Size = new Size(150, 30);
            this.Controls.Add(this.lblTitle);

            // Title Label and TextBox
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookTitle.Text = "Title:";
            this.lblBookTitle.Location = new Point(50, 60);
            this.Controls.Add(this.lblBookTitle);

            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTitle.Location = new Point(150, 60);
            this.txtTitle.Size = new Size(200, 20);
            this.Controls.Add(this.txtTitle);

            // Author Label and TextBox
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.Location = new Point(50, 100);
            this.Controls.Add(this.lblAuthor);

            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtAuthor.Location = new Point(150, 100);
            this.txtAuthor.Size = new Size(200, 20);
            this.Controls.Add(this.txtAuthor);

            // Genre Label and TextBox
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Location = new Point(50, 140);
            this.Controls.Add(this.lblGenre);

            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtGenre.Location = new Point(150, 140);
            this.txtGenre.Size = new Size(200, 20);
            this.Controls.Add(this.txtGenre);

            // Year Label and TextBox
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYear.Text = "Year:";
            this.lblYear.Location = new Point(50, 180);
            this.Controls.Add(this.lblYear);

            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtYear.Location = new Point(150, 180);
            this.txtYear.Size = new Size(200, 20);
            this.Controls.Add(this.txtYear);

            // ISBN Label and TextBox
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Location = new Point(50, 220);
            this.Controls.Add(this.lblISBN);

            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtISBN.Location = new Point(150, 220);
            this.txtISBN.Size = new Size(200, 20);
            this.Controls.Add(this.txtISBN);

            // Save Book Button
            this.btnSaveBook = new Button();
            this.btnSaveBook.Text = "Save Book";
            this.btnSaveBook.BackColor = Color.Blue;
            this.btnSaveBook.ForeColor = Color.White;
            this.btnSaveBook.Location = new Point(50, 260);
            this.btnSaveBook.Size = new Size(100, 30);
            this.btnSaveBook.Click += new EventHandler(this.SaveBook_Click);
            this.Controls.Add(this.btnSaveBook);

            // Back to Menu Button
            this.btnBackToMenu = new Button();
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.BackColor = Color.Blue;
            this.btnBackToMenu.ForeColor = Color.White;
            this.btnBackToMenu.Location = new Point(200, 260);
            this.btnBackToMenu.Size = new Size(100, 30);
            this.btnBackToMenu.Click += new EventHandler(this.BackToMenu_Click);
            this.Controls.Add(this.btnBackToMenu);

            // Finalize layout
            this.Text = "Add Book";
            this.Size = new Size(400, 350);
            this.ResumeLayout(false);
        }
    }
}
