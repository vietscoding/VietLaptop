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
    public partial class frmAddProduct : Form
    {
        private string connectionString = "Data Source=VIETDOAN\\SQLEXPRESS;Initial Catalog=VietLaptopStore;Integrated Security=True;";

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string brand = txtProductBrand.Text;
            string model = txtProductModel.Text;
            string priceString = txtProductPrice.Text;
            decimal price = 0;
            // decimal price = Convert.ToDecimal(priceString);
            decimal.TryParse(priceString, out price);
            // object inventory = Convert.ToInt32(txtProductInventoryQuantity.Text);
            string inventoryString = txtProductInventoryQuantity.Text;
            int inventory = 0;
            int.TryParse(inventoryString, out inventory);
            string description = txtProductDescription.Text;
            string imageURL = txtProductImageURL.Text;

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Invalid product name!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                
                txtProductName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show("Invalid product brand!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtProductBrand.Focus();
            }
            else if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Invalid product model!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtProductModel.Focus();
            }
            else if (string.IsNullOrWhiteSpace(priceString))
            {
                MessageBox.Show("Invalid product price!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtProductPrice.Focus();
            }
            else if (price == 0)
            {
                MessageBox.Show("Invalid product price! Require a number",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtProductPrice.Focus();
            }
            else if (inventory == 0)
            {
                MessageBox.Show("Invalid inventory quantity number! Require a number",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Invalid description!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtProductDescription.Focus();
            }
            else if (string.IsNullOrWhiteSpace(imageURL))
            {
                MessageBox.Show("Invalid product image URL!",
                                "Error Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtProductImageURL.Focus();
            } //////////////////////////////////////////////
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Products (product_name, brand, model, selling_price, inventory_quantity, description, image_url) VALUES (@ProductName, @Brand, @Model, @Price, @Inventory, @Description, @Image)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Inventory", inventory);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Image", imageURL);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Add a new product successful!",
                                "Successful!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    
                }
            }

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
            txtProductBrand.Text = string.Empty;
            txtProductModel.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductInventoryQuantity.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtProductImageURL.Text = string.Empty;
            txtProductName.Focus();
            picImage.Image = Image.FromFile("C:\\Users\\Acer\\source\\repos\\VietLaptop\\Resources\\Google-Noto-Emoji-Objects-62823-laptop-computer.512.png");

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(openFileDialog1.FileName);
                txtProductImageURL.Text = (openFileDialog1.FileName).ToString();
            }
        }
    }
}
