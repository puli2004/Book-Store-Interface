using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        // Save button click handler
        private void SaveBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book Saved!");
        }

        // Back to menu button click handler
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
