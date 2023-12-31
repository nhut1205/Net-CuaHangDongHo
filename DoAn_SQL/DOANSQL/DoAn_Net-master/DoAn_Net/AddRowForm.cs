using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Net
{
    public partial class AddRowForm : Form
    {
        public AddRowForm()
        {
            InitializeComponent();
        }

        private DatabaseHelper dbHelper;
        //AddCategoryForm addCategoryForm;

        public AddRowForm(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;

            // Khởi tạo giao diện cho form thêm sản phẩm mới
            InitializeForm();
            //AddCategoryForm addCategoryForm = new AddCategoryForm(dbHelper);
            //addCategoryForm = new AddCategoryForm();
            //addCategoryForm.CategoryAdded += UpdateCategoryComboBox;

            //AddVendorForm addVendorForm = new AddVendorForm(dbHelper);
            // Đăng ký sự kiện từ AddVendorForm
            //addVendorForm.VendorAdded += UpdateVendorComboBox;
        }

        private void InitializeForm()
        {
            // Lấy danh sách các Category Name từ bảng Category
            List<string> categoryNames = dbHelper.GetCategoryNames();

            // Lấy danh sách các Vendor Name từ bảng Vendor
            List<string> vendorNames = dbHelper.GetVendorNames();

            // Thêm danh sách category names vào ComboBox
            comboBoxCategory.Items.AddRange(categoryNames.ToArray());
            //comboBoxCategory.Items.Add("Thêm mới category..."); // Thêm mục "Thêm mới category..."

            comboBoxVendor.Items.AddRange(vendorNames.ToArray());
            //comboBoxVendor.Items.Add("Thêm mới vendor...");

            buttonAdd.Click += (sender, e) =>
            {
                string categoryName = comboBoxCategory.Text;

                string vendorName = comboBoxVendor.Text;

                // Kiểm tra xem category name đã tồn tại trong bảng Category hay chưa
                //if (categoryName == "Thêm mới category...")
                //{
                //    // Điều hướng đến form để thêm category mới
                //    AddCategoryForm addCategoryForm = new AddCategoryForm(dbHelper);
                //    addCategoryForm.ShowDialog();
                //}
                //else
                //{
                // Thực hiện thêm sản phẩm vào bảng Products
                string productName = textBoxName.Text;
                // Lấy giá trị từ các TextBox khác
                decimal productPrice = decimal.Parse(textBoxPrice.Text);
                int productQuantity = int.Parse(textBoxQuantity.Text);
                string Description = textBoxDescription.Text;
                int Guarantee = int.Parse(textBoxGuarantee.Text);
                bool IsLatestProduct = radioButtonIsLatestProduct.Checked;
                bool IsTrendingProduct = radioButtonIsTrendingProduct.Checked;
                bool IsSpecialProduct = radioButtonIsSpecialProduct.Checked;
                int DiscountPercent = int.Parse(textBoxDiscountPercent.Text);
                // Lấy giá trị từ các CheckBox khác (IsLatestProduct, IsTrendingProduct, IsSpecialProduct)
                //int productGuarantee = int.Parse(textBoxGuarantee.Text);

                // Thêm sản phẩm vào bảng Products (sử dụng dbHelper)
                bool success = dbHelper.AddProduct(productName, productPrice, productQuantity, categoryName, vendorName, Description, Guarantee, IsLatestProduct, IsTrendingProduct, IsSpecialProduct, DiscountPercent);

                if (success)
                {
                    MessageBox.Show("Thêm sản phẩm thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm.");
                }
                //}

                //// Kiểm tra xem category name đã tồn tại trong bảng Category hay chưa
                //if (vendorName == "Thêm mới Vendor...")
                //{
                //    // Điều hướng đến form để thêm category mới
                //    AddVendorForm addVendorForm = new AddVendorForm(dbHelper);
                //    addVendorForm.ShowDialog();
                //}
                //else
                //{
                //    // Thực hiện thêm sản phẩm vào bảng Products
                //    string productName = textBoxName.Text;
                //    // Lấy giá trị từ các TextBox khác
                //    decimal productPrice = decimal.Parse(textBoxPrice.Text);
                //    int productQuantity = int.Parse(textBoxQuantity.Text);
                //    // Lấy giá trị từ các CheckBox khác (IsLatestProduct, IsTrendingProduct, IsSpecialProduct)
                //    //int productGuarantee = int.Parse(textBoxGuarantee.Text);

                //    // Thêm sản phẩm vào bảng Products (sử dụng dbHelper)
                //    bool success = dbHelper.AddProduct(productName, productPrice, productQuantity, categoryName, vendorName);

                //    if (success)
                //    {
                //        MessageBox.Show("Thêm sản phẩm thành công.");
                //        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Lỗi khi thêm sản phẩm.");
                //    }
                //}
            };

            // Sự kiện xảy ra khi người dùng chọn mục trong comboBoxVendor
            //comboBoxVendor.SelectedIndexChanged += ComboBoxVendor_SelectedIndexChanged;

            // Thêm nút "Thêm" vào form
            //this.Controls.Add(buttonAdd);
        }

        //private void ComboBoxVendor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedVendor = comboBoxVendor.SelectedItem.ToString();

        //    if (selectedVendor == "Thêm mới Vendor...")
        //    {
        //        OpenAddVendorForm();
        //    }
        //}

        private void OpenAddCategoryForm()
        {
            using (AddCategoryForm addCategoryForm = new AddCategoryForm())
            {
                addCategoryForm.ShowDialog();

                // Sau khi người dùng tạo mới Vendor, cập nhật lại danh sách Vendor
                //UpdateVendorComboBox();
            }
        }

        private void OpenAddVendorForm()
        {
            using (AddVendorForm addVendorForm = new AddVendorForm())
            {
                addVendorForm.ShowDialog();

                // Sau khi người dùng tạo mới Vendor, cập nhật lại danh sách Vendor
                //UpdateCategoryComboBox();
            }
        }

        private void UpdateCategoryComboBox(/*string categoryName*/)
        {
            // Cập nhật danh sách category names từ cơ sở dữ liệu
            List<string> categoryNames = dbHelper.GetCategoryNames();

            // Xóa danh sách hiện tại trong comboBoxCategory
            comboBoxCategory.Items.Clear();

            // Thêm danh sách category names mới vào comboBoxCategory
            comboBoxCategory.Items.AddRange(categoryNames.ToArray());
            //comboBoxCategory.Items.Add("Thêm mới category..."); // Thêm mục "Thêm mới category..."
        }

        // Hàm xử lý sự kiện để cập nhật danh sách Vendor names trong comboBoxVendor
        private void UpdateVendorComboBox(/*string vendorName*/)
        {
            // Cập nhật danh sách Vendor names từ cơ sở dữ liệu
            List<string> vendorNames = dbHelper.GetVendorNames();

            // Xóa danh sách hiện tại trong comboBoxVendor
            comboBoxVendor.Items.Clear();

            // Thêm danh sách Vendor names mới vào comboBoxVendor
            comboBoxVendor.Items.AddRange(vendorNames.ToArray());
            //comboBoxVendor.Items.Add("Thêm mới Vendor..."); // Thêm mục "Thêm mới Vendor..."
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            OpenAddCategoryForm();
            UpdateCategoryComboBox();
            //AddCategoryForm addCategoryForm = new AddCategoryForm(dbHelper);
            //addCategoryForm.CategoryAdded += UpdateCategoryComboBox;
        }

        private void buttonAddVendor_Click(object sender, EventArgs e)
        {
            OpenAddVendorForm();
            UpdateVendorComboBox();
        }

        bool ValidateTextbox(string textbox, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textbox))
            {
                errorMessage = "Thông tin nhập không hợp lệ !";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!ValidateTextbox(textBoxName.Text, out errMsg))
            {
                e.Cancel = true;
                textBoxName.Select(0, textBoxName.Text.Length);

                this.errorProvider1.SetError(textBoxName, errMsg);
            }
            else
                this.errorProvider1.SetError(textBoxName, "");
        }

        private void textBoxValidateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
