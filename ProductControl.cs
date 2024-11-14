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
    public partial class ProductControl : UserControl
    {
        public static string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public ProductControl()
        {
            InitializeComponent();
            connection = new SqlConnection(_connectionString);
            LoadData();
            dgvProduct.ReadOnly = true;

            
            var imgColumn = dgvProduct.Columns["image"] as DataGridViewColumn;
            if (imgColumn != null )
            {
                imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvProduct.RowTemplate.Height = 100;

        }

        public void LoadData()
        {
            string query = "SELECT * FROM Products;";
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvProduct.DataSource = dataTable;

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells["image_url"].Value != null)
                {
                    string imagePath = row.Cells["image_url"].Value.ToString();
                    if (System.IO.File.Exists(imagePath))
                    {
                        Image image = Image.FromFile(imagePath);
                        row.Cells["image"].Value = image;
                    }
                    else
                    {
                        Image errorImage = Image.FromFile("C:\\Users\\Acer\\Downloads\\ErrorLaptopImage.png");
                    }
                }
            }
        }

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];
                txtEditProductName.Text = selectedRow.Cells["productnameDataGridViewTextBoxColumn"].Value.ToString();
                cmbEditBrand.Text = selectedRow.Cells["brandDataGridViewTextBoxColumn"].Value.ToString();
                txtEditModel.Text = selectedRow.Cells["modelDataGridViewTextBoxColumn"].Value.ToString();
                txtEditPrice.Text = selectedRow.Cells["sellingpriceDataGridViewTextBoxColumn"].Value.ToString();
                txtEditInventory.Text = selectedRow.Cells["inventoryquantityDataGridViewTextBoxColumn"].Value.ToString();
                txtEditDescription.Text = selectedRow.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                txtEditImageURL.Text = selectedRow.Cells["image_url"].Value.ToString();
                picProductImage.Image = Image.FromFile(txtEditImageURL.Text);
            }
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
                        string query = "DELETE FROM Products WHERE product_id = @ProductID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ProductID", productID);

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
            string productName = txtProductName.Text.Trim();
            string brand = cmbBrand.Text.Trim();
            string model = txtModel.Text.Trim();
            decimal minPrice, maxPrice;
            int minInventory, maxInventory;

            bool isMinPriceValid = decimal.TryParse(txtMinPrice.Text, out minPrice);
            bool isMaxPriceValid = decimal.TryParse(txtMaxPrice.Text, out maxPrice);
            bool isMinInventoryValid = int.TryParse(txtMinInventory.Text, out minInventory);
            bool isMaxInventoryValid = int.TryParse(txtMaxInventory.Text, out maxInventory);
            string description = txtDescription.Text.Trim();

            string query = "SELECT * FROM Products WHERE 1=1";

            if (!string.IsNullOrEmpty(productName))
            { query += " AND product_name LIKE @ProductName"; }
            if (!string.IsNullOrEmpty(brand))
            { query += " AND brand LIKE @Brand"; }
            if (!string.IsNullOrEmpty(model))
            { query += " AND model LIKE @Model"; }
            if (isMinPriceValid)
            { query += " AND selling_price <= @MinPrice"; }
            if (isMaxPriceValid)
            { query += " AND selling_price <= @MaxPrice"; }
            if (isMinInventoryValid)
            { query += " AND inventory_quantity <= @MinInventory"; }
            if (isMaxInventoryValid && maxInventory >= minInventory)
            { query += " AND inventory_quantity <= @MaxInventory"; }

            if (!string.IsNullOrEmpty(description))
            { query += " AND description LIKE @Description"; }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
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
                if (isMinInventoryValid)
                {
                    cmd.Parameters.AddWithValue("MinInventory", minInventory);
                }
                if (isMaxInventoryValid) 
                {
                    cmd.Parameters.AddWithValue("MaxInventory", maxInventory);
                }
                if (!string.IsNullOrEmpty(description))
                {
                    cmd.Parameters.AddWithValue("Description", "%" + description + "%");
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvProduct.DataSource = dataTable;

            }

        }


        private void EnabledSearchTextBoxs(bool condition)
        {
            
            txtProductName.Enabled = condition;
            txtModel.Enabled = condition;
            txtMinPrice.Enabled = condition;
            txtMaxPrice.Enabled = condition;
            txtMinInventory.Enabled = condition;
            txtMaxInventory.Enabled = condition;
            txtDescription.Enabled = condition;
            cmbBrand.Enabled = condition;

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

            if (txtProductID.Text.Trim().Length > 0)
            {
                EnabledSearchTextBoxs(false);
            }

            else { EnabledSearchTextBoxs(true); }

        }


        private void btnClearAll_Click(object sender, EventArgs e)
        {

            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtMinPrice.Text = string.Empty;
            txtMaxPrice.Text = string.Empty;
            txtMinInventory.Text = string.Empty;
            txtMaxInventory.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cmbBrand.Text = string.Empty;

        }


        private void txtMinInventory_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtEditProductName_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnClearEditTextBoxs_Click(object sender, EventArgs e)
        {

            txtEditProductName.Text = string.Empty.Trim();
            cmbEditBrand.Text = string.Empty.Trim();
            txtEditModel.Text = string.Empty.Trim();
            txtEditPrice.Text = string.Empty.Trim();
            txtEditInventory.Text = string.Empty.Trim();
            txtEditDescription.Text = string.Empty.Trim();
            txtEditImageURL.Text = string.Empty.Trim();
            picProductImage.Image = Image.FromFile("C:\\Users\\Acer\\source\\repos\\VietLaptop\\Resources\\Google-Noto-Emoji-Objects-62823-laptop-computer.512.png");

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit");
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

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@product_name", txtEditProductName.Text);
                    command.Parameters.AddWithValue("@brand", cmbEditBrand.Text);
                    command.Parameters.AddWithValue("@model", txtEditModel.Text);
                    command.Parameters.AddWithValue("@selling_price", Convert.ToDecimal(txtEditPrice.Text));
                    command.Parameters.AddWithValue("@inventory_quantity", Convert.ToInt32(txtEditInventory.Text));
                    command.Parameters.AddWithValue("@description", txtEditDescription.Text);
                    command.Parameters.AddWithValue("@image_url", txtEditImageURL.Text);
                    command.Parameters.AddWithValue("@product_id", productId);
                    
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

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

    }
}