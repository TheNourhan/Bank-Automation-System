using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace bank_automation_system
{
    public partial class Form_Main_Employee : Form
    {
        private int branchId;
        public Form_Main_Employee(int branchId)
        {
            InitializeComponent();
            this.branchId = branchId;
        }

        private void btn_Open_Account_Click(object sender, EventArgs e)
        {
            Form_Open_Account openAccountForm = new Form_Open_Account(branchId);
            openAccountForm.Show();
        }

        private void btn_Transfers_Click(object sender, EventArgs e)
        {
            Form_Transfers transfers = new Form_Transfers();
            transfers.Show();
        }

        private void btn_Close_Account_Click(object sender, EventArgs e)
        {
            Form_Close_Account closeAccount = new Form_Close_Account();
            closeAccount.Show();
        }

        private void btn_Statement_Click(object sender, EventArgs e)
        {
            Form_Make_Statement makeStatement = new Form_Make_Statement();
            makeStatement.Show();
        }
    }
}
