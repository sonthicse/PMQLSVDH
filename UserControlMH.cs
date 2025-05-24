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
    public partial class UserControlMH : UserControl
    {
        public UserControlMH()
        {
            InitializeComponent();

            // gán sự kiện động (không đụng tới Designer)
            Load += UserControlMH_Load;                               // khi control được load
            comboBoxKhoa.SelectedValueChanged += comboBoxKhoa_SelectedValueChanged;
            buttonSearch.Click += buttonSearch_Click;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }

        #region ⮞ Khởi tạo ban đầu
        private void UserControlMH_Load(object? sender, EventArgs e)
        {
            LoadComboKhoa();   // đổ khoa vào combobox
            LoadMonHoc();      // nạp danh sách môn (tất cả khoa)
        }
        #endregion

        #region ⮞ Combobox Khoa
        /// <summary>
        /// Lấy toàn bộ khoa, thêm dòng “Tất cả khoa” ở đầu bảng và gán cho combobox.
        /// </summary>
        private void LoadComboKhoa()
        {
            var dt = DatabaseHelper.GetAllKhoa(); // cột: MaKhoa, TenKhoa

            // thêm lựa chọn "Tất cả khoa"
            var row = dt.NewRow();
            row["MaKhoa"] = DBNull.Value;
            row["TenKhoa"] = "Tất cả khoa";
            dt.Rows.InsertAt(row, 0);

            comboBoxKhoa.DisplayMember = "TenKhoa";
            comboBoxKhoa.ValueMember = "MaKhoa";
            comboBoxKhoa.DataSource = dt;
            comboBoxKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // Hiển thị thông tin chi tiết của 1 môn học
        private void FillDetailFields(DataGridViewRow row)
        {
            textBoxMaMH.Text = row.Cells["MaMH"].Value?.ToString();
            textBoxTenMH.Text = row.Cells["TenMH"].Value?.ToString();
            textBoxTinChi.Text = row.Cells["SoTinChi"].Value?.ToString();

            var mk = row.Cells["MaKhoa"].Value?.ToString();
            comboBoxKhoa.SelectedValue = mk;
        }

        private void comboBoxKhoa_SelectedValueChanged(object? sender, EventArgs e)
        {
            LoadMonHoc();      // lọc lại danh sách môn theo khoa
        }
        #endregion

        #region ⮞ Danh sách môn học
        /// <summary>
        /// Nạp danh sách môn học theo khoa hiện chọn và ô tìm kiếm (nếu có).
        /// </summary>
        private void LoadMonHoc()
        {
            string? maKhoa = comboBoxKhoa.SelectedIndex <= 0
                                ? null           // "Tất cả khoa"
                                : comboBoxKhoa.SelectedValue?.ToString();

            string? kw = string.IsNullOrWhiteSpace(textBoxSearch.Text)
                                ? null
                                : textBoxSearch.Text.Trim();

            // Hàm đã có sẵn trong DatabaseHelper
            DatabaseHelper.LoadMaTenMH(dataGridView, maKhoa, kw);
        }

        private void buttonSearch_Click(object? sender, EventArgs e)
        {
            LoadMonHoc();
        }
        // ────────────────────────────────────────────────────────────────
        // 1) Hàm chọn giá trị cho Combobox Khoa một cách “an toàn”
        //    – tránh lỗi key = null hoặc maKhoa không tồn tại trong DS.
        private void SelectKhoaSafely(string? maKhoa)
        {
            // Tạm thời bỏ sự kiện SelectedValueChanged để tránh reload vòng lặp
            comboBoxKhoa.SelectedValueChanged -= comboBoxKhoa_SelectedValueChanged;

            if (string.IsNullOrWhiteSpace(maKhoa))
            {
                comboBoxKhoa.SelectedIndex = -1;         // “Tất cả khoa”
            }
            else
            {
                // tìm tay, vì DataTable.Rows.Find yêu cầu PK
                int found = -1;
                for (int i = 0; i < comboBoxKhoa.Items.Count; i++)
                {
                    if (comboBoxKhoa.Items[i] is DataRowView drv &&
                        drv["MaKhoa"]?.ToString() == maKhoa)
                    {
                        found = i;
                        break;
                    }
                }
                comboBoxKhoa.SelectedIndex = found >= 0 ? found : 0;   // không có → chọn “Tất cả khoa”
            }

            comboBoxKhoa.SelectedValueChanged += comboBoxKhoa_SelectedValueChanged;
        }

        // ────────────────────────────────────────────────────────────────
        // 2) Hàm nạp đầy đủ chi tiết Môn học vào các control ở panel dưới
        private void PopulateDetailFields(DataGridViewRow row)
        {
            textBoxMaMH.Text = row.Cells["MaMH"].Value?.ToString() ?? string.Empty;
            textBoxTenMH.Text = row.Cells["TenMH"].Value?.ToString() ?? string.Empty;
            textBoxTinChi.Text = row.Cells["SoTinChi"].Value?.ToString() ?? string.Empty;

            // đưa khoa lên combobox
            var maKhoa = row.Cells["MaKhoa"].Value?.ToString();
            SelectKhoaSafely(maKhoa);
        }

        /// <summary>
        /// Khi người dùng chọn 1 môn trong grid –> hiển thị danh sách GV dạy môn đó
        /// </summary>
        private void dataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                // Không chọn hàng nào → xoá sạch form & danh sách GV
                textBoxMaMH.Clear();
                textBoxTenMH.Clear();
                textBoxTinChi.Clear();
                comboBoxKhoa.SelectedIndex = -1;
                dataGridViewGV.DataSource = null;
                return;
            }

            // Có chọn → hiển thị chi tiết & danh sách giảng viên
            var row = dataGridView.SelectedRows[0];
            PopulateDetailFields(row);                      // ⟵ gọi hàm mới

            // Nạp GV dạy môn
            string maMH = row.Cells["MaMH"].Value!.ToString()!;
            DatabaseHelper.LoadGiangVienByMH(dataGridViewGV, maMH);
        }



        #endregion

        private void buttonSua_Click(object sender, EventArgs e)
        {
            buttonSua.Visible = false;
            buttonXoa.Visible = false;
            buttonXN.Visible = true;
            buttonHuy.Visible = true;
            textBoxMaMH.Enabled = true;
            textBoxTenMH.Enabled = true;
            textBoxTinChi.Enabled = true;
            comboBoxKhoa.Enabled = true;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonSua.Visible = true;
            buttonXoa.Visible = true;
            buttonXN.Visible = false;
            buttonHuy.Visible = false;
            textBoxMaMH.Enabled = false;
            textBoxTenMH.Enabled = false;
            textBoxTinChi.Enabled = false;
            comboBoxKhoa.Enabled = false;
        }

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
