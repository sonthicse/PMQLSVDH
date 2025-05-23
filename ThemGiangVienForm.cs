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
    public partial class ThemGiangVienForm : Form
    {
        private DataTable _dtKhoa;     // toàn bộ Khoa
        private DataTable _dtMonHoc;   // toàn bộ Môn học

        public ThemGiangVienForm()
        {
            InitializeComponent();
            comboBoxMH.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDataKhoa();                               // nạp Khoa ngay khi khởi tạo
            comboBoxKhoa.SelectedIndexChanged += ComboBoxKhoa_SelectedIndexChanged;
            //buttonXN.Click += ButtonXN_Click;
        }

        //──────────────────────────────────────────────
        // 1. Nạp danh sách Khoa
        //──────────────────────────────────────────────
        private void LoadDataKhoa()
        {
            _dtKhoa = DatabaseHelper.GetAllKhoa();        // (MaKhoa, TenKhoa)
            comboBoxKhoa.DataSource = _dtKhoa;
            comboBoxKhoa.DisplayMember = "TenKhoa";
            comboBoxKhoa.ValueMember = "MaKhoa";
            comboBoxKhoa.SelectedIndex = -1;              // chưa chọn
        }

        //──────────────────────────────────────────────
        // 2. Khi chọn Khoa → lọc Môn học thuộc khoa đó
        //──────────────────────────────────────────────
        private void ComboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKhoa.SelectedValue == null) return;
            string maKhoa = comboBoxKhoa.SelectedValue.ToString()!;

            // lần đầu: lấy sẵn toàn bộ môn học
            _dtMonHoc ??= DatabaseHelper.GetAllMonHoc();  // (MaMH, TenMH, MaKhoa)

            // lọc theo MaKhoa
            var filtered = _dtMonHoc.AsEnumerable()
                                    .Where(r => r.Field<string>("MaKhoa") == maKhoa);

            // nếu khoa hiện chưa có môn nào → xoá DS cũ
            comboBoxMH.DataSource = filtered.Any()
                                     ? filtered.CopyToDataTable()
                                     : null;

            comboBoxMH.DisplayMember = "TenMH";
            comboBoxMH.ValueMember = "MaMH";
            comboBoxMH.SelectedIndex = -1;
        }

        //──────────────────────────────────────────────
        // 3. Nút Hủy giữ nguyên như cũ
        //──────────────────────────────────────────────
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonXN_Click(object? sender, EventArgs e)
        {
            // 3.1 Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(textBoxMaGV.Text) ||
                string.IsNullOrWhiteSpace(textBoxTenGV.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                comboBoxKhoa.SelectedValue == null ||
                comboBoxMH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thiếu dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3.2 Tạo đối tượng GiangVien
            var gv = new GiangVien
            {
                MaGV = textBoxMaGV.Text.Trim(),
                TenGV = textBoxTenGV.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
                MaKhoa = comboBoxKhoa.SelectedValue.ToString(),
                MaMH = comboBoxMH.SelectedValue.ToString()
            };

            // 3.3 Gọi DatabaseHelper
            bool ok = DatabaseHelper.InsertGiangVien(gv);
            if (!ok)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!", "Trùng mã",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đã thêm giảng viên thành công.", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;   // form cha có thể Refresh
            Close();
        }
    }
}
