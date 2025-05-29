using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLaptop
{
    public partial class CtrlCustomer : UserControl
    {
        public string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public CtrlCustomer()
        {
            InitializeComponent();
            connection = new SqlConnection( _connectionString );
            LoadData(); 
        }

        private void txtEditCustomerEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void EnableSearchTextBoxesExceptTxtID(bool condition)
        {
            txtSearchCustomerName.Enabled = condition;
            txtSearchCustomerPhone.Enabled = condition;
            txtSearchCustomerAddress.Enabled = condition;
            txtSearchCustomerEmail.Enabled = condition;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Customers;";
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(query, _connectionString);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomerID.Text.Length >= 1)
            {
                string customerIdStr = txtSearchCustomerID.Text.Trim();
                int customerID;
                if (!int.TryParse(customerIdStr, out customerID))
                {
                    MessageBox.Show("Invalid Customer ID", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query1 = "SELECT * FROM Customers WHERE customer_id = @CustomerID;";
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query1, connection);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvCustomer.DataSource = dataTable;
                        txtSearchCustomerID.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally {
                        connection.Close();
                    }
                }
                return;
            }

            string customerName = txtSearchCustomerName.Text.Trim();
            string customerPhone = txtSearchCustomerPhone.Text.Trim();
            string customerAddress = txtSearchCustomerAddress.Text.Trim();
            string customerEmail = txtSearchCustomerEmail.Text.Trim();

            string query = "SELECT * FROM Customers WHERE 1=1";
            if (!string.IsNullOrEmpty(customerName))
            {
                query += " AND customer_name LIKE @CustomerName";
            }
            if (!string.IsNullOrEmpty(customerPhone))
            {
                query += " AND phone_number LIKE @Phone";
            }
            if (!string.IsNullOrEmpty(customerAddress))
            {
                query += " AND address LIKE @Address";
            }
            if (!string.IsNullOrEmpty(customerEmail))
            { 
                query += " AND email LIKE @Email";
            }

            using (SqlConnection connection = new SqlConnection(CtrlProduct._connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(customerName))
                    {
                        cmd.Parameters.AddWithValue("CustomerName", "%"+customerName+"%");
                    }
                    if (!string.IsNullOrEmpty(customerPhone))
                    {
                        cmd.Parameters.AddWithValue("Phone", "%"+customerPhone+"%");

                    }
                    if (!string.IsNullOrEmpty(customerAddress))
                    {
                        cmd.Parameters.AddWithValue("Address", "%"+customerAddress+"%");

                    }
                    if (!string.IsNullOrEmpty(customerEmail))
                    {
                        cmd.Parameters.AddWithValue("Email", "%" + customerEmail+ "%");
                    }
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvCustomer.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }



        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCustomerID.Text.Trim().Length > 0)
            {
                EnableSearchTextBoxesExceptTxtID(false);
            }
            else { EnableSearchTextBoxesExceptTxtID(true); }
        }

        private frmAddCustomer addCustomerForm;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (addCustomerForm == null || addCustomerForm.IsDisposed)
            {
                addCustomerForm = new frmAddCustomer();
                addCustomerForm.FormClosed += (s, args) =>
                {
                    LoadData();
                    addCustomerForm = null;
                };
                addCustomerForm.ShowDialog();
            }
            else
            {
                addCustomerForm.BringToFront();
            }
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            //if (e.RowIndex >= 0 && e.ColumnIndex == -1)
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                int customerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer? This action won't be able to undo.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        try
                        {
                            string query = "DELETE FROM OrderDetails WHERE order_i  d IN (SELECT order_id\r\nFROM Orders\r\nWHERE customer_id=@CustomerID);\r\nDELETE FROM Orders WHERE customer_id = @CustomerID;";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            connection.Close();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successful!");
                                LoadData();
                            }
                            else { MessageBox.Show("No customer found to delete."); }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please click row header to perform customer deletion",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnEditCustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomer.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a whole row to edit");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditCustomerName.Text) ||
                    string.IsNullOrWhiteSpace(txtEditCustomerPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtEditCustomerAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtEditCustomerEmail.Text))
                {
                    MessageBox.Show("Please enter all the necessary information of the customer");
                    return;
                }

                string customerIdStr = dgvCustomer.SelectedRows[0].Cells["customeridDataGridViewTextBoxColumn"].Value.ToString();
                int customerID;
                if (!int.TryParse(customerIdStr, out customerID))
                {
                    MessageBox.Show("Invalid Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {   
                    string query = @"
                                    UPDATE Customers 
                                    SET 
                                        customer_name = @CustomerName,
                                        phone_number = @Phone,
                                        address = @Address,
                                        email = @Email,
                                        update_at = GETDATE()
                                    WHERE customer_id = @CustomerID;
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", txtEditCustomerName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtEditCustomerPhone.Text);
                        cmd.Parameters.AddWithValue("@Address", txtEditCustomerAddress.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEditCustomerEmail.Text);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successful customer update!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();

                        }
                        else
                        {
                            MessageBox.Show("No customer found to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                 connection.Close();
            }


        }

       

        private void btnClearAllSearchTextBoxes_Click_1(object sender, EventArgs e)
        {
            txtSearchCustomerID.Text = string.Empty;
            txtSearchCustomerAddress.Text = string.Empty;
            txtSearchCustomerEmail.Text = string.Empty;
            txtSearchCustomerName.Text = string.Empty;
            txtSearchCustomerPhone.Text = string.Empty;
        }

        private void dgvCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCustomer.Rows[e.RowIndex];
                txtEditCustomerName.Text = selectedRow.Cells["customernameDataGridViewTextBoxColumn"].Value.ToString();
                txtEditCustomerPhone.Text = selectedRow.Cells["phonenumberDataGridViewTextBoxColumn"].Value.ToString();
                txtEditCustomerAddress.Text = selectedRow.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
                txtEditCustomerEmail.Text = selectedRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
    }
}
