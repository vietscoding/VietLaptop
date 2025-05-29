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
    public partial class frmAddCustomer : Form
    {

        private string connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            string customerName = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            char at = '@';

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Invalid customer name!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCustomerName.Focus();
            }
            else if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Invalid phone number! Require a 10-digit phone number",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else if (phone.Length != 10)
            {
                MessageBox.Show("Invalid phone number! Require a 10-digit phone number",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Invalid address!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Invalid email!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            

            else if (!email.Contains(at))
            {
                MessageBox.Show("Invalid email!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Customers (customer_name, phone_number, address, email) VALUES (@CustomerName, @Phone, @Address, @Email);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Add a new customer successful!",
                        "Successful!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
        }

        private void btnClearTxtBoxes_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCustomerName.Focus();
        }
    }
}
