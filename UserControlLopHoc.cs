using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class UserControlLopHoc : UserControl
    {
        public UserControlLopHoc() => InitializeComponent();

        public class RowSV
        {
            public string LopHoc { get; set; } = string.Empty;
            public string MaSV { get; set; } = string.Empty;
            public string TenSV { get; set; } = string.Empty;
            public string NgaySinh { get; set; } = string.Empty;
            public string GioiTinh { get; set; } = string.Empty;
            public float? Diem_CC { get; set; }
            public float? Diem_TX { get; set; }
            public float? Diem_THI { get; set; }
            public float? Diem_HP { get; set; }
        }

        public static void LoadAllStudents(DataGridView dgv, GiangVien gvTree, string? maLop = null)
        {
            if (gvTree.lopHocs == null || !gvTree.lopHocs.Any())
            {
                MessageBox.Show("Không có lớp học nào trong cây dữ liệu giảng viên.");
                return;
            }

            if (maLop != null && !gvTree.lopHocs.Any(lop => lop.MaLop == maLop))
            {
                MessageBox.Show($"Không tìm thấy lớp học với mã lớp: {maLop}");
                return;
            }

            var rows = (from lop in gvTree.lopHocs!
                        where maLop == null || lop.MaLop == maLop
                        from sv in lop.sinhViens!
                        let d = sv.diem!.FirstOrDefault()
                        select new RowSV
                        {
                            LopHoc = lop.TenLop,
                            MaSV = sv.MaSV!,
                            TenSV = sv.TenSV!,
                            NgaySinh = sv.NgaySinh!,
                            GioiTinh = sv.GioiTinh!,
                            Diem_CC = d?.Diem_CC,
                            Diem_TX = d?.Diem_TX,
                            Diem_THI = d?.Diem_THI,
                            Diem_HP = d?.Diem_HP
                        }).ToList();

            if (!rows.Any())
            {
                MessageBox.Show("Không có sinh viên nào được tìm thấy.");
                return;
            }

            MessageBox.Show($"Có {rows.Count} dòng");

            dgv.AutoGenerateColumns = false;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (string.IsNullOrEmpty(c.DataPropertyName))
                {
                    MessageBox.Show($"Cột {c.Name} chưa được gán DataPropertyName.");
                }
                c.DataPropertyName = c.Name;
            }
            dgv.DataSource = rows;
        }
    }
}