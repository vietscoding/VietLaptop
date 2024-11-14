namespace VietLaptop
{
    partial class frmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInventoryQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductBrand = new System.Windows.Forms.TextBox();
            this.txtProductModel = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductInventoryQuantity = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductImageURL = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(172, 37);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(289, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price (VND)";
            // 
            // lblInventoryQuantity
            // 
            this.lblInventoryQuantity.AutoSize = true;
            this.lblInventoryQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryQuantity.Location = new System.Drawing.Point(19, 206);
            this.lblInventoryQuantity.Name = "lblInventoryQuantity";
            this.lblInventoryQuantity.Size = new System.Drawing.Size(149, 19);
            this.lblInventoryQuantity.TabIndex = 1;
            this.lblInventoryQuantity.Text = "Inventory Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Image path";
            // 
            // txtProductBrand
            // 
            this.txtProductBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBrand.Location = new System.Drawing.Point(172, 73);
            this.txtProductBrand.MaxLength = 100;
            this.txtProductBrand.Name = "txtProductBrand";
            this.txtProductBrand.Size = new System.Drawing.Size(289, 26);
            this.txtProductBrand.TabIndex = 2;
            // 
            // txtProductModel
            // 
            this.txtProductModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductModel.Location = new System.Drawing.Point(172, 114);
            this.txtProductModel.MaxLength = 100;
            this.txtProductModel.Name = "txtProductModel";
            this.txtProductModel.Size = new System.Drawing.Size(289, 26);
            this.txtProductModel.TabIndex = 3;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(172, 158);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(289, 26);
            this.txtProductPrice.TabIndex = 4;
            // 
            // txtProductInventoryQuantity
            // 
            this.txtProductInventoryQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductInventoryQuantity.Location = new System.Drawing.Point(172, 203);
            this.txtProductInventoryQuantity.Name = "txtProductInventoryQuantity";
            this.txtProductInventoryQuantity.Size = new System.Drawing.Size(289, 26);
            this.txtProductInventoryQuantity.TabIndex = 5;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(172, 244);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(289, 26);
            this.txtProductDescription.TabIndex = 6;
            // 
            // txtProductImageURL
            // 
            this.txtProductImageURL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductImageURL.Location = new System.Drawing.Point(172, 289);
            this.txtProductImageURL.Name = "txtProductImageURL";
            this.txtProductImageURL.Size = new System.Drawing.Size(289, 26);
            this.txtProductImageURL.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancel.Location = new System.Drawing.Point(366, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.BackColor = System.Drawing.Color.Yellow;
            this.btnClearText.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearText.ForeColor = System.Drawing.Color.Black;
            this.btnClearText.Location = new System.Drawing.Point(366, 413);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(96, 39);
            this.btnClearText.TabIndex = 9;
            this.btnClearText.Text = "Clear";
            this.btnClearText.UseVisualStyleBackColor = false;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Location = new System.Drawing.Point(365, 514);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(96, 54);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Image";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(24, 364);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(315, 204);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 11;
            this.picImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUploadImage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUploadImage.Location = new System.Drawing.Point(365, 364);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(96, 37);
            this.btnUploadImage.TabIndex = 8;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 591);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInventoryQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductImageURL);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductInventoryQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductModel);
            this.Controls.Add(this.txtProductBrand);
            this.Controls.Add(this.txtProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInventoryQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductBrand;
        private System.Windows.Forms.TextBox txtProductModel;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductInventoryQuantity;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductImageURL;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUploadImage;
    }
}