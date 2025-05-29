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
    public partial class CtrlEmployee : UserControl
    {

        public static string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public CtrlEmployee()
        {
            InitializeComponent();
            LoadData();
            connection = new SqlConnection(_connectionString);




        }

        private void LoadData()
        {
            string query = "SELECT * FROM Employees;";

            try
            {
                //connection.Open();
                dataAdapter = new SqlDataAdapter(query, _connectionString);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvEmployee.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    connection.Close();
            //}
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchEmployeeID.Text.Length >= 1)
                {
                    string employeeIdStr = txtSearchEmployeeID.Text.Trim();
                    int employeeID;
                    if (!int.TryParse(employeeIdStr, out employeeID))
                    {
                        MessageBox.Show("Invalid Emoloyee ID", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query1 = "SELECT * FROM Employees WHERE employee_id = @EmployeeID;";
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query1, connection);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvEmployee.DataSource = dataTable;
                        txtSearchEmployeeID.Focus();
                    }
                    return;
                }

                string employeeName = txtSearchEmployeeName.Text.Trim();
                string employeePosition = txtSearchEmployeePosition.Text.Trim();
                string employeePhone = txtSearchPhone.Text.Trim();
                string employeeUserName = txtSearchUserName.Text.Trim();
                string employeeRole = cmbSearchEmployeeRole.Text.Trim();

                string query = "SELECT * FROM Employees WHERE 1=1";
                if (!string.IsNullOrEmpty(employeeName))
                {
                    query += " AND employee_name LIKE @EmployeeName";

                }
                if (!string.IsNullOrEmpty(employeePosition))
                {
                    query += " AND position LIKE @Position";
                }
                //if (!string.IsNullOrEmpty(employeeUserName))
                //{
                //    query += " AND username LIKE @UserName";
                //}
                if (!string.IsNullOrEmpty(employeeRole))
                {
                    query += " AND role LIKE @Role";
                }
                if (!string.IsNullOrEmpty(employeePhone))
                {
                    query += " AND phone LIKE @Phone";
                }

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(employeeName))
                    {
                        cmd.Parameters.AddWithValue("EmployeeName", "%" + employeeName + "%");
                    }
                    if (!string.IsNullOrEmpty(employeePosition))
                    {
                        cmd.Parameters.AddWithValue("Position", "%" + employeePosition + "%");
                    }
                    if (!string.IsNullOrEmpty(employeeUserName))
                    {
                        cmd.Parameters.AddWithValue("UserName", "%" + employeeUserName + "%");
                    }
                    if (!string.IsNullOrEmpty(employeeRole))
                    {
                        cmd.Parameters.AddWithValue("Role", "%" + employeeRole + "%");
                    }
                    if (!string.IsNullOrEmpty(employeePhone))
                    {
                        cmd.Parameters.AddWithValue("Phone", "%" + employeePhone + "%");
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvEmployee.DataSource = dataTable;
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

        private void btnClearAllSearchTextBoxs_Click(object sender, EventArgs e)
        {
            txtSearchEmployeeID.Text = string.Empty;
            txtSearchEmployeeName.Text = string.Empty;
            txtSearchEmployeePosition.Text = string.Empty;
            txtSearchPhone.Text = string.Empty;
            cmbEditRole.SelectedIndex = 0;
            txtSearchUserName.Text = string.Empty;
        }


        private void EnableTxtSearchExceptTxtId(bool condition)
        {
            txtSearchEmployeeName.Enabled = condition;
            txtSearchEmployeePosition.Enabled = condition;
            txtSearchPhone.Enabled = condition;
            cmbEditRole.Enabled = condition;
            txtSearchUserName.Enabled = condition;
        }

        private void txtSearchEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployeeID.Text.Trim().Length > 0)
            {
                EnableTxtSearchExceptTxtId(false);
            }
            else { EnableTxtSearchExceptTxtId(true);}
        }

        private frmAddEmployee addEmployeeForm;
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (addEmployeeForm == null || addEmployeeForm.IsDisposed)
            {
                addEmployeeForm = new frmAddEmployee();
                addEmployeeForm.FormClosed += (s, args) =>
                {
                    LoadData();
                    addEmployeeForm = null;
                };
                addEmployeeForm.ShowDialog();
            }
            else
            {
                addEmployeeForm.BringToFront();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int employeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee? This action won't be able to undo.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(_connectionString))

                        {
                            string query = "DELETE FROM Employees WHERE employee_id = @ID";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@ID", employeeID);
                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            connection.Close();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Deleted employee successful!");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No employee found to delete.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Please click the row header to perform customer deletion",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row header to edit employee's info",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtEditEmployeeName.Text) ||
                string.IsNullOrEmpty(txtEditEmployeePhone.Text) ||
                string.IsNullOrEmpty(txtEditEmployeePosition.Text)||
                string.IsNullOrEmpty(cmbEditRole.Text))
                //string.IsNullOrEmpty(txtEditUserName.Text) ||
                //string.IsNullOrEmpty(txtEditPassword.Text))
            {
                MessageBox.Show("Please enter all the necessary information of the employee",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string employeeIdStr = dgvEmployee.SelectedRows[0].Cells["employeeidDataGridViewTextBoxColumn"].Value.ToString();
            int employeeID;
            if (!int.TryParse(employeeIdStr, out employeeID))
            {
                MessageBox.Show("Invalid Employee ID!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                                UPDATE Employees
                                SET
                                    employee_name = @Name,
                                    position = @Position,
                                    role = @Role,
                                    phone = @Phone,
                                    update_at = GETDATE()
                                WHERE employee_id = @ID;
                                ";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Name", txtEditEmployeeName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", txtEditEmployeePosition.Text.Trim());
                        //cmd.Parameters.AddWithValue("@UserName", txtEditUserName.Text.Trim());
                        //cmd.Parameters.AddWithValue("@Password", txtEditPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cmbEditRole.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtEditEmployeePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", employeeID);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update employee's info successful!",
                                "Successful!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong, try again later",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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

            }

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEmployee.Rows[e.RowIndex];
                txtEditEmployeeName.Text = selectedRow.Cells["employeenameDataGridViewTextBoxColumn"].Value.ToString();
                txtEditEmployeePosition.Text = selectedRow.Cells["positionDataGridViewTextBoxColumn"].Value.ToString();
                //txtEditUserName.Text = selectedRow.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();
                //txtEditPassword.Text = selectedRow.Cells["passwordDataGridViewTextBoxColumn"].Value.ToString();
                txtEditEmployeePhone.Text = selectedRow.Cells["phoneDataGridViewTextBoxColumn"].Value.ToString();
                cmbEditRole.Text = selectedRow.Cells["roleDataGridViewTextBoxColumn"].Value.ToString();

            }
        }
    }
}
