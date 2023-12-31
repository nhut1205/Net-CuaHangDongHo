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

namespace DoAn_Net
{
    public partial class GD_BaoCao : Form
    {
        public GD_BaoCao()
        {
            InitializeComponent();
        }

        private void UpdateTotalOrderValue(DataTable dataTable)
        {
            decimal totalOrderTotal = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["OrderTotal"] != DBNull.Value)
                {
                    totalOrderTotal += Convert.ToDecimal(row["OrderTotal"]);
                }
            }
            label4.Text = $"{totalOrderTotal.ToString()}" + "$";
        }

        //Load chi tiết phiếu nhập
        private void LoadDataToDataGridView()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Orders";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            // Liên kết DataTable với DataGridView
            dataGridHoaDon.DataSource = dataTable;

            decimal totalOrderTotal = 0;
            foreach (DataRow row in dataTable.Rows)
            {

                if (row["OrderTotal"] != DBNull.Value)
                {
                    totalOrderTotal += Convert.ToDecimal(row["OrderTotal"]);
                }
            }

            // Hiển thị tổng OrderTotal lên Label (giả sử label có tên là labelTongOrderTotal)
            label4.Text = $"{totalOrderTotal.ToString()}" + "$";

        }


        private void GD_BaoCao_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void cbo_LocHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LocHoaDon.SelectedItem != null)
            {
                string selectedOption = cbo_LocHoaDon.SelectedItem.ToString();
                string query = "";
                string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Using parameterized queries to prevent SQL injection
                    string dateComparison = "";
                    string datePartFunction = "";

                    if (selectedOption == "Day")
                    {
                        dateComparison = "@CurrentDay";
                        datePartFunction = "DAY";
                    }
                    else if (selectedOption == "Month")
                    {
                        dateComparison = "@CurrentMonth";
                        datePartFunction = "MONTH";
                    }
                    else if (selectedOption == "Year")
                    {
                        dateComparison = "@CurrentYear";
                        datePartFunction = "YEAR";
                    }

                    // Constructing the SQL query using parameterized queries and dateComparison string
                    query = "SELECT * FROM Orders WHERE DATEPART(" + datePartFunction + ", OrderPlaced) = DATEPART(" + datePartFunction + ", @CurrentDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
                        command.Parameters.AddWithValue(dateComparison, DateTime.Now);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }

                // Binding DataTable to DataGridView
                dataGridHoaDon.DataSource = dataTable;

                // Update total order value label
                UpdateTotalOrderValue(dataTable);

                // Calculating total OrderTotal
                decimal totalOrderTotal = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["OrderTotal"] != DBNull.Value)
                    {
                        totalOrderTotal += Convert.ToDecimal(row["OrderTotal"]);
                    }
                }
                // Here you can use the totalOrderTotal as needed in your application
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("p_mathang_banchaynhat", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@TenMH";
                    outputParameter.SqlDbType = SqlDbType.NVarChar;
                    outputParameter.Size = 50;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    command.ExecuteNonQuery();

                    string tenMH = command.Parameters["@TenMH"].Value.ToString();

                    MessageBox.Show($"Sản phẩm bán chạy nhất là: {tenMH}");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
