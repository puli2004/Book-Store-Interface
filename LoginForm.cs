using System;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form properties
            this.Text = "Login Screen";
            this.Size = new System.Drawing.Size(400, 300);

            // Title Label
            Label lblTitle = new Label();
            lblTitle.Text = "Login Screen";
            lblTitle.Font = new System.Drawing.Font("Arial", 16);
            lblTitle.Location = new System.Drawing.Point(150, 20);
            this.Controls.Add(lblTitle);

            // Username Label
            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new System.Drawing.Point(50, 70);
            lblUsername.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(lblUsername);

            // Username TextBox
            this.txtUsername = new TextBox();
            this.txtUsername.Location = new System.Drawing.Point(150, 70);
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtUsername);

            // Password Label
            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(50, 110);
            lblPassword.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(lblPassword);

            // Password TextBox
            this.txtPassword = new TextBox();
            this.txtPassword.PasswordChar = '*';  // Masked password
            this.txtPassword.Location = new System.Drawing.Point(150, 110);
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtPassword);

            // Login Button
            this.btnLogin = new Button();
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(150, 150);
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.BackColor = System.Drawing.Color.Blue;  // Blue background
            this.btnLogin.ForeColor = System.Drawing.Color.White;  // White text
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            this.Controls.Add(this.btnLogin);

            // Cancel Button
            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(250, 150);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.BackColor = System.Drawing.Color.Blue;  // Blue background
            this.btnCancel.ForeColor = System.Drawing.Color.White;  // White text
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.Controls.Add(this.btnCancel);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate credentials (this can be extended to use a database)
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login Successful!");
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}
