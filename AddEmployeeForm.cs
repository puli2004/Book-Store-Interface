using BookStoreApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class AddEmployeeForm : Form
    {
        string firstName;
        char middleInitial;
        string lastName;
        DateTime hireDate;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Ensure first name is under 20 for DB
            if (firstName.Length > 20)
                firstName = firstName.Substring(0, 20);

            // Ensure last name is under 30 for DB
            if (lastName.Length > 30)
                lastName = lastName.Substring(0, 30);

            firstName = txtFirstName.Text;
            middleInitial = txtMiddleInitial.Text[0];
            lastName = txtLastName.Text;
            hireDate = dtpHireDate.Value;

            // ENTER CODE TO ADD TO DATABASE HERE
        }
    }
}
