namespace DoAn_Net
{
    partial class NhapKho
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
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            cbo_SanPham = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 25);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 132);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Chọn số lượng";
            // 
            // cbo_SanPham
            // 
            cbo_SanPham.FormattingEnabled = true;
            cbo_SanPham.Location = new Point(111, 67);
            cbo_SanPham.Name = "cbo_SanPham";
            cbo_SanPham.Size = new Size(338, 28);
            cbo_SanPham.TabIndex = 2;
            cbo_SanPham.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(122, 269);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 4;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(323, 269);
            button2.Name = "button2";
            button2.Size = new Size(100, 42);
            button2.TabIndex = 5;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            // 
            // NhapKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(cbo_SanPham);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhapKho";
            Text = "NhapKho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ColorDialog colorDialog1;
        private ComboBox cbo_SanPham;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}