namespace DoAn_Net
{
    partial class AddRowForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            comboBoxCategory = new ComboBox();
            buttonAdd = new Button();
            comboBoxVendor = new ComboBox();
            label5 = new Label();
            buttonAddCategory = new Button();
            buttonAddVendor = new Button();
            label6 = new Label();
            textBoxDescription = new TextBox();
            label10 = new Label();
            radioButtonIsLatestProduct = new RadioButton();
            radioButtonIsTrendingProduct = new RadioButton();
            radioButtonIsSpecialProduct = new RadioButton();
            textBoxGuarantee = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            textBoxDiscountPercent = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 57);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 123);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 168);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 211);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "Loại";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(266, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(292, 27);
            textBoxName.TabIndex = 4;
            textBoxName.Validating += textBox_Validating;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(266, 116);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(292, 27);
            textBoxPrice.TabIndex = 5;
            textBoxPrice.KeyPress += textBoxValidateNumber_KeyPress;
            textBoxPrice.Validating += textBox_Validating;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(266, 161);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(292, 27);
            textBoxQuantity.TabIndex = 6;
            textBoxQuantity.KeyPress += textBoxValidateNumber_KeyPress;
            textBoxQuantity.Validating += textBox_Validating;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(266, 203);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(292, 28);
            comboBoxCategory.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(464, 438);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxVendor
            // 
            comboBoxVendor.FormattingEnabled = true;
            comboBoxVendor.Location = new Point(266, 240);
            comboBoxVendor.Name = "comboBoxVendor";
            comboBoxVendor.Size = new Size(292, 28);
            comboBoxVendor.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 249);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Nhà cung cấp";
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(574, 202);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(167, 29);
            buttonAddCategory.TabIndex = 11;
            buttonAddCategory.Text = "Thêm mới Category";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonAddVendor
            // 
            buttonAddVendor.Location = new Point(574, 240);
            buttonAddVendor.Name = "buttonAddVendor";
            buttonAddVendor.Size = new Size(167, 29);
            buttonAddVendor.TabIndex = 12;
            buttonAddVendor.Text = "Thêm mới Vendor";
            buttonAddVendor.UseVisualStyleBackColor = true;
            buttonAddVendor.Click += buttonAddVendor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 90);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Mô tả";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(266, 83);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(292, 27);
            textBoxDescription.TabIndex = 14;
            textBoxDescription.Validating += textBox_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(64, 296);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 18;
            label10.Text = "Bảo hành (tháng)";
            // 
            // radioButtonIsLatestProduct
            // 
            radioButtonIsLatestProduct.AutoSize = true;
            radioButtonIsLatestProduct.Location = new Point(69, 389);
            radioButtonIsLatestProduct.Name = "radioButtonIsLatestProduct";
            radioButtonIsLatestProduct.Size = new Size(176, 24);
            radioButtonIsLatestProduct.TabIndex = 19;
            radioButtonIsLatestProduct.TabStop = true;
            radioButtonIsLatestProduct.Text = "Là sản phẩm mới nhất";
            radioButtonIsLatestProduct.UseVisualStyleBackColor = true;
            // 
            // radioButtonIsTrendingProduct
            // 
            radioButtonIsTrendingProduct.AutoSize = true;
            radioButtonIsTrendingProduct.Location = new Point(271, 389);
            radioButtonIsTrendingProduct.Name = "radioButtonIsTrendingProduct";
            radioButtonIsTrendingProduct.Size = new Size(186, 24);
            radioButtonIsTrendingProduct.TabIndex = 20;
            radioButtonIsTrendingProduct.TabStop = true;
            radioButtonIsTrendingProduct.Text = "Là sản phẩm thịnh hành";
            radioButtonIsTrendingProduct.UseVisualStyleBackColor = true;
            // 
            // radioButtonIsSpecialProduct
            // 
            radioButtonIsSpecialProduct.AutoSize = true;
            radioButtonIsSpecialProduct.Location = new Point(474, 389);
            radioButtonIsSpecialProduct.Name = "radioButtonIsSpecialProduct";
            radioButtonIsSpecialProduct.Size = new Size(171, 24);
            radioButtonIsSpecialProduct.TabIndex = 21;
            radioButtonIsSpecialProduct.TabStop = true;
            radioButtonIsSpecialProduct.Text = "Là sản phẩm đặc biệt";
            radioButtonIsSpecialProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxGuarantee
            // 
            textBoxGuarantee.Location = new Point(266, 289);
            textBoxGuarantee.Name = "textBoxGuarantee";
            textBoxGuarantee.Size = new Size(292, 27);
            textBoxGuarantee.TabIndex = 22;
            textBoxGuarantee.KeyPress += textBoxValidateNumber_KeyPress;
            textBoxGuarantee.Validating += textBox_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 339);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 23;
            label7.Text = "Giảm giá (%)";
            // 
            // textBoxDiscountPercent
            // 
            textBoxDiscountPercent.Location = new Point(266, 332);
            textBoxDiscountPercent.Name = "textBoxDiscountPercent";
            textBoxDiscountPercent.Size = new Size(292, 27);
            textBoxDiscountPercent.TabIndex = 24;
            // 
            // AddRowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 508);
            Controls.Add(textBoxDiscountPercent);
            Controls.Add(label7);
            Controls.Add(textBoxGuarantee);
            Controls.Add(radioButtonIsSpecialProduct);
            Controls.Add(radioButtonIsTrendingProduct);
            Controls.Add(radioButtonIsLatestProduct);
            Controls.Add(label10);
            Controls.Add(textBoxDescription);
            Controls.Add(label6);
            Controls.Add(buttonAddVendor);
            Controls.Add(buttonAddCategory);
            Controls.Add(label5);
            Controls.Add(comboBoxVendor);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRowForm";
            Text = "AddRowForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private ComboBox comboBoxCategory;
        private Button buttonAdd;
        private ComboBox comboBoxVendor;
        private Label label5;
        private Button buttonAddCategory;
        private Button buttonAddVendor;
        private Label label6;
        private TextBox textBoxDescription;
        private Label label10;
        private RadioButton radioButtonIsLatestProduct;
        private RadioButton radioButtonIsTrendingProduct;
        private RadioButton radioButtonIsSpecialProduct;
        private TextBox textBoxGuarantee;
        private ErrorProvider errorProvider1;
        private TextBox textBoxDiscountPercent;
        private Label label7;
    }
}