using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string _connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public ProductControl()
        {
            InitializeComponent();
            connection = new SqlConnection(_connectionString);
            LoadData();
            dgvProduct.ReadOnly = true;

        }

        public void LoadData()
        {
            string query = "SELECT * FROM Products;";
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvProduct.DataSource = dataTable;
             
            foreach (DataRow row in dataTable.Rows)
            {
                string imagePath = row["image_url"].ToString();
                Image productImage = null;

                // Kiểm tra xem file ảnh có tồn tại không
                if (File.Exists(imagePath))
                {
                    productImage = Image.FromFile(imagePath);
                }
                else
                {
                    productImage = Properties.Resources.Google_Noto_Emoji_Objects_62823_laptop_computer_72;
                }

                // Thêm dữ liệu vào DataGridView
                // dgvProduct.Rows.Add(productImage, row["product_name"], row["brand"], row["model"], row["selling_price"], row["inventory_quantity"], row["description"]);
            }


        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private frmAddProduct addProductForm;
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //frmAddProduct frmAddProduct = new frmAddProduct();
            //frmAddProduct.ShowDialog();
            //LoadData();

            //frmAddProduct addProductForm = new frmAddProduct();
            //addProductForm.FormClosed += (s, args) => LoadData(); 
            //addProductForm.Show();
            if (addProductForm == null || addProductForm.IsDisposed)
            {
                addProductForm = new frmAddProduct();
                addProductForm.FormClosed += (s, args) =>
                {
                    // Cập nhật dữ liệu khi form đóng và đặt biến về null
                    LoadData();
                    addProductForm = null;
                };
                addProductForm.ShowDialog(); // Mở form dưới dạng modal
            }
            else
            {
                // Đưa form addProductForm lên foreground nếu đã mở trước đó
                addProductForm.BringToFront();
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
            //string Id = txtProductID.Text.Trim();
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
            {
                query += " AND product_name LIKE @ProductName";
            }
            if (!string.IsNullOrEmpty(brand))
            {
                query += " AND brand LIKE @Brand";
            }
            if (!string.IsNullOrEmpty(model))
            {
                query += " AND model LIKE @Model";
            }
            if (isMinPriceValid)
            {
                query += " AND selling_price <= @MinPrice";
            }
            if (isMaxPriceValid)
            {
                query += " AND selling_price <= @MaxPrice";
            }
            if (isMinInventoryValid)
            {
                query += " AND inventory_quantity <= @MinInventory";
            }
            if (isMaxInventoryValid && maxInventory >= minInventory)
            {
                query += " AND inventory_quantity <= @MaxInventory";
            }
           
            if (!string.IsNullOrEmpty(description))
            {
                query += " AND description LIKE @Description";
            }
            
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                if (!string.IsNullOrEmpty(productName))
                {
                    cmd.Parameters.AddWithValue("ProductName", "%" + productName + "%");
                }
                if (!string.IsNullOrEmpty(brand))
                {
                    cmd.Parameters.AddWithValue("Brand", "%" + brand + "%");
                }
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
                    cmd.Parameters.AddWithValue("MaxPrice",  maxPrice);
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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void txtMinInventory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}