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
    public partial class Form_Open_Account : Form
    {
        private int branchId;
        //private string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;Integrated Security=True;TrustServerCertificate=True";
        private string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=emp;Password=123;";
        public Form_Open_Account(int branchId)
        {
            InitializeComponent();
            this.branchId = branchId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = txt_Cust_Firstname.Text;
            string lastname = txt_Cust_Lastname.Text;
            string email = txt_Cust_Email.Text;
            string phone = txt_Cust_Phone.Text;
            string password = txt_Cust_Password.Text;

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all info.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Customers (FirstName, LastName, Email, PasswordHash, Phone) VALUES (@FirstName, @LastName, @Email, @PasswordHash, @Phone)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@LastName", lastname);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PasswordHash", password);
                        command.Parameters.AddWithValue("@Phone", phone);

                        int result = command.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Customer info inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert customer info.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_Open_Account_Click(object sender, EventArgs e)
        {
            string customerId = txt_Customer_Id.Text;
            string accountType = txt_Account_Type.Text;
            string balanceText = txt_Balance.Text;

            if (string.IsNullOrEmpty(customerId) || string.IsNullOrEmpty(accountType) || string.IsNullOrEmpty(balanceText))
            {
                MessageBox.Show("Please enter all the required information.");
                return;
            }

            if (!decimal.TryParse(balanceText, out decimal balance))
            {
                MessageBox.Show("Please enter a valid balance.");
                return;
            }

            if (DoesCustomerExist(customerId))
            {
                InsertAccount(customerId, accountType, balance);
            }
            else
            {
                MessageBox.Show("Customer ID does not exist.");
            }
        }
        private bool DoesCustomerExist(string customerId)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        exists = count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return exists;
        }
        private void InsertAccount(string customerId, string accountType, decimal balance)
        {   
            string query = "INSERT INTO Accounts (BranchID, CustomerID, AccountType, Status, Balance, CreatedDate) VALUES (@BranchID, @CustomerID, @AccountType, 'Active', @Balance, @CreatedDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BranchID", branchId);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@AccountType", accountType);
                    command.Parameters.AddWithValue("@Balance", balance);
                    command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
