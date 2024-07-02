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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = text_email.Text;
            string password = text_password.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            // Check credentials against database
            var result = CheckCredentials(email, password);

            if (result.isAuthenticated)
            {
                if (result.role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                {
                    // If the user is a manager, no need to check permissions
                    MessageBox.Show("Login successful!");
                    this.Hide();

                    Form_Main_Manager mainForm = new Form_Main_Manager();
                    mainForm.Show();
                }
                else
                {
                    // Check if the employee has permission to login
                    bool hasLoginPermission = CheckEmployeePermission(result.employeeId, "Login");

                    if (hasLoginPermission)
                    {
                        int branchId = result.branchId;

                        MessageBox.Show("Login successful!");
                        this.Hide();

                        Form_Main_Employee employeeForm = new Form_Main_Employee(branchId);
                        employeeForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to login.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private (bool isAuthenticated, string role, int branchId, int employeeId) CheckCredentials(string email, string password)
        {
            bool isAuthenticated = false;
            string role = string.Empty;
            int branchId = 0;
            int employeeId = 0;
            string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=admin;Password=123;";
            string query = "SELECT EmployeeID, Role, BranchID FROM Employees WHERE Email = @Email AND PasswordHash = @PasswordHash";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PasswordHash", password);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isAuthenticated = true;
                            employeeId = Convert.ToInt32(reader["EmployeeID"]);
                            role = reader["Role"].ToString();
                            branchId = Convert.ToInt32(reader["BranchID"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return (isAuthenticated, role, branchId, employeeId);
        }

        private bool CheckEmployeePermission(int employeeId, string permissionName)
        {
            bool hasPermission = false;
            string connectionString = @"Data Source=DESKTOP-E66S709;Initial Catalog=BANK;User ID=admin;Password=123;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("CheckEmployeePermission", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    cmd.Parameters.AddWithValue("@PermissionName", permissionName);

                    try
                    {
                        con.Open();
                        int result = (int)cmd.ExecuteScalar();
                        hasPermission = (result == 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

            return hasPermission;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
