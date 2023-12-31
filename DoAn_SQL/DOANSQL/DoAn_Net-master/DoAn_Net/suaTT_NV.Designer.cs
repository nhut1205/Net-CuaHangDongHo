namespace DoAn_Net
{
    partial class suaTT_NV
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
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            txt_TenDangNhap = new TextBox();
            txt_TenHienThi = new TextBox();
            button2 = new Button();
            textBtxt_Email = new TextBox();
            label2 = new Label();
            label4 = new Label();
            cbo_Quyen = new ComboBox();
            btn_Luu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 75);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 141);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên hiển thị mới";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 9);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 6;
            label7.Text = "Sửa thông tin nhân viên";
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Enabled = false;
            txt_TenDangNhap.Location = new Point(216, 72);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(427, 27);
            txt_TenDangNhap.TabIndex = 7;
            // 
            // txt_TenHienThi
            // 
            txt_TenHienThi.Location = new Point(216, 134);
            txt_TenHienThi.Name = "txt_TenHienThi";
            txt_TenHienThi.Size = new Size(427, 27);
            txt_TenHienThi.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(549, 344);
            button2.Name = "button2";
            button2.Size = new Size(94, 43);
            button2.TabIndex = 13;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBtxt_Email
            // 
            textBtxt_Email.Location = new Point(216, 200);
            textBtxt_Email.Name = "textBtxt_Email";
            textBtxt_Email.Size = new Size(427, 27);
            textBtxt_Email.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 207);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 15;
            label2.Text = "Email mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 281);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "Quyền mới";
            // 
            // cbo_Quyen
            // 
            cbo_Quyen.FormattingEnabled = true;
            cbo_Quyen.Location = new Point(216, 281);
            cbo_Quyen.Name = "cbo_Quyen";
            cbo_Quyen.Size = new Size(427, 28);
            cbo_Quyen.TabIndex = 18;
            // 
            // btn_Luu
            // 
            btn_Luu.BackColor = Color.MediumSlateBlue;
            btn_Luu.ForeColor = Color.White;
            btn_Luu.Location = new Point(216, 344);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(96, 43);
            btn_Luu.TabIndex = 19;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = false;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // suaTT_NV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Luu);
            Controls.Add(cbo_Quyen);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBtxt_Email);
            Controls.Add(button2);
            Controls.Add(txt_TenHienThi);
            Controls.Add(txt_TenDangNhap);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "suaTT_NV";
            Text = "suaTT_NV";
            Load += suaTT_NV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label7;
        private TextBox txt_TenDangNhap;
        private TextBox txt_TenHienThi;
        private Button button2;
        private TextBox textBtxt_Email;
        private Label label2;
        private Label label4;
        private ComboBox cbo_Quyen;
        private Button btn_Luu;
    }
}