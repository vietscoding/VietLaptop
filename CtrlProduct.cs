using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLaptop
{
    public partial class CtrlProduct : UserControl
    {
        public static string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        private SqlConnection connection = new SqlConnection(_connectionString);
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public CtrlProduct()
        {
            InitializeComponent();
            //connection = new SqlConnection(_connectionString);
            //dgvProduct.RowTemplate.Height = 80;

            if (frmLogin._employeeRole == "sales")
            {
                btnAddProduct.Visible = false;
                btnDeleteProduct.Visible = false;
                gbEditProductSection.Visible = false;
            }

 

        }

        private void LoadData()
        {
            string query = "SELECT * FROM Products;";
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvProduct.DataSource = dataTable;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            //LoadDgvImage();

        }

        //public void LoadDgvImage()
        //{


        //    string errorImagePath = "C:\\Users\\Acer\\Downloads\\ErrorLaptopImage.png";
        //    Image errorImage = System.IO.File.Exists(errorImagePath) ? Image.FromFile(errorImagePath) : null;
        //    foreach (DataGridViewRow row in dgvProduct.Rows)
        //    {
        //        try
        //        {
        //            if (row.Cells["image_url"].Value != null)
        //            {
        //                string imagePath = row.Cells["image_url"].Value.ToString();
        //                if (System.IO.File.Exists(imagePath))
        //                {
        //                    Image image = Image.FromFile(imagePath);
        //                    row.Cells["image"].Value = image;
        //                }
        //                else
        //                {
        //                    row.Cells["image"].Value = errorImage;
        //                }
        //            }
        //            else
        //            {
        //                row.Cells["image"].Value = errorImage;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //            row.Cells["image"].Value = errorImage;
        //        }
        //    }
        //}

        private void ProductControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private frmAddProduct addProductForm;
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (addProductForm == null || addProductForm.IsDisposed)
            {
                addProductForm = new frmAddProduct();
                addProductForm.FormClosed += (s, args) =>
                {
                    LoadData();
                    addProductForm = null;
                };
                addProductForm.ShowDialog(); // Mở form dưới dạng modal
            }
            else
            {
                addProductForm.BringToFront();
            }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int productID = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        string query = "DECLARE @OrderIDs TABLE (\r\n\torder_id INT\r\n);\r\n\r\nINSERT INTO\t@OrderIDs (order_id)\r\nSELECT order_id\r\nFROM OrderDetails\r\nWHERE product_id=@ProductId;\r\n\r\nDELETE FROM OrderDetails WHERE product_id=@ProductId;\r\n\r\nDELETE FROM Orders WHERE order_id IN (SELECT * FROM @OrderIDs);\r\n\r\n" +
                            "DELETE FROM PurchaseDetails WHERE product_id=@ProductId;\r\n\r\nDELETE FROM Products WHERE product_id=@ProductId;";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ProductId", productID);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!");
                            LoadData();
                        }
                        else { MessageBox.Show("No products found to delete."); }

                    }

                }

            }
            else { MessageBox.Show("Please select the product you want to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtSearchProductID.Text.Length > 0)
                {
                    string productIdStr = txtSearchProductID.Text.Trim();
                    int productId;
                    bool isProductId = int.TryParse(productIdStr, out productId);
                    if (isProductId && productId > 0)
                    {
                        string querySelectProductById = "SELECT * FROM Products WHERE product_id=@productId";
                        using (SqlConnection conn = new SqlConnection(_connectionString))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(querySelectProductById, conn);
                            cmd.Parameters.AddWithValue("@productId", productId);

                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dgvProduct.DataSource = dataTable;
                            conn.Close();

                        }
                    }
                    
                }
                else
                {
                    string productName = txtSearchProductName.Text.Trim();
                    string brand = cmbSearchBrand.Text.Trim();
                    string model = txtSearchModel.Text.Trim();
                    decimal minPrice, maxPrice;
                    int inventory;
                    bool isMinPriceValid = decimal.TryParse(txtSearchMinPrice.Text, out minPrice);
                    bool isMaxPriceValid = decimal.TryParse(txtSearchMaxPrice.Text, out maxPrice);
                    bool isInventory = int.TryParse(txtSearchInventory.Text, out inventory);
                    string description = txtSearchDescription.Text.Trim();

                    string query = "SELECT * FROM Products WHERE 1=1";

                    if (!string.IsNullOrEmpty(productName))
                    { query += " AND product_name LIKE @ProductName"; }
                    if (!string.IsNullOrEmpty(brand))
                    { query += " AND brand LIKE @Brand"; }
                    if (!string.IsNullOrEmpty(model))
                    { query += " AND model LIKE @Model"; }
                    if (isMinPriceValid)
                    { query += " AND selling_price >= @MinPrice"; }
                    if (isMaxPriceValid)
                    { query += " AND selling_price <= @MaxPrice"; }
                    if (isInventory)
                    { query += " AND inventory_quantity = @Inventory"; }
                    //if (isMaxInventoryValid && maxInventory >= minInventory)
                    //{ query += " AND inventory_quantity <= @MaxInventory"; }

                    if (!string.IsNullOrEmpty(description))
                    { query += " AND description LIKE @Description"; }


                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);

                        if (!string.IsNullOrEmpty(productName))
                        { cmd.Parameters.AddWithValue("ProductName", "%" + productName + "%"); }
                        if (!string.IsNullOrEmpty(brand))
                        { cmd.Parameters.AddWithValue("Brand", "%" + brand + "%"); }
                        if (!string.IsNullOrEmpty(model))
                        {
                            cmd.Parameters.AddWithValue("Model", "%" + model + "%");
                        }
                        if (isMinPriceValid)
                        {
                            cmd.Parameters.AddWithValue("MinPrice", minPrice);
                        }
                        if (isMaxPriceValid)
                        {
                            cmd.Parameters.AddWithValue("MaxPrice", maxPrice);
                        }
                        //if (isMinInventoryValid)
                        //{
                        //    cmd.Parameters.AddWithValue("MinInventory", minInventory);

                        if (isInventory)
                        {
                            cmd.Parameters.AddWithValue("Inventory", inventory);
                        }
                        if (!string.IsNullOrEmpty(description))
                        {
                            cmd.Parameters.AddWithValue("Description", "%" + description + "%");
                        }

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvProduct.DataSource = dataTable;
                        connection.Close();
                        //LoadDgvImage();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void EnabledSearchTextBoxesExceptTxtID(bool condition)
        {
            
            txtSearchProductName.Enabled = condition;
            txtSearchModel.Enabled = condition;
            txtSearchMinPrice.Enabled = condition;
            txtSearchMaxPrice.Enabled = condition;
            //txtMinInventory.Enabled = condition;
            txtSearchInventory.Enabled = condition;
            txtSearchDescription.Enabled = condition;
            cmbSearchBrand.Enabled = condition;

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

            if (txtSearchProductID.Text.Trim().Length > 0)
            {
                EnabledSearchTextBoxesExceptTxtID(false);
            }

            else { EnabledSearchTextBoxesExceptTxtID(true); }

        }


        private void btnClearAll_Click(object sender, EventArgs e)
        {

            txtSearchProductID.Text = string.Empty;
            txtSearchProductName.Text = string.Empty;
            txtSearchModel.Text = string.Empty;
            txtSearchMinPrice.Text = string.Empty;
            txtSearchMaxPrice.Text = string.Empty;
            //txtMinInventory.Text = string.Empty;
            txtSearchInventory.Text = string.Empty;
            txtSearchDescription.Text = string.Empty;
            cmbSearchBrand.Text = string.Empty;

        }


        private void txtMinInventory_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtEditProductName_TextChanged(object sender, EventArgs e)
        {

        }


        //private void btnClearEditTextBoxs_Click(object sender, EventArgs e)
        //{

        //    txtEditProductName.Text = string.Empty.Trim();
        //    cmbEditBrand.Text = string.Empty.Trim();
        //    txtEditModel.Text = string.Empty.Trim();
        //    txtEditPrice.Text = string.Empty.Trim();
        //    txtEditInventory.Text = string.Empty.Trim();
        //    txtEditDescription.Text = string.Empty.Trim();
        //    txtEditImageURL.Text = string.Empty.Trim();
        //    picProductImage.Image = Image.FromFile("C:\\Users\\Acer\\source\\repos\\VietLaptop\\Resources\\Google-Noto-Emoji-Objects-62823-laptop-computer.512.png");

        //}

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvProduct.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row header of the product to edit");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditProductName.Text) ||
                    string.IsNullOrWhiteSpace(cmbEditBrand.Text) ||
                    string.IsNullOrWhiteSpace(txtEditModel.Text) ||
                    string.IsNullOrWhiteSpace(txtEditPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtEditInventory.Text) ||
                    string.IsNullOrWhiteSpace(txtEditDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtEditImageURL.Text))
                {
                    MessageBox.Show("Please enter all the necessary information.");
                    return;
                }

                string productIdStr = dgvProduct.SelectedRows[0].Cells["productidDataGridViewTextBoxColumn"].Value.ToString();

                int productId;
                if (!int.TryParse(productIdStr, out productId))
                {
                    MessageBox.Show("Invalid Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double price;
                if (!double.TryParse(txtEditPrice.Text.Trim(), out price))
                {
                    MessageBox.Show("Invalid product price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                                UPDATE Products 
                                SET 
                                    product_name = @product_name, 
                                    brand = @brand, 
                                    model = @model, 
                                    selling_price = @selling_price, 
                                    inventory_quantity = @inventory_quantity, 
                                    description = @description,
                                    image_url = @image_url,
                                    update_at = GETDATE()
                                WHERE product_id = @product_id;
                            ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@product_name", txtEditProductName.Text);
                            cmd.Parameters.AddWithValue("@brand", cmbEditBrand.Text);
                            cmd.Parameters.AddWithValue("@model", txtEditModel.Text);
                            cmd.Parameters.AddWithValue("@selling_price", Convert.ToDecimal(txtEditPrice.Text.Trim()));
                            cmd.Parameters.AddWithValue("@inventory_quantity", Convert.ToInt32(txtEditInventory.Text));
                            cmd.Parameters.AddWithValue("@description", txtEditDescription.Text);
                            cmd.Parameters.AddWithValue("@image_url", txtEditImageURL.Text);
                            cmd.Parameters.AddWithValue("@product_id", productId);

                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Successful product update!");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No product found to update.");
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
            catch (Exception ex)
            {
                MessageBox.Show("Erorr: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picProductImage.Image = Image.FromFile(openFileDialog1.FileName);
                txtEditImageURL.Text = (openFileDialog1.FileName).ToString();
            }
        }

        private void ProductControl_Load_1(object sender, EventArgs e)
        {
            LoadData();
            dgvProduct.ReadOnly = true;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];
                        txtEditProductName.Text = selectedRow.Cells["productnameDataGridViewTextBoxColumn"].Value.ToString();
                        cmbEditBrand.Text = selectedRow.Cells["brandDataGridViewTextBoxColumn"].Value.ToString();
                        txtEditModel.Text = selectedRow.Cells["modelDataGridViewTextBoxColumn"].Value.ToString();
                        txtEditPrice.Text = selectedRow.Cells["sellingpriceDataGridViewTextBoxColumn"].Value.ToString();
                        txtEditInventory.Text = selectedRow.Cells["inventoryquantityDataGridViewTextBoxColumn"].Value.ToString();
                        txtEditDescription.Text = selectedRow.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                        txtEditImageURL.Text = selectedRow.Cells["image_url"].Value.ToString();
                        string imagePath = txtEditImageURL.Text;
                        if (System.IO.File.Exists(imagePath))
                        {
                            picProductImage.Image = Image.FromFile(txtEditImageURL.Text);
                        }
                        else
                        {
                            picProductImage.Image = Image.FromFile("C:\\Users\\Acer\\Downloads\\ErrorLaptopImage.png");
                        }
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

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}