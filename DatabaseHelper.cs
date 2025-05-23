using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace PMQLSVDH
{
    internal static class DatabaseHelper
    {
        private const string Conn = "Data Source=PMQLSVDH_v2.db;";

        // ────────────────────────────────────────────────
        // 1. Danh sách lớp của giảng viên
        // ────────────────────────────────────────────────
        public static DataTable GetClassesOfGV(string? maGV = null)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            var sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("  lh.MaLop     AS MaLop,");
            sb.AppendLine("  lh.TenLop    AS TenLop,");
            sb.AppendLine("  lh.KhoaHoc   AS KhoaHoc,");      // <- thêm dòng này
            sb.AppendLine("  COUNT(sv.MaSV) AS SoHS");
            sb.AppendLine("FROM GiangDay gd");
            sb.AppendLine("JOIN LopHoc   lh ON gd.MaLop   = lh.MaLop");
            sb.AppendLine("LEFT JOIN SinhVien sv ON lh.MaLop = sv.MaLop");
            sb.AppendLine("WHERE (@maGV IS NULL OR gd.MaGV = @maGV)");
            sb.AppendLine("GROUP BY lh.MaLop, lh.TenLop, lh.KhoaHoc");  // <- thêm KhoaHoc
            sb.AppendLine("ORDER BY lh.MaLop;");

            using var cmd = new SqliteCommand(sb.ToString(), c);
            cmd.Parameters.AddWithValue("@maGV",
                string.IsNullOrWhiteSpace(maGV) ? DBNull.Value : (object)maGV);

            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }



        // ────────────────────────────────────────────────
        // 2. Danh sách sinh viên + điểm
        // ────────────────────────────────────────────────
        public static void LoadDataGV(string maGV, DataGridView dgv, string? maLop = null, string? kw = null)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            // 2.1 Xây truy vấn
            var sb = new StringBuilder();
            sb.AppendLine("SELECT lh.TenLop AS [Lớp], sv.MaSV AS [Mã SV], sv.TenSV AS [Họ và tên], sv.NgaySinh AS [Ngày sinh],");
            sb.AppendLine("       sv.GioiTinh AS [Giới tính], sv.DiaChi AS [Địa chỉ], sv.SDT AS [SĐT], sv.Email AS [Email],");
            sb.AppendLine("       d.Diem_CC AS [Điểm CC], d.Diem_TX AS [Điểm TX], d.Diem_THI AS [Điểm THI], d.Diem_HP AS [Điểm HP]");
            sb.AppendLine("FROM   GiangVien gv");
            sb.AppendLine("JOIN   GiangDay  gd ON gv.MaGV = gd.MaGV");
            sb.AppendLine("JOIN   LopHoc    lh ON gd.MaLop = lh.MaLop");
            sb.AppendLine("JOIN   SinhVien  sv ON sv.MaLop = lh.MaLop");
            sb.AppendLine("LEFT   JOIN Diem d  ON d.MaSV = sv.MaSV AND d.MaMH = gd.MaMH");
            sb.AppendLine("WHERE  gv.MaGV = @MaGV");
            if (maLop != null) sb.AppendLine("AND gd.MaLop = @MaLop");

            bool hasKw = !string.IsNullOrWhiteSpace(kw);
            bool numericKw = hasKw && double.TryParse(kw, out _);
            if (hasKw)
            {
                if (numericKw)
                {
                    sb.AppendLine("AND (sv.MaSV LIKE @kwLike OR sv.TenSV LIKE @kwLike OR sv.SDT LIKE @kwLike OR");
                    sb.AppendLine("     CAST(d.Diem_CC  AS TEXT) = @kw OR CAST(d.Diem_TX AS TEXT) = @kw OR");
                    sb.AppendLine("     CAST(d.Diem_THI AS TEXT) = @kw OR CAST(d.Diem_HP AS TEXT) = @kw)");
                }
                else
                {
                    sb.AppendLine("AND (sv.MaSV LIKE @kwLike OR sv.TenSV LIKE @kwLike OR sv.SDT LIKE @kwLike OR sv.Email LIKE @kwLike)");
                }
            }
            sb.AppendLine("ORDER BY lh.MaLop, sv.MaSV");

            // 2.2 Thực thi
            using var cmd = new SqliteCommand(sb.ToString(), c);
            cmd.Parameters.AddWithValue("@MaGV", maGV);
            if (maLop != null) cmd.Parameters.AddWithValue("@MaLop", maLop);
            if (hasKw)
            {
                cmd.Parameters.AddWithValue("@kwLike", $"%{kw!.Trim()}%");
                if (numericKw) cmd.Parameters.AddWithValue("@kw", kw!.Trim());
            }

            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            BindColumns(dgv);
            dgv.DataSource = dt;
        }

        // ────────────────────────────────────────────────
        // 3. Ánh xạ cột chỉ chạy 1 lần
        // ────────────────────────────────────────────────
        private static void BindColumns(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            void B(string n, string p)
            {
                if (dgv.Columns[n] != null)
                {
                    dgv.Columns[n].DataPropertyName = p;
                    dgv.Columns[n].DefaultCellStyle.Format = "0.00";   // <- thêm dòng này
                }
            }
            B("LopHoc", "Lớp"); B("MaSV", "Mã SV"); B("TenSV", "Họ và tên");
            B("NgaySinh", "Ngày sinh"); B("GioiTinh", "Giới tính");
            B("DiaChi", "Địa chỉ"); B("SDT", "SĐT"); B("Email", "Email");
            B("Diem_CC", "Điểm CC"); B("Diem_TX", "Điểm TX");
            B("Diem_THI", "Điểm THI"); B("Diem_HP", "Điểm HP");
        }

        public static void SaveScore(string maSV, string maLop,
                                     float? cc, float? tx, float? thi, float? hp)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            const string qMH = @"SELECT gd.MaMH
                         FROM   GiangDay gd
                         WHERE  gd.MaLop = @MaLop
                         LIMIT 1";
            using var cmd1 = new SqliteCommand(qMH, c);
            cmd1.Parameters.AddWithValue("@MaLop", maLop);
            var maMH = cmd1.ExecuteScalar()?.ToString();
            if (maMH == null) return;                 // không tìm thấy

            const string up = @"
        INSERT INTO Diem (MaSV, MaMH, Diem_CC, Diem_TX, Diem_THI, Diem_HP)
        VALUES (@MaSV,@MaMH,@CC,@TX,@THI,@HP)
        ON CONFLICT(MaSV,MaMH) DO UPDATE SET
            Diem_CC=@CC, Diem_TX=@TX, Diem_THI=@THI, Diem_HP=@HP";
            using var cmd2 = new SqliteCommand(up, c);
            cmd2.Parameters.AddWithValue("@MaSV", maSV);
            cmd2.Parameters.AddWithValue("@MaMH", maMH);
            cmd2.Parameters.AddWithValue("@CC", cc);
            cmd2.Parameters.AddWithValue("@TX", tx);
            cmd2.Parameters.AddWithValue("@THI", thi);
            cmd2.Parameters.AddWithValue("@HP", hp);
            cmd2.ExecuteNonQuery();
        }

        // THÊM dưới cùng class DatabaseHelper
        public static void LoadDataSV(DataGridView dgv, string? kw = null)
        {
            var sb = new StringBuilder(@"
        SELECT sv.MaSV      AS [Mã SV],
               sv.TenSV     AS [Họ và tên],
               sv.NgaySinh  AS [Ngày sinh],
               sv.GioiTinh  AS [Giới tính],
               sv.DiaChi    AS [Địa chỉ],
               sv.SDT       AS [SĐT],
               sv.Email     AS [Email],
               lh.TenLop    AS [Lớp]
          FROM SinhVien sv
          JOIN LopHoc  lh ON sv.MaLop = lh.MaLop
         WHERE 1 = 1 ");

            bool hasKw = !string.IsNullOrWhiteSpace(kw);
            bool numeric = hasKw && double.TryParse(kw, out _);
            if (hasKw)
            {
                if (numeric)
                    sb.AppendLine("AND (sv.MaSV LIKE @kwLike OR sv.SDT LIKE @kwLike)");
                else
                    sb.AppendLine("AND (sv.MaSV LIKE @kwLike OR sv.TenSV LIKE @kwLike OR sv.Email LIKE @kwLike)");
            }
            sb.AppendLine("ORDER BY sv.MaSV");

            using var c = new SqliteConnection(Conn); c.Open();
            using var cmd = new SqliteCommand(sb.ToString(), c);
            if (hasKw) cmd.Parameters.AddWithValue("@kwLike", $"%{kw}%");

            var dt = new DataTable(); dt.Load(cmd.ExecuteReader());

            // ánh xạ cột 1 lần
            if (dgv.Columns["MaSV"].DataPropertyName == "")
            {
                dgv.AutoGenerateColumns = false;
                dgv.Columns["MaSV"].DataPropertyName = "Mã SV";
                dgv.Columns["TenSV"].DataPropertyName = "Họ và tên";
                dgv.Columns["NgaySinh"].DataPropertyName = "Ngày sinh";
                dgv.Columns["GioiTinh"].DataPropertyName = "Giới tính";
                dgv.Columns["DiaChi"].DataPropertyName = "Địa chỉ";
                dgv.Columns["SDT"].DataPropertyName = "SĐT";
                dgv.Columns["Email"].DataPropertyName = "Email";
                dgv.Columns["LopHoc"].DataPropertyName = "Lớp";
            }
            dgv.DataSource = dt;
        }

        // ───────────────────────────────────────────────────────────────────
        // 4. Danh sách giảng viên
        // ───────────────────────────────────────────────────────────────────
        public static void LoadGiangVien(DataGridView dgv, string? kw = null)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            // 4.1 Xây dựng truy vấn
            var sb = new StringBuilder();
            sb.AppendLine("SELECT gv.MaGV    AS [Mã GV],");
            sb.AppendLine("       gv.TenGV   AS [Họ và tên],");
            sb.AppendLine("       gv.Email   AS [Email],");
            sb.AppendLine("       mh.TenMH   AS [Môn học],");
            sb.AppendLine("       k.TenKhoa AS [Khoa]");
            sb.AppendLine("FROM   GiangVien gv");
            sb.AppendLine("LEFT   JOIN MonHoc mh ON gv.MaMH    = mh.MaMH");
            sb.AppendLine("LEFT   JOIN Khoa    k  ON gv.MaKhoa = k.MaKhoa");
            sb.AppendLine("WHERE 1 = 1");
            if (!string.IsNullOrWhiteSpace(kw))
            {
                sb.AppendLine("  AND (gv.MaGV   LIKE @kw");
                sb.AppendLine("    OR gv.TenGV  LIKE @kw");
                sb.AppendLine("    OR gv.Email  LIKE @kw");
                sb.AppendLine("    OR mh.TenMH  LIKE @kw");
                sb.AppendLine("    OR k.TenKhoa LIKE @kw)");
            }
            sb.AppendLine("ORDER BY gv.MaGV");

            // 4.2 Thực thi
            using var cmd = new SqliteCommand(sb.ToString(), c);
            if (!string.IsNullOrWhiteSpace(kw))
                cmd.Parameters.AddWithValue("@kw", $"%{kw.Trim()}%");

            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            // 4.3 Ánh xạ cột (chỉ chạy 1 lần)
            if (dgv.Columns["MaGV"].DataPropertyName == "")
            {
                dgv.AutoGenerateColumns = false;
                dgv.Columns["MaGV"].DataPropertyName = "Mã GV";
                dgv.Columns["TenGV"].DataPropertyName = "Họ và tên";
                dgv.Columns["Email"].DataPropertyName = "Email";
                dgv.Columns["MonHoc"].DataPropertyName = "Môn học";
                dgv.Columns["Khoa"].DataPropertyName = "Khoa";
            }

            // 4.4 Gán nguồn dữ liệu
            dgv.DataSource = dt;
        }

    }
}