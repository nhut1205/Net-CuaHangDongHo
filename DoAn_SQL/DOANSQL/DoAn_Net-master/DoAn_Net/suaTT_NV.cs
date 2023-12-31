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
    public partial class suaTT_NV : Form
    {
        public suaTT_NV(string tenDangNhap, string tenHienThi, string email, string quyen)
        {
            InitializeComponent();
            txt_TenDangNhap.Text = tenDangNhap;
            txt_TenHienThi.Text = tenHienThi;
            textBtxt_Email.Text = email;
            cbo_Quyen.SelectedItem = quyen;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Lấy giá trị đã chỉnh sửa từ các điều khiển trên form
            string tenDangNhapMoi = txt_TenDangNhap.Text;
            string tenHienThiMoi = txt_TenHienThi.Text;
            string emailMoi = textBtxt_Email.Text;
            string quyenMoi = cbo_Quyen.SelectedValue.ToString();

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Chuẩn bị câu lệnh SQL UPDATE
                string updateQuery = "UPDATE Account SET Displayname = @Displayname, Email = @Email, IsAdminID = @IsAdminID WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Thay thế các tham số trong câu lệnh SQL với giá trị đã chỉnh sửa
                    command.Parameters.AddWithValue("@Username", tenDangNhapMoi);
                    command.Parameters.AddWithValue("@Displayname", tenHienThiMoi);
                    command.Parameters.AddWithValue("@Email", emailMoi);
                    command.Parameters.AddWithValue("@IsAdminID", quyenMoi);

                    // Thực hiện câu lệnh SQL UPDATE
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có bản ghi nào bị cập nhật không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin đã được cập nhật.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin.");
                    }
                }
            }

            // Đóng form sau khi lưu thông tin
            this.Close();
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

        public void load_IsAdmin()
        {
            string sql = "select * from IsAdmin";
            DataTable dt_sanPham = getDatatable(sql);
            cbo_Quyen.DataSource = dt_sanPham;
            cbo_Quyen.ValueMember = "IsAdminID";
            cbo_Quyen.DisplayMember = "NameA";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void suaTT_NV_Load(object sender, EventArgs e)
        {
            load_IsAdmin();
        }
    }
}
