namespace DoAn_Net
{
    partial class AddVendorForm
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
            buttonLamMoi = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonAdd = new Button();
            buttonTimKiem = new Button();
            textBoxSearchVendor = new TextBox();
            dataGridView_Category = new DataGridView();
            textBoxVendorName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxSearchProduct = new TextBox();
            button2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxVendorId = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Category).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.BackColor = Color.FromArgb(192, 0, 192);
            buttonLamMoi.ForeColor = Color.White;
            buttonLamMoi.Location = new Point(794, 13);
            buttonLamMoi.Margin = new Padding(11, 13, 11, 13);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(94, 29);
            buttonLamMoi.TabIndex = 72;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.FromArgb(192, 0, 192);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(533, 13);
            buttonXoa.Margin = new Padding(11, 13, 11, 13);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 71;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.FromArgb(192, 0, 192);
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(272, 13);
            buttonSua.Margin = new Padding(11, 13, 11, 13);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 70;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 0, 192);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(11, 13);
            buttonAdd.Margin = new Padding(11, 13, 11, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 69;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.BackColor = Color.FromArgb(192, 0, 192);
            buttonTimKiem.ForeColor = Color.White;
            buttonTimKiem.Location = new Point(730, 13);
            buttonTimKiem.Margin = new Padding(11, 13, 11, 13);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 29);
            buttonTimKiem.TabIndex = 68;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxSearchVendor
            // 
            textBoxSearchVendor.Dock = DockStyle.Fill;
            textBoxSearchVendor.Location = new Point(11, 13);
            textBoxSearchVendor.Margin = new Padding(11, 13, 11, 13);
            textBoxSearchVendor.Name = "textBoxSearchVendor";
            textBoxSearchVendor.Size = new Size(697, 27);
            textBoxSearchVendor.TabIndex = 67;
            textBoxSearchVendor.TextChanged += textBoxSearchVendor_TextChanged;
            // 
            // dataGridView_Category
            // 
            dataGridView_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Category.Dock = DockStyle.Fill;
            dataGridView_Category.Location = new Point(0, 0);
            dataGridView_Category.Name = "dataGridView_Category";
            dataGridView_Category.RowHeadersWidth = 51;
            dataGridView_Category.RowTemplate.Height = 29;
            dataGridView_Category.Size = new Size(1045, 247);
            dataGridView_Category.TabIndex = 66;
            dataGridView_Category.RowHeaderMouseClick += dataGridView_Category_RowHeaderMouseClick;
            // 
            // textBoxVendorName
            // 
            textBoxVendorName.Dock = DockStyle.Fill;
            textBoxVendorName.Location = new Point(678, 3);
            textBoxVendorName.Name = "textBoxVendorName";
            textBoxVendorName.Size = new Size(324, 27);
            textBoxVendorName.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(576, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 40);
            label1.TabIndex = 64;
            label1.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 40);
            label3.TabIndex = 62;
            label3.Text = "Mã nhà cung cấp";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.8325958F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1674F));
            tableLayoutPanel1.Controls.Add(textBoxSearchVendor, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonTimKiem, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1045, 67);
            tableLayoutPanel1.TabIndex = 73;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.8325958F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1674F));
            tableLayoutPanel2.Controls.Add(textBoxSearchProduct, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Dock = DockStyle.Fill;
            textBoxSearchProduct.Location = new Point(10, 10);
            textBoxSearchProduct.Margin = new Padding(10);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.Size = new Size(117, 27);
            textBoxSearchProduct.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(147, 10);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(43, 22);
            button2.TabIndex = 7;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.845606F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6465931F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5021248F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.845607F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.64378F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.516288F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 3, 0);
            tableLayoutPanel3.Controls.Add(textBoxVendorName, 4, 0);
            tableLayoutPanel3.Controls.Add(textBoxVendorId, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 67);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1045, 64);
            tableLayoutPanel3.TabIndex = 74;
            // 
            // textBoxVendorId
            // 
            textBoxVendorId.Enabled = false;
            textBoxVendorId.Location = new Point(105, 3);
            textBoxVendorId.Name = "textBoxVendorId";
            textBoxVendorId.Size = new Size(324, 27);
            textBoxVendorId.TabIndex = 66;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Category);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 131);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 247);
            panel1.TabIndex = 75;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.LightGray;
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonSua, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonXoa, 2, 0);
            tableLayoutPanel4.Controls.Add(buttonLamMoi, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 378);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1045, 63);
            tableLayoutPanel4.TabIndex = 76;
            // 
            // AddVendorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 441);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "AddVendorForm";
            Text = "AddVendorForm";
            Load += AddVendorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Category).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLamMoi;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonAdd;
        private Button buttonTimKiem;
        private TextBox textBoxSearchVendor;
        private DataGridView dataGridView_Category;
        private TextBox textBoxVendorName;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxSearchProduct;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBoxVendorId;
    }
}