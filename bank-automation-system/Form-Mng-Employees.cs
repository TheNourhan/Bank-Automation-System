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
    public partial class Form_Mng_Employees : Form
    {
        string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;Integrated Security=True;TrustServerCertificate=True";

        public Form_Mng_Employees()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txt_Firstname.Text;
            string lastName = txt_Lastname.Text;
            string username = txt_Username.Text;
            string email = txt_Email.Text;
            string role = txt_Role.Text;
            string passwordHash = txt_Password.Text;

            int branchId = 0;
            if (!int.TryParse(txt_BranchId.Text, out branchId))
            {
                MessageBox.Show("Branch ID must be a valid integer.");
                return;
            }

            int managerId = 0;
            if (!int.TryParse(txt_MngId.Text, out managerId))
            {
                MessageBox.Show("Manager ID must be a valid integer.");
                return;
            }

            bool statementPermission = chk_Statement.Checked;
            bool transfersPermission = chk_Transfers.Checked;
            bool closeAccPermission = chk_Close_Acc.Checked;
            bool newAccPermission = chk_New_Acc.Checked;
            bool loginPermission = chk_Login.Checked;

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        int employeeId = AddEmployee(connection, transaction, firstName, lastName, username, email, role, passwordHash, branchId, managerId);

                        ManageEmployeePermissions(connection, transaction, employeeId, statementPermission, transfersPermission, closeAccPermission, newAccPermission, loginPermission);

                        // Commit transaction if all steps succeed
                        transaction.Commit();

                        MessageBox.Show("Employee added successfully with permissions.");
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction if an error occurs
                        transaction.Rollback();
                        MessageBox.Show("Error adding employee: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }

        private int AddEmployee(SqlConnection connection, SqlTransaction transaction, string firstName, string lastName, string username, string email, string role, string passwordHash, int branchId, int managerId)
        {
            int employeeId = 0;

            using (SqlCommand command = new SqlCommand("AddEmployee", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@BranchID", branchId);
                command.Parameters.AddWithValue("@ManagerID", managerId);
                command.Parameters.AddWithValue("@Username", username);

                // Add output parameter
                SqlParameter paramEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                paramEmployeeID.Direction = ParameterDirection.Output;
                command.Parameters.Add(paramEmployeeID);

                // Execute the command
                command.ExecuteNonQuery();

                // Retrieve EmployeeID from output parameter
                if (paramEmployeeID.Value != DBNull.Value)
                {
                    employeeId = Convert.ToInt32(paramEmployeeID.Value);
                }
            }

            return employeeId;
        }

        private void ManageEmployeePermissions(SqlConnection connection, SqlTransaction transaction, int employeeId, bool statementPermission, bool transfersPermission, bool closeAccPermission, bool newAccPermission, bool loginPermission)
        {
            using (SqlCommand command = new SqlCommand("ManageEmployeePermissions", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters for ManageEmployeePermissions stored procedure
                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                command.Parameters.AddWithValue("@StatementPermission", statementPermission ? 1 : 0);
                command.Parameters.AddWithValue("@TransfersPermission", transfersPermission ? 1 : 0);
                command.Parameters.AddWithValue("@CloseAccPermission", closeAccPermission ? 1 : 0);
                command.Parameters.AddWithValue("@NewAccPermission", newAccPermission ? 1 : 0);
                command.Parameters.AddWithValue("@LoginPermission", loginPermission ? 1 : 0);

                command.ExecuteNonQuery();
            }
        }

    }
}
