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
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            ThemSinhVienForm themSV = new ThemSinhVienForm();
            themSV.ShowDialog();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;
            var row = dataGridView.SelectedRows[0];
            textBoxMaLop.Text = row.Cells["MaLop"].Value?.ToString() ?? "";
            textBoxTenLop.Text = row.Cells["TenLop"].Value?.ToString() ?? "";
            textBoxKhoaHoc.Text = row.Cells["KhoaHoc"].Value?.ToString() ?? "";
        }
    }
}
