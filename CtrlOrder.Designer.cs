namespace VietLaptop
{
    partial class CtrlOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_at_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vietLaptopStoreDataSetOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vietLaptopStoreDataSetOrders = new VietLaptop.VietLaptopStoreDataSetOrders();
            this.btnClearAllSearchTextBoxs = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new VietLaptop.VietLaptopStoreDataSetOrdersTableAdapters.OrderDetailsTableAdapter();
            this.ordersTableAdapter = new VietLaptop.VietLaptopStoreDataSetOrdersTableAdapters.OrdersTableAdapter();
            this.txtSearchOrderID = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerID = new System.Windows.Forms.TextBox();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.txtSearchPrice = new System.Windows.Forms.TextBox();
            this.txtSearchQuantity = new System.Windows.Forms.TextBox();
            this.txtSearchTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbSearchStatus = new System.Windows.Forms.ComboBox();
            this.txtEditOrderID = new System.Windows.Forms.TextBox();
            this.txtEditCustomerID = new System.Windows.Forms.TextBox();
            this.txtEditProductID = new System.Windows.Forms.TextBox();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.txtEditQuantity = new System.Windows.Forms.TextBox();
            this.txtEditTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbEditStatus = new System.Windows.Forms.ComboBox();
            this.grpEditOrder = new System.Windows.Forms.GroupBox();
            this.orderDate = new VietLaptop.OrderDate();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSetOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSetOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.grpEditOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.product_id,
            this.price_at_purchase,
            this.quantity,
            this.customer_id,
            this.total_amount,
            this.status});
            this.dgvOrder.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.Location = new System.Drawing.Point(26, 161);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(1508, 552);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrder_RowHeaderMouseClick);
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Product ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // price_at_purchase
            // 
            this.price_at_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price_at_purchase.DataPropertyName = "price_at_purchase";
            this.price_at_purchase.HeaderText = "Price";
            this.price_at_purchase.Name = "price_at_purchase";
            this.price_at_purchase.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // customer_id
            // 
            this.customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "Customer ID";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            // 
            // total_amount
            // 
            this.total_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_amount.DataPropertyName = "total_amount";
            this.total_amount.HeaderText = "Total amount";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.vietLaptopStoreDataSetOrdersBindingSource;
            // 
            // vietLaptopStoreDataSetOrdersBindingSource
            // 
            this.vietLaptopStoreDataSetOrdersBindingSource.DataSource = this.vietLaptopStoreDataSetOrders;
            this.vietLaptopStoreDataSetOrdersBindingSource.Position = 0;
            // 
            // vietLaptopStoreDataSetOrders
            // 
            this.vietLaptopStoreDataSetOrders.DataSetName = "VietLaptopStoreDataSetOrders";
            this.vietLaptopStoreDataSetOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClearAllSearchTextBoxs
            // 
            this.btnClearAllSearchTextBoxs.BackColor = System.Drawing.Color.Orange;
            this.btnClearAllSearchTextBoxs.FlatAppearance.BorderSize = 2;
            this.btnClearAllSearchTextBoxs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllSearchTextBoxs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSearchTextBoxs.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Restart_32;
            this.btnClearAllSearchTextBoxs.Location = new System.Drawing.Point(1540, 119);
            this.btnClearAllSearchTextBoxs.Name = "btnClearAllSearchTextBoxs";
            this.btnClearAllSearchTextBoxs.Size = new System.Drawing.Size(64, 36);
            this.btnClearAllSearchTextBoxs.TabIndex = 17;
            this.btnClearAllSearchTextBoxs.UseVisualStyleBackColor = false;
            this.btnClearAllSearchTextBoxs.Click += new System.EventHandler(this.btnClearAllSearchTextBoxs_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.Yellow;
            this.btnEditOrder.FlatAppearance.BorderSize = 2;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditOrder.Image = global::VietLaptop.Properties.Resources.Picol_Picol_Edit2;
            this.btnEditOrder.Location = new System.Drawing.Point(1484, 45);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(64, 42);
            this.btnEditOrder.TabIndex = 21;
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::VietLaptop.Properties.Resources.Custom_Icon_Design_Mono_General_2_Search_32;
            this.btnSearch.Location = new System.Drawing.Point(1540, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 180);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 2;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteOrder.Image = global::VietLaptop.Properties.Resources.Pixelkit_Gentle_Edges_Trash_32;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1540, 533);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(64, 180);
            this.btnDeleteOrder.TabIndex = 20;
            this.btnDeleteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddOrder.FlatAppearance.BorderSize = 2;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrder.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Plus_box_32;
            this.btnAddOrder.Location = new System.Drawing.Point(1540, 347);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(64, 180);
            this.btnAddOrder.TabIndex = 19;
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.vietLaptopStoreDataSetOrdersBindingSource;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearchOrderID
            // 
            this.txtSearchOrderID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrderID.Location = new System.Drawing.Point(69, 128);
            this.txtSearchOrderID.Name = "txtSearchOrderID";
            this.txtSearchOrderID.Size = new System.Drawing.Size(207, 27);
            this.txtSearchOrderID.TabIndex = 22;
            this.txtSearchOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchCustomerID
            // 
            this.txtSearchCustomerID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomerID.Location = new System.Drawing.Point(282, 128);
            this.txtSearchCustomerID.Name = "txtSearchCustomerID";
            this.txtSearchCustomerID.Size = new System.Drawing.Size(203, 27);
            this.txtSearchCustomerID.TabIndex = 22;
            this.txtSearchCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductID.Location = new System.Drawing.Point(491, 128);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(203, 27);
            this.txtSearchProductID.TabIndex = 22;
            this.txtSearchProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchPrice
            // 
            this.txtSearchPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPrice.Location = new System.Drawing.Point(700, 128);
            this.txtSearchPrice.Name = "txtSearchPrice";
            this.txtSearchPrice.Size = new System.Drawing.Size(203, 27);
            this.txtSearchPrice.TabIndex = 22;
            this.txtSearchPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchQuantity
            // 
            this.txtSearchQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchQuantity.Location = new System.Drawing.Point(909, 128);
            this.txtSearchQuantity.Name = "txtSearchQuantity";
            this.txtSearchQuantity.Size = new System.Drawing.Size(203, 27);
            this.txtSearchQuantity.TabIndex = 22;
            this.txtSearchQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchTotalAmount
            // 
            this.txtSearchTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTotalAmount.Location = new System.Drawing.Point(1118, 128);
            this.txtSearchTotalAmount.Name = "txtSearchTotalAmount";
            this.txtSearchTotalAmount.Size = new System.Drawing.Size(203, 27);
            this.txtSearchTotalAmount.TabIndex = 22;
            this.txtSearchTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbSearchStatus
            // 
            this.cmbSearchStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchStatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbSearchStatus.FormattingEnabled = true;
            this.cmbSearchStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled",
            "Refunded",
            "Returned",
            "Failed",
            "On hold",
            "Partially Shipped"});
            this.cmbSearchStatus.Location = new System.Drawing.Point(1327, 128);
            this.cmbSearchStatus.Name = "cmbSearchStatus";
            this.cmbSearchStatus.Size = new System.Drawing.Size(207, 27);
            this.cmbSearchStatus.TabIndex = 23;
            // 
            // txtEditOrderID
            // 
            this.txtEditOrderID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditOrderID.Location = new System.Drawing.Point(19, 45);
            this.txtEditOrderID.Name = "txtEditOrderID";
            this.txtEditOrderID.Size = new System.Drawing.Size(207, 27);
            this.txtEditOrderID.TabIndex = 22;
            this.txtEditOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditCustomerID
            // 
            this.txtEditCustomerID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCustomerID.Location = new System.Drawing.Point(232, 45);
            this.txtEditCustomerID.Name = "txtEditCustomerID";
            this.txtEditCustomerID.Size = new System.Drawing.Size(203, 27);
            this.txtEditCustomerID.TabIndex = 22;
            this.txtEditCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditProductID
            // 
            this.txtEditProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditProductID.Location = new System.Drawing.Point(441, 45);
            this.txtEditProductID.Name = "txtEditProductID";
            this.txtEditProductID.Size = new System.Drawing.Size(203, 27);
            this.txtEditProductID.TabIndex = 22;
            this.txtEditProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrice.Location = new System.Drawing.Point(650, 45);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(203, 27);
            this.txtEditPrice.TabIndex = 22;
            this.txtEditPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditQuantity
            // 
            this.txtEditQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditQuantity.Location = new System.Drawing.Point(859, 45);
            this.txtEditQuantity.Name = "txtEditQuantity";
            this.txtEditQuantity.Size = new System.Drawing.Size(203, 27);
            this.txtEditQuantity.TabIndex = 22;
            this.txtEditQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditTotalAmount
            // 
            this.txtEditTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTotalAmount.Location = new System.Drawing.Point(1068, 45);
            this.txtEditTotalAmount.Name = "txtEditTotalAmount";
            this.txtEditTotalAmount.Size = new System.Drawing.Size(203, 27);
            this.txtEditTotalAmount.TabIndex = 22;
            this.txtEditTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbEditStatus
            // 
            this.cmbEditStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEditStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEditStatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbEditStatus.FormattingEnabled = true;
            this.cmbEditStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled",
            "Refunded",
            "Returned",
            "Failed",
            "On hold",
            "Partially Shipped"});
            this.cmbEditStatus.Location = new System.Drawing.Point(1277, 45);
            this.cmbEditStatus.Name = "cmbEditStatus";
            this.cmbEditStatus.Size = new System.Drawing.Size(194, 27);
            this.cmbEditStatus.TabIndex = 23;
            // 
            // grpEditOrder
            // 
            this.grpEditOrder.Controls.Add(this.btnEditOrder);
            this.grpEditOrder.Controls.Add(this.cmbEditStatus);
            this.grpEditOrder.Controls.Add(this.txtEditOrderID);
            this.grpEditOrder.Controls.Add(this.txtEditTotalAmount);
            this.grpEditOrder.Controls.Add(this.txtEditCustomerID);
            this.grpEditOrder.Controls.Add(this.txtEditProductID);
            this.grpEditOrder.Controls.Add(this.txtEditQuantity);
            this.grpEditOrder.Controls.Add(this.txtEditPrice);
            this.grpEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditOrder.Location = new System.Drawing.Point(50, 719);
            this.grpEditOrder.Name = "grpEditOrder";
            this.grpEditOrder.Size = new System.Drawing.Size(1554, 100);
            this.grpEditOrder.TabIndex = 24;
            this.grpEditOrder.TabStop = false;
            this.grpEditOrder.Text = "Edit Section";
            // 
            // orderDate
            // 
            this.orderDate.DataSetName = "OrderDate";
            this.orderDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CtrlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpEditOrder);
            this.Controls.Add(this.cmbSearchStatus);
            this.Controls.Add(this.txtSearchTotalAmount);
            this.Controls.Add(this.txtSearchQuantity);
            this.Controls.Add(this.txtSearchPrice);
            this.Controls.Add(this.txtSearchProductID);
            this.Controls.Add(this.txtSearchCustomerID);
            this.Controls.Add(this.txtSearchOrderID);
            this.Controls.Add(this.btnClearAllSearchTextBoxs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Name = "CtrlOrder";
            this.Size = new System.Drawing.Size(1623, 884);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSetOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSetOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.grpEditOrder.ResumeLayout(false);
            this.grpEditOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.BindingSource vietLaptopStoreDataSetOrdersBindingSource;
        private VietLaptopStoreDataSetOrders vietLaptopStoreDataSetOrders;
        private System.Windows.Forms.Button btnClearAllSearchTextBoxs;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private VietLaptopStoreDataSetOrdersTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private VietLaptopStoreDataSetOrdersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.TextBox txtSearchOrderID;
        private System.Windows.Forms.TextBox txtSearchCustomerID;
        private System.Windows.Forms.TextBox txtSearchProductID;
        private System.Windows.Forms.TextBox txtSearchPrice;
        private System.Windows.Forms.TextBox txtSearchQuantity;
        private System.Windows.Forms.TextBox txtSearchTotalAmount;
        private System.Windows.Forms.ComboBox cmbSearchStatus;
        private System.Windows.Forms.TextBox txtEditOrderID;
        private System.Windows.Forms.TextBox txtEditCustomerID;
        private System.Windows.Forms.TextBox txtEditProductID;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.TextBox txtEditQuantity;
        private System.Windows.Forms.TextBox txtEditTotalAmount;
        private System.Windows.Forms.ComboBox cmbEditStatus;
        private System.Windows.Forms.GroupBox grpEditOrder;
        private OrderDate orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_at_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
