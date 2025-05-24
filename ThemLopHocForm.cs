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
    public partial class ThemLopHocForm : Form
    {
        public ThemLopHocForm()
        {
            InitializeComponent();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXN_Click(object sender, EventArgs e)
        {
            // 1. Lấy và làm sạch dữ liệu nhập
            var lh = new LopHoc
            {
                MaLop = textBoxMaLop.Text.Trim(),
                TenLop = textBoxTenLop.Text.Trim(),
                KhoaHoc = textBoxKhoaHoc.Text.Trim()
            };

            // 2. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(lh.MaLop) ||
                string.IsNullOrWhiteSpace(lh.TenLop) ||
                string.IsNullOrWhiteSpace(lh.KhoaHoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp, Tên lớp và Khóa học!",
                                "Thiếu dữ liệu", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 3. Gọi DatabaseHelper
            bool ok = DatabaseHelper.InsertLopHoc(lh);
            if (ok)
            {
                MessageBox.Show("Đã thêm lớp thành công!",
                                "Thành công", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;   // giúp form cha refresh nếu muốn
                Close();
            }
            else
            {
                MessageBox.Show("Mã lớp đã tồn tại – hãy chọn mã khác.",
                                "Trùng mã", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
