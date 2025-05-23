using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class UserControlGiangVien : UserControl
    {
        public UserControlGiangVien()
        {
            InitializeComponent();

            // Thiết lập selection chỉ chọn nguyên hàng
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            // Đăng ký sự kiện chọn hàng
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;

            // Đăng ký sự kiện tìm kiếm
            buttonSearch.Click += (s, e) =>
            {
                DatabaseHelper.LoadGiangVien(dataGridView, textBoxSearch.Text);
            };

            // Load dữ liệu mặc định khi khởi tạo
            DatabaseHelper.LoadGiangVien(dataGridView, null);
        }

        private void DataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            var row = dataGridView.SelectedRows[0];
            var maGV = row.Cells["MaGV"].Value?.ToString() ?? "";

            // 1. Đổ thông tin giảng viên xuống các TextBox/ComboBox
            textBoxMaGV.Text = maGV;
            textBoxTenGV.Text = row.Cells["TenGV"].Value?.ToString() ?? "";
            textBoxEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            comboBoxMH.Text = row.Cells["MonHoc"].Value?.ToString() ?? "";
            comboBoxKhoa.Text = row.Cells["Khoa"].Value?.ToString() ?? "";

            // 2. Lấy danh sách lớp của giảng viên này
            var dtLop = DatabaseHelper.GetClassesOfGV(maGV);

            // 3. Ánh xạ cột (nếu cần chỉ làm 1 lần)
            if (dataGridViewLopHoc.Columns.Count > 0 && dataGridViewLopHoc.Columns["MaLop"].DataPropertyName == "")
            {
                dataGridViewLopHoc.AutoGenerateColumns = false;

                // Giả sử bạn đã thêm hai cột trong Designer với Name = "MaLop" và "TenLop"
                dataGridViewLopHoc.Columns["MaLop"].DataPropertyName = "MaLop";
                dataGridViewLopHoc.Columns["TenLop"].DataPropertyName = "TenLop";
                dataGridViewLopHoc.Columns["SoHS"].DataPropertyName = "SoHS";
            }

            // 4. Gán DataSource
            dataGridViewLopHoc.DataSource = dtLop;
        }


    }
}
