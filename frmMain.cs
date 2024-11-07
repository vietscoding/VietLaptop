using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace VietLaptop
{
    public partial class frmMain : Form
    {

        private Panel panelContainer;

        public frmMain()
        {
            InitializeComponent();
            panelContainer = new Panel
            {
                Location = new Point(270, 103),
                Size = new Size(1623, 884)
            };
            this.Controls.Add(panelContainer);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Panel panelContainer = new Panel
            //{
            //    Location = new Point(270, 103),
            //    Size = new Size(1623, 884)
            //};

            //this.Controls.Add(panelContainer);

            //panelContainer.Controls.Clear();

            //DashboardControl dashboardControl = new DashboardControl();

            //panelContainer.Controls.Add(dashboardControl);

            panelContainer.Controls.Clear();
            DashboardControl dashboardControl = new DashboardControl();
            panelContainer.Controls.Add(dashboardControl);

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //Panel panelContainer = new Panel
            //{
            //    Location = new Point(270, 103),
            //    Size = new Size(1623, 884)
            //};

            //this.Controls.Add(panelContainer);

            //panelContainer.Controls.Clear();
            //ProductControl productControl = new ProductControl();
            //panelContainer.Controls.Add(productControl);

            panelContainer.Controls.Clear();
            ProductControl productControl = new ProductControl();
            panelContainer.Controls.Add((ProductControl)productControl);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
