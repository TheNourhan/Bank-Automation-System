using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bank_automation_system
{
    public partial class Form_Transfers : Form
    {
        //private string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;Integrated Security=True;TrustServerCertificate=True";
        private string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=emp;Password=123;";
        public Form_Transfers()
        {
            InitializeComponent();
        }

        private void btn__Submit_Transfers_Click(object sender, EventArgs e)
        {
            string fromAccount = txt_From.Text;
            string toAccount = txt_To.Text;
            string amountText = txt_Amount.Text;

            int fromAccountId;
            int toAccountId;
            decimal transferAmount;

            // Convert inputs to integers and decimal
            if (!int.TryParse(fromAccount, out fromAccountId))
            {
                MessageBox.Show("Invalid From Account ID. Please enter a valid integer.");
                return;
            }

            if (!int.TryParse(toAccount, out toAccountId))
            {
                MessageBox.Show("Invalid To Account ID. Please enter a valid integer.");
                return;
            }

            if (!decimal.TryParse(amountText, out transferAmount))
            {
                MessageBox.Show("Invalid amount. Please enter a valid decimal number.");
                return;
            }

            // Check if both accounts exist
            if (DoesAccountExistAndActive(fromAccountId) && DoesAccountExistAndActive(toAccountId))
            {
                // Insert the transfer into the database
                InsertTransfer(fromAccountId, toAccountId, transferAmount);
            }
            else
            {
                MessageBox.Show("One or both of the account IDs do not exist.");
            }
        }

        private bool DoesAccountExistAndActive(int accountId)
        {
            bool existsAndActive = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("CheckAccountStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountID", accountId);

                    SqlParameter accountExistsParam = new SqlParameter("@AccountExists", SqlDbType.Bit);
                    accountExistsParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(accountExistsParam);

                    SqlParameter isActiveParam = new SqlParameter("@IsActive", SqlDbType.Bit);
                    isActiveParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(isActiveParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        bool accountExists = Convert.ToBoolean(accountExistsParam.Value);
                        bool isActive = Convert.ToBoolean(isActiveParam.Value);

                        existsAndActive = accountExists && isActive;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return existsAndActive;
        }
        private void InsertTransfer(int fromAccountId, int toAccountId, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand("TransferFunds", connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FromAccountID", fromAccountId);
                        command.Parameters.AddWithValue("@ToAccountID", toAccountId);
                        command.Parameters.AddWithValue("@Amount", amount);

                        command.ExecuteNonQuery();

                        // Commit transaction if all operations succeed
                        transaction.Commit();
                        MessageBox.Show("Transfer recorded successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting transfer: " + ex.Message);

                    // Rollback transaction in case of error
                    transaction.Rollback();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
