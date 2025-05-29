namespace VietLaptop
{
    partial class CtrlCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vietLaptopStoreDataSetCustomer = new VietLaptop.VietLaptopStoreDataSetCustomer();
            this.customersTableAdapter = new VietLaptop.VietLaptopStoreDataSetCustomerTableAdapters.CustomersTableAdapter();
            this.txtSearchCustomerName = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtSearchCustomerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtEditCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtEditCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtEditCustomerName = new System.Windows.Forms.TextBox();
            this.btnEditCustomerInfo = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnClearAllSearchTextBoxes = new System.Windows.Forms.Button();
            this.gbEditCustomerSection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSetCustomer)).BeginInit();
            this.gbEditCustomerSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Manager";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updateatDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.customersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.Location = new System.Drawing.Point(26, 161);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer.Size = new System.Drawing.Size(1501, 552);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellClick);
            this.dgvCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomer_RowHeaderMouseClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.FillWeight = 30F;
            this.customeridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "Customer name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 150F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
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
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.vietLaptopStoreDataSetCustomer;
            // 
            // vietLaptopStoreDataSetCustomer
            // 
            this.vietLaptopStoreDataSetCustomer.DataSetName = "VietLaptopStoreDataSetCustomer";
            this.vietLaptopStoreDataSetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearchCustomerName
            // 
            this.txtSearchCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomerName.Location = new System.Drawing.Point(163, 128);
            this.txtSearchCustomerName.Name = "txtSearchCustomerName";
            this.txtSearchCustomerName.Size = new System.Drawing.Size(295, 27);
            this.txtSearchCustomerName.TabIndex = 2;
            // 
            // txtSearchCustomerAddress
            // 
            this.txtSearchCustomerAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomerAddress.Location = new System.Drawing.Point(767, 128);
            this.txtSearchCustomerAddress.Name = "txtSearchCustomerAddress";
            this.txtSearchCustomerAddress.Size = new System.Drawing.Size(299, 27);
            this.txtSearchCustomerAddress.TabIndex = 4;
            this.txtSearchCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearchCustomerEmail
            // 
            this.txtSearchCustomerEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomerEmail.Location = new System.Drawing.Point(1072, 128);
            this.txtSearchCustomerEmail.Name = "txtSearchCustomerEmail";
            this.txtSearchCustomerEmail.Size = new System.Drawing.Size(455, 27);
            this.txtSearchCustomerEmail.TabIndex = 5;
            // 
            // txtSearchCustomerPhone
            // 
            this.txtSearchCustomerPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomerPhone.Location = new System.Drawing.Point(464, 128);
            this.txtSearchCustomerPhone.Name = "txtSearchCustomerPhone";
            this.txtSearchCustomerPhone.Size = new System.Drawing.Size(297, 27);
            this.txtSearchCustomerPhone.TabIndex = 3;
            // 
            // txtSearchCustomerID
            // 
            this.txtSearchCustomerID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomerID.Location = new System.Drawing.Point(69, 128);
            this.txtSearchCustomerID.Name = "txtSearchCustomerID";
            this.txtSearchCustomerID.Size = new System.Drawing.Size(88, 27);
            this.txtSearchCustomerID.TabIndex = 1;
            this.txtSearchCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Customer Name";
            // 
            // txtEditCustomerEmail
            // 
            this.txtEditCustomerEmail.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCustomerEmail.Location = new System.Drawing.Point(413, 95);
            this.txtEditCustomerEmail.Name = "txtEditCustomerEmail";
            this.txtEditCustomerEmail.Size = new System.Drawing.Size(206, 23);
            this.txtEditCustomerEmail.TabIndex = 13;
            this.txtEditCustomerEmail.TextChanged += new System.EventHandler(this.txtEditCustomerEmail_TextChanged);
            // 
            // txtEditCustomerPhone
            // 
            this.txtEditCustomerPhone.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCustomerPhone.Location = new System.Drawing.Point(413, 31);
            this.txtEditCustomerPhone.Name = "txtEditCustomerPhone";
            this.txtEditCustomerPhone.Size = new System.Drawing.Size(206, 23);
            this.txtEditCustomerPhone.TabIndex = 11;
            // 
            // txtEditCustomerAddress
            // 
            this.txtEditCustomerAddress.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCustomerAddress.Location = new System.Drawing.Point(185, 95);
            this.txtEditCustomerAddress.Name = "txtEditCustomerAddress";
            this.txtEditCustomerAddress.Size = new System.Drawing.Size(206, 23);
            this.txtEditCustomerAddress.TabIndex = 12;
            // 
            // txtEditCustomerName
            // 
            this.txtEditCustomerName.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCustomerName.Location = new System.Drawing.Point(185, 32);
            this.txtEditCustomerName.Name = "txtEditCustomerName";
            this.txtEditCustomerName.Size = new System.Drawing.Size(206, 23);
            this.txtEditCustomerName.TabIndex = 10;
            // 
            // btnEditCustomerInfo
            // 
            this.btnEditCustomerInfo.BackColor = System.Drawing.Color.Yellow;
            this.btnEditCustomerInfo.FlatAppearance.BorderSize = 2;
            this.btnEditCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomerInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditCustomerInfo.Image = global::VietLaptop.Properties.Resources.Picol_Picol_Edit2;
            this.btnEditCustomerInfo.Location = new System.Drawing.Point(647, 49);
            this.btnEditCustomerInfo.Name = "btnEditCustomerInfo";
            this.btnEditCustomerInfo.Size = new System.Drawing.Size(77, 47);
            this.btnEditCustomerInfo.TabIndex = 14;
            this.btnEditCustomerInfo.UseVisualStyleBackColor = false;
            this.btnEditCustomerInfo.Click += new System.EventHandler(this.btnEditCustomerInfo_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 2;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCustomer.Image = global::VietLaptop.Properties.Resources.Pixelkit_Gentle_Edges_Trash_32;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1533, 533);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(64, 180);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddCustomer.FlatAppearance.BorderSize = 2;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Plus_box_32;
            this.btnAddCustomer.Location = new System.Drawing.Point(1533, 347);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(64, 180);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchCustomer.FlatAppearance.BorderSize = 2;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = global::VietLaptop.Properties.Resources.Custom_Icon_Design_Mono_General_2_Search_32;
            this.btnSearchCustomer.Location = new System.Drawing.Point(1533, 161);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(64, 180);
            this.btnSearchCustomer.TabIndex = 7;
            this.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnClearAllSearchTextBoxes
            // 
            this.btnClearAllSearchTextBoxes.BackColor = System.Drawing.Color.Orange;
            this.btnClearAllSearchTextBoxes.FlatAppearance.BorderSize = 2;
            this.btnClearAllSearchTextBoxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllSearchTextBoxes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSearchTextBoxes.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Restart_32;
            this.btnClearAllSearchTextBoxes.Location = new System.Drawing.Point(1533, 119);
            this.btnClearAllSearchTextBoxes.Name = "btnClearAllSearchTextBoxes";
            this.btnClearAllSearchTextBoxes.Size = new System.Drawing.Size(64, 36);
            this.btnClearAllSearchTextBoxes.TabIndex = 6;
            this.btnClearAllSearchTextBoxes.UseVisualStyleBackColor = false;
            this.btnClearAllSearchTextBoxes.Click += new System.EventHandler(this.btnClearAllSearchTextBoxes_Click_1);
            // 
            // gbEditCustomerSection
            // 
            this.gbEditCustomerSection.Controls.Add(this.btnEditCustomerInfo);
            this.gbEditCustomerSection.Controls.Add(this.txtEditCustomerName);
            this.gbEditCustomerSection.Controls.Add(this.txtEditCustomerAddress);
            this.gbEditCustomerSection.Controls.Add(this.txtEditCustomerPhone);
            this.gbEditCustomerSection.Controls.Add(this.txtEditCustomerEmail);
            this.gbEditCustomerSection.Controls.Add(this.label8);
            this.gbEditCustomerSection.Controls.Add(this.label2);
            this.gbEditCustomerSection.Controls.Add(this.label5);
            this.gbEditCustomerSection.Controls.Add(this.label3);
            this.gbEditCustomerSection.Location = new System.Drawing.Point(408, 742);
            this.gbEditCustomerSection.Name = "gbEditCustomerSection";
            this.gbEditCustomerSection.Size = new System.Drawing.Size(787, 139);
            this.gbEditCustomerSection.TabIndex = 63;
            this.gbEditCustomerSection.TabStop = false;
            this.gbEditCustomerSection.Text = "Edit Section";
            // 
            // CtrlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gbEditCustomerSection);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnClearAllSearchTextBoxes);
            this.Controls.Add(this.txtSearchCustomerName);
            this.Controls.Add(this.txtSearchCustomerAddress);
            this.Controls.Add(this.txtSearchCustomerEmail);
            this.Controls.Add(this.txtSearchCustomerPhone);
            this.Controls.Add(this.txtSearchCustomerID);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.label1);
            this.Name = "CtrlCustomer";
            this.Size = new System.Drawing.Size(1623, 884);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vietLaptopStoreDataSetCustomer)).EndInit();
            this.gbEditCustomerSection.ResumeLayout(false);
            this.gbEditCustomerSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private VietLaptopStoreDataSetCustomer vietLaptopStoreDataSetCustomer;
        private VietLaptopStoreDataSetCustomerTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnClearAllSearchTextBoxes;
        private System.Windows.Forms.TextBox txtSearchCustomerName;
        private System.Windows.Forms.TextBox txtSearchCustomerAddress;
        private System.Windows.Forms.TextBox txtSearchCustomerEmail;
        private System.Windows.Forms.TextBox txtSearchCustomerPhone;
        private System.Windows.Forms.TextBox txtSearchCustomerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditCustomerEmail;
        private System.Windows.Forms.TextBox txtEditCustomerPhone;
        private System.Windows.Forms.TextBox txtEditCustomerAddress;
        private System.Windows.Forms.TextBox txtEditCustomerName;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateatDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbEditCustomerSection;
    }
}
