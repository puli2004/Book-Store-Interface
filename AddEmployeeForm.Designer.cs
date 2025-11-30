namespace Book_Store_Interface
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeMiddleInitial = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 44);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Add Employee";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(19, 77);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(74, 23);
            this.lblEmployeeFirstName.TabIndex = 14;
            this.lblEmployeeFirstName.Text = "First Name:";
            this.lblEmployeeFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(99, 77);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(246, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblEmployeeMiddleInitial
            // 
            this.lblEmployeeMiddleInitial.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeMiddleInitial.Location = new System.Drawing.Point(12, 117);
            this.lblEmployeeMiddleInitial.Name = "lblEmployeeMiddleInitial";
            this.lblEmployeeMiddleInitial.Size = new System.Drawing.Size(81, 23);
            this.lblEmployeeMiddleInitial.TabIndex = 16;
            this.lblEmployeeMiddleInitial.Text = "Middle Initial:";
            this.lblEmployeeMiddleInitial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(99, 117);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(246, 21);
            this.txtMiddleInitial.TabIndex = 1;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLastName.Location = new System.Drawing.Point(19, 157);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(74, 23);
            this.lblEmployeeLastName.TabIndex = 18;
            this.lblEmployeeLastName.Text = "Last Name:";
            this.lblEmployeeLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(99, 157);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(246, 21);
            this.txtLastName.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(22, 197);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(71, 23);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Hire Date:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Blue;
            this.btnAddEmployee.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(69, 240);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 40);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Blue;
            this.btnBackToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMenu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(204, 240);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(120, 40);
            this.btnBackToMenu.TabIndex = 5;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(100, 199);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(245, 20);
            this.dtpHireDate.TabIndex = 3;
            // 
            // AddEmployeeForm
            // 
            this.AcceptButton = this.btnAddEmployee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBackToMenu;
            this.ClientSize = new System.Drawing.Size(376, 306);
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

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmployeeMiddleInitial;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
    }
}