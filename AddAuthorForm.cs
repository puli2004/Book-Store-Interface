using Book_Store_Interface.Models;
using Book_Store_Interface.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            StringBuilder errorMessages = new StringBuilder();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.txtID.Text))
            {
                errorMessages.AppendLine("Author ID is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(this.txtID.Text, @"^\d{3}-\d{2}-\d{4}$"))
            {
                errorMessages.AppendLine("Author ID must be in the format: ###-##-#### (e.g., 123-45-6789).");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                errorMessages.AppendLine("First Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                errorMessages.AppendLine("Last Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.mtxtPhoneNumber.Text))
            {
                errorMessages.AppendLine("Phone Number is required.");
                isValid = false;
            }


            if (this.txtFirstName.Text.Length > 20)
            {
                errorMessages.AppendLine("First Name cannot exceed 20 characters.");
                isValid = false;
            }

            if (this.txtLastName.Text.Length > 40)
            {
                errorMessages.AppendLine("Last Name cannot exceed 40 characters.");
                isValid = false;
            }

            if (this.mtxtPhoneNumber.Text.Length > 12)
            {
                errorMessages.AppendLine("Phone Number cannot exceed 12 characters.");
                isValid = false;
            }

            if (this.txtAddress.Text.Length > 40)
            {
                errorMessages.AppendLine("Address cannot exceed 40 characters.");
                isValid = false;
            }

            if (this.txtCity.Text.Length > 20)
            {
                errorMessages.AppendLine("City cannot exceed 20 characters.");
                isValid = false;
            }

            if (this.txtZipCode.Text.Length > 5)
            {
                errorMessages.AppendLine("Zip Code cannot exceed 5 characters.");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessages.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void ClearFields()
        {
            this.txtFirstName.Text = string.Empty;
            this.txtLastName.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtCity.Text = string.Empty;
            this.txtZipCode.Text = string.Empty;
            this.txtID.Text = string.Empty;
            this.mtxtPhoneNumber.Clear();
            this.cboState.SelectedIndex = -1;
            this.chkContract.Checked = false;
            this.txtID.Focus();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Author author = new Author();
                author.AuthorId = txtID.Text;
                author.Fname = txtFirstName.Text;
                author.Lname = txtLastName.Text;
                author.PhoneNumber = mtxtPhoneNumber.Text;
                author.Address = txtAddress.Text;
                author.City = txtCity.Text;
                author.State = cboState.Text;
                if (int.TryParse(txtZipCode.Text, out int zipValue))
                {
                    author.ZipCode = zipValue;
                }
                else
                {
                    author.ZipCode = null;
                }
                author.IsContract = chkContract.Checked;

                AuthorRepository repo = new AuthorRepository();
                if (repo.addAuthor(author))
                {
                    MessageBox.Show("Author succesfully added to the database", "Success");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Error");
                }
            }
        }

    }
}
