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
    public partial class CapNhatThongTin : Form
    {
        public CapNhatThongTin()
        {
            InitializeComponent();
        }

        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        private string tenDangNhap;
        public CapNhatThongTin(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private string GetLoggedInUsername()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Điều kiện để xác định tên tài khoản đang đăng nhập.
                string userName = GetNameForCurrentUser(tenDangNhap);
                string selectQuery = "SELECT Username FROM Account WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.AddWithValue("@Username", userName);

                    // Thực thi câu lệnh SQL và trả về tên tài khoản
                    return (string)command.ExecuteScalar();
                }
            }
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

        private void CapNhatThongTin_Load(object sender, EventArgs e)
        {
            label1.Text = tenDangNhap;
        }

        public bool UpdateInfor(string username, string address, string cmnd, string phone)
        {
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra xem thông tin của username đã tồn tại trong bảng hay chưa
                string checkIfExistsQuery = "SELECT COUNT(*) FROM Userdetails WHERE Username = @Username";
                using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExistsQuery, connection))
                {
                    checkIfExistsCommand.Parameters.AddWithValue("@Username", username);
                    int count = (int)checkIfExistsCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Nếu thông tin đã tồn tại, thực hiện câu lệnh UPDATE
                        string updateQuery = "UPDATE Userdetails SET Address = @NewAddress, CMND = @NewCMND, PhoneNumber = @NewPhoneNumber WHERE Username = @Username";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@NewAddress", address);
                            updateCommand.Parameters.AddWithValue("@NewCMND", cmnd);
                            updateCommand.Parameters.AddWithValue("@NewPhoneNumber", phone);
                            updateCommand.Parameters.AddWithValue("@Username", username);

                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                    else
                    {
                        // Nếu thông tin chưa tồn tại, thực hiện câu lệnh INSERT
                        string insertQuery = "INSERT INTO Userdetails (Username, Address, CMND, PhoneNumber) VALUES (@Username, @Address, @CMND, @PhoneNumber)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Username", username);
                            insertCommand.Parameters.AddWithValue("@Address", address);
                            insertCommand.Parameters.AddWithValue("@CMND", cmnd);
                            insertCommand.Parameters.AddWithValue("@PhoneNumber", phone);

                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                }
            }
        }


        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string diaChi = txt_Address.Text;
            string cmnd = textBoxCMND.Text;
            string phone = textPhone.Text;

            if (cmnd.Length != 12 || phone.Length != 10)
            {
                MessageBox.Show("Định dạng số CMND hoặc số điện thoại không đúng");
            }
            else
            {
                string username = GetLoggedInUsername(); // Lấy tên tài khoản từ cơ sở dữ liệu

                if (!string.IsNullOrEmpty(username))
                {
                    if (UpdateInfor(username, diaChi, cmnd, phone))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Sau khi cập nhật thành công, bạn có thể thực hiện các hành động khác ở đây.
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void textBoxValidateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
