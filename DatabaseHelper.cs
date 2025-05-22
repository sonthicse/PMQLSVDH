using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace PMQLSVDH
{
    internal class DatabaseHelper
    {
        private static readonly string dbPath = "PMQLSVDH_v2.db";
        private static readonly string connectionString = $"Data Source={dbPath};";

        /// <summary>
        /// Nạp bảng điểm + thông tin sinh viên cho giảng viên
        /// </summary>
        public static void LoadDataGV(string MaGV, DataGridView dataGridView)
        {
            try
            {
                using var conn = new SqliteConnection(connectionString);
                conn.Open();

                string query = @"SELECT lh.TenLop  AS [Lớp],
                                            sv.MaSV  AS [Mã SV],
                                            sv.TenSV AS [Họ và tên],
                                            sv.NgaySinh AS [Ngày sinh],
                                            sv.GioiTinh AS [Giới tính],
                                            d.Diem_CC AS [Điểm CC],
                                            d.Diem_TX AS [Điểm TX],
                                            d.Diem_THI AS [Điểm THI],
                                            d.Diem_HP AS [Điểm HP]
                                     FROM GiangVien gv
                                     INNER JOIN GiangDay gd ON gv.MaGV = gd.MaGV
                                     INNER JOIN MonHoc   mh ON gd.MaMH = mh.MaMH
                                     INNER JOIN LopHoc   lh ON gd.MaLop = lh.MaLop
                                     INNER JOIN SinhVien sv ON sv.MaLop = lh.MaLop
                                     LEFT  JOIN Diem     d  ON d.MaSV = sv.MaSV AND d.MaMH = mh.MaMH
                                     WHERE gv.MaGV = @MaGV
                                     ORDER BY lh.MaLop, sv.MaSV";

                using var cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGV", MaGV);

                using var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);

                dataGridView.AutoGenerateColumns = false;
                dataGridView.Columns["LopHoc"].DataPropertyName = "Lớp";
                dataGridView.Columns["MaSV"].DataPropertyName = "Mã SV";
                dataGridView.Columns["TenSV"].DataPropertyName = "Họ và tên";
                dataGridView.Columns["NgaySinh"].DataPropertyName = "Ngày sinh";
                dataGridView.Columns["GioiTinh"].DataPropertyName = "Giới tính";
                dataGridView.Columns["Diem_CC"].DataPropertyName = "Điểm CC";
                dataGridView.Columns["Diem_TX"].DataPropertyName = "Điểm TX";
                dataGridView.Columns["Diem_THI"].DataPropertyName = "Điểm THI";
                dataGridView.Columns["Diem_HP"].DataPropertyName = "Điểm HP";

                dataGridView.DataSource = dt;

                foreach (var col in new[] { "Diem_CC", "Diem_TX", "Diem_THI", "Diem_HP" })
                    dataGridView.Columns[col].DefaultCellStyle.Format = "N1";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        /// <summary>
        /// Trả về cây dữ liệu GiangVien → LopHoc → SinhVien → Diem
        /// </summary>
        public static GiangVien LoadGiangVienTree(string maGV)
        {
            var gv = new GiangVien { MaGV = maGV };
            var lopDict = new Dictionary<string, LopHoc>();
            var svDict = new Dictionary<string, SinhVien>();

            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT gv.MaGV, lh.MaLop, lh.TenLop, lh.KhoaHoc,
                                        sv.MaSV, sv.TenSV, sv.NgaySinh, sv.GioiTinh,
                                        sv.DiaChi, sv.SDT, sv.Email,
                                        d.MaMH, d.Diem_CC, d.Diem_TX, d.Diem_THI, d.Diem_HP
                                 FROM GiangVien gv
                                 INNER JOIN GiangDay gd ON gv.MaGV = gd.MaGV
                                 INNER JOIN LopHoc   lh ON gd.MaLop = lh.MaLop
                                 INNER JOIN SinhVien sv ON sv.MaLop = lh.MaLop
                                 LEFT  JOIN Diem     d  ON d.MaSV = sv.MaSV AND d.MaMH = gd.MaMH
                                 WHERE gv.MaGV = @MaGV
                                 ORDER BY lh.MaLop, sv.MaSV";
            cmd.Parameters.AddWithValue("@MaGV", maGV);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maLop = reader.GetString(reader.GetOrdinal("MaLop"));
                if (!lopDict.TryGetValue(maLop, out var lop))
                {
                    lop = new LopHoc
                    {
                        MaLop = maLop,
                        TenLop = reader.GetString(reader.GetOrdinal("TenLop")),
                        KhoaHoc = reader.GetString(reader.GetOrdinal("KhoaHoc"))
                    };
                    lopDict[maLop] = lop;
                    gv.lopHocs!.Add(lop);
                }

                string maSV = reader.GetString(reader.GetOrdinal("MaSV"));
                if (!svDict.TryGetValue(maSV, out var sv))
                {
                    sv = new SinhVien
                    {
                        MaSV = maSV,
                        TenSV = reader.GetString(reader.GetOrdinal("TenSV")),
                        NgaySinh = reader.GetString(reader.GetOrdinal("NgaySinh")),
                        GioiTinh = reader.GetString(reader.GetOrdinal("GioiTinh")),
                        DiaChi = reader.GetString(reader.GetOrdinal("DiaChi")),
                        SDT = reader.GetString(reader.GetOrdinal("SDT")),
                        Email = reader.GetString(reader.GetOrdinal("Email"))
                    };
                    svDict[maSV] = sv;
                    lop.sinhViens!.Add(sv);
                }

                if (!reader.IsDBNull(reader.GetOrdinal("MaMH")))
                {
                    sv.diem!.Add(new Diem
                    {
                        MaSV = maSV,
                        MaMH = reader.GetString(reader.GetOrdinal("MaMH")),
                        Diem_CC = reader.IsDBNull(reader.GetOrdinal("Diem_CC")) ? 0 : (float)reader.GetDouble(reader.GetOrdinal("Diem_CC")),
                        Diem_TX = reader.IsDBNull(reader.GetOrdinal("Diem_TX")) ? 0 : (float)reader.GetDouble(reader.GetOrdinal("Diem_TX")),
                        Diem_THI = reader.IsDBNull(reader.GetOrdinal("Diem_THI")) ? 0 : (float)reader.GetDouble(reader.GetOrdinal("Diem_THI")),
                        Diem_HP = reader.IsDBNull(reader.GetOrdinal("Diem_HP")) ? 0 : (float)reader.GetDouble(reader.GetOrdinal("Diem_HP"))
                    });
                }
            }
            return gv;
        }
    }
}