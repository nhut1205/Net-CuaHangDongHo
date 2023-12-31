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
using System.Data;

namespace DoAn_Net
{
    public partial class NhapKho : Form
    {

        Connection db = new Connection();

        DataTable dt_banHang = new DataTable();

        public NhapKho()
        {
            InitializeComponent();
            load_SanPham();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void load_SanPham()
        {
            string sql = "select * from Products";
            DataTable dt_sanPham = getDatatable(sql);
            cbo_SanPham.DataSource = dt_sanPham;
            cbo_SanPham.ValueMember = "ProductID";
            cbo_SanPham.DisplayMember = "Name";
        }
    }
}
