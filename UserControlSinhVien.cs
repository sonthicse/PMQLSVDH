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
    public partial class UserControlSinhVien : UserControl
    {
        private string? oldMaSV;
        public UserControlSinhVien()
        {
            InitializeComponent();

            // chỉ chọn 1 hàng
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;

            // nút TÌM KIẾM
            buttonSearch.Click += (_, __) =>
            {
                DatabaseHelper.LoadDataSV(dataGridView, textBoxSearch.Text);
            };
            textBoxSearch.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    DatabaseHelper.LoadDataSV(dataGridView, textBoxSearch.Text);
                }
            };

            // nạp ban đầu
            DatabaseHelper.LoadDataSV(dataGridView);
            buttonXacNhan.Click += ButtonXacNhan_Click;
            buttonHuy.Click += (_, __) => ResetDetail();   // hủy sửa

            var dtLop = DatabaseHelper.GetClassesOfGV();   // maGV = null → lấy tất cả lớp
            comboBoxLop.DataSource = dtLop;
            comboBoxLop.DisplayMember = "TenLop";          // tên hiển thị
            comboBoxLop.ValueMember = "MaLop";           // giá trị lưu
            comboBoxLop.SelectedIndex = -1;                // chưa chọn gì lúc mở
        }

        private void ButtonXacNhan_Click(object? sender, EventArgs e)
        {
            var sv = new SinhVien
            {
                MaSV = textBoxMaSV.Text.Trim(),
                TenSV = textBoxTenSV.Text.Trim(),
                NgaySinh = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd"),
                GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ",
                DiaChi = textBoxDiaChi.Text.Trim(),
                SDT = textBoxSDT.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
                MaLop = comboBoxLop.SelectedValue?.ToString()
            };

            if (!DatabaseHelper.UpdateSinhVien(sv, oldMaSV))
            {
                MessageBox.Show("Cập nhật KHÔNG thành công!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đã lưu thay đổi.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // refresh lưới và khóa lại ô nhập
            DatabaseHelper.LoadDataSV(dataGridView);
            ResetDetail();
        }

        // khôi phục UI (khóa control + ẩn/hiện nút)
        private void ResetDetail()
        {
            buttonSua.Visible = true;
            buttonXoa.Visible = true;
            buttonXacNhan.Visible = false;
            buttonHuy.Visible = false;

            foreach (var ctl in new Control[]
            { textBoxMaSV,textBoxTenSV,dateTimePickerNgaySinh,
      textBoxDiaChi,textBoxSDT,textBoxEmail,comboBoxLop,
      radioButtonNam,radioButtonNu })
                ctl.Enabled = false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            buttonSua.Visible = false;
            buttonXoa.Visible = false;
            buttonHuy.Visible = true;
            buttonXacNhan.Visible = true;
            textBoxMaSV.Enabled = true;
            textBoxTenSV.Enabled = true;
            dateTimePickerNgaySinh.Enabled = true;
            textBoxDiaChi.Enabled = true;
            textBoxSDT.Enabled = true;
            textBoxEmail.Enabled = true;
            comboBoxLop.Enabled = true;
            radioButtonNam.Enabled = true;
            radioButtonNu.Enabled = true;
        }

        private void DataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            oldMaSV = dataGridView.CurrentRow.Cells["MaSV"].Value?.ToString();
            var r = dataGridView.CurrentRow.Cells;

            textBoxMaSV.Text = r["MaSV"].Value?.ToString() ?? "";
            textBoxTenSV.Text = r["TenSV"].Value?.ToString() ?? "";
            DateTime.TryParse(r["NgaySinh"].Value?.ToString(), out var d);
            dateTimePickerNgaySinh.Value = d == DateTime.MinValue ? DateTime.Today : d;

            textBoxDiaChi.Text = r["DiaChi"].Value?.ToString() ?? "";
            textBoxSDT.Text = r["SDT"].Value?.ToString() ?? "";
            textBoxEmail.Text = r["Email"].Value?.ToString() ?? "";

            var gt = r["GioiTinh"].Value?.ToString();
            radioButtonNam.Checked = gt == "Nam";
            radioButtonNu.Checked = gt == "Nữ";

            comboBoxLop.Text = r["LopHoc"].Value?.ToString() ?? "";
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            ThemSinhVienForm themSV = new ThemSinhVienForm();
            themSV.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var maSV = dataGridView.SelectedRows[0].Cells["MaSV"].Value?.ToString();

            if (MessageBox.Show($"Xóa sinh viên {maSV} và toàn bộ điểm?",
                                "Xác nhận", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var ok = DatabaseHelper.DeleteSinhVien(maSV);
                MessageBox.Show(ok ? "Đã xóa!" : "Không tìm thấy sinh viên.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (ok)
                    DatabaseHelper.LoadDataSV(dataGridView);
            }
        }
    }
}
