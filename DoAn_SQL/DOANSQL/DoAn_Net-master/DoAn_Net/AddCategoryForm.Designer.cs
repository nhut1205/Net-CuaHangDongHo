namespace DoAn_Net
{
    partial class AddCategoryForm
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
            label3 = new Label();
            textBoxCategoryId = new TextBox();
            textBoxCategoryName = new TextBox();
            label1 = new Label();
            dataGridView_Category = new DataGridView();
            buttonTimKiem = new Button();
            textBoxSearchProduct = new TextBox();
            buttonLamMoi = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Category).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(51, 9);
            label3.Margin = new Padding(8, 9, 8, 9);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã loại";
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Dock = DockStyle.Fill;
            textBoxCategoryId.Enabled = false;
            textBoxCategoryId.Location = new Point(121, 3);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.Size = new Size(375, 27);
            textBoxCategoryId.TabIndex = 1;
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Dock = DockStyle.Fill;
            textBoxCategoryName.Location = new Point(782, 3);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(375, 27);
            textBoxCategoryName.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(710, 9);
            label1.Margin = new Padding(8, 9, 8, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên loại";
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
            dataGridView_Category.Size = new Size(1206, 249);
            dataGridView_Category.TabIndex = 5;
            dataGridView_Category.RowHeaderMouseClick += dataGridView_Category_RowHeaderMouseClick;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.BackColor = Color.FromArgb(192, 0, 192);
            buttonTimKiem.ForeColor = Color.White;
            buttonTimKiem.Location = new Point(841, 13);
            buttonTimKiem.Margin = new Padding(11, 13, 11, 13);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 29);
            buttonTimKiem.TabIndex = 7;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Dock = DockStyle.Fill;
            textBoxSearchProduct.Location = new Point(11, 13);
            textBoxSearchProduct.Margin = new Padding(11, 13, 11, 13);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.Size = new Size(808, 27);
            textBoxSearchProduct.TabIndex = 6;
            textBoxSearchProduct.TextChanged += textBoxSearchProduct_TextChanged;
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.BackColor = Color.FromArgb(192, 0, 192);
            buttonLamMoi.ForeColor = Color.White;
            buttonLamMoi.Location = new Point(914, 13);
            buttonLamMoi.Margin = new Padding(11, 13, 11, 13);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(94, 29);
            buttonLamMoi.TabIndex = 61;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = false;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.FromArgb(192, 0, 192);
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(613, 13);
            buttonXoa.Margin = new Padding(11, 13, 11, 13);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 60;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.FromArgb(192, 0, 192);
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(312, 13);
            buttonSua.Margin = new Padding(11, 13, 11, 13);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 59;
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
            buttonAdd.TabIndex = 58;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAddCategory_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.8325958F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1674F));
            tableLayoutPanel1.Controls.Add(textBoxSearchProduct, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonTimKiem, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1206, 111);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.845606F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6465931F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5021248F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.845607F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.64378F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.516288F));
            tableLayoutPanel2.Controls.Add(label1, 3, 0);
            tableLayoutPanel2.Controls.Add(textBoxCategoryId, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxCategoryName, 4, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 111);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1206, 64);
            tableLayoutPanel2.TabIndex = 63;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Category);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 175);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 249);
            panel1.TabIndex = 64;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonSua, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonXoa, 2, 0);
            tableLayoutPanel3.Controls.Add(buttonLamMoi, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 424);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1206, 68);
            tableLayoutPanel3.TabIndex = 65;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1206, 492);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "AddCategoryForm";
            Text = "AddCategoryForm";
            Load += AddCategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Category).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddCategory;
        private Label label1;
        private Label label2;
        private TextBox textBoxCategoryId;
        private Label label3;
        private TextBox textBoxCategoryName;
        private DataGridView dataGridView_Category;
        private Button buttonTimKiem;
        private TextBox textBoxSearchProduct;
        private Button buttonLamMoi;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}