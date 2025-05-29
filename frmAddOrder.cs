using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLaptop
{
    
    public partial class frmAddOrder : Form
    {

        public string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        //public bool IsSelectCustomerIdButtonClicked {  get; private set; } = false;
        private static decimal _sellingPrice = 0;
        public frmAddOrder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            cmbStatus.Text = string.Empty;
            _sellingPrice = 0;
            
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Get all textbox info
            try
            {
                string customerIdStr = txtCustomerID.Text.Trim();
                string productIdStr = txtProductID.Text.Trim();
                string sellingPriceStr = txtPrice.Text.Trim();
                string quantityStr = txtQuantity.Text.Trim();
                string totalAmountStr = txtTotalAmount.Text.Trim();
                string statusStr = cmbStatus.Text.Trim();

                int customerId = 0;
                int productId = 0;
                decimal sellingPrice = 0M;
                int quantity = 0;
                decimal totalAmount = 0M;

                bool isCustomerId = int.TryParse(customerIdStr, out customerId);
                bool isProductId = int.TryParse(productIdStr, out productId);
                bool isSellingPrice = decimal.TryParse(sellingPriceStr, out sellingPrice);
                bool isQuantity = int.TryParse(quantityStr, out quantity);
                bool isTotalAmount = decimal.TryParse(totalAmountStr, out totalAmount);

                if (!isCustomerId)
                {
                    MessageBox.Show("Invalid customer ID! Require an integer number",
                                    "Error Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (!isProductId)
                {
                    MessageBox.Show("Invalid product ID! Require an integer number",
                                    "Error Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (!isSellingPrice)
                {
                    MessageBox.Show("Invalid selling price!",
                                    "Error Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (!isQuantity)
                {
                    MessageBox.Show("Invalid quantity!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else if (quantity <= 0)
                {
                    MessageBox.Show("Invalid quantity! Require positive integer number.",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    if (productId > 0 && quantity > 0)
                    {
                        int inventory_quantity;
                        using (SqlConnection conn = new SqlConnection(_connectionString))
                        {
                            string queryCheckInventoryByProductId = "SELECT inventory_quantity FROM Products WHERE product_id=@productId";
                            SqlCommand cmd = new SqlCommand(queryCheckInventoryByProductId, conn);
                            cmd.Parameters.AddWithValue("@productId", productId);
                            conn.Open();
                            inventory_quantity = (int)cmd.ExecuteScalar();
                            conn.Close();
                        }
                        if (inventory_quantity > quantity)
                        {
                            using (SqlConnection connection = new SqlConnection(_connectionString))
                            {
                                string queryInsertOrders = "INSERT INTO Orders (customer_id, employee_id, order_date, total_amount, status, update_at) VALUES (@customerId, @employeeId, GETDATE(), @totalAmount, @status, GETDATE());";
                                string querySelectOrderId = "SELECT MAX(order_id) FROM Orders";
                                string queryInsertOrderDetails = "INSERT INTO OrderDetails (order_id, product_id, quantity, price_at_purchase) VALUES (@orderId, @productId, @quantity, @sellingPrice);";

                                SqlCommand cmd = new SqlCommand(queryInsertOrders, connection);
                                cmd.Parameters.AddWithValue("@customerId", customerId);
                                cmd.Parameters.AddWithValue("@employeeId", frmLogin.EMPLOYEE_ID);
                                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                                cmd.Parameters.AddWithValue("@status", statusStr);

                                connection.Open();
                                cmd.ExecuteNonQuery();

                                SqlCommand cmdToSelectOrderId = new SqlCommand(querySelectOrderId, connection);
                                int orderId = (int)cmdToSelectOrderId.ExecuteScalar();

                                SqlCommand cmdToInsertIntoOrderDetails = new SqlCommand(queryInsertOrderDetails, connection);
                                cmdToInsertIntoOrderDetails.Parameters.AddWithValue("@orderId", orderId);
                                cmdToInsertIntoOrderDetails.Parameters.AddWithValue("@productId", productId);
                                cmdToInsertIntoOrderDetails.Parameters.AddWithValue("@quantity", quantity);
                                cmdToInsertIntoOrderDetails.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                                cmdToInsertIntoOrderDetails.ExecuteNonQuery();

                                connection.Close();
                                MessageBox.Show("Successful!", "Successful");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Insufficient inventory to place an order for this product\n"+ "Product ID:" + productId +"\nInventory: " + inventory_quantity, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid product ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }



        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT selling_price FROM Products WHERE product_id=@ProductID";
            string productIdStr = txtProductID.Text.Trim();
            int productId;
            bool isProductId = int.TryParse(productIdStr, out productId);

            if (isProductId)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("ProductID", productId);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            decimal sellingPrice = Convert.ToDecimal(result);
                            _sellingPrice = sellingPrice;
                            txtPrice.Text = sellingPrice.ToString();
                        }
                        else
                        {
                            txtPrice.Text = string.Empty;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
            }
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string quantityStr;
            quantityStr = txtQuantity.Text.Trim();
            decimal quantity;
            bool isQuantity = decimal.TryParse(quantityStr, out quantity);
            if (isQuantity && quantity >0 && _sellingPrice != 0)
            {
                decimal result = quantity * _sellingPrice;
                txtTotalAmount.Text = result.ToString();
                //lblQuantity.ForeColor = Color.LimeGreen;

            }
            else
            {
                //lblQuantity.ForeColor = Color.Tomato;
                txtTotalAmount.Text = string.Empty;
            }
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] statusArr = { "Pending, Processing, Shipped, Delivered, Cancelled, Refunded, Returned, Failed, On hold, Partially Shipped" };
            //string statusStr = cmbStatus.Text;
            //foreach (string status in statusArr)
            //{
            //    if (status != statusStr)
            //    {
            //        lblStatus.ForeColor = Color.Tomato;

                    
            //    }
            //    else
            //    {
            //        lblStatus.ForeColor = Color.LimeGreen;
            //    }
            //}

        }
    }
}
