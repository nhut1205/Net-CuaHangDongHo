using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_Net
{
    public partial class GDSanPham : Form
    {
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL_CHDONGHO;Integrated Security=True";
        string ID;

        DatabaseHelper dbHelper;
        SqlDataAdapter adapter;
        DataTable dataTable;
        SqlConnection connection;

        public GDSanPham()
        {
            InitializeComponent();
            this.dbHelper = new DatabaseHelper(connectionString);
            connection = new SqlConnection(connectionString);

            InitializeOpenFileDialog();


        }

        private void GDSanPham_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            LoadDataToComboboxCategory();
            LoadDataToComboboxVendor();

            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.TopLevel = false;
            addCategoryForm.FormBorderStyle = FormBorderStyle.None;
            addCategoryForm.Dock = DockStyle.Fill; // Điều này làm cho form con lấp đầy Panel
            panelCategory.Controls.Add(addCategoryForm);
            addCategoryForm.Show();

            AddVendorForm addVendorForm = new AddVendorForm();
            addVendorForm.TopLevel = false;
            addVendorForm.FormBorderStyle = FormBorderStyle.None;
            addVendorForm.Dock = DockStyle.Fill; // Điều này làm cho form con lấp đầy Panel
            panelVendor.Controls.Add(addVendorForm);
            addVendorForm.Show();
        }

        void LoadDataToComboboxCategory()
        {
            string query_Categories = "SELECT * FROM Categories";
            DataTable dataTable_Categories = dbHelper.GetDataTable(query_Categories);
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = dataTable_Categories;
        }

        void LoadDataToComboboxVendor()
        {
            string query_Vendor = "SELECT * FROM Vendors";
            DataTable dataTable_Vendor = dbHelper.GetDataTable(query_Vendor);
            comboBoxVendor.DisplayMember = "Name";
            comboBoxVendor.ValueMember = "VendorId";
            comboBoxVendor.DataSource = dataTable_Vendor;
        }

        void LoadDataToDataGridView()
        {
            string query = "SELECT * FROM Products";

            try
            {

                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dataTable.Columns[0];
                dataTable.PrimaryKey = key;


                dataGridView_SanPham.DataSource = dataTable;

                dataGridView_SanPham.AllowUserToAddRows = false;
                dataGridView_SanPham.AllowUserToDeleteRows = false;


                LoadDataToComboboxCategory();

                LoadDataToComboboxVendor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView_SanPham_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (String.IsNullOrEmpty(dataGridView_SanPham.Rows[e.RowIndex].Cells["Name"].Value.ToString()))
            //{
            ID = dataGridView_SanPham.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
            textBoxProductId.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
            textBoxName.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["Name"].Value.ToString();

            textBoxDescription.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            textBoxPrice.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            textBoxQuantity.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            //comboBoxCategory.SelectedItem = dataGridView_SanPham.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            comboBoxCategory.SelectedValue = dataGridView_SanPham.Rows[e.RowIndex].Cells["CategoryId"].Value.ToString();

            //comboBoxVendor.SelectedItem = dataGridView_SanPham.Rows[e.RowIndex].Cells["VendorName"].Value.ToString();
            comboBoxVendor.SelectedValue = dataGridView_SanPham.Rows[e.RowIndex].Cells["VendorId"].Value.ToString();

            textBoxGuarantee.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["Guarantee"].Value.ToString();
            textBoxDiscountPercent.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["DiscountPercent"].Value.ToString();
            //}
            //else
            //{
            //    textBoxProductId.Clear();
            //    textBoxName.Clear();
            //}
        }

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

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            OpenAddCategoryForm();
            //UpdateCategoryComboBox();
            LoadDataToComboboxCategory();
        }

        private void buttonAddVendor_Click(object sender, EventArgs e)
        {
            OpenAddVendorForm();
            //UpdateVendorComboBox();
            LoadDataToComboboxVendor();
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        PictureBox pb = new PictureBox();
                        System.Drawing.Image loadedImage = System.Drawing.Image.FromFile(file);

                        //textBox1.Text = file.Substring(file.LastIndexOf("\\") + 1);

                        textBox_FilePath.Text = file;

                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        //pb.Image = loadedImage;
                        //flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonThemHinhAnh_Click(object sender, EventArgs e)
        {
            if (textBox_FilePath.Text != string.Empty)
            {
                string productName = textBoxName.Text;
                string FilePath = textBox_FilePath.Text;
                bool successImageUpload = dbHelper.AddImageUpload(productName, FilePath);
                if (successImageUpload)
                {
                    MessageBox.Show("Thêm đường dẫn thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm Đường dẫn.");
                }
            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string categoryName = comboBoxCategory.Text;
            string vendorName = comboBoxVendor.Text;

            // Tạo mã sản phẩm ngẫu nhiên
            string productId = GenerateRandomProductId();

            string productName = textBoxName.Text;
            decimal productPrice = decimal.Parse(textBoxPrice.Text);
            int productQuantity = int.Parse(textBoxQuantity.Text);
            string description = textBoxDescription.Text;
            string guarantee = textBoxGuarantee.Text;

            int discountPercent;
            if (textBoxDiscountPercent.Text == string.Empty)
                discountPercent = 0;
            else
                discountPercent = int.Parse(textBoxDiscountPercent.Text);

            DataRow newrow = dataTable.NewRow();
            newrow["ProductId"] = productId;
            newrow["Name"] = productName;
            newrow["Price"] = productPrice;
            newrow["Quantity"] = productQuantity;
            newrow["CategoryId"] = comboBoxCategory.SelectedValue;
            newrow["VendorId"] = comboBoxVendor.SelectedValue;
            newrow["Description"] = description;
            newrow["Guarantee"] = guarantee;
            newrow["DiscountPercent"] = discountPercent;

            dataTable.Rows.Add(newrow);
            int kq = dbHelper.UpdataDatabase(adapter, dataTable);

            if (kq > 0)
            {
                MessageBox.Show("Thêm sản phẩm thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm.");
            }

            LoadDataToDataGridView();
        }

        // Hàm tạo mã ProductId ngẫu nhiên
        private string GenerateRandomProductId()
        {
            Random random = new Random();
            const string chars = "0123456789";
            string productId = "Prod" + new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return productId;
        }


        //private void buttonXoa_Click(object sender, EventArgs e)
        //{
        //    string categoryName = comboBoxCategory.Text;

        //    string vendorName = comboBoxVendor.Text;

        //    // Thực hiện thêm sản phẩm vào bảng Products
        //    string productName = textBoxName.Text;
        //    decimal productPrice = decimal.Parse(textBoxPrice.Text);
        //    int productQuantity = int.Parse(textBoxQuantity.Text);
        //    string Description = textBoxDescription.Text;
        //    int Guarantee = int.Parse(textBoxGuarantee.Text);
        //    int DiscountPercent;


        //    if (textBoxDiscountPercent.Text == string.Empty)
        //        DiscountPercent = 0;
        //    else
        //        DiscountPercent = int.Parse(textBoxDiscountPercent.Text);

        //    DataRow dr = dataTable.Rows.Find(textBoxProductId.Text);

        //    if (dr != null)
        //    {
        //        dr.Delete();
        //    }
        //    int kq = dbHelper.UpdataDatabase(adapter, dataTable);

        //    if (kq > 0)
        //    {
        //        MessageBox.Show("Xóa thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Xóa không thành công !");
        //    }

        //    LoadDataToDataGridView();
        //}

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string productIdToDelete = textBoxProductId.Text;

            // Kiểm tra xem sản phẩm có trong OrderDetails không
            string checkProductInOrdersQuery = "SELECT COUNT(*) FROM OrderDetails WHERE ProductId = @ProductId";
            int orderCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand checkProductInOrdersCommand = new SqlCommand(checkProductInOrdersQuery, connection);
                    checkProductInOrdersCommand.Parameters.AddWithValue("@ProductId", productIdToDelete);
                    orderCount = (int)checkProductInOrdersCommand.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return;
            }

            if (orderCount > 0)
            {
                // Nếu sản phẩm đã được bán ít nhất một lần, hiển thị thông báo và không xóa sản phẩm
                MessageBox.Show("Sản phẩm đã được bán ít nhất một lần. Không thể xóa!");
            }
            else
            {
                // Nếu sản phẩm không có trong OrderDetails, thực hiện xóa sản phẩm từ bảng Products
                DataRow dr = dataTable.Rows.Find(textBoxProductId.Text);

                if (dr != null)
                {
                    dr.Delete();
                    int kq = dbHelper.UpdataDatabase(adapter, dataTable);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công !");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần xóa trong dữ liệu.");
                }
            }

            LoadDataToDataGridView();
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            //Tim dong du lieu co ma khoa trung voi ma khoa nhap
            //trong textbox
            DataRow dr = dataTable.Rows.Find(textBoxProductId.Text);
            // Hieu chinh thong tin dong tin moi vua tim duoc
            if (dr != null)
            {
                string productName = textBoxName.Text;
                decimal productPrice = decimal.Parse(textBoxPrice.Text);
                int productQuantity = int.Parse(textBoxQuantity.Text);
                string Description = textBoxDescription.Text;
                string Guarantee = textBoxGuarantee.Text;
                bool IsLatestProduct = checkBoxIsLatestProduct.Checked;
                bool IsTrendingProduct = checkBoxIsTrendingProduct.Checked;
                bool IsSpecialProduct = checkBoxIsSpecialProduct.Checked;
                int DiscountPercent;

                if (textBoxDiscountPercent.Text == string.Empty)
                    DiscountPercent = 0;
                else
                    DiscountPercent = int.Parse(textBoxDiscountPercent.Text);

                dr["Name"] = productName;
                dr["Price"] = productPrice;
                dr["Quantity"] = productQuantity;
                dr["CategoryId"] = comboBoxCategory.SelectedValue;
                dr["VendorId"] = comboBoxVendor.SelectedValue;
                dr["Description"] = Description;
                dr["Guarantee"] = Guarantee;
                dr["DiscountPercent"] = DiscountPercent;
            }

            int kq = dbHelper.UpdataDatabase(adapter, dataTable);

            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công !");
            }
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = textBoxSearchProduct.Text;

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable_textBoxSearchProduct = new DataTable();


            string query = "SELECT * FROM Products WHERE Name LIKE " + "'%" + searchText + "%'";
            dataTable_textBoxSearchProduct = dbHelper.GetDataTable(query);

            // Liên kết DataTable với DataGridView để hiển thị kết quả tìm kiếm
            dataGridView_SanPham.DataSource = dataTable_textBoxSearchProduct;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string searchText = textBoxSearchProduct.Text;

            // Tạo DataTable và kết nối đến cơ sở dữ liệu
            DataTable dataTable_textBoxSearchProduct = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL tìm kiếm dựa trên giá trị nhập vào TextBox
                string query = "SELECT * FROM Products WHERE Name LIKE @SearchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable_textBoxSearchProduct);
                }
            }
            // Liên kết DataTable với DataGridView để hiển thị kết quả tìm kiếm
            dataGridView_SanPham.DataSource = dataTable_textBoxSearchProduct;
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            LoadDataToComboboxCategory();
            LoadDataToComboboxVendor();
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductId.Text = dataGridView_SanPham.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
        }

        private void dataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
