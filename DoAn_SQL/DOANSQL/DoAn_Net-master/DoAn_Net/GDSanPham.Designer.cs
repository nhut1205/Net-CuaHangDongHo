namespace DoAn_Net
{
    partial class GDSanPham
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
            components = new System.ComponentModel.Container();
            dataGridView_SanPham = new DataGridView();
            buttonAdd = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            textBoxSearchProduct = new TextBox();
            buttonTimKiem = new Button();
            textBoxDescription = new TextBox();
            label6 = new Label();
            buttonAddVendor = new Button();
            buttonAddCategory = new Button();
            label5 = new Label();
            comboBoxVendor = new ComboBox();
            comboBoxCategory = new ComboBox();
            textBoxQuantity = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxIsLatestProduct = new CheckBox();
            checkBoxIsTrendingProduct = new CheckBox();
            checkBoxIsSpecialProduct = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            textBoxDiscountPercent = new TextBox();
            label7 = new Label();
            textBoxGuarantee = new TextBox();
            label8 = new Label();
            label9 = new Label();
            button_UploadImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox_FilePath = new TextBox();
            buttonThemHinhAnh = new Button();
            label10 = new Label();
            textBoxProductId = new TextBox();
            buttonLamMoi = new Button();
            buttonXoaHinhAnh = new Button();
            buttonSuaHinhAnh = new Button();
            tabControl1 = new TabControl();
            tabPage_Product = new TabPage();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanelTimKiem = new TableLayoutPanel();
            tabPage_Category = new TabPage();
            panelCategory = new Panel();
            tabPageVendor = new TabPage();
            panelVendor = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage_Product.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanelTimKiem.SuspendLayout();
            tabPage_Category.SuspendLayout();
            tabPageVendor.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_SanPham
            // 
            dataGridView_SanPham.BackgroundColor = Color.White;
            dataGridView_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SanPham.Dock = DockStyle.Fill;
            dataGridView_SanPham.Location = new Point(0, 0);
            dataGridView_SanPham.Name = "dataGridView_SanPham";
            dataGridView_SanPham.RowHeadersWidth = 51;
            dataGridView_SanPham.RowTemplate.Height = 29;
            dataGridView_SanPham.Size = new Size(1568, 284);
            dataGridView_SanPham.TabIndex = 0;
            dataGridView_SanPham.CellClick += dataGridView_SanPham_CellClick;
            dataGridView_SanPham.CellContentClick += dataGridView_SanPham_CellContentClick;
            dataGridView_SanPham.RowHeaderMouseClick += dataGridView_SanPham_RowHeaderMouseClick;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSlateBlue;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(14, 16);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(6, 7, 6, 7);
            buttonAdd.Size = new Size(103, 41);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.MediumSlateBlue;
            buttonSua.FlatAppearance.BorderSize = 0;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(400, 16);
            buttonSua.Name = "buttonSua";
            buttonSua.Padding = new Padding(6, 7, 6, 7);
            buttonSua.Size = new Size(103, 41);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.MediumSlateBlue;
            buttonXoa.FlatAppearance.BorderSize = 0;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(786, 16);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Padding = new Padding(6, 7, 6, 7);
            buttonXoa.Size = new Size(103, 41);
            buttonXoa.TabIndex = 3;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Dock = DockStyle.Fill;
            textBoxSearchProduct.Location = new Point(15, 16);
            textBoxSearchProduct.Margin = new Padding(5);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.Size = new Size(1305, 27);
            textBoxSearchProduct.TabIndex = 4;
            textBoxSearchProduct.TextChanged += textBoxSearchProduct_TextChanged;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.BackColor = Color.MediumSlateBlue;
            buttonTimKiem.FlatAppearance.BorderSize = 0;
            buttonTimKiem.FlatStyle = FlatStyle.Flat;
            buttonTimKiem.ForeColor = Color.White;
            buttonTimKiem.Location = new Point(1328, 14);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 29);
            buttonTimKiem.TabIndex = 5;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(1072, 3);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(417, 27);
            textBoxDescription.TabIndex = 37;
            textBoxDescription.Validating += textBox_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(942, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 36;
            label6.Text = "Mô tả";
            // 
            // buttonAddVendor
            // 
            buttonAddVendor.Location = new Point(589, 765);
            buttonAddVendor.Name = "buttonAddVendor";
            buttonAddVendor.Size = new Size(167, 29);
            buttonAddVendor.TabIndex = 35;
            buttonAddVendor.Text = "Quản lý nhà cung cấp";
            buttonAddVendor.UseVisualStyleBackColor = true;
            buttonAddVendor.Click += buttonAddVendor_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(402, 765);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(181, 29);
            buttonAddCategory.TabIndex = 34;
            buttonAddCategory.Text = "Quản lý loại sản phẩm";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(942, 177);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 33;
            label5.Text = "Nhà cung cấp";
            // 
            // comboBoxVendor
            // 
            comboBoxVendor.Dock = DockStyle.Fill;
            comboBoxVendor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVendor.FormattingEnabled = true;
            comboBoxVendor.Location = new Point(1072, 180);
            comboBoxVendor.Name = "comboBoxVendor";
            comboBoxVendor.Size = new Size(417, 28);
            comboBoxVendor.TabIndex = 32;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Dock = DockStyle.Fill;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(1072, 121);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(417, 28);
            comboBoxCategory.TabIndex = 30;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Dock = DockStyle.Fill;
            textBoxQuantity.Location = new Point(173, 121);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(647, 27);
            textBoxQuantity.TabIndex = 29;
            textBoxQuantity.KeyPress += textBoxValidateNumber_KeyPress;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Dock = DockStyle.Fill;
            textBoxPrice.Location = new Point(1072, 62);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(417, 27);
            textBoxPrice.TabIndex = 28;
            textBoxPrice.KeyPress += textBoxValidateNumber_KeyPress;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(173, 62);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(647, 27);
            textBoxName.TabIndex = 27;
            textBoxName.Validating += textBox_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(942, 118);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 26;
            label4.Text = "Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 118);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 25;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(942, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 24;
            label2.Text = "Giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 59);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 23;
            label1.Text = "Tên sản phẩm";
            // 
            // checkBoxIsLatestProduct
            // 
            checkBoxIsLatestProduct.AutoSize = true;
            checkBoxIsLatestProduct.Location = new Point(9, 5);
            checkBoxIsLatestProduct.Name = "checkBoxIsLatestProduct";
            checkBoxIsLatestProduct.Size = new Size(177, 24);
            checkBoxIsLatestProduct.TabIndex = 43;
            checkBoxIsLatestProduct.Text = "Là sản phẩm mới nhất";
            checkBoxIsLatestProduct.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsTrendingProduct
            // 
            checkBoxIsTrendingProduct.AutoSize = true;
            checkBoxIsTrendingProduct.Location = new Point(379, 5);
            checkBoxIsTrendingProduct.Name = "checkBoxIsTrendingProduct";
            checkBoxIsTrendingProduct.Size = new Size(187, 24);
            checkBoxIsTrendingProduct.TabIndex = 44;
            checkBoxIsTrendingProduct.Text = "Là sản phẩm thịnh hành";
            checkBoxIsTrendingProduct.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSpecialProduct
            // 
            checkBoxIsSpecialProduct.AutoSize = true;
            checkBoxIsSpecialProduct.Location = new Point(198, 5);
            checkBoxIsSpecialProduct.Name = "checkBoxIsSpecialProduct";
            checkBoxIsSpecialProduct.Size = new Size(172, 24);
            checkBoxIsSpecialProduct.TabIndex = 45;
            checkBoxIsSpecialProduct.Text = "Là sản phẩm đặc biệt";
            checkBoxIsSpecialProduct.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textBoxDiscountPercent
            // 
            textBoxDiscountPercent.Dock = DockStyle.Fill;
            textBoxDiscountPercent.Location = new Point(173, 239);
            textBoxDiscountPercent.Name = "textBoxDiscountPercent";
            textBoxDiscountPercent.Size = new Size(647, 27);
            textBoxDiscountPercent.TabIndex = 49;
            textBoxDiscountPercent.KeyPress += textBoxValidateNumber_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 236);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 48;
            label7.Text = "Giảm giá (%)";
            // 
            // textBoxGuarantee
            // 
            textBoxGuarantee.Dock = DockStyle.Fill;
            textBoxGuarantee.Location = new Point(173, 180);
            textBoxGuarantee.Name = "textBoxGuarantee";
            textBoxGuarantee.Size = new Size(647, 27);
            textBoxGuarantee.TabIndex = 47;
            textBoxGuarantee.KeyPress += textBoxValidateNumber_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 177);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 46;
            label8.Text = "Bảo hành (tháng)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(921, 769);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 50;
            label9.Text = "Hình ảnh";
            // 
            // button_UploadImage
            // 
            button_UploadImage.Location = new Point(776, 765);
            button_UploadImage.Margin = new Padding(3, 4, 3, 4);
            button_UploadImage.Name = "button_UploadImage";
            button_UploadImage.Size = new Size(125, 31);
            button_UploadImage.TabIndex = 51;
            button_UploadImage.Text = "Tải lên hình ảnh";
            button_UploadImage.UseVisualStyleBackColor = true;
            button_UploadImage.Click += button_UploadImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(929, 75);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 409);
            flowLayoutPanel1.TabIndex = 52;
            // 
            // textBox_FilePath
            // 
            textBox_FilePath.Location = new Point(1014, 767);
            textBox_FilePath.Name = "textBox_FilePath";
            textBox_FilePath.Size = new Size(290, 27);
            textBox_FilePath.TabIndex = 53;
            // 
            // buttonThemHinhAnh
            // 
            buttonThemHinhAnh.Location = new Point(9, 764);
            buttonThemHinhAnh.Margin = new Padding(3, 4, 3, 4);
            buttonThemHinhAnh.Name = "buttonThemHinhAnh";
            buttonThemHinhAnh.Size = new Size(125, 31);
            buttonThemHinhAnh.TabIndex = 54;
            buttonThemHinhAnh.Text = "Thêm hình ảnh";
            buttonThemHinhAnh.UseVisualStyleBackColor = true;
            buttonThemHinhAnh.Click += buttonThemHinhAnh_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 55;
            label10.Text = "Mã sản phẩm";
            // 
            // textBoxProductId
            // 
            textBoxProductId.Dock = DockStyle.Fill;
            textBoxProductId.Enabled = false;
            textBoxProductId.Location = new Point(173, 3);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.Size = new Size(647, 27);
            textBoxProductId.TabIndex = 56;
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.BackColor = Color.MediumSlateBlue;
            buttonLamMoi.FlatAppearance.BorderSize = 0;
            buttonLamMoi.FlatStyle = FlatStyle.Flat;
            buttonLamMoi.ForeColor = Color.White;
            buttonLamMoi.Location = new Point(1172, 16);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Padding = new Padding(6, 7, 6, 7);
            buttonLamMoi.Size = new Size(103, 41);
            buttonLamMoi.TabIndex = 57;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = false;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // buttonXoaHinhAnh
            // 
            buttonXoaHinhAnh.Location = new Point(141, 764);
            buttonXoaHinhAnh.Margin = new Padding(3, 4, 3, 4);
            buttonXoaHinhAnh.Name = "buttonXoaHinhAnh";
            buttonXoaHinhAnh.Size = new Size(125, 31);
            buttonXoaHinhAnh.TabIndex = 58;
            buttonXoaHinhAnh.Text = "Xóa hình ảnh";
            buttonXoaHinhAnh.UseVisualStyleBackColor = true;
            // 
            // buttonSuaHinhAnh
            // 
            buttonSuaHinhAnh.Location = new Point(271, 764);
            buttonSuaHinhAnh.Margin = new Padding(3, 4, 3, 4);
            buttonSuaHinhAnh.Name = "buttonSuaHinhAnh";
            buttonSuaHinhAnh.Size = new Size(125, 31);
            buttonSuaHinhAnh.TabIndex = 59;
            buttonSuaHinhAnh.Text = "Sửa hình ảnh";
            buttonSuaHinhAnh.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_Product);
            tabControl1.Controls.Add(tabPage_Category);
            tabControl1.Controls.Add(tabPageVendor);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImeMode = ImeMode.Katakana;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1582, 848);
            tabControl1.TabIndex = 60;
            // 
            // tabPage_Product
            // 
            tabPage_Product.BackColor = Color.LightGray;
            tabPage_Product.Controls.Add(panel1);
            tabPage_Product.ForeColor = SystemColors.ControlText;
            tabPage_Product.Location = new Point(4, 29);
            tabPage_Product.Margin = new Padding(3, 4, 3, 4);
            tabPage_Product.Name = "tabPage_Product";
            tabPage_Product.Padding = new Padding(3, 4, 3, 4);
            tabPage_Product.Size = new Size(1574, 815);
            tabPage_Product.TabIndex = 0;
            tabPage_Product.Text = "Sản phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button_UploadImage);
            panel1.Controls.Add(textBox_FilePath);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buttonSuaHinhAnh);
            panel1.Controls.Add(buttonXoaHinhAnh);
            panel1.Controls.Add(buttonThemHinhAnh);
            panel1.Controls.Add(buttonAddCategory);
            panel1.Controls.Add(buttonAddVendor);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanelTimKiem);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1568, 807);
            panel1.TabIndex = 60;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonLamMoi, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonSua, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonXoa, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 681);
            tableLayoutPanel1.Margin = new Padding(11, 13, 11, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1568, 75);
            tableLayoutPanel1.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView_SanPham);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 397);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1568, 284);
            panel3.TabIndex = 62;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBoxIsLatestProduct);
            panel2.Controls.Add(checkBoxIsSpecialProduct);
            panel2.Controls.Add(checkBoxIsTrendingProduct);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(1568, 40);
            panel2.TabIndex = 61;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.89583F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.0833359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.208334F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.354167F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 423F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.45833349F));
            tableLayoutPanel2.Controls.Add(textBoxProductId, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 3, 1);
            tableLayoutPanel2.Controls.Add(textBoxDiscountPercent, 1, 4);
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(textBoxGuarantee, 1, 3);
            tableLayoutPanel2.Controls.Add(textBoxQuantity, 1, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(textBoxDescription, 4, 0);
            tableLayoutPanel2.Controls.Add(comboBoxCategory, 4, 2);
            tableLayoutPanel2.Controls.Add(comboBoxVendor, 4, 3);
            tableLayoutPanel2.Controls.Add(textBoxPrice, 4, 1);
            tableLayoutPanel2.Controls.Add(label5, 3, 3);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 61);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1568, 296);
            tableLayoutPanel2.TabIndex = 60;
            // 
            // tableLayoutPanelTimKiem
            // 
            tableLayoutPanelTimKiem.ColumnCount = 2;
            tableLayoutPanelTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanelTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelTimKiem.Controls.Add(textBoxSearchProduct, 0, 0);
            tableLayoutPanelTimKiem.Controls.Add(buttonTimKiem, 1, 0);
            tableLayoutPanelTimKiem.Dock = DockStyle.Top;
            tableLayoutPanelTimKiem.Location = new Point(0, 0);
            tableLayoutPanelTimKiem.Margin = new Padding(11, 13, 11, 13);
            tableLayoutPanelTimKiem.Name = "tableLayoutPanelTimKiem";
            tableLayoutPanelTimKiem.Padding = new Padding(10, 11, 10, 11);
            tableLayoutPanelTimKiem.RowCount = 1;
            tableLayoutPanelTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTimKiem.Size = new Size(1568, 61);
            tableLayoutPanelTimKiem.TabIndex = 57;
            // 
            // tabPage_Category
            // 
            tabPage_Category.Controls.Add(panelCategory);
            tabPage_Category.Location = new Point(4, 29);
            tabPage_Category.Margin = new Padding(3, 4, 3, 4);
            tabPage_Category.Name = "tabPage_Category";
            tabPage_Category.Padding = new Padding(3, 4, 3, 4);
            tabPage_Category.Size = new Size(1574, 815);
            tabPage_Category.TabIndex = 1;
            tabPage_Category.Text = "Loại sản phẩm";
            tabPage_Category.UseVisualStyleBackColor = true;
            // 
            // panelCategory
            // 
            panelCategory.Dock = DockStyle.Fill;
            panelCategory.Location = new Point(3, 4);
            panelCategory.Margin = new Padding(3, 4, 3, 4);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(1568, 807);
            panelCategory.TabIndex = 0;
            // 
            // tabPageVendor
            // 
            tabPageVendor.Controls.Add(panelVendor);
            tabPageVendor.Location = new Point(4, 29);
            tabPageVendor.Margin = new Padding(3, 4, 3, 4);
            tabPageVendor.Name = "tabPageVendor";
            tabPageVendor.Padding = new Padding(3, 4, 3, 4);
            tabPageVendor.Size = new Size(1574, 815);
            tabPageVendor.TabIndex = 2;
            tabPageVendor.Text = "Nhà cung cấp";
            tabPageVendor.UseVisualStyleBackColor = true;
            // 
            // panelVendor
            // 
            panelVendor.Dock = DockStyle.Fill;
            panelVendor.Location = new Point(3, 4);
            panelVendor.Name = "panelVendor";
            panelVendor.Size = new Size(1568, 807);
            panelVendor.TabIndex = 0;
            // 
            // GDSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1582, 848);
            Controls.Add(tabControl1);
            Controls.Add(flowLayoutPanel1);
            Name = "GDSanPham";
            Text = "GDSanPham";
            Load += GDSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_SanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage_Product.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanelTimKiem.ResumeLayout(false);
            tableLayoutPanelTimKiem.PerformLayout();
            tabPage_Category.ResumeLayout(false);
            tabPageVendor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_SanPham;
        private Button buttonAdd;
        private Button buttonSua;
        private Button buttonXoa;
        private TextBox textBoxSearchProduct;
        private Button buttonTimKiem;
        private TextBox textBoxDescription;
        private Label label6;
        private Button buttonAddVendor;
        private Button buttonAddCategory;
        private Label label5;
        private ComboBox comboBoxVendor;
        private ComboBox comboBoxCategory;
        private TextBox textBoxQuantity;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxIsLatestProduct;
        private CheckBox checkBoxIsTrendingProduct;
        private CheckBox checkBoxIsSpecialProduct;
        private ErrorProvider errorProvider1;
        private TextBox textBoxDiscountPercent;
        private Label label7;
        private TextBox textBoxGuarantee;
        private Label label8;
        private Label label9;
        private Button button_UploadImage;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox_FilePath;
        private Button buttonThemHinhAnh;
        private TextBox textBoxProductId;
        private Label label10;
        private Button buttonLamMoi;
        private Button buttonSuaHinhAnh;
        private Button buttonXoaHinhAnh;
        private TabControl tabControl1;
        private TabPage tabPage_Product;
        private TabPage tabPage_Category;
        private TabPage tabPageVendor;
        private Panel panelCategory;
        private Panel panelVendor;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelTimKiem;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}