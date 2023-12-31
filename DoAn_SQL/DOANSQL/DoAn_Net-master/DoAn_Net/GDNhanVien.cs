using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn_Net
{
    public partial class GDNhanVien : Form
    {
        public GDNhanVien()
        {
            InitializeComponent();
        }

        private void LoadDataToDataGridView()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Account";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            // Liên kết DataTable với DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNV nv = new ThemNV();
            nv.ShowDialog();
            LoadDataToDataGridView();
        }

        private void GDNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.Columns["Pass"].DisplayIndex = 4;
            dataGridView1.Columns["Username"].DisplayIndex = 0; // Cột Tên đăng nhập
            dataGridView1.Columns["Displayname"].DisplayIndex = 1;  // Cột Tên hiển thị
            dataGridView1.Columns["Email"].DisplayIndex = 2;        // Cột Email
            dataGridView1.Columns["IsAdminID"].DisplayIndex = 3;        // Cột Quyền
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        //tìm kiếm đối tượng có tên gần đúng
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = textBox1.Text;

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL tìm kiếm dựa trên giá trị nhập vào TextBox
                string query = "SELECT * FROM Account WHERE Username LIKE @SearchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            // Liên kết DataTable với DataGridView để hiển thị kết quả tìm kiếm
            dataGridView1.DataSource = dataTable;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của các cột từ dòng đang chọn
                string tenDangNhap = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                string tenHienThi = dataGridView1.SelectedRows[0].Cells["Displayname"].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                string quyen = dataGridView1.SelectedRows[0].Cells["IsAdminID"].Value.ToString();

                // Tạo một thể hiện của form SuaThongTinNV và truyền dữ liệu đã lấy từ DataGridView
                suaTT_NV suaForm = new suaTT_NV(tenDangNhap, tenHienThi, email, quyen);

                // Hiển thị form SuaThongTinNV
                suaForm.ShowDialog();

                // Sau khi form SuaThongTinNV được đóng, cập nhật lại DataGridView
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        //private void btn_Xoa_Click(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem có dòng nào được chọn không
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        string tenDangNhap = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
        //        string quyen = dataGridView1.SelectedRows[0].Cells["IsAdminID"].Value.ToString();

        //        if (quyen == "ad")
        //        {
        //            MessageBox.Show("Bạn không thể xóa người dùng có quyền là 'Admin'.", "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //            if (result == DialogResult.Yes)
        //            {
        //                string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

        //                using (SqlConnection connection = new SqlConnection(connectionString))
        //                {
        //                    connection.Open();

        //                    // Chuẩn bị câu lệnh SQL DELETE từ bảng UserDetails trước
        //                    string deleteUserDetailsQuery = "DELETE FROM UserDetails WHERE Username = @TenDangNhap";

        //                    using (SqlCommand userDetailsCommand = new SqlCommand(deleteUserDetailsQuery, connection))
        //                    {
        //                        userDetailsCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

        //                        // Thực hiện câu lệnh SQL DELETE để xóa thông tin liên quan từ bảng UserDetails
        //                        int userDetailsRowsAffected = userDetailsCommand.ExecuteNonQuery();

        //                        // Tiếp tục xóa từ bảng Account nếu đã xóa thành công từ UserDetails và nếu không phải là quyền 'Admin'
        //                        if (userDetailsRowsAffected > 0 && quyen != "1")
        //                        {
        //                            // Tiếp tục với việc xóa tài khoản từ bảng Account
        //                            string deleteAccountQuery = "DELETE FROM Account WHERE Username = @TenDangNhap";

        //                            using (SqlCommand accountCommand = new SqlCommand(deleteAccountQuery, connection))
        //                            {
        //                                accountCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

        //                                // Thực hiện câu lệnh SQL DELETE từ bảng Account
        //                                int accountRowsAffected = accountCommand.ExecuteNonQuery();

        //                                if (accountRowsAffected > 0)
        //                                {
        //                                    MessageBox.Show("Nhân viên có Tên đăng nhập: " + tenDangNhap + " đã được xóa.");
        //                                }
        //                                else
        //                                {
        //                                    MessageBox.Show("Không thể xóa nhân viên có Tên đăng nhập: " + tenDangNhap);
        //                                }
        //                            }
        //                        }
        //                        else if (quyen == "1")
        //                        {
        //                            MessageBox.Show("Bạn không thể xóa người dùng có quyền là 'Admin'.", "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Không thể xóa thông tin chi tiết của nhân viên có Tên đăng nhập: " + tenDangNhap);
        //                        }
        //                    }
        //                }

        //                // Sau khi xóa, cập nhật lại DataGridView
        //                LoadDataToDataGridView();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một dòng để xóa.");
        //    }
        //}


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tenDangNhap = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                string quyen = dataGridView1.SelectedRows[0].Cells["IsAdminID"].Value.ToString();

                string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Kiểm tra nếu là người dùng có quyền 'Admin' thì không thực hiện xóa
                        if (quyen == "ad")
                        {
                            MessageBox.Show("Bạn không thể xóa người dùng có quyền là 'Admin'.", "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Chuẩn bị câu lệnh SQL kiểm tra xem có đơn hàng liên quan từ bảng Orders không
                            string checkOrdersQuery = "SELECT COUNT(*) FROM Orders WHERE Username = @TenDangNhap";

                            using (SqlCommand checkOrdersCommand = new SqlCommand(checkOrdersQuery, connection))
                            {
                                checkOrdersCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                                int ordersCount = (int)checkOrdersCommand.ExecuteScalar();

                                if (ordersCount > 0)
                                {
                                    MessageBox.Show("Cảnh báo: Người dùng này đang có đơn hàng trong hệ thống. Không thể xóa thông tin chi tiết của người dùng có Tên đăng nhập: " + tenDangNhap);
                                }
                                else
                                {
                                    // Nếu không có đơn hàng liên quan, xóa thông tin từ UserDetails và Account

                                    // Chuẩn bị câu lệnh SQL DELETE từ bảng UserDetails
                                    string deleteUserDetailsQuery = "DELETE FROM UserDetails WHERE Username = @TenDangNhap";

                                    using (SqlCommand userDetailsCommand = new SqlCommand(deleteUserDetailsQuery, connection))
                                    {
                                        userDetailsCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                                        // Thực hiện câu lệnh SQL DELETE để xóa thông tin liên quan từ bảng UserDetails
                                        int userDetailsRowsAffected = userDetailsCommand.ExecuteNonQuery();

                                        if (userDetailsRowsAffected > 0)
                                        {
                                            MessageBox.Show("Thông tin của người dùng có Tên đăng nhập: " + tenDangNhap + " đã được xóa từ UserDetails.");

                                            // Tiến hành xóa người dùng từ bảng Account
                                            string deleteAccountQuery = "DELETE FROM Account WHERE Username = @TenDangNhap";

                                            using (SqlCommand accountCommand = new SqlCommand(deleteAccountQuery, connection))
                                            {
                                                accountCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                                                // Thực hiện câu lệnh SQL DELETE từ bảng Account
                                                int accountRowsAffected = accountCommand.ExecuteNonQuery();

                                                if (accountRowsAffected > 0)
                                                {
                                                    MessageBox.Show("Thông tin tài khoản của người dùng có Tên đăng nhập: " + tenDangNhap + " đã được xóa từ Account.");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Không thể xóa thông tin tài khoản của người dùng có Tên đăng nhập: " + tenDangNhap);
                                                }
                                            }

                                            // Sau khi xóa UserDetails và Account, cập nhật lại DataGridView
                                            LoadDataToDataGridView();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Không thể xóa thông tin chi tiết của người dùng có Tên đăng nhập: " + tenDangNhap);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa: " + ex.Message, "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }
 

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
