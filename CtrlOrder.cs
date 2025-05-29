using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLaptop
{
    public partial class CtrlOrder : UserControl
    {
        private static string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        private SqlConnection connection = new SqlConnection(_connectionString);
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public CtrlOrder()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string query = "SELECT O.order_id, O.customer_id, O.total_amount, O.status, OD.product_id, OD.quantity, OD.price_at_purchase FROM Orders O JOIN OrderDetails OD ON O.order_id = OD.order_id;";
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvOrder.DataSource = dataTable;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string orderID = txtSearchOrderID.Text.Trim();
                string customerID = txtSearchCustomerID.Text.Trim();
                string productID = txtSearchProductID.Text.Trim();
                string price = txtSearchPrice.Text.Trim();
                string quantity = txtSearchQuantity.Text.Trim();
                string totalAmount = txtSearchTotalAmount.Text.Trim();
                string status = cmbSearchStatus.Text.Trim();

                string query = "SELECT O.order_id, O.customer_id, O.total_amount, O.status, OD.product_id, OD.quantity, OD.price_at_purchase\r\nFROM Orders O\r\nJOIN OrderDetails OD ON O.order_id = OD.order_id\r\n WHERE 1=1";
                if (!string.IsNullOrEmpty(orderID))
                {
                    query += " AND O.order_id LIKE @OrderID";
                }
                if (!string.IsNullOrEmpty(customerID))
                {
                    query += " AND O.customer_id LIKE @CustomerID";
                }
                if (!string.IsNullOrEmpty(productID))
                {
                    query += " AND OD.product_id LIKE @ProductID";
                }
                if (!string.IsNullOrEmpty(price))
                {
                    query += " AND OD.price_at_purchase LIKE @Price";

                }
                if (!string.IsNullOrEmpty(quantity))
                {
                    query += " AND OD.quantity LIKE @Quantity";
                }
                if (!string.IsNullOrEmpty(totalAmount))
                {
                    query += " AND O.total_amount LIKE @Total";
                }
                if (!string.IsNullOrEmpty(status))
                {
                    query += " AND O.status LIKE @Status";
                }

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(orderID))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", "%" + orderID + "%");
                    }
                    if (!string.IsNullOrEmpty(customerID))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", "%" + customerID + "%");
                    }
                    if (!string.IsNullOrEmpty(productID))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", "%" + productID + "%");
                    }
                    if (!string.IsNullOrEmpty(price))
                    {
                        cmd.Parameters.AddWithValue("@Price", "%" + price + "%");

                    }
                    if (!string.IsNullOrEmpty(quantity))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", "%" + quantity + "%");
                    }
                    if (!string.IsNullOrEmpty(totalAmount))
                    {
                        cmd.Parameters.AddWithValue("@Total", "%" + totalAmount + "%");
                    }
                    if (!string.IsNullOrEmpty(status))
                    {
                        cmd.Parameters.AddWithValue("@Status", "%" + status + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvOrder.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private frmAddOrder addOrderForm;
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (addOrderForm == null || addOrderForm.IsDisposed)
            {
                addOrderForm = new frmAddOrder();
                addOrderForm.FormClosed += (s, args) =>
                {
                    LoadData();
                    addOrderForm = null;
                };
                addOrderForm.Show();
            }
            else
            {
                addOrderForm.BringToFront();
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int orderID = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        string queryDeleteOrderDetails = "DELETE FROM OrderDetails WHERE order_id=@orderId;";
                        string queryDeleteOrders = "DELETE FROM Orders WHERE order_id=@orderId";
                        SqlCommand cmd = new SqlCommand(queryDeleteOrderDetails, connection);
                        cmd.Parameters.AddWithValue("@orderId", orderID);

                        SqlCommand cmdDeleteOrders = new SqlCommand(queryDeleteOrders, connection);
                        cmdDeleteOrders.Parameters.AddWithValue("@orderId", orderID);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        int rowsAffected2 = cmdDeleteOrders.ExecuteNonQuery();
                        connection.Close();
                        
                        if (rowsAffected > 0 && rowsAffected2 > 0)
                        {
                            MessageBox.Show("Order deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No order found to delete.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an order you want to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnClearAllSearchTextBoxs_Click(object sender, EventArgs e)
        {
            txtSearchCustomerID.Text = string.Empty;
            txtSearchOrderID.Text = string.Empty;
            txtSearchPrice.Text = string.Empty;
            txtSearchProductID.Text = string.Empty;
            txtSearchQuantity.Text = string.Empty;
            txtSearchTotalAmount.Text = string.Empty;
            
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrder.SelectedRows.Count == 0 )
                {
                    MessageBox.Show("Please select a row header of an order to edit");
                    return;
                }
                if (string.IsNullOrEmpty(txtEditOrderID.Text) ||
                    string.IsNullOrEmpty(txtEditCustomerID.Text) ||
                    string.IsNullOrEmpty(txtEditQuantity.Text) ||
                    string.IsNullOrEmpty(txtEditPrice.Text) ||
                    string.IsNullOrEmpty(txtEditTotalAmount.Text) ||
                    string.IsNullOrEmpty(txtEditProductID.Text))
                {
                    MessageBox.Show("Please enter all the neccessary information.");
                    return;
                }

                string orderIdStr = dgvOrder.SelectedRows[0].Cells["orderidDataGridViewTextBoxColumn"].Value.ToString();
                string quantityStr = txtEditQuantity.Text.Trim();
                int orderId, quantity;
                bool isOrderId = int.TryParse(orderIdStr, out orderId);
                bool isQuantity = int.TryParse(quantityStr, out quantity);
                if (!isOrderId)
                {
                    MessageBox.Show("Invalid Order ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!isQuantity)
                {
                    MessageBox.Show("Invalid quantity! Require an positive integer number" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                double price, amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        DataGridViewRow selectedRow = dgvOrder.Rows[e.RowIndex];
                        txtEditOrderID.Text = selectedRow.Cells["orderidDataGridViewTextBoxColumn"].Value.ToString();
                        txtEditProductID.Text = selectedRow.Cells["product_id"].Value.ToString();
                        txtEditPrice.Text = selectedRow.Cells["price_at_purchase"].Value.ToString();
                        txtEditQuantity.Text = selectedRow.Cells["quantity"].Value.ToString();
                        txtEditCustomerID.Text = selectedRow.Cells["customer_id"].Value.ToString();
                        txtEditTotalAmount.Text = selectedRow.Cells["total_amount"].Value.ToString();
                        cmbEditStatus.Text = selectedRow.Cells["status"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); 
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
