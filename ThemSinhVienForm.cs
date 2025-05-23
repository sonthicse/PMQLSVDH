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
        }

        private void LoadComboLop()
        {
            // 1. Lấy DataTable chứa MaLop, TenLop (và các cột khác, nhưng Combobox chỉ dùng 2 cột này)
            var dt = DatabaseHelper.GetClassesOfGV(null);

            // 2. Gán nguồn dữ liệu
            comboBoxLop.DataSource = dt;
            comboBoxLop.DisplayMember = "TenLop";   // hiển thị tên lớp
            comboBoxLop.ValueMember = "MaLop";    // giá trị lấy ra là mã lớp
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            // Corrected the MessageBox usage to use MessageBox.Show method
            DialogResult result = MessageBox.Show("Xác nhận thêm Sinh Viên vào?????", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TaTho
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
