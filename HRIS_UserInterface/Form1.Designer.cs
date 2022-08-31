
namespace HRIS_UserInterface
{
    partial class Form1
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
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.labelEmployeeList = new System.Windows.Forms.Label();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.salaryScrollBar = new System.Windows.Forms.HScrollBar();
            this.currentScrolledSalary = new System.Windows.Forms.Label();
            this.jobListBox = new System.Windows.Forms.ListBox();
            this.setJobSalary = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.currentSalary = new System.Windows.Forms.Label();
            this.selectedName = new System.Windows.Forms.Label();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelMaxSalary = new System.Windows.Forms.Label();
            this.placeholderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fNameInput
            // 
            this.fNameInput.Location = new System.Drawing.Point(148, 46);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(199, 22);
            this.fNameInput.TabIndex = 0;
            // 
            // lNameInput
            // 
            this.lNameInput.Location = new System.Drawing.Point(148, 87);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(199, 22);
            this.lNameInput.TabIndex = 1;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(148, 128);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(199, 22);
            this.emailInput.TabIndex = 2;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(148, 175);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(199, 22);
            this.phoneInput.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(39, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(39, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(39, 175);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(103, 17);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone Number";
            // 
            // addEmployee
            // 
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.04651F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.Location = new System.Drawing.Point(148, 248);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(169, 43);
            this.addEmployee.TabIndex = 8;
            this.addEmployee.Text = "Add employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEmployeeList
            // 
            this.labelEmployeeList.AutoSize = true;
            this.labelEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.04651F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeList.Location = new System.Drawing.Point(403, 45);
            this.labelEmployeeList.Name = "labelEmployeeList";
            this.labelEmployeeList.Size = new System.Drawing.Size(103, 22);
            this.labelEmployeeList.TabIndex = 9;
            this.labelEmployeeList.Text = "Employees:";
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(512, 46);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(203, 148);
            this.employeeListBox.TabIndex = 10;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged_1);
            // 
            // salaryScrollBar
            // 
            this.salaryScrollBar.Enabled = false;
            this.salaryScrollBar.LargeChange = 1;
            this.salaryScrollBar.Location = new System.Drawing.Point(920, 208);
            this.salaryScrollBar.Maximum = 26;
            this.salaryScrollBar.Minimum = 19;
            this.salaryScrollBar.Name = "salaryScrollBar";
            this.salaryScrollBar.Size = new System.Drawing.Size(152, 20);
            this.salaryScrollBar.TabIndex = 11;
            this.salaryScrollBar.Value = 26;
            this.salaryScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // currentScrolledSalary
            // 
            this.currentScrolledSalary.AutoSize = true;
            this.currentScrolledSalary.Location = new System.Drawing.Point(979, 238);
            this.currentScrolledSalary.Name = "currentScrolledSalary";
            this.currentScrolledSalary.Size = new System.Drawing.Size(16, 17);
            this.currentScrolledSalary.TabIndex = 12;
            this.currentScrolledSalary.Text = "0";
            // 
            // jobListBox
            // 
            this.jobListBox.Enabled = false;
            this.jobListBox.FormattingEnabled = true;
            this.jobListBox.ItemHeight = 16;
            this.jobListBox.Location = new System.Drawing.Point(923, 46);
            this.jobListBox.Name = "jobListBox";
            this.jobListBox.Size = new System.Drawing.Size(153, 132);
            this.jobListBox.TabIndex = 13;
            this.jobListBox.SelectedIndexChanged += new System.EventHandler(this.jobListBox_SelectedIndexChanged);
            // 
            // setJobSalary
            // 
            this.setJobSalary.Location = new System.Drawing.Point(901, 281);
            this.setJobSalary.Name = "setJobSalary";
            this.setJobSalary.Size = new System.Drawing.Size(172, 43);
            this.setJobSalary.TabIndex = 14;
            this.setJobSalary.Text = "Set Position and Salary";
            this.setJobSalary.UseVisualStyleBackColor = true;
            this.setJobSalary.Click += new System.EventHandler(this.setJobSalary_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Position:";
            // 
            // currentSalary
            // 
            this.currentSalary.AutoSize = true;
            this.currentSalary.Location = new System.Drawing.Point(736, 117);
            this.currentSalary.Name = "currentSalary";
            this.currentSalary.Size = new System.Drawing.Size(52, 17);
            this.currentSalary.TabIndex = 16;
            this.currentSalary.Text = "Salary:";
            // 
            // selectedName
            // 
            this.selectedName.AutoSize = true;
            this.selectedName.Location = new System.Drawing.Point(736, 45);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(45, 17);
            this.selectedName.TabIndex = 17;
            this.selectedName.Text = "Name";
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.AutoSize = true;
            this.labelMinSalary.Location = new System.Drawing.Point(843, 208);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(0, 17);
            this.labelMinSalary.TabIndex = 18;
            // 
            // labelMaxSalary
            // 
            this.labelMaxSalary.AutoSize = true;
            this.labelMaxSalary.Location = new System.Drawing.Point(1076, 208);
            this.labelMaxSalary.Name = "labelMaxSalary";
            this.labelMaxSalary.Size = new System.Drawing.Size(0, 17);
            this.labelMaxSalary.TabIndex = 19;
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.AutoSize = true;
            this.placeholderLabel.Location = new System.Drawing.Point(1075, 415);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(0, 17);
            this.placeholderLabel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select salary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeholderLabel);
            this.Controls.Add(this.labelMaxSalary);
            this.Controls.Add(this.labelMinSalary);
            this.Controls.Add(this.selectedName);
            this.Controls.Add(this.currentSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.setJobSalary);
            this.Controls.Add(this.jobListBox);
            this.Controls.Add(this.currentScrolledSalary);
            this.Controls.Add(this.salaryScrollBar);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.labelEmployeeList);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.fNameInput);
            this.Name = "Form1";
            this.Text = "HRIS v0.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label labelEmployeeList;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.HScrollBar salaryScrollBar;
        private System.Windows.Forms.Label currentScrolledSalary;
        private System.Windows.Forms.ListBox jobListBox;
        private System.Windows.Forms.Button setJobSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentSalary;
        private System.Windows.Forms.Label selectedName;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelMaxSalary;
        private System.Windows.Forms.Label placeholderLabel;
        private System.Windows.Forms.Label label1;
    }
}

