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
    public partial class Form_Make_Statement : Form
    {
        //string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;Integrated Security=True;TrustServerCertificate=True";
        string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=emp;Password=123;";
        public Form_Make_Statement()
        {
            InitializeComponent();
        }

        private void btn_Print_Statement_Click(object sender, EventArgs e)
        {
            string accountIdStr = txt_Account_Id.Text;

            if (int.TryParse(accountIdStr, out int accountId))
            {
                // Check if account ID exists and is active
                if (CheckAccountStatus(accountId, out bool isActive))
                {
                    if (isActive)
                    {
                        DateTime fromDate = date_From.Value;
                        DateTime toDate = date_To.Value;

                        // Create instance of Form_Account_Statement and pass parameters
                        Form_Account_Statement accountStatement = new Form_Account_Statement(accountId, fromDate, toDate);
                        this.Hide();
                        accountStatement.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Account is not active. Please enter a valid Account ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Account ID does not exist. Please enter a valid Account ID.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Account ID. Please enter a valid integer.");
            }
        }
        private bool CheckAccountStatus(int accountId, out bool isActive)
        {
            isActive = false;
            bool accountExists = false;
            string procedureName = "CheckAccountStatus";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountID", accountId);

                    SqlParameter accountExistsParam = new SqlParameter("@AccountExists", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    SqlParameter isActiveParam = new SqlParameter("@IsActive", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(accountExistsParam);
                    command.Parameters.Add(isActiveParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        accountExists = (bool)accountExistsParam.Value;
                        isActive = (bool)isActiveParam.Value;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking account status: " + ex.Message);
                    }
                }
            }

            return accountExists;
        }
    }
}
