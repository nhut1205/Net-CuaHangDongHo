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
using System.Security.Principal;
using FontAwesome.Sharp;
using System.Windows.Media;
using DrawingColor = System.Drawing.Color;

namespace DoAn_Net
{
    public partial class f_main : Form
    {
        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        private string tenTaiKhoan;

        IconButton currentButton;
        Panel leftBorderButton;
        Form currentChildForm;

        public f_main()
        {
            InitializeComponent();

        }

        // Constructor mới nhận tên tài khoản
        public f_main(string tenTaiKhoan)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 59);
            panelLeftFormMain.Controls.Add(leftBorderButton);
        }


        private void f_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat khong?", "Xac nhan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btn_QuanLiKho_Click(object sender, EventArgs e)
        {
            GD_Kho kho = new GD_Kho(tenTaiKhoan);
            this.Hide();
            kho.ShowDialog();
            this.Show();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            GD_BaoCao baoCao = new GD_BaoCao();
            this.Hide();
            baoCao.ShowDialog();
            this.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuanLiNV_Click(object sender, EventArgs e)
        {

            string quyen = GetQuyenForCurrentUser();

            if (quyen == "Admin")
            {
                GDNhanVien nv = new GDNhanVien();
                this.Hide();
                nv.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Lỗi truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetQuyenForCurrentUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IsAdminID FROM Account WHERE Username = @TenTaiKhoan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                    object quyen = command.ExecuteScalar();
                    if (quyen != null)
                    {
                        MessageBox.Show("Quyền của bạn: " + quyen.ToString());
                        return quyen.ToString();
                    }
                }
            }

            return string.Empty;
        }

        private void f_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            GDSanPham sanPham = new GDSanPham();
            this.Hide();
            sanPham.ShowDialog();
            this.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tk = new ThongTinTaiKhoan(tenTaiKhoan);
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private struct RGBColors
        {
            public static DrawingColor color1 = DrawingColor.FromArgb(172, 126, 241);
            public static DrawingColor color2 = DrawingColor.FromArgb(249, 118, 176);
            public static DrawingColor color3 = DrawingColor.FromArgb(253, 138, 114);
            public static DrawingColor color4 = DrawingColor.FromArgb(95, 77, 221);
            public static DrawingColor color5 = DrawingColor.FromArgb(249, 88, 155);
            public static DrawingColor color6 = DrawingColor.FromArgb(24, 161, 251);
        }

        private void KichHoatButton(object sender, DrawingColor color)
        {
            if (sender != null)
            {
                HuyKichHoatButton();

                currentButton = (IconButton)sender;
                currentButton.BackColor = DrawingColor.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                iconPictureBoxCurrentChildForm.IconChar = currentButton.IconChar;
                iconPictureBoxCurrentChildForm.IconColor = color;
            }
        }

        private void HuyKichHoatButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = DrawingColor.FromArgb(31, 30, 68);
                currentButton.ForeColor = DrawingColor.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = DrawingColor.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            HuyKichHoatButton();
            leftBorderButton.Visible = false;
            iconPictureBoxCurrentChildForm.IconChar = IconChar.Home;
            iconPictureBoxCurrentChildForm.IconColor = DrawingColor.MediumPurple;
            labelTitleBar.Text = "Trang chủ";
        }

        private void iconButtonTrangChu_Click(object sender, EventArgs e)
        {
            KichHoatButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void iconButtonSanPham_Click(object sender, EventArgs e)
        {
            KichHoatButton(sender, RGBColors.color2);
            OpenChildForm(new GDSanPham());
        }

        private void iconButtonBanHang_Click(object sender, EventArgs e)
        {
            KichHoatButton(sender, RGBColors.color3);
            OpenChildForm(new GD_Kho(tenTaiKhoan));
        }

        private void iconButtonBaoCao_Click(object sender, EventArgs e)
        {
            KichHoatButton(sender, RGBColors.color4);
            OpenChildForm(new GD_BaoCao());
        }

        private void iconButtonNhanVien_Click(object sender, EventArgs e)
        {
            string quyen = GetQuyenForCurrentUser();

            if (quyen == "ad")
            {
                KichHoatButton(sender, RGBColors.color5);
                OpenChildForm(new GDNhanVien());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Lỗi truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButtonThongTinNV_Click(object sender, EventArgs e)
        {
            KichHoatButton(sender, RGBColors.color6);
            OpenChildForm(new ThongTinTaiKhoan(tenTaiKhoan));
        }

        private void iconButtonDangXuat_Click(object sender, EventArgs e)
        {
            KichHoatButton(sender, RGBColors.color1);
            this.Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = panelDesktop.Size;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            labelTitleBar.Text = childForm.Text;
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
    }
}

