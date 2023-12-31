namespace DoAn_Net
{
    partial class GD_BaoCao
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
            dataGridHoaDon = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            cbo_LocHoaDon = new ComboBox();
            panel4 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridHoaDon).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridHoaDon
            // 
            dataGridHoaDon.BackgroundColor = Color.White;
            dataGridHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHoaDon.Location = new Point(361, 74);
            dataGridHoaDon.Name = "dataGridHoaDon";
            dataGridHoaDon.RowHeadersWidth = 51;
            dataGridHoaDon.RowTemplate.Height = 29;
            dataGridHoaDon.Size = new Size(1031, 486);
            dataGridHoaDon.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbo_LocHoaDon);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(9, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 221);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(19, 129);
            button1.Name = "button1";
            button1.Size = new Size(309, 29);
            button1.TabIndex = 6;
            button1.Text = "Sản phẩm bán chạy nhất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "Lọc danh thu";
            // 
            // cbo_LocHoaDon
            // 
            cbo_LocHoaDon.FormattingEnabled = true;
            cbo_LocHoaDon.Items.AddRange(new object[] { "Day", "Month", "Year" });
            cbo_LocHoaDon.Location = new Point(19, 80);
            cbo_LocHoaDon.Name = "cbo_LocHoaDon";
            cbo_LocHoaDon.Size = new Size(309, 28);
            cbo_LocHoaDon.TabIndex = 6;
            cbo_LocHoaDon.SelectedIndexChanged += cbo_LocHoaDon_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 0, 192);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 37);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo bán hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 20);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(474, 20);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // GD_BaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 572);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(dataGridHoaDon);
            Name = "GD_BaoCao";
            Text = "GD_BaoCao";
            Load += GD_BaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridHoaDon;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox cbo_LocHoaDon;
        private Label label2;
        private Button button1;
    }
}