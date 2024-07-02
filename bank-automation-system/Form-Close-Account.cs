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
    public partial class Form_Close_Account : Form
    {
        private string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;Integrated Security=True;TrustServerCertificate=True";
        public Form_Close_Account()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            string accountId = txt_Acount_Id.Text;

            // Check if accountId is a valid integer
            if (!int.TryParse(accountId, out int accountIdInt))
            {
                MessageBox.Show("Invalid Account ID. Please enter a valid integer.");
                return;
            }

            // Check if account exists and update status to 'closed'
            if (AccountExists(accountIdInt))
            {
                if (UpdateAccountStatus(accountIdInt))
                {
                    MessageBox.Show("Account closed successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update account status.");
                }
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }

        private bool AccountExists(int accountId)
        {
            string query = "SELECT COUNT(*) FROM Accounts WHERE AccountID = @AccountID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", accountId);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking account existence: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private bool UpdateAccountStatus(int accountId)
        {
            string updateQuery = "UPDATE Accounts SET Status = 'closed', ClosedDate = GETDATE() WHERE AccountID = @AccountID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", accountId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating account status: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
