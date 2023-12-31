using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DoAn_Net
{
    public partial class Login : Form
    {
        private string tenTaiKhoan;
        public Login()
        {
            InitializeComponent();
        }

        public static string TenTaiKhoan { get; private set; }

        Modify modify = new Modify();


        private void button1_Click(object sender, EventArgs e)
        {
            string tenTK = txt_TenDangNhap.Text;
            string matKhau = txt_MatKhau.Text;

            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else
            {
                string query = "Select * from Account where Username = '" + tenTK + "' and Pass = '" + matKhau + "' COLLATE Latin1_General_BIN"; var users = modify.Users(query);

                if (users.Count() != 0)
                {
                    if (matKhau == "nhutdz123")
                    {
                        // Hiển thị trang đổi lại mật khẩu ở đây
                        // Điều này phụ thuộc vào cách bạn thiết kế form đổi mật khẩu.
                        DoiMK doiMK = new DoiMK(tenTK);
                        this.Hide();
                        doiMK.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        // Truyền tên tài khoản vào form f_main
                        f_main f_Main = new f_main(tenTK);
                        this.Hide();
                        f_Main.ShowDialog();
                        txt_MatKhau.Text = "";
                        txt_TenDangNhap.Text = "";
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác !");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
        }
    }
}
