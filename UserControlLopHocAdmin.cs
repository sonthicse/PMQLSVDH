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
    public partial class UserControlLopHocAdmin : UserControl
    {
        public UserControlLopHocAdmin()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["MaLop"].DataPropertyName = "MaLop";
            dataGridView.Columns["KhoaHoc"].DataPropertyName = "KhoaHoc";
            dataGridView.Columns["TenLop"].DataPropertyName = "TenLop";
            dataGridView.Columns["SoHS"].DataPropertyName = "SoHS";
            dataGridView.MultiSelect = false;
            InitGridSinhVien();
            InitGridMonHoc();

            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            ThemSinhVienForm themSV = new ThemSinhVienForm();
            themSV.ShowDialog();
        }
        private void DataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                dataGridViewSV.DataSource = null;
                dataGridViewMH.DataSource = null;
                return;
            }

            string maLop = dataGridView.SelectedRows[0]
                           .Cells["MaLop"].Value!.ToString()!;

            // Đổ sinh viên
            DatabaseHelper.LoadMaTenSV(dataGridViewSV, maLop);

            // Đổ môn học – dùng bảng GiangDay liên kết Lop ↔ Mon
            DatabaseHelper.LoadMaTenMHByLop(dataGridViewMH, maLop);

            // Điền textbox
            textBoxMaLop.Text = maLop;
            textBoxTenLop.Text = dataGridView.SelectedRows[0]
                                 .Cells["TenLop"].Value?.ToString() ?? "";
            textBoxKhoaHoc.Text = dataGridView.SelectedRows[0]
                                 .Cells["KhoaHoc"].Value?.ToString() ?? "";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            buttonXN.Visible = true;
            buttonHuy.Visible = true;
            buttonSua.Visible = false;
            textBoxMaLop.Enabled = true;
            textBoxTenLop.Enabled = true;
            textBoxKhoaHoc.Enabled = true;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonXN.Visible = false;
            buttonHuy.Visible = false;
            buttonSua.Visible = true;
            textBoxMaLop.Enabled = false;
            textBoxTenLop.Enabled = false;
            textBoxKhoaHoc.Enabled = false;
            dataGridView.DataSource = DatabaseHelper.GetClassesOfGV();
        }

        private void buttonXN_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            using var f = new ThemLopHocForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Sau khi thêm thành công, reload lại danh sách lớp
                dataGridView.DataSource = DatabaseHelper.GetAllLopHoc(); // hoặc hàm load riêng
            }
        }
    }
}
