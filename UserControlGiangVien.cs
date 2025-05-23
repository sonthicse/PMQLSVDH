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
        private DataTable dtMonHoc;
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

            DatabaseHelper.LoadGiangVien(dataGridView, null);

            var dtKhoa = DatabaseHelper.GetAllKhoa();
            comboBoxKhoa.DataSource = dtKhoa;
            comboBoxKhoa.DisplayMember = "TenKhoa";
            comboBoxKhoa.ValueMember = "MaKhoa";

            // 2. Load toàn bộ môn học
            dtMonHoc = DatabaseHelper.GetAllMonHoc();
            comboBoxMH.DataSource = dtMonHoc;
            comboBoxMH.DisplayMember = "TenMH";
            comboBoxMH.ValueMember = "MaMH";

            // 3. Khi đổi khoa thì filter môn
            comboBoxKhoa.SelectedIndexChanged += (s, e) =>
            {
                var maKhoa = comboBoxKhoa.SelectedValue?.ToString() ?? "";
                var dv = dtMonHoc.DefaultView;
                dv.RowFilter = $"MaKhoa = '{maKhoa}'";
                comboBoxMH.DataSource = dv;
            };
        }

        private void DataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            var row = dataGridView.SelectedRows[0];
            var maGV = row.Cells["MaGV"].Value?.ToString() ?? "";

            textBoxMaGV.Text = maGV;
            textBoxTenGV.Text = row.Cells["TenGV"].Value?.ToString() ?? "";
            textBoxEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            comboBoxMH.Text = row.Cells["MonHoc"].Value?.ToString() ?? "";
            comboBoxKhoa.Text = row.Cells["Khoa"].Value?.ToString() ?? "";

            var dtLop = DatabaseHelper.GetClassesOfGV(maGV);

            if (dataGridViewLopHoc.Columns.Count > 0 && dataGridViewLopHoc.Columns["MaLop"].DataPropertyName == "")
            {
                dataGridViewLopHoc.AutoGenerateColumns = false;

                dataGridViewLopHoc.Columns["MaLop"].DataPropertyName = "MaLop";
                dataGridViewLopHoc.Columns["TenLop"].DataPropertyName = "TenLop";
                dataGridViewLopHoc.Columns["SoHS"].DataPropertyName = "SoHS";
            }

            // 4. Gán DataSource
            dataGridViewLopHoc.DataSource = dtLop;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            textBoxTenGV.Enabled = true;
            textBoxEmail.Enabled = true;
            buttonHuy.Visible = true;
            buttonXN.Visible = true;
            buttonSua.Visible = false;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonSua.Visible = true;
            buttonXN.Visible = false;
            buttonHuy.Visible = false;
            textBoxTenGV.Enabled = false;
            textBoxEmail.Enabled = false;
            DatabaseHelper.LoadGiangVien(dataGridView, null);
        }

        private void buttonXN_Click(object sender, EventArgs e)
        {
            var maGV = textBoxMaGV.Text.Trim();          // MaGV đang KHÔNG cho sửa
            var tenGV = textBoxTenGV.Text.Trim();
            var email = textBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenGV) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Tên và Email không được để trống!");
                return;
            }

            var ok = DatabaseHelper.UpdateGiangVienInfo(maGV, tenGV, email);
            MessageBox.Show(ok ? "Đã cập nhật!" : "Không tìm thấy giảng viên.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ok) DatabaseHelper.LoadGiangVien(dataGridView);

            buttonSua.Visible = true;
            buttonXN.Visible = false;
            buttonHuy.Visible = false;
            textBoxTenGV.Enabled = false;
            textBoxEmail.Enabled = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemGiangVienForm themGV = new ThemGiangVienForm();
            themGV.ShowDialog();
        }
    }
}
