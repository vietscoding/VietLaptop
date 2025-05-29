using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLaptop
{
    public partial class frmResetPassword : Form
    {
        private static string connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;TrustServerCertificate=True";
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Chuyển đổi thành chuỗi Hexadecimal
                }
                return builder.ToString();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAtLeast12Charaters.ForeColor == Color.Tomato)
                {
                    MessageBox.Show("Password must contain at least 12 characters", "Password not satisfied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblCapitalLetter.ForeColor == Color.Tomato)
                {
                    MessageBox.Show("Password must contain uppercase letters", "Password not satisfied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblLowerCase.ForeColor == Color.Tomato)
                {
                    MessageBox.Show("Password must contain lowercase letters", "Password not satisfied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblNumbers.ForeColor == Color.Tomato)
                {
                    MessageBox.Show("Password must contain at least a digit", "Password not satisfied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblSpecialChar.ForeColor == Color.Tomato)
                {
                    MessageBox.Show("Password must contain a special character", "Password not satisfied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNewPassword.Text != txtReEnterPassword.Text)
                {
                    MessageBox.Show("The password below does not match the password above.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string query = "UPDATE Employees SET password = @Password, password_reset_require = 0 WHERE employee_id = " + frmLogin.EMPLOYEE_ID;

                    string newPassword = txtNewPassword.Text;
                    string hasedNewPassword = HashPassword(newPassword);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Password", hasedNewPassword);
                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Update password sucessfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string selectRoleQuery = "SELECT role FROM Employees WHERE employee_id=@ID";
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand(selectRoleQuery, connection))
                                    {
                                        command.Parameters.AddWithValue("@ID", frmLogin.EMPLOYEE_ID);
                                        var result1 = command.ExecuteScalar();
                                        if (result1 != null)
                                        {
                                            frmLogin._employeeRole = result1.ToString();
                                            this.Hide();
                                            frmMain mainForm = new frmMain();
                                            mainForm.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("An error occurs, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    connection.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("An error occurs, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        conn.Close();
                    }

                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtNewPassword.Text;

            bool isMinLength = password.Length >= 12;
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            HighlightLabel(lblAtLeast12Charaters, isMinLength);
            HighlightLabel(lblCapitalLetter, hasUpperCase);
            HighlightLabel(lblLowerCase, hasLowerCase);
            HighlightLabel(lblNumbers, hasDigit);
            HighlightLabel(lblSpecialChar, hasSpecialChar);
        }

        private void HighlightLabel(Label lbl, bool condition)
        {
            if (condition)
            {
                lbl.ForeColor = Color.LimeGreen;
            }
            else
            {
                lbl.ForeColor = Color.Tomato;
            }
        }

        private void txtReEnterPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtReEnterPassword.Text != txtNewPassword.Text)
            {
                lblDoesntMatchPassword.Visible = true;
            }
            else
            {
                lblDoesntMatchPassword.Visible = false;
            }
        }

        private void checkBox_NewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NewPassword.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '●';
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel? The application will exit and password will keep in same", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void checkBox_ReEnterPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ReEnterPassword.Checked)
            {
                txtReEnterPassword.PasswordChar = '\0';
            }
            else
            {
                txtReEnterPassword.PasswordChar = '●';
            }
        }
    }
}
