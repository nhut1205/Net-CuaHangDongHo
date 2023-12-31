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
    public partial class AddVendorForm : Form
    {
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        int ID = 0;

        DatabaseHelper dbHelper;
        SqlDataAdapter adapter;
        DataTable dataTable;
        SqlConnection connection;
        public AddVendorForm()
        {
            InitializeComponent();
            this.dbHelper = new DatabaseHelper(connectionString);
            connection = new SqlConnection(connectionString);
        }

        void LoadDataToDataGridView()
        {
            string query = "SELECT * FROM Vendors";

            try
            {
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dataTable.Columns[0];
                dataTable.PrimaryKey = key;
                dataGridView_Category.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Xử lý sự kiện thêm Vendor
        private void buttonAddVendor_Click(object sender, EventArgs e)
        {
            string vendorName = textBoxVendorName.Text;
            string vendorID = textBoxVendorId.Text;

            DataRow newrow = dataTable.NewRow();

            newrow["VendorId"] = vendorID; // Gán giá trị trực tiếp từ chuỗi vendorID
            newrow["Name"] = vendorName;

            dataTable.Rows.Add(newrow);
            int kq = dbHelper.UpdataDatabase(adapter, dataTable);

            if (kq > 0)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp.");
            }

            LoadDataToDataGridView();
        }

        private void AddVendorForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string vendorName = textBoxVendorName.Text;

            // Tạo mã vendorId ngẫu nhiên
            string vendorID = GenerateRandomVendorId();

            DataRow newrow = dataTable.NewRow();

            newrow["VendorId"] = vendorID;
            newrow["Name"] = vendorName;

            dataTable.Rows.Add(newrow);
            int kq = dbHelper.UpdataDatabase(adapter, dataTable);

            if (kq > 0)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp.");
            }

            LoadDataToDataGridView();
        }

        // Hàm tạo mã VendorId ngẫu nhiên
        private string GenerateRandomVendorId()
        {
            Random random = new Random();
            const string chars = "0123456789";
            string vendorId = "Vendo" + new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return vendorId;
        }


        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string categoryId = textBoxVendorId.Text;

            string checkQuery = "SELECT COUNT(*) FROM Products WHERE VendorID = @CategoryId";
            SqlParameter parameter = new SqlParameter("@CategoryId", SqlDbType.VarChar);
            parameter.Value = categoryId;

            int kq_checkQuery = (int)dbHelper.GetScalar(checkQuery, parameter);

            if (kq_checkQuery > 0)
            {
                MessageBox.Show("Vi phạm ràng buộc khóa ngoại !");
            }
            else
            {
                DataRow dr = dataTable.Rows.Find(textBoxVendorId.Text);
                // Xoa dong du lieu vua tim duoc
                if (dr != null)
                {
                    dr.Delete();
                }
                int kq = dbHelper.UpdataDatabase(adapter, dataTable);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    textBoxVendorId.Clear();
                    textBoxVendorName.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }
            LoadDataToDataGridView();
        }

        private void dataGridView_Category_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxVendorId.Text = dataGridView_Category.Rows[e.RowIndex].Cells["VendorId"].Value.ToString();
            textBoxVendorName.Text = dataGridView_Category.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.Rows.Find(textBoxVendorId.Text);
            // Hieu chinh thong tin dong tin moi vua tim duoc
            if (dr != null)
            {
                string vendorName = textBoxVendorName.Text;

                dr["Name"] = vendorName;
            }

            int kq = dbHelper.UpdataDatabase(adapter, dataTable);

            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công !");
            }
        }

        private void textBoxSearchVendor_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = textBoxSearchVendor.Text;

            string query = "SELECT * FROM Vendors WHERE Name LIKE " + "'%" + searchText + "%'";
            DataTable dataTable_textBoxSearchProduct = dbHelper.GetDataTable(query);

            // Liên kết DataTable với DataGridView để hiển thị kết quả tìm kiếm
            dataGridView_Category.DataSource = dataTable_textBoxSearchProduct;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = textBoxSearchVendor.Text;

            string query = "SELECT * FROM Vendors WHERE Name LIKE " + "'%" + searchText + "%'";
            DataTable dataTable_textBoxSearchProduct = dbHelper.GetDataTable(query);

            // Liên kết DataTable với DataGridView để hiển thị kết quả tìm kiếm
            dataGridView_Category.DataSource = dataTable_textBoxSearchProduct;
        }
    }
}
