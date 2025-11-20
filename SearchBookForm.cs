using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Title Label
            Label lblTitle = new Label();
            lblTitle.Text = "Search Book";
            lblTitle.Font = new Font("Arial", 16);
            lblTitle.Location = new Point(120, 10);
            lblTitle.Size = new Size(150, 30);
            this.Controls.Add(lblTitle);

            // Search Textbox
            Label lblSearch = new Label();
            lblSearch.Text = "Enter keyword:";
            lblSearch.Location = new Point(50, 60);
            this.Controls.Add(lblSearch);

            TextBox txtSearch = new TextBox();
            txtSearch.Location = new Point(150, 60);
            txtSearch.Size = new Size(200, 20);
            this.Controls.Add(txtSearch);

            // Search Button
            Button btnSearch = new Button();
            btnSearch.Text = "Search";
            btnSearch.BackColor = Color.Blue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(370, 60);
            btnSearch.Size = new Size(100, 30);
            btnSearch.Click += (sender, e) => SearchBook(txtSearch.Text);
            this.Controls.Add(btnSearch);

            // Search Result Area (TextBox)
            Label lblSearchResult = new Label();
            lblSearchResult.Text = "Search Results:";
            lblSearchResult.Location = new Point(50, 100);
            this.Controls.Add(lblSearchResult);

            TextBox txtSearchResults = new TextBox();
            txtSearchResults.Location = new Point(150, 100);
            txtSearchResults.Size = new Size(200, 100);
            txtSearchResults.Multiline = true;
            txtSearchResults.ReadOnly = true;
            txtSearchResults.BackColor = Color.LightBlue;
            txtSearchResults.ForeColor = Color.White;
            this.Controls.Add(txtSearchResults);

            // View Details Button
            Button btnViewDetails = new Button();
            btnViewDetails.Text = "View Details";
            btnViewDetails.BackColor = Color.Blue;
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(50, 220);
            btnViewDetails.Size = new Size(100, 30);
            btnViewDetails.Click += (sender, e) => ViewDetails(txtSearchResults.Text);  // You can implement detailed logic here
            this.Controls.Add(btnViewDetails);

            // Back Button
            Button btnBack = new Button();
            btnBack.Text = "Back";
            btnBack.BackColor = Color.Blue;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(200, 220);
            btnBack.Size = new Size(100, 30);
            btnBack.Click += (sender, e) => GoBack();
            this.Controls.Add(btnBack);

            // Form Properties
            this.Text = "Search Book";
            this.Size = new Size(500, 300);
            this.ResumeLayout(false);
        }

        private void SearchBook(string searchQuery)
        {
            // Perform search logic here. For now, it will just display the search query in the results.
            // You can replace this with actual logic to search for books in a database.

            MessageBox.Show($"Searching for books with title: {searchQuery}");
        }

        private void ViewDetails(string searchResult)
        {
            // Implement logic to view the details of the selected book from the search results.
            // For example, open a new form or display a message.
            MessageBox.Show($"Viewing details for book: {searchResult}");
        }

        private void GoBack()
        {
            // Navigate back to the Main Menu
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
