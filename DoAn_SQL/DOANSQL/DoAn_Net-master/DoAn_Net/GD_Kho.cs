using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DoAn_Net
{
    public partial class GD_Kho : Form
    {
        Connection db = new Connection();
        DataTable dt_banHang = new DataTable();

        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        private string tenDangNhap;

        public GD_Kho(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapKho nhapKho = new NhapKho();
            nhapKho.ShowDialog();
            this.Show();
        }

        public string GetNameForCurrentUser(string tenDangNhap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Username FROM Account WHERE Username = @UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", tenDangNhap); // Sử dụng tham số tenDangNhap
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Lấy tên đăng nhập từ cơ sở dữ liệu và gán cho biến tenTaiKhoan
                        tenDangNhap = reader["Username"].ToString();
                    }
                }

                connection.Close();
            }

            return tenDangNhap;
        }

        //Load chi tiết hóa đơn
        private void LoadDataToDataGridView()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM OrderDetails";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            // Liên kết DataTable với DataGridView
            dataGrid_BanHang.DataSource = dataTable;
        }

        //Load hóa đơn
        private void LoadDataToDataGridViewHoaDon()
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
            dataOrder.DataSource = dataTable;
        }

        private void LoadDataToDataGridViewCustomer()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Customer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            // Liên kết DataTable với DataGridView
            data_Customer.DataSource = dataTable;
        }

        public void docPhieuNhap()
        {
            string sql = "select * from orders";
            DataTable dt_Order = db.getDatatable(sql);
            cbo_maNhap.DataSource = dt_Order;
            cbo_maNhap.ValueMember = "orderID";
            cbo_maNhap.DisplayMember = "orderID";
        }

        public void load_maSanPham()
        {
            string sql = "select * from Products";
            DataTable dt_sanPham = db.getDatatable(sql);
            cbo_sanPham.DataSource = dt_sanPham;
            cbo_sanPham.ValueMember = "productID";
            cbo_sanPham.DisplayMember = "Name";
        }

        // Hàm tạo số ngẫu nhiên cho OrderDetailId
        private string GenerateRandomOrderDetailId()
        {
            Random random = new Random();
            const string chars = "0123456789"; // Các ký tự có thể sử dụng cho OrderDetailId
            return "OD" + new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            string connection1 = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
            string maphieunhap = cbo_maNhap.SelectedValue.ToString();
            string masanPham = cbo_sanPham.SelectedValue.ToString();
            int soLuongMoi = 0;

            if (!string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                if (int.TryParse(txt_SoLuong.Text, out int parsedValue))
                {
                    soLuongMoi = parsedValue;

                    // Lấy số lượng sản phẩm từ cơ sở dữ liệu
                    string quantityQuery = $"SELECT Quantity FROM Products WHERE ProductId = '{masanPham}'";
                    int soLuongTrongCSDL = 0;

                    // Thực hiện truy vấn để lấy số lượng sản phẩm từ cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(connection1))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(quantityQuery, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            soLuongTrongCSDL = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    // Kiểm tra nếu số lượng nhập vào lớn hơn số lượng trong cơ sở dữ liệu
                    if (soLuongMoi > soLuongTrongCSDL)
                    {
                        MessageBox.Show("Số lượng không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tiếp tục xử lý của bạn nếu số lượng đủ
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên cho số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện các thao tác thêm dữ liệu vào bảng orderdetails và xử lý khác ở đây
            string sql = "select * from orderdetails";
            dt_banHang = db.getDatatable(sql);

            DataRow existingRow = dt_banHang.AsEnumerable().FirstOrDefault(row =>
            {
                string orderid = row["orderid"].ToString();
                string productid = row["productid"].ToString();
                return orderid == maphieunhap && productid == masanPham;
            });

            if (existingRow != null)
            {
                int soLuongHienTai = Convert.ToInt32(existingRow["amount"]);
                existingRow["amount"] = soLuongHienTai + soLuongMoi;
            }
            else
            {
                string randomOrderDetailId = GenerateRandomOrderDetailId();
                DataRow newrow = dt_banHang.NewRow();
                newrow["OrderDetailId"] = randomOrderDetailId;
                newrow["orderid"] = maphieunhap;
                newrow["productid"] = masanPham;
                newrow["price"] = txt_DonGia.Text;
                newrow["amount"] = soLuongMoi;

                dt_banHang.Rows.Add(newrow);
            }

            int kq = db.updateDataBaseCT(dt_banHang);

            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                LoadDataToDataGridViewHoaDon();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }


        public void loadDonGia_SP()
        {
            if (cbo_sanPham != null && cbo_sanPham.SelectedValue != null)
            {
                string productId = cbo_sanPham.SelectedValue.ToString();
                // Kiểm tra productId có giá trị không rỗng
                if (!string.IsNullOrEmpty(productId))
                {
                    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True"; // Replace this with your actual connection string
                    using (SqlConnection dbConnection = new SqlConnection(connectionString))
                    {
                        string sql = "SELECT Price FROM Products WHERE ProductId = @ProductId";

                        SqlCommand cmd = new SqlCommand(sql, dbConnection);
                        cmd.Parameters.AddWithValue("@ProductId", productId);

                        DataTable dt_sanPham = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        try
                        {
                            dbConnection.Open();
                            adapter.Fill(dt_sanPham);

                            if (dt_sanPham.Rows.Count > 0)
                            {
                                decimal donGia = Convert.ToDecimal(dt_sanPham.Rows[0]["Price"]);
                                txt_DonGia.Text = donGia.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions (e.g., log the error, show an error message)
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        finally
                        {
                            // Ensure to close the connection after usage
                            dbConnection.Close();
                        }
                    }
                }
            }
        }

        SqlConnection conn;
        string str_Connection = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

        public DataTable getDatatable(string sql)
        {
            conn = new SqlConnection(str_Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, str_Connection);
            da.Fill(dt);
            return dt;
        }

        public void loadGender()
        {
            string sql = "select * from Gender";
            DataTable dt_sanPham = getDatatable(sql);
            cbo_GioiTinh.DataSource = dt_sanPham;
            cbo_GioiTinh.ValueMember = "GenderID";
            cbo_GioiTinh.DisplayMember = "GenderType";
        }

        private void GD_Kho_Load(object sender, EventArgs e)
        {
            // Lấy thông tin người đăng nhập từ hàm GetNameForCurrentUser
            string userName = GetNameForCurrentUser(tenDangNhap);

            // Tạo một đối tượng DataHelper
            DataHelper dataHelper = new DataHelper();

            // Gọi hàm GetUserInfo để lấy thông tin người dùng
            Account user = dataHelper.GetUserInfo(userName);
            if (user != null)
            {
                text_tenDangNhap.Text = user.UserName;
            }
            docPhieuNhap();
            load_maSanPham();
            loadDonGia_SP();
            LoadDataToDataGridView();
            LoadDataToDataGridViewHoaDon();
            loadKhachHang();
            LoadDataToDataGridViewCustomer();
            loadGender();
        }

        private void cbo_sanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            //loadDonGia_SP();
        }

        private void cbo_sanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDonGia_SP();
        }

        //Tạo hóa đơn
        private void btn_Tao_Click(object sender, EventArgs e)
        {
            string orderId = GenerateRandomOrderId(); // Tạo mã đơn hàng ngẫu nhiên

            string sql = "select * from orders";
            dt_banHang = db.getDatatable(sql);

            DataRow newrow = dt_banHang.NewRow();

            newrow["OrderId"] = orderId;
            newrow["CustomerID"] = cbo_TenKH.SelectedValue.ToString();
            newrow["address"] = string.IsNullOrWhiteSpace(txt_Adress.Text) ? "Không xác định" : txt_Adress.Text;
            newrow["ordertotal"] = 0;
            newrow["orderplaced"] = dateTimePicker1.Text;
            newrow["Username"] = text_tenDangNhap.Text;

            // Thêm dữ liệu mới vào DataTable
            if (!string.IsNullOrWhiteSpace(cbo_TenKH.SelectedValue.ToString()) && !string.IsNullOrWhiteSpace(text_tenDangNhap.ToString()))
            {
                dt_banHang.Rows.Add(newrow);
            }

            // Cập nhật cơ sở dữ liệu
            int kq = db.updateDataBase(dt_banHang);

            if (kq > 0)
                MessageBox.Show("Tạo thành công");
            else
                MessageBox.Show("Tạo thất bại");
        }

        // Hàm tạo mã đơn hàng ngẫu nhiên
        private string GenerateRandomOrderId()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string orderId = "HD" + new string(Enumerable.Repeat(chars, 8) // 8 là độ dài của chuỗi ngẫu nhiên, bạn có thể thay đổi nếu muốn
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return orderId;
        }

        private string GenerateRandomCus()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string orderId = "KH" + new string(Enumerable.Repeat(chars, 8) // 8 là độ dài của chuỗi ngẫu nhiên, bạn có thể thay đổi nếu muốn
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return orderId;
        }
        //Xóa

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGrid_BanHang.SelectedRows.Count > 0)
            {

                string OrderetailID = dataGrid_BanHang.SelectedRows[0].Cells["OrderDetailId"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Chuỗi kết nối đến cơ sở dữ liệu
                    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Chuẩn bị câu lệnh SQL DELETE
                        string deleteQuery = "DELETE FROM OrderDetails WHERE OrderDetailId = @OrderDetailId";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add("@OrderDetailId", SqlDbType.VarChar).Value = OrderetailID;

                            // Thực hiện câu lệnh SQL DELETE
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có bản ghi nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Chi tiết có mã : " + OrderetailID + " đã được xóa.");
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa " + OrderetailID);
                            }
                        }
                    }

                    // Sau khi xóa, cập nhật lại DataGridView
                    LoadDataToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }


        public void loadKhachHang()
        {
            string sql = "select * from Customer";
            DataTable dt_sanPham = db.getDatatable(sql);
            cbo_TenKH.DataSource = dt_sanPham;
            cbo_TenKH.ValueMember = "CustomerID";
            cbo_TenKH.DisplayMember = "FirtName" + "LastName";
        }

        private void btn_TaoKH_Click(object sender, EventArgs e)
        {
            string orderId = GenerateRandomCus(); // Tạo mã đơn hàng ngẫu nhiên

            string sql = "select * from customer";
            dt_banHang = db.getDatatable(sql);

            DataRow newrow = dt_banHang.NewRow();

            newrow["CustomerID"] = orderId;
            newrow["FirtName"] = textBoxFName.Text;
            newrow["LastName"] = textBoxLName.Text;
            if (textBoxPhone.Text.Length == 10)
            {
                newrow["PhoneNumber"] = textBoxPhone.Text;
            }
            else
            {
                // Nếu số điện thoại không đủ dài, bạn có thể xuất một thông báo hoặc thực hiện hành động khác ở đây.
                Console.WriteLine("Số điện thoại không hợp lệ!");
            }
            newrow["Email"] = textBoxEmail.Text;
            newrow["GenderID"] = cbo_GioiTinh.SelectedValue.ToString();


            dt_banHang.Rows.Add(newrow);

            // Cập nhật cơ sở dữ liệu
            int kq = db.updateDataBaseCus(dt_banHang);

            if (kq > 0)
            {
                MessageBox.Show("Tạo thành công");
                LoadDataToDataGridViewHoaDon();
            }
            else
                MessageBox.Show("Tạo thất bại");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = textSearch.Text;

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL tìm kiếm dựa trên giá trị nhập vào TextBox
                string query = "SELECT * FROM Customer WHERE FirtName LIKE @SearchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            // Liên kết DataTable với DataGridView để hiển thị kết quả tìm kiếm
            data_Customer.DataSource = dataTable;
        }

        private void search_KH_Click(object sender, EventArgs e)
        {

            string customerID = textSearch.Text.Trim(); // Lấy mã khách hàng từ TextBox

            try
            {
                // Tạo kết nối mới đến SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo đối tượng SqlCommand để thực thi hàm
                    SqlCommand command = new SqlCommand("SELECT * FROM dbo.f_inTT_Customer(@CUSID)", connection);

                    // Thêm tham số cho hàm
                    command.Parameters.AddWithValue("@CUSID", customerID);

                    // Tạo SqlDataAdapter để lấy dữ liệu trả về từ hàm
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu lấy được trong DataGridView
                    data_Customer.DataSource = dataTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (data_Customer.SelectedRows.Count > 0)
            {

                string OrderetailID = data_Customer.SelectedRows[0].Cells["CustomerID"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Chuỗi kết nối đến cơ sở dữ liệu
                    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Chuẩn bị câu lệnh SQL DELETE
                        string deleteQuery = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = OrderetailID;

                            // Thực hiện câu lệnh SQL DELETE
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có bản ghi nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("khách hàng có mã : " + OrderetailID + " đã được xóa.");
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa " + OrderetailID);
                            }
                        }
                    }

                    // Sau khi xóa, cập nhật lại DataGridView
                    LoadDataToDataGridViewCustomer();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
