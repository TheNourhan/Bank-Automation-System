namespace bank_automation_system
{
    partial class Form_Main_Manager
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
            btn_backup = new Button();
            btn_restore = new Button();
            btn_permissions = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Hello Manager!";
            // 
            // btn_backup
            // 
            btn_backup.Location = new Point(175, 115);
            btn_backup.Name = "btn_backup";
            btn_backup.Size = new Size(178, 49);
            btn_backup.TabIndex = 1;
            btn_backup.Text = "Backup Data";
            btn_backup.UseVisualStyleBackColor = true;
            btn_backup.Click += btn_backup_Click;
            // 
            // btn_restore
            // 
            btn_restore.Location = new Point(468, 115);
            btn_restore.Name = "btn_restore";
            btn_restore.Size = new Size(178, 49);
            btn_restore.TabIndex = 2;
            btn_restore.Text = "Restore Data";
            btn_restore.UseVisualStyleBackColor = true;
            btn_restore.Click += btn_restore_Click;
            // 
            // btn_permissions
            // 
            btn_permissions.Location = new Point(175, 241);
            btn_permissions.Name = "btn_permissions";
            btn_permissions.Size = new Size(178, 49);
            btn_permissions.TabIndex = 3;
            btn_permissions.Text = "Permissions ";
            btn_permissions.UseVisualStyleBackColor = true;
            btn_permissions.Click += btn_permissions_Click;
            // 
            // button1
            // 
            button1.Location = new Point(468, 241);
            button1.Name = "button1";
            button1.Size = new Size(178, 49);
            button1.TabIndex = 4;
            button1.Text = "Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Main_Manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_permissions);
            Controls.Add(btn_restore);
            Controls.Add(btn_backup);
            Controls.Add(label1);
            Name = "Form_Main_Manager";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_backup;
        private Button btn_restore;
        private Button btn_permissions;
        private Button button1;
    }
}