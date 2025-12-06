using System;
using System.Drawing;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.lblTitle = new Label();
            this.lblEmployeeFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblEmployeeMiddleInitial = new Label();
            this.txtMiddleInitial = new TextBox();
            this.lblEmployeeLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblYear = new Label();
            this.btnAddEmployee = new Button();
            this.btnBackToMenu = new Button();
            this.dtpHireDate = new DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Corbel", 24F, FontStyle.Regular);
            this.lblTitle.Location = new Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(352, 44);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Add Employee";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.Font = new Font("Corbel", 9.75F);
            this.lblEmployeeFirstName.Location = new Point(19, 77);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new Size(74, 23);
            this.lblEmployeeFirstName.TabIndex = 14;
            this.lblEmployeeFirstName.Text = "First Name:";
            this.lblEmployeeFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new Font("Corbel", 8.25F);
            this.txtFirstName.Location = new Point(99, 77);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new Size(246, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblEmployeeMiddleInitial
            // 
            this.lblEmployeeMiddleInitial.Font = new Font("Corbel", 9.75F);
            this.lblEmployeeMiddleInitial.Location = new Point(12, 117);
            this.lblEmployeeMiddleInitial.Name = "lblEmployeeMiddleInitial";
            this.lblEmployeeMiddleInitial.Size = new Size(81, 23);
            this.lblEmployeeMiddleInitial.TabIndex = 16;
            this.lblEmployeeMiddleInitial.Text = "Middle Initial:";
            this.lblEmployeeMiddleInitial.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new Font("Corbel", 8.25F);
            this.txtMiddleInitial.Location = new Point(99, 117);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new Size(246, 21);
            this.txtMiddleInitial.TabIndex = 1;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.Font = new Font("Corbel", 9.75F);
            this.lblEmployeeLastName.Location = new Point(19, 157);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new Size(74, 23);
            this.lblEmployeeLastName.TabIndex = 18;
            this.lblEmployeeLastName.Text = "Last Name:";
            this.lblEmployeeLastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new Font("Corbel", 8.25F);
            this.txtLastName.Location = new Point(99, 157);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(246, 21);
            this.txtLastName.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.Font = new Font("Corbel", 9.75F);
            this.lblYear.Location = new Point(22, 197);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new Size(71, 23);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Hire Date:";
            this.lblYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new Font("Corbel", 12F);
            this.btnAddEmployee.Location = new Point(69, 240);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new Size(120, 40);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new EventHandler(this.btnAddEmployee_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.DialogResult = DialogResult.Cancel;
            this.btnBackToMenu.Font = new Font("Corbel", 12F);
            this.btnBackToMenu.Location = new Point(204, 240);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new Size(120, 40);
            this.btnBackToMenu.TabIndex = 5;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new EventHandler(this.btnBackToMenu_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new Point(100, 199);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new Size(245, 20);
            this.dtpHireDate.TabIndex = 3;
            // 
            // AddEmployeeForm
            // 
            this.AcceptButton = this.btnAddEmployee;
            this.CancelButton = this.btnBackToMenu;
            this.ClientSize = new Size(376, 306);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEmployeeMiddleInitial);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnBackToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblEmployeeFirstName;
        private TextBox txtFirstName;
        private Label lblEmployeeMiddleInitial;
        private TextBox txtMiddleInitial;
        private Label lblEmployeeLastName;
        private TextBox txtLastName;
        private Label lblYear;
        private Button btnAddEmployee;
        private Button btnBackToMenu;
        private DateTimePicker dtpHireDate;
    }
}
