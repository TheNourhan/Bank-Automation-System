namespace bank_automation_system
{
    partial class Form_Open_Account
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
            label4 = new Label();
            txt_Customer_Id = new TextBox();
            txt_Account_Type = new TextBox();
            txt_Balance = new TextBox();
            btn_Open_Account = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            linkLabel1 = new LinkLabel();
            txt_Cust_Firstname = new TextBox();
            txt_Cust_Lastname = new TextBox();
            txt_Cust_Email = new TextBox();
            txt_Cust_Phone = new TextBox();
            txt_Cust_Password = new TextBox();
            groupBox1 = new GroupBox();
            btn_New_Customer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 394);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 445);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Account Type ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 499);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 3;
            label4.Text = "Balance ";
            // 
            // txt_Customer_Id
            // 
            txt_Customer_Id.Location = new Point(487, 388);
            txt_Customer_Id.Name = "txt_Customer_Id";
            txt_Customer_Id.Size = new Size(200, 31);
            txt_Customer_Id.TabIndex = 4;
            // 
            // txt_Account_Type
            // 
            txt_Account_Type.Location = new Point(487, 442);
            txt_Account_Type.Name = "txt_Account_Type";
            txt_Account_Type.Size = new Size(200, 31);
            txt_Account_Type.TabIndex = 5;
            // 
            // txt_Balance
            // 
            txt_Balance.Location = new Point(487, 496);
            txt_Balance.Name = "txt_Balance";
            txt_Balance.Size = new Size(200, 31);
            txt_Balance.TabIndex = 7;
            txt_Balance.TextChanged += txt_Balance_TextChanged;
            // 
            // btn_Open_Account
            // 
            btn_Open_Account.Location = new Point(305, 560);
            btn_Open_Account.Name = "btn_Open_Account";
            btn_Open_Account.Size = new Size(178, 49);
            btn_Open_Account.TabIndex = 8;
            btn_Open_Account.Text = "Open Account";
            btn_Open_Account.UseVisualStyleBackColor = true;
            btn_Open_Account.Click += btn_Open_Account_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 53);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 10;
            label5.Text = "FirstName ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 97);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 11;
            label6.Text = "LastName ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 144);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 12;
            label7.Text = "Email ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 236);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 13;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 191);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 14;
            label9.Text = "Phone ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(451, 131);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 15;
            // 
            // txt_Cust_Firstname
            // 
            txt_Cust_Firstname.Location = new Point(232, 53);
            txt_Cust_Firstname.Name = "txt_Cust_Firstname";
            txt_Cust_Firstname.Size = new Size(200, 31);
            txt_Cust_Firstname.TabIndex = 16;
            txt_Cust_Firstname.TextChanged += textBox1_TextChanged;
            // 
            // txt_Cust_Lastname
            // 
            txt_Cust_Lastname.Location = new Point(232, 94);
            txt_Cust_Lastname.Name = "txt_Cust_Lastname";
            txt_Cust_Lastname.Size = new Size(200, 31);
            txt_Cust_Lastname.TabIndex = 17;
            // 
            // txt_Cust_Email
            // 
            txt_Cust_Email.Location = new Point(232, 144);
            txt_Cust_Email.Name = "txt_Cust_Email";
            txt_Cust_Email.Size = new Size(200, 31);
            txt_Cust_Email.TabIndex = 18;
            // 
            // txt_Cust_Phone
            // 
            txt_Cust_Phone.Location = new Point(232, 191);
            txt_Cust_Phone.Name = "txt_Cust_Phone";
            txt_Cust_Phone.Size = new Size(200, 31);
            txt_Cust_Phone.TabIndex = 19;
            // 
            // txt_Cust_Password
            // 
            txt_Cust_Password.Location = new Point(232, 236);
            txt_Cust_Password.Name = "txt_Cust_Password";
            txt_Cust_Password.Size = new Size(200, 31);
            txt_Cust_Password.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btn_New_Customer);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_Cust_Password);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_Cust_Phone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_Cust_Email);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_Cust_Lastname);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_Cust_Firstname);
            groupBox1.Location = new Point(73, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 306);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Customer?";
            // 
            // btn_New_Customer
            // 
            btn_New_Customer.Location = new Point(469, 135);
            btn_New_Customer.Name = "btn_New_Customer";
            btn_New_Customer.Size = new Size(178, 49);
            btn_New_Customer.TabIndex = 21;
            btn_New_Customer.Text = "New Customer";
            btn_New_Customer.UseVisualStyleBackColor = true;
            btn_New_Customer.Click += button1_Click;
            // 
            // Form_Open_Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 683);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Open_Account);
            Controls.Add(txt_Balance);
            Controls.Add(txt_Account_Type);
            Controls.Add(txt_Customer_Id);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Open_Account";
            Text = "Form_Open_Account";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txt_Customer_Id;
        private TextBox txt_Account_Type;
        private TextBox txt_Balance;
        private Button btn_Open_Account;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private LinkLabel linkLabel1;
        private TextBox txt_Cust_Firstname;
        private TextBox txt_Cust_Lastname;
        private TextBox txt_Cust_Email;
        private TextBox txt_Cust_Phone;
        private TextBox txt_Cust_Password;
        private GroupBox groupBox1;
        private Button btn_New_Customer;
    }
}