namespace bank_automation_system
{
    partial class Form_Close_Account
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
            txt_Acount_Id = new TextBox();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 102);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Id";
            // 
            // txt_Acount_Id
            // 
            txt_Acount_Id.Location = new Point(450, 102);
            txt_Acount_Id.Name = "txt_Acount_Id";
            txt_Acount_Id.Size = new Size(200, 31);
            txt_Acount_Id.TabIndex = 1;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(299, 234);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(178, 49);
            btn_Close.TabIndex = 2;
            btn_Close.Text = "Close Account";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Form_Close_Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Close);
            Controls.Add(txt_Acount_Id);
            Controls.Add(label1);
            Name = "Form_Close_Account";
            Text = "Form_Close_Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Acount_Id;
        private Button btn_Close;
    }
}