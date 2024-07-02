namespace bank_automation_system
{
    partial class Form_Main_Employee
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
            btn_Transfers = new Button();
            btn_Statement = new Button();
            btn_Open_Account = new Button();
            btn_Close_Account = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Transfers
            // 
            btn_Transfers.Location = new Point(175, 115);
            btn_Transfers.Name = "btn_Transfers";
            btn_Transfers.Size = new Size(178, 49);
            btn_Transfers.TabIndex = 0;
            btn_Transfers.Text = "Transfers";
            btn_Transfers.UseVisualStyleBackColor = true;
            btn_Transfers.Click += btn_Transfers_Click;
            // 
            // btn_Statement
            // 
            btn_Statement.Location = new Point(468, 115);
            btn_Statement.Name = "btn_Statement";
            btn_Statement.Size = new Size(178, 49);
            btn_Statement.TabIndex = 1;
            btn_Statement.Text = "Account Statement";
            btn_Statement.UseVisualStyleBackColor = true;
            btn_Statement.Click += btn_Statement_Click;
            // 
            // btn_Open_Account
            // 
            btn_Open_Account.Location = new Point(175, 241);
            btn_Open_Account.Name = "btn_Open_Account";
            btn_Open_Account.Size = new Size(178, 49);
            btn_Open_Account.TabIndex = 2;
            btn_Open_Account.Text = "Open Account";
            btn_Open_Account.UseVisualStyleBackColor = true;
            btn_Open_Account.Click += btn_Open_Account_Click;
            // 
            // btn_Close_Account
            // 
            btn_Close_Account.Location = new Point(468, 241);
            btn_Close_Account.Name = "btn_Close_Account";
            btn_Close_Account.Size = new Size(178, 49);
            btn_Close_Account.TabIndex = 3;
            btn_Close_Account.Text = "Close Account";
            btn_Close_Account.UseVisualStyleBackColor = true;
            btn_Close_Account.Click += btn_Close_Account_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 4;
            label1.Text = "Hello Emp!";
            // 
            // Form_Main_Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_Close_Account);
            Controls.Add(btn_Open_Account);
            Controls.Add(btn_Statement);
            Controls.Add(btn_Transfers);
            Name = "Form_Main_Employee";
            Text = "Form_Main_Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Transfers;
        private Button btn_Statement;
        private Button btn_Open_Account;
        private Button btn_Close_Account;
        private Label label1;
    }
}