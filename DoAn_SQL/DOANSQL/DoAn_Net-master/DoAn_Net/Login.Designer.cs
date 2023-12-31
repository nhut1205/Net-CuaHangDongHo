namespace DoAn_Net
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_TenDangNhap = new TextBox();
            txt_MatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Login = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(135, 127);
            txt_TenDangNhap.Margin = new Padding(3, 2, 3, 2);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(265, 23);
            txt_TenDangNhap.TabIndex = 0;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(135, 177);
            txt_MatKhau.Margin = new Padding(3, 2, 3, 2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(265, 23);
            txt_MatKhau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 127);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 183);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.MediumSlateBlue;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(28, 232);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(372, 37);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txt_TenDangNhap);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_MatKhau);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 361);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 78);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 33);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 5;
            label3.Text = "Welcome";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(432, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 361);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(927, 361);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Gainsboro;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_TenDangNhap;
        private TextBox txt_MatKhau;
        private Label label1;
        private Label label2;
        private Button btn_Login;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}