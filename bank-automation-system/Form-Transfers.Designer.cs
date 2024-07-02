namespace bank_automation_system
{
    partial class Form_Transfers
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
            txt_From = new TextBox();
            txt_To = new TextBox();
            txt_Amount = new TextBox();
            label3 = new Label();
            btn__Submit_Transfers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 94);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 165);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // txt_From
            // 
            txt_From.Location = new Point(441, 94);
            txt_From.Name = "txt_From";
            txt_From.Size = new Size(200, 31);
            txt_From.TabIndex = 2;
            // 
            // txt_To
            // 
            txt_To.Location = new Point(441, 165);
            txt_To.Name = "txt_To";
            txt_To.Size = new Size(200, 31);
            txt_To.TabIndex = 3;
            // 
            // txt_Amount
            // 
            txt_Amount.Location = new Point(441, 244);
            txt_Amount.Name = "txt_Amount";
            txt_Amount.Size = new Size(200, 31);
            txt_Amount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 244);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "Amount";
            // 
            // btn__Submit_Transfers
            // 
            btn__Submit_Transfers.Location = new Point(281, 324);
            btn__Submit_Transfers.Name = "btn__Submit_Transfers";
            btn__Submit_Transfers.Size = new Size(178, 49);
            btn__Submit_Transfers.TabIndex = 6;
            btn__Submit_Transfers.Text = "Transfers";
            btn__Submit_Transfers.UseVisualStyleBackColor = true;
            btn__Submit_Transfers.Click += btn__Submit_Transfers_Click;
            // 
            // Form_Transfers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn__Submit_Transfers);
            Controls.Add(label3);
            Controls.Add(txt_Amount);
            Controls.Add(txt_To);
            Controls.Add(txt_From);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Transfers";
            Text = "Form_Transfers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_From;
        private TextBox txt_To;
        private TextBox txt_Amount;
        private Label label3;
        private Button btn__Submit_Transfers;
    }
}