using System;
using System.Data;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class UserControlLopHoc : UserControl
    {
        private string? _maGV; private DataTable? _cachedClasses;  // cache lớp
        public UserControlLopHoc()
        {
            InitializeComponent();
            dataGridView.SelectionChanged += GridSelChanged;
            buttonSearch.Click += (_, __) => LoadSelected(textBoxSearch.Text);
            textBoxSearch.KeyDown += (_, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; LoadSelected(textBoxSearch.Text); } };
        }

        public void InitForGiangVien(string maGV)
        {
            if (maGV != _maGV) _cachedClasses = null; // giảng viên đổi -> clear cache
            _maGV = maGV;
            if (_cachedClasses == null) _cachedClasses = DatabaseHelper.GetClassesOfGV(maGV);

            comboBoxLop.SelectedIndexChanged -= CbChanged;
            comboBoxLop.DataSource = _cachedClasses; comboBoxLop.DisplayMember = "TenLop"; comboBoxLop.ValueMember = "MaLop";
            comboBoxLop.SelectedIndexChanged += CbChanged;
            if (comboBoxLop.Items.Count > 0) LoadSelected();
        }

        private void CbChanged(object? s, EventArgs e) => LoadSelected();

        private void LoadSelected(string? kw = null)
        {
            if (_maGV == null || comboBoxLop.SelectedValue == null) return;
            dataGridView.SelectionChanged -= GridSelChanged;
            DatabaseHelper.LoadDataGV(_maGV, dataGridView, comboBoxLop.SelectedValue.ToString(), kw);
            dataGridView.SelectionChanged += GridSelChanged;
        }

        private void GridSelChanged(object? s, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return; var c = dataGridView.CurrentRow.Cells;
            textBoxMaSV.Text = c["MaSV"].Value?.ToString() ?? "";
            textBoxTenSV.Text = c["TenSV"].Value?.ToString() ?? "";
            if (DateTime.TryParse(c["NgaySinh"].Value?.ToString(), out var d)) dateTimePickerNgaySinh.Value = d;
            textBoxDiaChi.Text = c["DiaChi"].Value?.ToString() ?? "";
            textBoxSDT.Text = c["SDT"].Value?.ToString() ?? "";
            textBoxEmail.Text = c["Email"].Value?.ToString() ?? "";
            textBoxDiemCC.Text = c["Diem_CC"].Value?.ToString() ?? "";
            textBoxDiemTX.Text = c["Diem_TX"].Value?.ToString() ?? "";
            textBoxDiemTHI.Text = c["Diem_THI"].Value?.ToString() ?? "";
            textBoxDiemHP.Text = c["Diem_HP"].Value?.ToString() ?? "";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            textBoxDiemCC.Enabled = true;
            textBoxDiemTX.Enabled = true;
            textBoxDiemTHI.Enabled = true;
            buttonSua.Enabled = false;
            buttonSua.Visible = false;
            buttonXN.Enabled = true;
            buttonXN.Visible = true;
            buttonHuy.Enabled = true;
            buttonHuy.Visible = true;
        }
    }
}
