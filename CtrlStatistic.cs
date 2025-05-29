using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLaptop
{
    public partial class CtrlStatistic : UserControl
    {
        private static string connectionString = CtrlProduct._connectionString;
        public CtrlStatistic()
        {
            InitializeComponent();
            btnLoadData_Click(null, EventArgs.Empty);
        }

        private void btnLoadSales_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                string startDateSQL = "", endDateSQL = "";
                string timeType = "";

                if (rdDay.Checked == true)
                {
                    timeType = "day";
                    startDateSQL = dtpStartDateSales.Value.ToString("yyyy-MM-dd");
                    endDateSQL = dtpEndDateSales.Value.ToString("yyyy-MM-dd");
                    query = "SELECT CONVERT(DATE, purchase_date) AS time_unit, SUM(total_amount) AS total_amount FROM PurchaseHistory WHERE purchase_date BETWEEN @startDate AND @endDate GROUP BY CONVERT(DATE, purchase_date) ORDER BY time_unit;";

                }
                else if (rdMonth.Checked == true)
                {
                    timeType = "month";
                    startDateSQL = dtpStartDateSales.Value.ToString("yyyy-MM-01");
                    endDateSQL = dtpEndDateSales.Value.ToString("yyyy-MM-01");
                    query = "SELECT FORMAT(purchase_date, 'yyyy-MM') AS time_unit, SUM(total_amount) AS total_amount FROM PurchaseHistory WHERE purchase_date BETWEEN @startDate AND @endDate GROUP BY FORMAT(purchase_date, 'yyyy-MM') ORDER BY time_unit;";
                }
                else if (rdYear.Checked == true)
                {
                    timeType = "year";
                    startDateSQL = dtpStartDateSales.Value.ToString("yyyy-01-01");
                    endDateSQL = dtpEndDateSales.Value.ToString("yyyy-01-01");
                    query = "SELECT YEAR(purchase_date) AS time_unit, SUM(total_amount) AS total_amount FROM PurchaseHistory WHERE purchase_date BETWEEN @startDate AND @endDate GROUP BY YEAR(purchase_date) ORDER BY time_unit;";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@startDate", startDateSQL);
                        cmd.Parameters.AddWithValue("@endDate", endDateSQL);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            chartRevenue.Series["Series2"].Points.Clear();
                            while (reader.Read())
                            {
                                string timeUnit = reader["time_unit"].ToString();
                                decimal totalAmount = reader.GetDecimal(reader.GetOrdinal("total_amount"));

                                chartRevenue.Series["Series2"].Points.AddXY(timeUnit, totalAmount);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT product_id, product_name, inventory_quantity FROM Products WHERE update_at BETWEEN @startDay AND @endDay";
                string startDaySQLFormat = dtpStartDay.Value.ToString("yyyy-MM-dd");
                string endDaySQLFormat = dtpEndDay.Value.ToString("yyyy-MM-dd");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("startDay", startDaySQLFormat);
                        cmd.Parameters.AddWithValue("endDay",endDaySQLFormat);
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            chartProduct.Series["Series1"].Points.Clear();
                            while (reader.Read())
                            {
                                int productId = reader.GetInt32(reader.GetOrdinal("product_id"));
                                int inventory = reader.GetInt32(reader.GetOrdinal("inventory_quantity"));
                                chartProduct.Series["Series1"].Points.AddXY(productId, inventory);
                            }
                        }


                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvProductImportedByID.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CtrlStatistic_Load(object sender, EventArgs e)
        {

        }

        private void btnNumberOfProductsImportedById_Click(object sender, EventArgs e)
        {
            gbSalesRevenue.Visible = false;
            gbStatisticsProduct.Visible = true;
            gbStatisticsProduct.Location = new System.Drawing.Point(26, 253);
            gbStatisticsProduct.Size = new System.Drawing.Size(1575, 609);
        }

        private void btnSalesRevenueByTime_Click(object sender, EventArgs e)
        {
            gbStatisticsProduct.Visible=false;
            gbSalesRevenue.Visible = true;
            gbSalesRevenue.Location = new System.Drawing.Point(26, 253);
            gbSalesRevenue.Size = new System.Drawing.Size(1575, 609);
        }

        private void btnProfitByProductEmployee_Click(object sender, EventArgs e)
        {

        }

        private void rdDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDay.Checked)
            {
                dtpStartDateSales.Format = DateTimePickerFormat.Custom;
                dtpStartDateSales.CustomFormat = "dd/MM/yyyy";
                //dtpStartDateSales.ShowUpDown = true; 

                dtpEndDateSales.Format = DateTimePickerFormat.Custom;
                dtpEndDateSales.CustomFormat = "dd/MM/yyyy";
                //dtpEndDateSales.ShowUpDown = true;
            }
        }

        private void rdMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMonth.Checked)
            {
                dtpStartDateSales.Format = DateTimePickerFormat.Custom;
                dtpStartDateSales.CustomFormat = "MM/yyyy";
                //dtpStartDateSales.ShowUpDown = true;

                dtpEndDateSales.Format = DateTimePickerFormat.Custom;
                dtpEndDateSales.CustomFormat = "MM/yyyy";
                //dtpEndDateSales.ShowUpDown = true;
            }
        }

        private void rdYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdYear.Checked)
            {
                dtpStartDateSales.Format = DateTimePickerFormat.Custom;
                dtpStartDateSales.CustomFormat = "yyyy";
                dtpStartDateSales.ShowUpDown = true;

                dtpEndDateSales.Format = DateTimePickerFormat.Custom;
                dtpEndDateSales.CustomFormat = "yyyy";
                dtpEndDateSales.ShowUpDown = true;
            }
        }

        
    }
}
