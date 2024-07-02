namespace bank_automation_system
{
    partial class Form_Backup
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
            btn_Browse = new Button();
            btn_Backup = new Button();
            txt_Folder_Path = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 73);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Folder";
            // 
            // btn_Browse
            // 
            btn_Browse.Location = new Point(564, 132);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(112, 34);
            btn_Browse.TabIndex = 1;
            btn_Browse.Text = "Browse";
            btn_Browse.UseVisualStyleBackColor = true;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // btn_Backup
            // 
            btn_Backup.Enabled = false;
            btn_Backup.Location = new Point(320, 226);
            btn_Backup.Name = "btn_Backup";
            btn_Backup.Size = new Size(112, 34);
            btn_Backup.TabIndex = 2;
            btn_Backup.Text = "Backup";
            btn_Backup.UseVisualStyleBackColor = true;
            btn_Backup.Click += btn_Backup_Click;
            // 
            // txt_Folder_Path
            // 
            txt_Folder_Path.Location = new Point(106, 132);
            txt_Folder_Path.Name = "txt_Folder_Path";
            txt_Folder_Path.Size = new Size(450, 31);
            txt_Folder_Path.TabIndex = 3;
            // 
            // Form_Backup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Folder_Path);
            Controls.Add(btn_Backup);
            Controls.Add(btn_Browse);
            Controls.Add(label1);
            Name = "Form_Backup";
            Text = "Form_Backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Browse;
        private Button btn_Backup;
        private TextBox txt_Folder_Path;
    }
}