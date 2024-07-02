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

namespace bank_automation_system
{
    public partial class Form_Restore : Form
    {
        static string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=admin;Password=123;";
        SqlConnection con = new SqlConnection(connectionString);

        public Form_Restore()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "SQL SERVER database backup files|*.bak",
                Title = "Database Restore"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_Folder_Path.Text = ofd.FileName;
                btn_Restore.Enabled = true;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            con.Open();
            String database = con.Database.ToString();
            try
            {
                //restore cmd
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txt_Folder_Path.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Database Restored successfully");

                btn_Restore.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}

