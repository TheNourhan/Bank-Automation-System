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
    public partial class Form_Permissions : Form
    {
        string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=admin;Password=123;";

        public Form_Permissions()
        {
            InitializeComponent();
        }
        private bool DoesUserExist(string username)
        {
            bool userExists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT 1 FROM sys.database_principals WHERE name = @Username";
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            userExists = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking user existence: " + ex.Message);
                    }
                }
            }

            return userExists;
        }


        private void AddOrUpdateUser(string username, string password, bool isDbWriter, bool isDbReader, bool isDbAccessAdmin, bool isDbOwner, bool isDbDdlAdmin, bool isDbSecurityAdmin, bool isDbBackupOperator)
        {
            string cmdText = "USE [master]; " +
                             "CREATE LOGIN [" + username + "] WITH PASSWORD = '" + password + "', " +
                             "DEFAULT_DATABASE = [BANK], CHECK_EXPIRATION = OFF, CHECK_POLICY = ON; " +
                             "USE [BANK]; " +
                             "CREATE USER [" + username + "] FOR LOGIN [" + username + "]; ";

            if (isDbWriter)
            {
                cmdText += "ALTER ROLE [db_datawriter] ADD MEMBER [" + username + "]; ";
            }
            if (isDbReader)
            {
                cmdText += "ALTER ROLE [db_datareader] ADD MEMBER [" + username + "]; ";
            }
            if (isDbAccessAdmin)
            {
                cmdText += "ALTER ROLE [db_accessadmin] ADD MEMBER [" + username + "]; ";
            }
            if (isDbOwner)
            {
                cmdText += "ALTER ROLE [db_owner] ADD MEMBER [" + username + "]; ";
            }
            if (isDbDdlAdmin)
            {
                cmdText += "ALTER ROLE [db_ddladmin] ADD MEMBER [" + username + "]; ";
            }
            if (isDbSecurityAdmin)
            {
                cmdText += "ALTER ROLE [db_securityadmin] ADD MEMBER [" + username + "]; ";
            }
            if (isDbBackupOperator)
            {
                cmdText += "ALTER ROLE [db_backupoperator] ADD MEMBER [" + username + "]; ";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("User added or updated successfully with the specified permissions.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Add_DB_User_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            bool isBackupOperator = chk_db_backupoperator.Checked;
            bool isSecurityAdmin = chk_db_securityadmin.Checked;
            bool isDdlAdmin = chk_db_ddladmin.Checked;
            bool isAccessAdmin = chk_db_accessadmin.Checked;
            bool isDbOwner = chk_db_owner.Checked;
            bool isDbReader = chk_db_reader.Checked;
            bool isDbWriter = chk_db_writer.Checked;

            if (DoesUserExist(username))
            {
                MessageBox.Show("User already exists!");
            }
            else
            {
                AddOrUpdateUser(username, password, isDbWriter, isDbReader, isAccessAdmin, isDbOwner, isDdlAdmin, isSecurityAdmin, isBackupOperator);
            }
        }

        // Close button click event
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
       
}
