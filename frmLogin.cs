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

namespace VietLaptop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            string query = "SELECT COUNT(*) FROM Employees WHERE username=@username AND password=@password AND role=@role";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@role", cmbRole.Text);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();

            

            if(count > 0 )
            {
                // MessageBox.Show("Login success", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username, role, or password","Error",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                txtPassword.PasswordChar = '*';
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
