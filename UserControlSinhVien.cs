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

        // ───── Hiển thị chi tiết sinh viên ─────
        private void DataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
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
    }
}
