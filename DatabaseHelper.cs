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

        public static DataTable GetAllKhoa()
        {
            using var c = new SqliteConnection(Conn);
            c.Open();
            using var cmd = new SqliteCommand("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa", c);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static DataTable GetAllMonHoc()
        {
            using var c = new SqliteConnection(Conn);
            c.Open();
            using var cmd = new SqliteCommand("SELECT MaMH, TenMH, MaKhoa FROM MonHoc ORDER BY TenMH", c);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static bool InsertSinhVien(SinhVien sv)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            // 1. Tránh trùng khóa chính
            const string chk = "SELECT COUNT(1) FROM SinhVien WHERE MaSV = @MaSV";
            using (var cmdChk = new SqliteCommand(chk, c))
            {
                cmdChk.Parameters.AddWithValue("@MaSV", sv.MaSV);
                if ((long)cmdChk.ExecuteScalar() > 0) return false;   // đã tồn tại
            }

            // 2. Insert
            const string ins = @"
INSERT INTO SinhVien (MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SDT, Email, MaLop)
VALUES (@MaSV,@TenSV,@NS,@GT,@DC,@SDT,@Email,@MaLop)";
            using var cmd = new SqliteCommand(ins, c);
            cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
            cmd.Parameters.AddWithValue("@TenSV", sv.TenSV);
            cmd.Parameters.AddWithValue("@NS", sv.NgaySinh);
            cmd.Parameters.AddWithValue("@GT", sv.GioiTinh);
            cmd.Parameters.AddWithValue("@DC", sv.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", sv.SDT);
            cmd.Parameters.AddWithValue("@Email", sv.Email);
            cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
            cmd.ExecuteNonQuery();
            return true;
        }

        public static bool UpdateSinhVien(SinhVien sv, string oldMaSV)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();
            using var tx = c.BeginTransaction();

            // ───────────────────────────────────────────
            // 1. Nếu đổi sang MaSV mới → kiểm tra trùng
            // ───────────────────────────────────────────
            if (!sv.MaSV.Equals(oldMaSV, StringComparison.OrdinalIgnoreCase))
            {
                const string sqlChk = "SELECT 1 FROM SinhVien WHERE MaSV = @NewID LIMIT 1";
                using var cmdChk = new SqliteCommand(sqlChk, c, tx);
                cmdChk.Parameters.AddWithValue("@NewID", sv.MaSV);
                if (cmdChk.ExecuteScalar() != null)    // đã có mã mới
                {
                    tx.Rollback();
                    return false;
                }
            }

            // ───────────────────────────────────────────
            // 2. Cập nhật bảng SinhVien
            // ───────────────────────────────────────────
            const string sqlSV = @"
UPDATE SinhVien SET
    MaSV     = @NewID,
    TenSV    = @TenSV,
    NgaySinh = @NgaySinh,
    GioiTinh = @GioiTinh,
    DiaChi   = @DiaChi,
    SDT      = @SDT,
    Email    = @Email,
    MaLop    = @MaLop
WHERE MaSV   = @OldID;";
            using var cmdSV = new SqliteCommand(sqlSV, c, tx);
            cmdSV.Parameters.AddWithValue("@NewID", sv.MaSV);
            cmdSV.Parameters.AddWithValue("@TenSV", sv.TenSV);
            cmdSV.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
            cmdSV.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
            cmdSV.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
            cmdSV.Parameters.AddWithValue("@SDT", sv.SDT);
            cmdSV.Parameters.AddWithValue("@Email", sv.Email);
            cmdSV.Parameters.AddWithValue("@MaLop", sv.MaLop);
            cmdSV.Parameters.AddWithValue("@OldID", oldMaSV);

            if (cmdSV.ExecuteNonQuery() != 1)
            {
                tx.Rollback();
                return false;           // không tìm thấy SV cũ
            }

            // ───────────────────────────────────────────
            // 3. (Tuỳ chọn) đồng bộ các bảng phụ
            // ───────────────────────────────────────────
            const string sqlDiem = "UPDATE Diem SET MaSV = @NewID WHERE MaSV = @OldID;";
            using var cmdD = new SqliteCommand(sqlDiem, c, tx);
            cmdD.Parameters.AddWithValue("@NewID", sv.MaSV);
            cmdD.Parameters.AddWithValue("@OldID", oldMaSV);
            cmdD.ExecuteNonQuery();     // có thể 0 hàng nếu SV chưa có điểm

            tx.Commit();
            return true;
        }

        public static bool DeleteSinhVien(string maSV)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();
            using var tx = c.BeginTransaction();

            // 1. Xóa điểm của SV (nếu có)
            const string sqlDiem = "DELETE FROM Diem WHERE MaSV = @MaSV";
            using (var cmd = new SqliteCommand(sqlDiem, c, tx))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.ExecuteNonQuery();            // có thể 0–n dòng
            }

            // 2. Xóa sinh viên
            const string sqlSV = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
            using (var cmd = new SqliteCommand(sqlSV, c, tx))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                var affected = cmd.ExecuteNonQuery();  // 1 nếu tồn tại, 0 nếu không
                if (affected != 1)
                {
                    tx.Rollback();
                    return false;               // không tìm thấy SV
                }
            }

            tx.Commit();
            return true;
        }

        // DatabaseHelper.cs
        public static bool UpdateGiangVienInfo(string maGV, string tenGV, string email)
        {
            using var c = new SqliteConnection(Conn);          // Conn = "Data Source=PMQLSVDH_v2.db;"
            c.Open();

            const string sql = @"
        UPDATE GiangVien
        SET    TenGV = @TenGV,
               Email = @Email
        WHERE  MaGV  = @MaGV;";

            using var cmd = new SqliteCommand(sql, c);
            cmd.Parameters.AddWithValue("@TenGV", tenGV);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@MaGV", maGV);

            return cmd.ExecuteNonQuery() == 1;   // trả về true nếu sửa đúng 1 dòng
        }

    }
}