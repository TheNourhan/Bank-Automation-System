namespace bank_automation_system
{
    partial class Form_Restore
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
            btn_Restore = new Button();
            txt_Folder_Path = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 97);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Folder";
            // 
            // btn_Browse
            // 
            btn_Browse.Location = new Point(567, 148);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(112, 34);
            btn_Browse.TabIndex = 1;
            btn_Browse.Text = "Browse";
            btn_Browse.UseVisualStyleBackColor = true;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Location = new Point(326, 263);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(112, 34);
            btn_Restore.TabIndex = 2;
            btn_Restore.Text = "Restore";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // txt_Folder_Path
            // 
            txt_Folder_Path.Location = new Point(111, 150);
            txt_Folder_Path.Name = "txt_Folder_Path";
            txt_Folder_Path.Size = new Size(450, 31);
            txt_Folder_Path.TabIndex = 3;
            // 
            // Form_Restore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Folder_Path);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Browse);
            Controls.Add(label1);
            Name = "Form_Restore";
            Text = "Form_Restore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Browse;
        private Button btn_Restore;
        private TextBox txt_Folder_Path;
    }
}