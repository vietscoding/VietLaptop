using System.Windows.Forms;

namespace VietLaptop
{
    partial class CtrlProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vietLaptopStoreDataSet = new VietLaptop.VietLaptopStoreDataSet();
            this.productsTableAdapter = new VietLaptop.VietLaptopStoreDataSetTableAdapters.ProductsTableAdapter();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.txtSearchModel = new System.Windows.Forms.TextBox();
            this.txtSearchMinPrice = new System.Windows.Forms.TextBox();
            this.txtSearchMaxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchInventory = new System.Windows.Forms.TextBox();
            this.txtSearchDescription = new System.Windows.Forms.TextBox();
            this.cmbSearchBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditProductName = new System.Windows.Forms.TextBox();
            this.txtEditModel = new System.Windows.Forms.TextBox();
            this.cmbEditBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.txtEditInventory = new System.Windows.Forms.TextBox();
            this.txtEditImageURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.btnClearAllSearchTextBoxs = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.gbEditProductSection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbEditProductSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.vietLaptopStoreDataSet;
            // 
            // vietLaptopStoreDataSet
            // 
            this.vietLaptopStoreDataSet.DataSetName = "VietLaptopStoreDataSet";
            this.vietLaptopStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductName.Location = new System.Drawing.Point(142, 128);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(274, 27);
            this.txtSearchProductName.TabIndex = 2;
            this.txtSearchProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchModel.Location = new System.Drawing.Point(548, 127);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(278, 27);
            this.txtSearchModel.TabIndex = 4;
            // 
            // txtSearchMinPrice
            // 
            this.txtSearchMinPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMinPrice.Location = new System.Drawing.Point(832, 128);
            this.txtSearchMinPrice.Name = "txtSearchMinPrice";
            this.txtSearchMinPrice.Size = new System.Drawing.Size(105, 27);
            this.txtSearchMinPrice.TabIndex = 5;
            this.txtSearchMinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchMaxPrice
            // 
            this.txtSearchMaxPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaxPrice.Location = new System.Drawing.Point(952, 128);
            this.txtSearchMaxPrice.Name = "txtSearchMaxPrice";
            this.txtSearchMaxPrice.Size = new System.Drawing.Size(101, 27);
            this.txtSearchMaxPrice.TabIndex = 6;
            this.txtSearchMaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(828, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(948, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max";
            // 
            // txtSearchInventory
            // 
            this.txtSearchInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInventory.Location = new System.Drawing.Point(1059, 128);
            this.txtSearchInventory.Name = "txtSearchInventory";
            this.txtSearchInventory.Size = new System.Drawing.Size(112, 27);
            this.txtSearchInventory.TabIndex = 7;
            this.txtSearchInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchDescription
            // 
            this.txtSearchDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDescription.Location = new System.Drawing.Point(1177, 128);
            this.txtSearchDescription.Name = "txtSearchDescription";
            this.txtSearchDescription.Size = new System.Drawing.Size(347, 27);
            this.txtSearchDescription.TabIndex = 8;
            // 
            // cmbSearchBrand
            // 
            this.cmbSearchBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchBrand.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbSearchBrand.FormattingEnabled = true;
            this.cmbSearchBrand.Items.AddRange(new object[] {
            "Apple",
            "Dell",
            "HP",
            "Lenovo",
            "Asus",
            "Acer",
            "MSI",
            "Microsoft",
            "Samsung",
            "LG"});
            this.cmbSearchBrand.Location = new System.Drawing.Point(422, 127);
            this.cmbSearchBrand.Name = "cmbSearchBrand";
            this.cmbSearchBrand.Size = new System.Drawing.Size(120, 27);
            this.cmbSearchBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 63);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product Manager";
            // 
            // txtEditProductName
            // 
            this.txtEditProductName.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditProductName.Location = new System.Drawing.Point(43, 43);
            this.txtEditProductName.Name = "txtEditProductName";
            this.txtEditProductName.Size = new System.Drawing.Size(142, 23);
            this.txtEditProductName.TabIndex = 11;
            this.txtEditProductName.TextChanged += new System.EventHandler(this.txtEditProductName_TextChanged);
            // 
            // txtEditModel
            // 
            this.txtEditModel.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModel.Location = new System.Drawing.Point(343, 43);
            this.txtEditModel.Name = "txtEditModel";
            this.txtEditModel.Size = new System.Drawing.Size(147, 23);
            this.txtEditModel.TabIndex = 13;
            // 
            // cmbEditBrand
            // 
            this.cmbEditBrand.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditBrand.FormattingEnabled = true;
            this.cmbEditBrand.Items.AddRange(new object[] {
            "Apple",
            "Dell",
            "HP",
            "Lenovo",
            "Asus",
            "Acer",
            "MSI",
            "Microsoft",
            "Samsung",
            "LG"});
            this.cmbEditBrand.Location = new System.Drawing.Point(191, 41);
            this.cmbEditBrand.Name = "cmbEditBrand";
            this.cmbEditBrand.Size = new System.Drawing.Size(145, 25);
            this.cmbEditBrand.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Name";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrice.Location = new System.Drawing.Point(496, 43);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(146, 23);
            this.txtEditPrice.TabIndex = 14;
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDescription.Location = new System.Drawing.Point(43, 98);
            this.txtEditDescription.Multiline = true;
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(293, 44);
            this.txtEditDescription.TabIndex = 16;
            // 
            // txtEditInventory
            // 
            this.txtEditInventory.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditInventory.Location = new System.Drawing.Point(648, 43);
            this.txtEditInventory.Name = "txtEditInventory";
            this.txtEditInventory.Size = new System.Drawing.Size(113, 23);
            this.txtEditInventory.TabIndex = 15;
            // 
            // txtEditImageURL
            // 
            this.txtEditImageURL.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditImageURL.Location = new System.Drawing.Point(345, 98);
            this.txtEditImageURL.Multiline = true;
            this.txtEditImageURL.Name = "txtEditImageURL";
            this.txtEditImageURL.Size = new System.Drawing.Size(297, 44);
            this.txtEditImageURL.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Inventory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(341, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Image Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Violet;
            this.btnUploadImage.FlatAppearance.BorderSize = 2;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Upload_32;
            this.btnUploadImage.Location = new System.Drawing.Point(711, 76);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(50, 69);
            this.btnUploadImage.TabIndex = 19;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // picProductImage
            // 
            this.picProductImage.Image = global::VietLaptop.Properties.Resources.Google_Noto_Emoji_Objects_62823_laptop_computer_512;
            this.picProductImage.Location = new System.Drawing.Point(1059, 738);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(222, 138);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductImage.TabIndex = 25;
            this.picProductImage.TabStop = false;
            // 
            // btnClearAllSearchTextBoxs
            // 
            this.btnClearAllSearchTextBoxs.BackColor = System.Drawing.Color.Orange;
            this.btnClearAllSearchTextBoxs.FlatAppearance.BorderSize = 2;
            this.btnClearAllSearchTextBoxs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllSearchTextBoxs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSearchTextBoxs.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Restart_32;
            this.btnClearAllSearchTextBoxs.Location = new System.Drawing.Point(1530, 123);
            this.btnClearAllSearchTextBoxs.Name = "btnClearAllSearchTextBoxs";
            this.btnClearAllSearchTextBoxs.Size = new System.Drawing.Size(64, 32);
            this.btnClearAllSearchTextBoxs.TabIndex = 9;
            this.btnClearAllSearchTextBoxs.UseVisualStyleBackColor = false;
            this.btnClearAllSearchTextBoxs.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Yellow;
            this.btnEditProduct.FlatAppearance.BorderSize = 2;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.Image = global::VietLaptop.Properties.Resources.Picol_Picol_Edit2;
            this.btnEditProduct.Location = new System.Drawing.Point(648, 76);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(53, 69);
            this.btnEditProduct.TabIndex = 18;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::VietLaptop.Properties.Resources.Custom_Icon_Design_Mono_General_2_Search_32;
            this.btnSearch.Location = new System.Drawing.Point(1530, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 180);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 2;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteProduct.Image = global::VietLaptop.Properties.Resources.Pixelkit_Gentle_Edges_Trash_32;
            this.btnDeleteProduct.Location = new System.Drawing.Point(1530, 533);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(64, 180);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddProduct.FlatAppearance.BorderSize = 2;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Plus_box_32;
            this.btnAddProduct.Location = new System.Drawing.Point(1530, 347);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(64, 180);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 30;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.sellingpriceDataGridViewTextBoxColumn,
            this.inventoryquantityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.image_url,
            this.createdatDataGridViewTextBoxColumn,
            this.updateatDataGridViewTextBoxColumn,
            this.image});
            this.dgvProduct.DataSource = this.productsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.GridColor = System.Drawing.Color.MintCream;
            this.dgvProduct.Location = new System.Drawing.Point(26, 161);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.Size = new System.Drawing.Size(1498, 552);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.FillWeight = 30F;
            this.productidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.FillWeight = 122.767F;
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.FillWeight = 52.52065F;
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.FillWeight = 122.767F;
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingpriceDataGridViewTextBoxColumn
            // 
            this.sellingpriceDataGridViewTextBoxColumn.DataPropertyName = "selling_price";
            this.sellingpriceDataGridViewTextBoxColumn.FillWeight = 98.35934F;
            this.sellingpriceDataGridViewTextBoxColumn.HeaderText = "Price (USD)";
            this.sellingpriceDataGridViewTextBoxColumn.Name = "sellingpriceDataGridViewTextBoxColumn";
            this.sellingpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryquantityDataGridViewTextBoxColumn
            // 
            this.inventoryquantityDataGridViewTextBoxColumn.DataPropertyName = "inventory_quantity";
            this.inventoryquantityDataGridViewTextBoxColumn.FillWeight = 50F;
            this.inventoryquantityDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inventoryquantityDataGridViewTextBoxColumn.Name = "inventoryquantityDataGridViewTextBoxColumn";
            this.inventoryquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 150F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // image_url
            // 
            this.image_url.DataPropertyName = "image_url";
            this.image_url.FillWeight = 117.7991F;
            this.image_url.HeaderText = "image_url";
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Visible = false;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateatDataGridViewTextBoxColumn
            // 
            this.updateatDataGridViewTextBoxColumn.DataPropertyName = "update_at";
            this.updateatDataGridViewTextBoxColumn.HeaderText = "update_at";
            this.updateatDataGridViewTextBoxColumn.Name = "updateatDataGridViewTextBoxColumn";
            this.updateatDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateatDataGridViewTextBoxColumn.Visible = false;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.FillWeight = 122.767F;
            this.image.HeaderText = "Image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.MinimumWidth = 100;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.Visible = false;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductID.Location = new System.Drawing.Point(69, 128);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(67, 27);
            this.txtSearchProductID.TabIndex = 1;
            this.txtSearchProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // gbEditProductSection
            // 
            this.gbEditProductSection.Controls.Add(this.btnUploadImage);
            this.gbEditProductSection.Controls.Add(this.btnEditProduct);
            this.gbEditProductSection.Controls.Add(this.txtEditProductName);
            this.gbEditProductSection.Controls.Add(this.label4);
            this.gbEditProductSection.Controls.Add(this.txtEditModel);
            this.gbEditProductSection.Controls.Add(this.label12);
            this.gbEditProductSection.Controls.Add(this.txtEditPrice);
            this.gbEditProductSection.Controls.Add(this.label8);
            this.gbEditProductSection.Controls.Add(this.txtEditDescription);
            this.gbEditProductSection.Controls.Add(this.label11);
            this.gbEditProductSection.Controls.Add(this.txtEditImageURL);
            this.gbEditProductSection.Controls.Add(this.label5);
            this.gbEditProductSection.Controls.Add(this.txtEditInventory);
            this.gbEditProductSection.Controls.Add(this.label3);
            this.gbEditProductSection.Controls.Add(this.cmbEditBrand);
            this.gbEditProductSection.Controls.Add(this.label1);
            this.gbEditProductSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditProductSection.Location = new System.Drawing.Point(283, 719);
            this.gbEditProductSection.Name = "gbEditProductSection";
            this.gbEditProductSection.Size = new System.Drawing.Size(770, 162);
            this.gbEditProductSection.TabIndex = 26;
            this.gbEditProductSection.TabStop = false;
            this.gbEditProductSection.Text = "Edit Section";
            // 
            // CtrlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picProductImage);
            this.Controls.Add(this.gbEditProductSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearAllSearchTextBoxs);
            this.Controls.Add(this.cmbSearchBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchProductName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchInventory);
            this.Controls.Add(this.txtSearchMaxPrice);
            this.Controls.Add(this.txtSearchMinPrice);
            this.Controls.Add(this.txtSearchDescription);
            this.Controls.Add(this.txtSearchModel);
            this.Controls.Add(this.txtSearchProductID);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvProduct);
            this.Name = "CtrlProduct";
            this.Size = new System.Drawing.Size(1623, 884);
            this.Load += new System.EventHandler(this.ProductControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbEditProductSection.ResumeLayout(false);
            this.gbEditProductSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productsBindingSource;
        private VietLaptopStoreDataSet vietLaptopStoreDataSet;
        private VietLaptopStoreDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchProductName;
        private System.Windows.Forms.TextBox txtSearchModel;
        private System.Windows.Forms.TextBox txtSearchMinPrice;
        private System.Windows.Forms.TextBox txtSearchMaxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchInventory;
        private System.Windows.Forms.TextBox txtSearchDescription;
        private System.Windows.Forms.ComboBox cmbSearchBrand;
        private System.Windows.Forms.Button btnClearAllSearchTextBoxs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.TextBox txtEditProductName;
        private System.Windows.Forms.TextBox txtEditModel;
        private System.Windows.Forms.ComboBox cmbEditBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.TextBox txtEditInventory;
        private System.Windows.Forms.TextBox txtEditImageURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private PictureBox picProductImage;
        private Button btnUploadImage;
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellingpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inventoryquantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn image_url;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateatDataGridViewTextBoxColumn;
        private DataGridViewImageColumn image;
        private TextBox txtSearchProductID;
        private GroupBox gbEditProductSection;
    }
}
