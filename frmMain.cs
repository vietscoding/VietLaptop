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
using System.Security.Cryptography;
namespace VietLaptop
{
    public partial class frmMain : Form
    {
        private frmMain _frm;
        private frmAddOrder _frmAddOrder = new frmAddOrder();
        private Panel panelContainer;

        private Button highlightButton = null;

        private void HighlightButton(Button btn)
        {
            if (highlightButton != null)
            {
                highlightButton.BackColor = Color.FromArgb(91, 209, 248);
                highlightButton.ForeColor = SystemColors.ActiveCaptionText;

            }

            btn.BackColor = Color.FromArgb(0, 110, 163);
            btn.ForeColor = SystemColors.ButtonHighlight;
            highlightButton = btn;
        }

        public frmMain()
        {


            InitializeComponent();
            panelContainer = new Panel
            {
                Location = new Point(270, 103),
                Size = new Size(1623, 884)
            };
            this.Controls.Add(panelContainer);

            if (frmLogin._employeeRole == "sales")
            {
                btnEmployee.Visible = false;
                //btnCustomer.Visible = false;
                btnStatistic.Visible = false;
            }
            else if (frmLogin._employeeRole == "warehouse")
            {
                btnOrder.Visible = false;
                btnCustomer.Visible= false;
                btnEmployee.Visible = false;
                btnStatistic.Location = new Point(4, 422);
            }

            

            //if (_frmAddOrder.IsSelectCustomerIdButtonClicked)
            //{
            //    btnDashboard.Visible = false;
            //    btnCustomer.Visible = false;
            //    btnProduct.Visible = false;
            //    btnStatistic.Visible = false;
            //    btnEmployee.Visible = false;
            //    btnCustomer.Visible = false;

            //}


        }

        public frmMain(Form frm)
        {
            InitializeComponent();
            
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
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
            CtrlOrder dashboardControl = new CtrlOrder();
            panelContainer.Controls.Add(dashboardControl);

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CtrlProduct productControl = new CtrlProduct();
            panelContainer.Controls.Add((CtrlProduct)productControl);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlNavigation.Controls)
            {
                if (ctrl is Button btn && btn != btnLogout)
                {
                    btn.Click += (s, ev) => HighlightButton(btn);
                }
            }

            

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CtrlCustomer customerControl = new CtrlCustomer();
            panelContainer.Controls.Add((CtrlCustomer)customerControl);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CtrlEmployee employeeControl = new CtrlEmployee();
            panelContainer.Controls.Add(((CtrlEmployee)employeeControl));
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CtrlStatistic statisticControl = new CtrlStatistic();
            panelContainer.Controls.Add(((CtrlStatistic)statisticControl));
        }
    }
}
