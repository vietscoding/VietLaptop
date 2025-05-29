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
using System.Diagnostics;
using System.Security.Cryptography;

namespace VietLaptop
{
    public partial class frmLogin : Form
    {
        private static string connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;TrustServerCertificate=True";
        public static string _employeeRole;
        public static string USER_NAME;
        public static string PASSWORD;
        public static int EMPLOYEE_ID;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); 
                }
                return builder.ToString();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string inputUserName = txtUserName.Text;
                string inputPassword = txtPassword.Text;
                string hasedInputPassword = HashPassword(inputPassword);



                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT employee_id FROM Employees WHERE username=@username AND password=@password;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", inputUserName);
                cmd.Parameters.AddWithValue("@password", hasedInputPassword);

                //int count = (int)cmd.ExecuteScalar();
                //EMPLOYEE_ID = count;

                object result = cmd.ExecuteScalar();
                EMPLOYEE_ID = result != null ? Convert.ToInt32(result) : -1;

                if (EMPLOYEE_ID == -1)
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;

                }

               




                if (EMPLOYEE_ID > 0)
                {
                    MessageBox.Show(" Login successful! Employee ID is: " + EMPLOYEE_ID, "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query1 = "SELECT password_reset_require FROM Employees WHERE employee_id=@employeeId";
                    SqlCommand command2 = new SqlCommand(query1, connection);
                    command2.Parameters.AddWithValue("@employeeId", EMPLOYEE_ID);
                    object result2 = command2.ExecuteScalar();
                    int passwordResetRequire = result2 != null ? Convert.ToInt32(result2) : -1;

                    if (passwordResetRequire == 1)
                    {
                        frmResetPassword frmResetPassword = new frmResetPassword();
                        this.Hide();
                        frmResetPassword.ShowDialog();
                        
                    }
                    else
                    {



                        string selectRoleQuery = "SELECT role FROM Employees WHERE employee_id=@employeeId";

                        using (SqlConnection connection1 = new SqlConnection(connectionString))
                        {
                            connection1.Open();
                            using (SqlCommand command = new SqlCommand(selectRoleQuery, connection))
                            {
                                command.Parameters.AddWithValue("@employeeId", EMPLOYEE_ID);
                                var result1 = command.ExecuteScalar();
                                if (result1 != null)
                                {
                                    _employeeRole = result1.ToString();
                                    frmMain mainForm = new frmMain();
                                    mainForm.Show();
                                    this.Hide();
                                    USER_NAME = txtUserName.Text;
                                    PASSWORD = txtPassword.Text;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                }
                            }
                            connection1.Close();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
            //frmMain mainForm = new frmMain();
            //mainForm.Show();
            //this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }

        }

        private void linkLabel_ForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("An OTP has sent to your email! Check your email to change the password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                txtUserName.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                txtPassword.Clear();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }

        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }
    }


}
