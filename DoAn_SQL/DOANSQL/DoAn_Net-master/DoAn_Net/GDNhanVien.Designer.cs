namespace DoAn_Net
{
    partial class GDNhanVien
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
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btn_reload = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.MediumSlateBlue;
            btn_Xoa.FlatAppearance.BorderSize = 0;
            btn_Xoa.FlatStyle = FlatStyle.Flat;
            btn_Xoa.ForeColor = Color.White;
            btn_Xoa.Location = new Point(405, 13);
            btn_Xoa.Margin = new Padding(11, 13, 11, 13);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(114, 43);
            btn_Xoa.TabIndex = 6;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.MediumSlateBlue;
            btn_Sua.FlatAppearance.BorderSize = 0;
            btn_Sua.FlatStyle = FlatStyle.Flat;
            btn_Sua.ForeColor = Color.White;
            btn_Sua.Location = new Point(208, 13);
            btn_Sua.Margin = new Padding(11, 13, 11, 13);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(114, 43);
            btn_Sua.TabIndex = 5;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.MediumSlateBlue;
            btn_Them.FlatAppearance.BorderSize = 0;
            btn_Them.FlatStyle = FlatStyle.Flat;
            btn_Them.ForeColor = Color.White;
            btn_Them.Location = new Point(11, 13);
            btn_Them.Margin = new Padding(11, 13, 11, 13);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(114, 43);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(554, 13);
            button4.Margin = new Padding(11, 13, 11, 13);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(11, 13);
            textBox1.Margin = new Padding(11, 13, 11, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(521, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(789, 260);
            dataGridView1.TabIndex = 9;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // btn_reload
            // 
            btn_reload.BackColor = Color.MediumSlateBlue;
            btn_reload.FlatAppearance.BorderSize = 0;
            btn_reload.FlatStyle = FlatStyle.Flat;
            btn_reload.ForeColor = Color.White;
            btn_reload.Location = new Point(602, 13);
            btn_reload.Margin = new Padding(11, 13, 11, 13);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(114, 43);
            btn_reload.TabIndex = 10;
            btn_reload.Text = "Làm mới";
            btn_reload.UseVisualStyleBackColor = false;
            btn_reload.Click += btn_reload_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.8325958F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1674F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(789, 67);
            tableLayoutPanel1.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 260);
            panel1.TabIndex = 75;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btn_Them, 0, 0);
            tableLayoutPanel4.Controls.Add(btn_Sua, 1, 0);
            tableLayoutPanel4.Controls.Add(btn_Xoa, 2, 0);
            tableLayoutPanel4.Controls.Add(btn_reload, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 327);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(789, 74);
            tableLayoutPanel4.TabIndex = 77;
            // 
            // GDNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 401);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "GDNhanVien";
            Text = "GDNhanVien";
            Load += GDNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Button button4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btn_reload;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
    }
}