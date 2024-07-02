namespace bank_automation_system
{
    partial class Form_Permissions
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
            groupBox1 = new GroupBox();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            btn_Add_DB_User = new Button();
            chk_db_writer = new CheckBox();
            chk_db_reader = new CheckBox();
            chk_db_owner = new CheckBox();
            chk_db_accessadmin = new CheckBox();
            chk_db_ddladmin = new CheckBox();
            chk_db_securityadmin = new CheckBox();
            chk_db_backupoperator = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 155);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chk_db_backupoperator);
            groupBox1.Controls.Add(chk_db_securityadmin);
            groupBox1.Controls.Add(chk_db_ddladmin);
            groupBox1.Controls.Add(chk_db_accessadmin);
            groupBox1.Controls.Add(chk_db_owner);
            groupBox1.Controls.Add(chk_db_reader);
            groupBox1.Controls.Add(chk_db_writer);
            groupBox1.Location = new Point(433, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 326);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(127, 95);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(150, 31);
            txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(127, 212);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(150, 31);
            txt_Password.TabIndex = 4;
            // 
            // btn_Add_DB_User
            // 
            btn_Add_DB_User.Location = new Point(127, 316);
            btn_Add_DB_User.Name = "btn_Add_DB_User";
            btn_Add_DB_User.Size = new Size(150, 51);
            btn_Add_DB_User.TabIndex = 5;
            btn_Add_DB_User.Text = "Add DB User";
            btn_Add_DB_User.UseVisualStyleBackColor = true;
            btn_Add_DB_User.Click += btn_Add_DB_User_Click;
            // 
            // chk_db_writer
            // 
            chk_db_writer.AutoSize = true;
            chk_db_writer.Location = new Point(33, 56);
            chk_db_writer.Name = "chk_db_writer";
            chk_db_writer.Size = new Size(111, 29);
            chk_db_writer.TabIndex = 0;
            chk_db_writer.Text = "db_writer";
            chk_db_writer.UseVisualStyleBackColor = true;
            // 
            // chk_db_reader
            // 
            chk_db_reader.AutoSize = true;
            chk_db_reader.Location = new Point(33, 91);
            chk_db_reader.Name = "chk_db_reader";
            chk_db_reader.Size = new Size(117, 29);
            chk_db_reader.TabIndex = 1;
            chk_db_reader.Text = "db_reader";
            chk_db_reader.UseVisualStyleBackColor = true;
            // 
            // chk_db_owner
            // 
            chk_db_owner.AutoSize = true;
            chk_db_owner.Location = new Point(33, 126);
            chk_db_owner.Name = "chk_db_owner";
            chk_db_owner.Size = new Size(116, 29);
            chk_db_owner.TabIndex = 2;
            chk_db_owner.Text = "db_owner";
            chk_db_owner.UseVisualStyleBackColor = true;
            // 
            // chk_db_accessadmin
            // 
            chk_db_accessadmin.AutoSize = true;
            chk_db_accessadmin.Location = new Point(33, 161);
            chk_db_accessadmin.Name = "chk_db_accessadmin";
            chk_db_accessadmin.Size = new Size(167, 29);
            chk_db_accessadmin.TabIndex = 3;
            chk_db_accessadmin.Text = "db_accessadmin";
            chk_db_accessadmin.UseVisualStyleBackColor = true;
            // 
            // chk_db_ddladmin
            // 
            chk_db_ddladmin.AutoSize = true;
            chk_db_ddladmin.Location = new Point(33, 196);
            chk_db_ddladmin.Name = "chk_db_ddladmin";
            chk_db_ddladmin.Size = new Size(143, 29);
            chk_db_ddladmin.TabIndex = 4;
            chk_db_ddladmin.Text = "db_ddladmin";
            chk_db_ddladmin.UseVisualStyleBackColor = true;
            // 
            // chk_db_securityadmin
            // 
            chk_db_securityadmin.AutoSize = true;
            chk_db_securityadmin.Location = new Point(33, 231);
            chk_db_securityadmin.Name = "chk_db_securityadmin";
            chk_db_securityadmin.Size = new Size(177, 29);
            chk_db_securityadmin.TabIndex = 5;
            chk_db_securityadmin.Text = "db_securityadmin";
            chk_db_securityadmin.UseVisualStyleBackColor = true;
            // 
            // chk_db_backupoperator
            // 
            chk_db_backupoperator.AutoSize = true;
            chk_db_backupoperator.Location = new Point(33, 266);
            chk_db_backupoperator.Name = "chk_db_backupoperator";
            chk_db_backupoperator.Size = new Size(194, 29);
            chk_db_backupoperator.TabIndex = 6;
            chk_db_backupoperator.Text = "db_backupoperator";
            chk_db_backupoperator.UseVisualStyleBackColor = true;
            // 
            // Form_Permissions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Add_DB_User);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Permissions";
            Text = "Form_Permissions";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private CheckBox chk_db_backupoperator;
        private CheckBox chk_db_securityadmin;
        private CheckBox chk_db_ddladmin;
        private CheckBox chk_db_accessadmin;
        private CheckBox chk_db_owner;
        private CheckBox chk_db_reader;
        private CheckBox chk_db_writer;
        private Button btn_Add_DB_User;
    }
}