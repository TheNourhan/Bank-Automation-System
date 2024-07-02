using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_automation_system
{
    public partial class Form_Main_Manager : Form
    {
        public Form_Main_Manager()
        {
            InitializeComponent();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Form_Restore form_Restore = new Form_Restore();
            form_Restore.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Mng_Employees mng_Employees = new Form_Mng_Employees();
            mng_Employees.ShowDialog();
        }

        private void btn_permissions_Click(object sender, EventArgs e)
        {
            Form_Permissions mng_Permissions = new Form_Permissions();
            mng_Permissions.ShowDialog();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            Form_Backup mng_Backup = new Form_Backup();
            mng_Backup.ShowDialog();  
        }
    }
}
