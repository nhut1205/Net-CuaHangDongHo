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
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Data;

namespace DoAn_Net
{
    public partial class ThemNV : Form
    {
        Connection db = new Connection();

        DataTable dt_banHang = new DataTable();

        public ThemNV()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string TenTaiKhoan = txt_TenTaiKhoan.Text;
            string tenHienThi = tenNhanVien.Text;
            //string MatKhau = txt_MatKhau.Text;
            string MatKhau = "nhutdz123";
            string quyen = combo_Quyen.SelectedValue.ToString();
            string gender = cbo_Gender.SelectedValue.ToString();
            if (TenTaiKhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }

            try
            {
                string query = "INSERT INTO Account (Username, Pass , Displayname , IsAdminID , GenderID ) VALUES ('" + TenTaiKhoan + "', '" + MatKhau + "' , '" + tenHienThi + "' , '" + quyen + "' , '"+ gender + "')";
                modify.Command(query);

                if (MessageBox.Show(" Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show(" Tài khoản đã được đăng ký , vui lòng nhập tài khoản khác");
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

        public void load_IsAdmin()
        {
            string sql = "select * from IsAdmin";
            DataTable dt_sanPham = getDatatable(sql);
            combo_Quyen.DataSource = dt_sanPham;
            combo_Quyen.ValueMember = "IsAdminID";
            combo_Quyen.DisplayMember = "NameA";
        }

        public void load_Gender()
        {
            string sql = "select * from Gender";
            DataTable dt_sanPham = getDatatable(sql);
            cbo_Gender.DataSource = dt_sanPham;
            cbo_Gender.ValueMember = "GenderID";
            cbo_Gender.DisplayMember = "GenderType";
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {
            load_IsAdmin();
            load_Gender();
        }
    }
}
