namespace VietLaptop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "VietLaptop Store";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 1080);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::VietLaptop.Properties.Resources.Artdesigner_Workspace_Notebook_128;
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::VietLaptop.Properties.Resources.Fa_Team_Fontawesome_FontAwesome_Gear_32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 804);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(246, 68);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = global::VietLaptop.Properties.Resources.Icons8_Windows_8_Users_Administrator_32;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(3, 712);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(246, 68);
            this.btnUser.TabIndex = 11;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnStatistic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.Image = global::VietLaptop.Properties.Resources.Steve_Zondicons_Chart_Pie_32;
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(3, 577);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(246, 68);
            this.btnStatistic.TabIndex = 9;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::VietLaptop.Properties.Resources.Bootstrap_Bootstrap_Bootstrap_laptop_fill_32;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 315);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(246, 68);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = global::VietLaptop.Properties.Resources.Picol_Picol_User_Profile_32;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 489);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(246, 68);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomer.Image = global::VietLaptop.Properties.Resources.Icons8_Windows_8_Users_Group_32;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(3, 402);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(246, 68);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnLogout.Image = global::VietLaptop.Properties.Resources.Hopstarter_Sleek_Xp_Software_Windows_Turn_Off_48;
            this.btnLogout.Location = new System.Drawing.Point(97, 904);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 45);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDashboard.Image = global::VietLaptop.Properties.Resources.Pictogrammers_Material_Home_32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 229);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(249, 68);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(238, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1694, 81);
            this.panel2.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "VSSMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}