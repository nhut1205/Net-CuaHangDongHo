namespace DoAn_Net
{
    partial class CapNhatThongTin
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
            label2 = new Label();
            tenNv = new Label();
            label6 = new Label();
            button2 = new Button();
            btn_XacNhan = new Button();
            label1 = new Label();
            txt_Address = new TextBox();
            textBoxCMND = new TextBox();
            textPhone = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 213);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 47;
            label2.Text = "PhoneNumber";
            // 
            // tenNv
            // 
            tenNv.AutoSize = true;
            tenNv.Location = new Point(108, 121);
            tenNv.Name = "tenNv";
            tenNv.Size = new Size(55, 20);
            tenNv.TabIndex = 43;
            tenNv.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 167);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 42;
            label6.Text = "CMND";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(533, 299);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 41;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.BackColor = Color.MediumSlateBlue;
            btn_XacNhan.ForeColor = Color.White;
            btn_XacNhan.Location = new Point(292, 299);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(114, 43);
            btn_XacNhan.TabIndex = 40;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = false;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 78);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 38;
            label1.Text = "Tên đăng nhập";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(266, 118);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(427, 27);
            txt_Address.TabIndex = 44;
            // 
            // textBoxCMND
            // 
            textBoxCMND.Location = new Point(266, 160);
            textBoxCMND.Name = "textBoxCMND";
            textBoxCMND.Size = new Size(427, 27);
            textBoxCMND.TabIndex = 48;
            textBoxCMND.KeyPress += textBoxValidateNumber_KeyPress;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(266, 213);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(427, 27);
            textPhone.TabIndex = 49;
            textPhone.KeyPress += textBoxValidateNumber_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 78);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 50;
            label3.Text = "Tên tài khoản";
            // 
            // CapNhatThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textPhone);
            Controls.Add(textBoxCMND);
            Controls.Add(label2);
            Controls.Add(txt_Address);
            Controls.Add(tenNv);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(btn_XacNhan);
            Controls.Add(label1);
            Name = "CapNhatThongTin";
            Text = "CapNhatThongTin";
            Load += CapNhatThongTin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label tenNv;
        private Label label6;
        private Button button2;
        private Button btn_XacNhan;
        private Label label1;
        private TextBox txt_Address;
        private TextBox textBoxCMND;
        private TextBox textPhone;
        private Label label3;
    }
}