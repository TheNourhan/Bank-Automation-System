using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bank_automation_system
{
    public partial class Form_Backup : Form
    {
        static string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=admin;Password=123;";
        SqlConnection con = new SqlConnection(connectionString);

        public Form_Backup()
        {
            InitializeComponent();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            string databaseName = con.Database.ToString();
            if (string.IsNullOrEmpty(txt_Folder_Path.Text))
            {
                MessageBox.Show("Please enter the backup file location.");
                return;
            }

            string backupFileName = $"Database_Nourhan_133991-{DateTime.Now:yyyy-MM-dd--HH-mm-ss}.bak";
            string backupPath = System.IO.Path.Combine(txt_Folder_Path.Text, backupFileName);
            string bakStr = $"BACKUP DATABASE [{databaseName}] TO DISK='{backupPath}'";

            try
            {
                con.Open();
                SqlCommand bakCmd = new SqlCommand(bakStr, con);
                bakCmd.ExecuteNonQuery();
                MessageBox.Show("Database backup completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while backing up the database: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Folder_Path.Text = fbd.SelectedPath;
                btn_Backup.Enabled = true;
            }
        }
    }
}
