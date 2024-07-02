namespace bank_automation_system
{
    partial class Form_Login
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
            btn_login = new Button();
            label1 = new Label();
            label2 = new Label();
            text_email = new TextBox();
            text_password = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(313, 284);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 87);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 171);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // text_email
            // 
            text_email.Location = new Point(378, 87);
            text_email.Name = "text_email";
            text_email.Size = new Size(200, 31);
            text_email.TabIndex = 3;
            // 
            // text_password
            // 
            text_password.Location = new Point(378, 171);
            text_password.Name = "text_password";
            text_password.PasswordChar = '*';
            text_password.Size = new Size(200, 31);
            text_password.TabIndex = 4;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(text_password);
            Controls.Add(text_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            MaximizeBox = false;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label label1;
        private Label label2;
        private TextBox text_email;
        private TextBox text_password;
    }
}