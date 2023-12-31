namespace DoAn_Net
{
    partial class ThemNV
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
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            txt_TenTaiKhoan = new TextBox();
            label7 = new Label();
            label1 = new Label();
            tenNhanVien = new TextBox();
            tenNv = new Label();
            combo_Quyen = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            cbo_Gender = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 174);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 29;
            label6.Text = "Quyền";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(526, 329);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 28;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(287, 329);
            button1.Name = "button1";
            button1.Size = new Size(115, 43);
            button1.TabIndex = 27;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_TenTaiKhoan
            // 
            txt_TenTaiKhoan.Location = new Point(258, 71);
            txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            txt_TenTaiKhoan.Size = new Size(427, 27);
            txt_TenTaiKhoan.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 21);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 22;
            label7.Text = "Thêm nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 74);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 17;
            label1.Text = "Tên đăng nhập";
            // 
            // tenNhanVien
            // 
            tenNhanVien.Location = new Point(258, 114);
            tenNhanVien.Name = "tenNhanVien";
            tenNhanVien.Size = new Size(427, 27);
            tenNhanVien.TabIndex = 33;
            // 
            // tenNv
            // 
            tenNv.AutoSize = true;
            tenNv.Location = new Point(100, 117);
            tenNv.Name = "tenNv";
            tenNv.Size = new Size(85, 20);
            tenNv.TabIndex = 32;
            tenNv.Text = "Tên hiển thị";
            // 
            // combo_Quyen
            // 
            combo_Quyen.FormattingEnabled = true;
            combo_Quyen.Location = new Point(258, 174);
            combo_Quyen.Name = "combo_Quyen";
            combo_Quyen.Size = new Size(427, 28);
            combo_Quyen.TabIndex = 34;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 35;
            iconPictureBox1.TabStop = false;
            // 
            // cbo_Gender
            // 
            cbo_Gender.FormattingEnabled = true;
            cbo_Gender.Location = new Point(258, 245);
            cbo_Gender.Name = "cbo_Gender";
            cbo_Gender.Size = new Size(427, 28);
            cbo_Gender.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 253);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 37;
            label2.Text = "Giới tính";
            // 
            // ThemNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(cbo_Gender);
            Controls.Add(iconPictureBox1);
            Controls.Add(combo_Quyen);
            Controls.Add(tenNhanVien);
            Controls.Add(tenNv);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_TenTaiKhoan);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "ThemNV";
            Text = "ThemNV";
            Load += ThemNV_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Button button2;
        private Button button1;
        private TextBox txt_TenTaiKhoan;
        private Label label7;
        private Label label1;
        private TextBox tenNhanVien;
        private Label tenNv;
        private ComboBox combo_Quyen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox cbo_Gender;
        private Label label2;
    }
}