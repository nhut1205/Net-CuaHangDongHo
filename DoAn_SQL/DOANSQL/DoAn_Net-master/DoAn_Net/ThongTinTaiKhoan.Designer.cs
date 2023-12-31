namespace DoAn_Net
{
    partial class ThongTinTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_CapNhat = new Button();
            txt_TenHienThi = new TextBox();
            txt_Email = new TextBox();
            txt_TenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(610, 12);
            label4.Name = "label4";
            label4.Size = new Size(210, 32);
            label4.TabIndex = 6;
            label4.Text = "Thông tin chi tiết";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(264, 3);
            button1.Name = "button1";
            button1.Size = new Size(109, 43);
            button1.TabIndex = 7;
            button1.Text = "Đổi mật khẩu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1356, 64);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.95055F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.00315F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tableLayoutPanel2.Controls.Add(btn_CapNhat, 2, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 249);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1356, 227);
            tableLayoutPanel2.TabIndex = 11;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.BackColor = Color.MediumSlateBlue;
            btn_CapNhat.FlatAppearance.BorderSize = 0;
            btn_CapNhat.FlatStyle = FlatStyle.Flat;
            btn_CapNhat.ForeColor = Color.White;
            btn_CapNhat.Location = new Point(650, 3);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(147, 43);
            btn_CapNhat.TabIndex = 9;
            btn_CapNhat.Text = "Cập nhật thông tin";
            btn_CapNhat.UseVisualStyleBackColor = false;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // txt_TenHienThi
            // 
            txt_TenHienThi.Dock = DockStyle.Fill;
            txt_TenHienThi.Location = new Point(249, 64);
            txt_TenHienThi.Name = "txt_TenHienThi";
            txt_TenHienThi.Size = new Size(733, 27);
            txt_TenHienThi.TabIndex = 4;
            // 
            // txt_Email
            // 
            txt_Email.Dock = DockStyle.Fill;
            txt_Email.Location = new Point(249, 125);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(733, 27);
            txt_Email.TabIndex = 5;
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Dock = DockStyle.Fill;
            txt_TenDangNhap.Location = new Point(249, 3);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(733, 27);
            txt_TenDangNhap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 122);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 9;
            label8.Text = "Địa chỉ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txt_TenDangNhap, 1, 0);
            tableLayoutPanel1.Controls.Add(txt_Email, 1, 2);
            tableLayoutPanel1.Controls.Add(txt_TenHienThi, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1356, 185);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // ThongTinTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1356, 476);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "ThongTinTaiKhoan";
            Text = "ThongTinTaiKhoan";
            Load += ThongTinTaiKhoan_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button button1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_CapNhat;
        private TextBox txt_TenHienThi;
        private TextBox txt_Email;
        private TextBox txt_TenDangNhap;
        private Label label2;
        private Label label1;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel1;
    }
}