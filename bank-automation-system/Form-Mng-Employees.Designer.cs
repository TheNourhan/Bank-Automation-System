namespace bank_automation_system
{
    partial class Form_Mng_Employees
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_Firstname = new TextBox();
            txt_Lastname = new TextBox();
            txt_Username = new TextBox();
            txt_Email = new TextBox();
            txt_Role = new TextBox();
            txt_Password = new TextBox();
            txt_BranchId = new TextBox();
            txt_MngId = new TextBox();
            groupBox1 = new GroupBox();
            chk_Statement = new CheckBox();
            chk_Transfers = new CheckBox();
            chk_Close_Acc = new CheckBox();
            chk_New_Acc = new CheckBox();
            chk_Login = new CheckBox();
            btn_Add_Emp = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Emploee!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 50);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 103);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 149);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 196);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 383);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 5;
            label6.Text = "Manager Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 336);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 6;
            label7.Text = "Branch Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 241);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 7;
            label8.Text = "Role";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 287);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 8;
            label9.Text = "Password";
            // 
            // txt_Firstname
            // 
            txt_Firstname.Location = new Point(297, 47);
            txt_Firstname.Name = "txt_Firstname";
            txt_Firstname.Size = new Size(150, 31);
            txt_Firstname.TabIndex = 9;
            // 
            // txt_Lastname
            // 
            txt_Lastname.Location = new Point(297, 100);
            txt_Lastname.Name = "txt_Lastname";
            txt_Lastname.Size = new Size(150, 31);
            txt_Lastname.TabIndex = 10;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(297, 146);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(150, 31);
            txt_Username.TabIndex = 11;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(297, 193);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(150, 31);
            txt_Email.TabIndex = 12;
            // 
            // txt_Role
            // 
            txt_Role.Location = new Point(297, 238);
            txt_Role.Name = "txt_Role";
            txt_Role.Size = new Size(150, 31);
            txt_Role.TabIndex = 13;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(297, 284);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(150, 31);
            txt_Password.TabIndex = 14;
            // 
            // txt_BranchId
            // 
            txt_BranchId.Location = new Point(297, 333);
            txt_BranchId.Name = "txt_BranchId";
            txt_BranchId.Size = new Size(150, 31);
            txt_BranchId.TabIndex = 15;
            // 
            // txt_MngId
            // 
            txt_MngId.Location = new Point(297, 380);
            txt_MngId.Name = "txt_MngId";
            txt_MngId.Size = new Size(150, 31);
            txt_MngId.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chk_Statement);
            groupBox1.Controls.Add(chk_Transfers);
            groupBox1.Controls.Add(chk_Close_Acc);
            groupBox1.Controls.Add(chk_New_Acc);
            groupBox1.Controls.Add(chk_Login);
            groupBox1.Location = new Point(496, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 378);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permissions ";
            // 
            // chk_Statement
            // 
            chk_Statement.AutoSize = true;
            chk_Statement.Location = new Point(25, 250);
            chk_Statement.Name = "chk_Statement";
            chk_Statement.Size = new Size(223, 29);
            chk_Statement.TabIndex = 4;
            chk_Statement.Text = "Make a Bank Statement";
            chk_Statement.UseVisualStyleBackColor = true;
            // 
            // chk_Transfers
            // 
            chk_Transfers.AutoSize = true;
            chk_Transfers.Location = new Point(25, 204);
            chk_Transfers.Name = "chk_Transfers";
            chk_Transfers.Size = new Size(107, 29);
            chk_Transfers.TabIndex = 3;
            chk_Transfers.Text = "Transfers";
            chk_Transfers.UseVisualStyleBackColor = true;
            // 
            // chk_Close_Acc
            // 
            chk_Close_Acc.AutoSize = true;
            chk_Close_Acc.Location = new Point(25, 159);
            chk_Close_Acc.Name = "chk_Close_Acc";
            chk_Close_Acc.Size = new Size(175, 29);
            chk_Close_Acc.TabIndex = 2;
            chk_Close_Acc.Text = "Close an Account";
            chk_Close_Acc.UseVisualStyleBackColor = true;
            // 
            // chk_New_Acc
            // 
            chk_New_Acc.AutoSize = true;
            chk_New_Acc.Location = new Point(25, 112);
            chk_New_Acc.Name = "chk_New_Acc";
            chk_New_Acc.Size = new Size(206, 29);
            chk_New_Acc.TabIndex = 1;
            chk_New_Acc.Text = "Open a New Account";
            chk_New_Acc.UseVisualStyleBackColor = true;
            // 
            // chk_Login
            // 
            chk_Login.AutoSize = true;
            chk_Login.Location = new Point(25, 69);
            chk_Login.Name = "chk_Login";
            chk_Login.Size = new Size(82, 29);
            chk_Login.TabIndex = 0;
            chk_Login.Text = "Login";
            chk_Login.UseVisualStyleBackColor = true;
            chk_Login.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_Add_Emp
            // 
            btn_Add_Emp.Location = new Point(366, 474);
            btn_Add_Emp.Name = "btn_Add_Emp";
            btn_Add_Emp.Size = new Size(112, 34);
            btn_Add_Emp.TabIndex = 18;
            btn_Add_Emp.Text = "Add Emp";
            btn_Add_Emp.UseVisualStyleBackColor = true;
            btn_Add_Emp.Click += button1_Click;
            // 
            // Form_Mng_Employees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 580);
            Controls.Add(btn_Add_Emp);
            Controls.Add(txt_MngId);
            Controls.Add(txt_BranchId);
            Controls.Add(txt_Password);
            Controls.Add(txt_Role);
            Controls.Add(txt_Email);
            Controls.Add(txt_Username);
            Controls.Add(txt_Lastname);
            Controls.Add(txt_Firstname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form_Mng_Employees";
            Text = "Form_Mng_Employees";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_Firstname;
        private TextBox txt_Lastname;
        private TextBox txt_Username;
        private TextBox txt_Email;
        private TextBox txt_Role;
        private TextBox txt_Password;
        private TextBox txt_BranchId;
        private TextBox txt_MngId;
        private GroupBox groupBox1;
        private CheckBox chk_Statement;
        private CheckBox chk_Transfers;
        private CheckBox chk_Close_Acc;
        private CheckBox chk_New_Acc;
        private CheckBox chk_Login;
        private Button btn_Add_Emp;
    }
}