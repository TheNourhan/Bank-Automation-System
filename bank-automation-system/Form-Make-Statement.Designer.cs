namespace bank_automation_system
{
    partial class Form_Make_Statement
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
            btn_Print_Statement = new Button();
            txt_Account_Id = new TextBox();
            date_From = new DateTimePicker();
            date_To = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 138);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "From Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 215);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "To Date";
            // 
            // btn_Print_Statement
            // 
            btn_Print_Statement.Location = new Point(321, 306);
            btn_Print_Statement.Name = "btn_Print_Statement";
            btn_Print_Statement.Size = new Size(112, 34);
            btn_Print_Statement.TabIndex = 3;
            btn_Print_Statement.Text = "Print";
            btn_Print_Statement.UseVisualStyleBackColor = true;
            btn_Print_Statement.Click += btn_Print_Statement_Click;
            // 
            // txt_Account_Id
            // 
            txt_Account_Id.Location = new Point(427, 60);
            txt_Account_Id.Name = "txt_Account_Id";
            txt_Account_Id.Size = new Size(200, 31);
            txt_Account_Id.TabIndex = 4;
            // 
            // date_From
            // 
            date_From.Format = DateTimePickerFormat.Short;
            date_From.Location = new Point(427, 138);
            date_From.Name = "date_From";
            date_From.Size = new Size(200, 31);
            date_From.TabIndex = 5;
            // 
            // date_To
            // 
            date_To.Format = DateTimePickerFormat.Short;
            date_To.Location = new Point(427, 215);
            date_To.Name = "date_To";
            date_To.Size = new Size(200, 31);
            date_To.TabIndex = 6;
            // 
            // Form_Make_Statement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(date_To);
            Controls.Add(date_From);
            Controls.Add(txt_Account_Id);
            Controls.Add(btn_Print_Statement);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Make_Statement";
            Text = "Form_Make_Statement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Print_Statement;
        private TextBox txt_Account_Id;
        private DateTimePicker date_From;
        private DateTimePicker date_To;
    }
}