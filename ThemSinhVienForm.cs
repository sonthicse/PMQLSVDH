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
    public partial class ThemSinhVienForm : Form
    {
        public ThemSinhVienForm()
        {
            InitializeComponent();
            LoadComboLop();
            comboBoxLop.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadComboLop()
        {
            // 1. Lấy DataTable chứa MaLop, TenLop (và các cột khác, nhưng Combobox chỉ dùng 2 cột này)
            var dt = DatabaseHelper.GetAllLopHoc();

            // 2. Gán nguồn dữ liệu
            comboBoxLop.DataSource = dt;
            comboBoxLop.DisplayMember = "TenLop";   // hiển thị tên lớp
            comboBoxLop.ValueMember = "MaLop";    // giá trị lấy ra là mã lớp
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
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

            var ok = DatabaseHelper.InsertSinhVien(sv);
            MessageBox.Show(ok ? "Thêm thành công!" : "Mã sinh viên đã tồn tại.",
                            "Thông báo", MessageBoxButtons.OK,
                            ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ok) Close();    // đóng form khi thêm xong
        }


        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
