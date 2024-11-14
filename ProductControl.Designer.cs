using System.Windows.Forms;

namespace VietLaptop
{
    partial class ProductControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vietLaptopStoreDataSet = new VietLaptop.VietLaptopStoreDataSet();
            this.productsTableAdapter = new VietLaptop.VietLaptopStoreDataSetTableAdapters.ProductsTableAdapter();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinInventory = new System.Windows.Forms.TextBox();
            this.txtMaxInventory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.btnClearAllSearchTextBoxs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
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
            this.label13 = new System.Windows.Forms.Label();
            this.btnClearEditTextBoxs = new System.Windows.Forms.Button();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.image_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.sellingpriceDataGridViewTextBoxColumn,
            this.inventoryquantityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.image,
            this.image_url,
            this.createdatDataGridViewTextBoxColumn,
            this.updateatDataGridViewTextBoxColumn});
            this.dgvProduct.DataSource = this.productsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.GridColor = System.Drawing.Color.MintCream;
            this.dgvProduct.Location = new System.Drawing.Point(26, 161);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.Size = new System.Drawing.Size(1568, 552);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
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
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(69, 128);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(146, 27);
            this.txtProductID.TabIndex = 5;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(227, 128);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(142, 27);
            this.txtProductName.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(527, 128);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(147, 27);
            this.txtModel.TabIndex = 5;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinPrice.Location = new System.Drawing.Point(680, 128);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(69, 27);
            this.txtMinPrice.TabIndex = 5;
            this.txtMinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPrice.Location = new System.Drawing.Point(752, 128);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(74, 27);
            this.txtMaxPrice.TabIndex = 5;
            this.txtMaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max";
            // 
            // txtMinInventory
            // 
            this.txtMinInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinInventory.Location = new System.Drawing.Point(832, 128);
            this.txtMinInventory.Name = "txtMinInventory";
            this.txtMinInventory.Size = new System.Drawing.Size(69, 27);
            this.txtMinInventory.TabIndex = 5;
            this.txtMinInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinInventory.TextChanged += new System.EventHandler(this.txtMinInventory_TextChanged);
            // 
            // txtMaxInventory
            // 
            this.txtMaxInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxInventory.Location = new System.Drawing.Point(905, 128);
            this.txtMaxInventory.Name = "txtMaxInventory";
            this.txtMaxInventory.Size = new System.Drawing.Size(75, 27);
            this.txtMaxInventory.TabIndex = 5;
            this.txtMaxInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(828, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(901, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Max";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(986, 128);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(147, 27);
            this.txtDescription.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::VietLaptop.Properties.Resources.Custom_Icon_Design_Mono_General_2_Search_32;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1290, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 49);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 2;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteProduct.Image = global::VietLaptop.Properties.Resources.Pixelkit_Gentle_Edges_Trash_32;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(1433, 106);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(161, 49);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "DELETE";
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
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(35, 796);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(147, 47);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbBrand
            // 
            this.cmbBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBrand.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
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
            this.cmbBrand.Location = new System.Drawing.Point(375, 128);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(145, 27);
            this.cmbBrand.TabIndex = 17;
            // 
            // btnClearAllSearchTextBoxs
            // 
            this.btnClearAllSearchTextBoxs.BackColor = System.Drawing.Color.HotPink;
            this.btnClearAllSearchTextBoxs.FlatAppearance.BorderSize = 2;
            this.btnClearAllSearchTextBoxs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllSearchTextBoxs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSearchTextBoxs.Location = new System.Drawing.Point(1152, 106);
            this.btnClearAllSearchTextBoxs.Name = "btnClearAllSearchTextBoxs";
            this.btnClearAllSearchTextBoxs.Size = new System.Drawing.Size(123, 49);
            this.btnClearAllSearchTextBoxs.TabIndex = 18;
            this.btnClearAllSearchTextBoxs.Text = "CLEAR";
            this.btnClearAllSearchTextBoxs.UseVisualStyleBackColor = false;
            this.btnClearAllSearchTextBoxs.Click += new System.EventHandler(this.btnClearAll_Click);
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
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Yellow;
            this.btnEditProduct.FlatAppearance.BorderSize = 2;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.Image = global::VietLaptop.Properties.Resources.Picol_Picol_Edit2;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(1467, 796);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(127, 46);
            this.btnEditProduct.TabIndex = 13;
            this.btnEditProduct.Text = "SAVE";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // txtEditProductName
            // 
            this.txtEditProductName.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditProductName.Location = new System.Drawing.Point(144, 754);
            this.txtEditProductName.Name = "txtEditProductName";
            this.txtEditProductName.Size = new System.Drawing.Size(142, 23);
            this.txtEditProductName.TabIndex = 21;
            this.txtEditProductName.TextChanged += new System.EventHandler(this.txtEditProductName_TextChanged);
            // 
            // txtEditModel
            // 
            this.txtEditModel.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModel.Location = new System.Drawing.Point(444, 754);
            this.txtEditModel.Name = "txtEditModel";
            this.txtEditModel.Size = new System.Drawing.Size(147, 23);
            this.txtEditModel.TabIndex = 21;
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
            this.cmbEditBrand.Location = new System.Drawing.Point(292, 752);
            this.cmbEditBrand.Name = "cmbEditBrand";
            this.cmbEditBrand.Size = new System.Drawing.Size(145, 25);
            this.cmbEditBrand.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 732);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Name";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrice.Location = new System.Drawing.Point(597, 754);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(146, 23);
            this.txtEditPrice.TabIndex = 21;
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDescription.Location = new System.Drawing.Point(903, 754);
            this.txtEditDescription.Multiline = true;
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(213, 86);
            this.txtEditDescription.TabIndex = 21;
            // 
            // txtEditInventory
            // 
            this.txtEditInventory.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditInventory.Location = new System.Drawing.Point(749, 754);
            this.txtEditInventory.Name = "txtEditInventory";
            this.txtEditInventory.Size = new System.Drawing.Size(148, 23);
            this.txtEditInventory.TabIndex = 21;
            // 
            // txtEditImageURL
            // 
            this.txtEditImageURL.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditImageURL.Location = new System.Drawing.Point(1134, 754);
            this.txtEditImageURL.Multiline = true;
            this.txtEditImageURL.Name = "txtEditImageURL";
            this.txtEditImageURL.Size = new System.Drawing.Size(195, 86);
            this.txtEditImageURL.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 730);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(745, 732);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Inventory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 732);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(901, 732);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1130, 732);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Image Path";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 756);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Edit Section";
            // 
            // btnClearEditTextBoxs
            // 
            this.btnClearEditTextBoxs.BackColor = System.Drawing.Color.Orange;
            this.btnClearEditTextBoxs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearEditTextBoxs.Location = new System.Drawing.Point(749, 788);
            this.btnClearEditTextBoxs.Name = "btnClearEditTextBoxs";
            this.btnClearEditTextBoxs.Size = new System.Drawing.Size(134, 52);
            this.btnClearEditTextBoxs.TabIndex = 24;
            this.btnClearEditTextBoxs.Text = "Clear Edit Text Boxs";
            this.btnClearEditTextBoxs.UseVisualStyleBackColor = false;
            this.btnClearEditTextBoxs.Click += new System.EventHandler(this.btnClearEditTextBoxs_Click);
            // 
            // picProductImage
            // 
            this.picProductImage.Image = global::VietLaptop.Properties.Resources.Google_Noto_Emoji_Objects_62823_laptop_computer_512;
            this.picProductImage.Location = new System.Drawing.Point(1335, 754);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(126, 84);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductImage.TabIndex = 25;
            this.picProductImage.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1368, 732);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 19);
            this.label14.TabIndex = 23;
            this.label14.Text = "Image";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(1467, 752);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(127, 38);
            this.btnUploadImage.TabIndex = 26;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingpriceDataGridViewTextBoxColumn
            // 
            this.sellingpriceDataGridViewTextBoxColumn.DataPropertyName = "selling_price";
            this.sellingpriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.sellingpriceDataGridViewTextBoxColumn.Name = "sellingpriceDataGridViewTextBoxColumn";
            this.sellingpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryquantityDataGridViewTextBoxColumn
            // 
            this.inventoryquantityDataGridViewTextBoxColumn.DataPropertyName = "inventory_quantity";
            this.inventoryquantityDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inventoryquantityDataGridViewTextBoxColumn.Name = "inventoryquantityDataGridViewTextBoxColumn";
            this.inventoryquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "Image";
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // image_url
            // 
            this.image_url.DataPropertyName = "image_url";
            this.image_url.HeaderText = "image_url";
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Visible = false;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Created at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateatDataGridViewTextBoxColumn
            // 
            this.updateatDataGridViewTextBoxColumn.DataPropertyName = "update_at";
            this.updateatDataGridViewTextBoxColumn.HeaderText = "Update at";
            this.updateatDataGridViewTextBoxColumn.Name = "updateatDataGridViewTextBoxColumn";
            this.updateatDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateatDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.picProductImage);
            this.Controls.Add(this.btnClearEditTextBoxs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEditBrand);
            this.Controls.Add(this.txtEditInventory);
            this.Controls.Add(this.txtEditImageURL);
            this.Controls.Add(this.txtEditDescription);
            this.Controls.Add(this.txtEditPrice);
            this.Controls.Add(this.txtEditModel);
            this.Controls.Add(this.txtEditProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearAllSearchTextBoxs);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMaxInventory);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.txtMinInventory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvProduct);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1623, 884);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private VietLaptopStoreDataSet vietLaptopStoreDataSet;
        private VietLaptopStoreDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinInventory;
        private System.Windows.Forms.TextBox txtMaxInventory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbBrand;
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
        private Label label13;
        private Button btnClearEditTextBoxs;
        private PictureBox picProductImage;
        private Label label14;
        private Button btnUploadImage;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellingpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inventoryquantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn image_url;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateatDataGridViewTextBoxColumn;
    }
}
