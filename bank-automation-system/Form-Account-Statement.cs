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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bank_automation_system
{
    public partial class Form_Account_Statement : Form
    {
        //string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;Integrated Security=True;TrustServerCertificate=True";
        string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=emp;Password=123;";
        public int AccountId;
        public DateTime FromDate;
        public DateTime ToDate;
        public Form_Account_Statement(int accountId, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.AccountId = accountId;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form_Account_Statement_Load(object sender, EventArgs e)
        {
            
        }

        private void Form_Account_Statement_Load_1(object sender, EventArgs e)
        {
            LoadAccountDetails(AccountId);
            LoadTransfersDetails(AccountId, FromDate, ToDate);
        }
        private void LoadAccountDetails(int accountId)
        {
            string procedureName = "GetAccountStatement";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountId", accountId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lbl_Date.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                lbl_Firstname.Text = reader["FirstName"].ToString();
                                lbl_Lastname.Text = reader["LastName"].ToString();
                                lbl_AccountId.Text = reader["AccountID"].ToString();
                                lbl_Status.Text = reader["Status"].ToString();
                                lbl_Balance.Text = reader["Balance"].ToString();
                                lbl_Branch.Text = reader["BranchName"].ToString();
                                lbl_Created_Date.Text = reader["CreatedDate"].ToString();
                                lbl_Num_Transfers.Text = reader["NumberOfTransfers"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified account ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading account details: " + ex.Message);
                    }
                }
            }
        }

        private void LoadTransfersDetails(int AccountId, DateTime FromDate, DateTime ToDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetTransferDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters for the stored procedure
                    command.Parameters.AddWithValue("@AccountId", AccountId); 
                    command.Parameters.AddWithValue("@FromDate", FromDate); 
                    command.Parameters.AddWithValue("@ToDate", ToDate);

                    // Create a SqlDataAdapter to fetch the data
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to your DataGridView
                        dataGridView_Transfer.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading transfer details: " + ex.Message);
                    }
                }
            }
        }

    }
}
