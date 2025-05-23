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

            // MỚI
            buttonSua.Click += buttonSua_Click;
            buttonHuy.Click += buttonHuy_Click;
            buttonXN.Click += buttonXN_Click;
        }


        public void InitForGiangVien(string maGV)
        {
            if (maGV != _maGV) _cachedClasses = null;
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
            var gt = c["GioiTinh"].Value?.ToString();
            radioButtonNam.Checked = gt == "Nam";
            radioButtonNu.Checked = gt == "Nữ";
        }

        private void ToggleEdit(bool edit)
        {
            textBoxDiemCC.Enabled =
            textBoxDiemTX.Enabled =
            textBoxDiemTHI.Enabled = edit;

            buttonSua.Visible = buttonSua.Enabled = !edit;
            buttonXN.Visible = buttonXN.Enabled = edit;
            buttonHuy.Visible = buttonHuy.Enabled = edit;
        }

        private void buttonSua_Click(object? s, EventArgs e) => ToggleEdit(true);

        private void buttonHuy_Click(object? s, EventArgs e)
        {
            ToggleEdit(false);
            GridSelChanged(null, EventArgs.Empty);   // trả về giá trị gốc
        }

        private void buttonXN_Click(object? s, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            var c = dataGridView.CurrentRow.Cells;
            string maSV = c["MaSV"].Value!.ToString()!;
            string maLop = comboBoxLop.SelectedValue!.ToString()!;

            // Parse điểm – nếu trống giữ nguyên null
            bool okCC = float.TryParse(textBoxDiemCC.Text, out var cc);
            bool okTX = float.TryParse(textBoxDiemTX.Text, out var tx);
            bool okTHI = float.TryParse(textBoxDiemTHI.Text, out var thi);
            if (!(okCC && okTX && okTHI)) { MessageBox.Show("Điểm phải là số."); return; }
            float hp = (float)Math.Round(0.1f * cc + 0.3f * tx + 0.6f * thi, 2);
            textBoxDiemHP.Text = hp.ToString("0.00");

            DatabaseHelper.SaveScore(maSV, maLop, cc, tx, thi, hp);

            ToggleEdit(false);
            LoadSelected();                          // refresh lưới
        }
    }
}
