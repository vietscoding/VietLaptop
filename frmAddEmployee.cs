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

namespace VietLaptop
{
    public partial class frmAddEmployee : Form
    {
        private string connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtEmployeeName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Invalid employee name!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmployeeName.Focus();
            }
            else if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Invalid position!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPosition.Focus();
            }
            else if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Invalid Username!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid Password!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Invalid Role!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbRole.SelectedIndex = 0;
            }
            else if (string.IsNullOrEmpty (phone))
            {
                MessageBox.Show("Invalid phone number! The field can't be empty.",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else if (phone.Length != 10)
            {
                MessageBox.Show("Invalid phone number! Require a 10-digit phone number.",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else
            {
                try
                {
                    string hashedPassword = frmResetPassword.HashPassword(password);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Employees (employee_name, position, username, password, role, phone, password_reset_require) VALUES (@Name, @Position, @UserName, @Password, @Role, @Phone, 1);";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Position", position);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Add a new employee successful!",
                            "Successful!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnClearAllTxtBoxes_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtPosition.Text = string.Empty;
            cmbRole.Text = string.Empty;
            txtUsername.Focus();
        }
    }
}
