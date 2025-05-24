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

        public static bool InsertGiangVien(GiangVien gv)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            // 1. Không cho trùng mã
            const string chk = "SELECT 1 FROM GiangVien WHERE MaGV = @MaGV LIMIT 1";
            using (var cmdChk = new SqliteCommand(chk, c))
            {
                cmdChk.Parameters.AddWithValue("@MaGV", gv.MaGV);
                if (cmdChk.ExecuteScalar() != null) return false;     // đã tồn tại
            }

            // 2. Thêm mới
            const string ins = @"
INSERT INTO GiangVien (MaGV, TenGV, Email, MaKhoa, MaMH)
VALUES (@MaGV,@TenGV,@Email,@MaKhoa,@MaMH);";
            using var cmd = new SqliteCommand(ins, c);
            cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
            cmd.Parameters.AddWithValue("@TenGV", gv.TenGV);
            cmd.Parameters.AddWithValue("@Email", gv.Email);
            cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);
            cmd.Parameters.AddWithValue("@MaMH", gv.MaMH);
            cmd.ExecuteNonQuery();
            return true;
        }
        // DatabaseHelper.cs
        // ────────────────────────────────────────────────────────
        // 7.  Danh sách Mã-Tên môn học của MỘT lớp
        // ────────────────────────────────────────────────────────
      
        // ───────────────────────────────────────────────────
        // 5.  Danh sách Mã-Tên sinh viên (tùy chọn theo lớp)
        // ───────────────────────────────────────────────────
        public static void LoadMaTenSV(DataGridView dgv,
                                       string? maLop = null,
                                       string? kw = null)
        {
            var sql = new StringBuilder(@"
        SELECT sv.MaSV AS [Mã SV],
               sv.TenSV AS [Tên SV]
          FROM SinhVien sv ");

            if (!string.IsNullOrWhiteSpace(maLop))
                sql.AppendLine("WHERE sv.MaLop = @MaLop");

            if (!string.IsNullOrWhiteSpace(kw))
                sql.AppendLine((maLop == null ? "WHERE" : "AND") +
                               " (sv.MaSV LIKE @kw OR sv.TenSV LIKE @kw)");

            sql.AppendLine("ORDER BY sv.MaSV;");

            using var c = new SqliteConnection(Conn); c.Open();
            using var cmd = new SqliteCommand(sql.ToString(), c);
            if (maLop != null) cmd.Parameters.AddWithValue("@MaLop", maLop);
            if (kw != null) cmd.Parameters.AddWithValue("@kw", $"%{kw.Trim()}%");

            var dt = new DataTable(); dt.Load(cmd.ExecuteReader());

            // ánh xạ cột một lần
            if (dgv.Columns["MaSV"]?.DataPropertyName == "")
            {
                dgv.AutoGenerateColumns = false;
                dgv.Columns["MaSV"].DataPropertyName = "Mã SV";
                dgv.Columns["TenSV"].DataPropertyName = "Tên SV";
            }
            dgv.DataSource = dt;
        }
        // ───────────────────────────────────────────────────
        // 6.  Danh sách Mã-Tên môn học (tùy chọn theo khoa)
        // ───────────────────────────────────────────────────
        public static void LoadMaTenMH(DataGridView dgv,
                                       string? maKhoa = null,
                                       string? kw = null)
        {
            var sql = new StringBuilder(@"
        SELECT mh.MaMH AS [Mã MH],
               mh.TenMH AS [Tên MH]
          FROM MonHoc mh ");

            // 1. Lọc theo khoa (nếu có)
            if (!string.IsNullOrWhiteSpace(maKhoa))
                sql.AppendLine("WHERE mh.MaKhoa = @MaKhoa");

            // 2. Tìm kiếm nhanh
            if (!string.IsNullOrWhiteSpace(kw))
                sql.AppendLine((maKhoa == null ? "WHERE" : "AND") +
                               " (mh.MaMH LIKE @kw OR mh.TenMH LIKE @kw)");

            sql.AppendLine("ORDER BY mh.MaMH;");

            using var c = new SqliteConnection(Conn); c.Open();
            using var cmd = new SqliteCommand(sql.ToString(), c);
            if (maKhoa != null) cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
            if (kw != null) cmd.Parameters.AddWithValue("@kw", $"%{kw.Trim()}%");

            var dt = new DataTable(); dt.Load(cmd.ExecuteReader());

            // ánh xạ cột – chỉ cần 1 lần cho mỗi DataGridView
            if (dgv.Columns["MaMH"]?.DataPropertyName == "")
            {
                dgv.AutoGenerateColumns = false;
                dgv.Columns["MaMH"].DataPropertyName = "Mã MH";
                dgv.Columns["TenMH"].DataPropertyName = "Tên MH";
            }
            dgv.DataSource = dt;
        }
        // DatabaseHelper.cs
        // ─────────────────────────────────────────────────────────────
        // 7.  Danh sách Mã-Tên môn học CỦA MỘT LỚP (theo GiangDay)
        // ─────────────────────────────────────────────────────────────
        public static void LoadMaTenMHByLop(DataGridView dgv,
                                            string maLop,
                                            string? kw = null)
        {
            if (string.IsNullOrWhiteSpace(maLop))
            {
                dgv.DataSource = null;
                return;
            }

            var sb = new StringBuilder(@"
        SELECT mh.MaMH  AS [Mã MH],
               mh.TenMH AS [Tên MH]
        FROM   GiangDay gd
        JOIN   MonHoc   mh ON mh.MaMH = gd.MaMH
        WHERE  gd.MaLop = @MaLop ");

            // thêm điều kiện tìm kiếm nếu có
            if (!string.IsNullOrWhiteSpace(kw))
                sb.AppendLine("AND (mh.MaMH LIKE @kw OR mh.TenMH LIKE @kw)");

            sb.AppendLine("ORDER BY mh.MaMH;");

            DataTable dt = new();

            try
            {
                using var c = new SqliteConnection(Conn);
                using var cmd = new SqliteCommand(sb.ToString(), c);

                cmd.Parameters.AddWithValue("@MaLop", maLop);
                if (!string.IsNullOrWhiteSpace(kw))
                    cmd.Parameters.AddWithValue("@kw", $"%{kw.Trim()}%");

                c.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SQL ERROR: {ex.Message}", "LoadMaTenMHByLop");
                return;                     // không gán DataSource khi lỗi
            }

            /* ánh xạ cột (chạy đúng 1 lần cho dgv này) */
            if (string.IsNullOrEmpty(dgv.Columns["MaMH"]?.DataPropertyName))
            {
                dgv.AutoGenerateColumns = false;
                dgv.Columns.Clear();

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "MaMH",
                    HeaderText = "Mã MH",
                    DataPropertyName = "Mã MH",
                    Width = 90
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TenMH",
                    HeaderText = "Tên MH",
                    DataPropertyName = "Tên MH",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            dgv.DataSource = dt;
        }

        // THÊM dưới cùng file DatabaseHelper.cs (ngay sau InsertGiangVien chẳng hạn)
        public static bool InsertLopHoc(LopHoc lh)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            /* 1. Ngăn trùng khóa chính */
            const string chk = "SELECT 1 FROM LopHoc WHERE MaLop = @MaLop LIMIT 1";
            using (var cmdChk = new SqliteCommand(chk, c))
            {
                cmdChk.Parameters.AddWithValue("@MaLop", lh.MaLop);
                if (cmdChk.ExecuteScalar() != null) return false;   // đã tồn tại
            }

            /* 2. Thực hiện INSERT */
            const string ins = @"
        INSERT INTO LopHoc (MaLop, TenLop, KhoaHoc)
        VALUES (@MaLop, @TenLop, @KhoaHoc);";

            using var cmd = new SqliteCommand(ins, c);
            cmd.Parameters.AddWithValue("@MaLop", lh.MaLop);
            cmd.Parameters.AddWithValue("@TenLop", lh.TenLop);
            cmd.Parameters.AddWithValue("@KhoaHoc", lh.KhoaHoc);
            cmd.ExecuteNonQuery();
            return true;            // thêm OK
        }

        public static DataTable GetAllLopHoc(string? kw = null)
        {
            using var c = new SqliteConnection(Conn);
            c.Open();

            var sb = new StringBuilder();

            sb.AppendLine(@"
SELECT  lh.MaLop   AS MaLop,
        lh.TenLop  AS TenLop,
        lh.KhoaHoc AS KhoaHoc,
        COUNT(sv.MaSV) AS SoHS
FROM    LopHoc lh
LEFT    JOIN SinhVien sv ON sv.MaLop = lh.MaLop
WHERE   1 = 1");

            if (!string.IsNullOrWhiteSpace(kw))
                sb.AppendLine("  AND (lh.MaLop LIKE @kw OR lh.TenLop LIKE @kw)");

            // *** thêm dấu cách hoặc xuống dòng rõ ràng ***
            sb.AppendLine("GROUP BY lh.MaLop, lh.TenLop, lh.KhoaHoc");
            sb.AppendLine("ORDER BY lh.MaLop;");

            using var cmd = new SqliteCommand(sb.ToString(), c);
            if (!string.IsNullOrWhiteSpace(kw))
                cmd.Parameters.AddWithValue("@kw", $"%{kw.Trim()}%");

            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        // ─────────────────────────────────────────────────────────────
        // 8.  Danh sách giảng viên dạy 1 môn học
        // ─────────────────────────────────────────────────────────────
        public static void LoadGiangVienByMH(DataGridView dgv,
                                             string maMH,
                                             string? kw = null)
        {
            if (string.IsNullOrWhiteSpace(maMH))
            {
                dgv.DataSource = null;
                return;
            }

            var sb = new StringBuilder(@"
SELECT gv.MaGV  AS [Mã GV],
       gv.TenGV AS [Họ và tên],
       gv.Email AS [Email],
       mh.TenMH AS [Môn học],
       k.TenKhoa AS [Khoa]
FROM   GiangVien gv
JOIN   MonHoc   mh ON gv.MaMH   = mh.MaMH
JOIN   Khoa      k ON gv.MaKhoa = k.MaKhoa
WHERE  gv.MaMH = @MaMH ");

            if (!string.IsNullOrWhiteSpace(kw))
                sb.AppendLine("AND (gv.MaGV LIKE @kw OR gv.TenGV LIKE @kw OR gv.Email LIKE @kw)");

            sb.AppendLine("ORDER BY gv.MaGV;");

            using var c = new SqliteConnection(Conn); c.Open();
            using var cmd = new SqliteCommand(sb.ToString(), c);
            cmd.Parameters.AddWithValue("@MaMH", maMH);
            if (kw != null) cmd.Parameters.AddWithValue("@kw", $"%{kw.Trim()}%");

            var dt = new DataTable(); dt.Load(cmd.ExecuteReader());

            /* ánh xạ cột 1 lần duy nhất */
            if (string.IsNullOrEmpty(dgv.Columns["MaGV"]?.DataPropertyName))
            {
                dgv.AutoGenerateColumns = false;
                dgv.Columns.Clear();
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "MaGV",
                    HeaderText = "Mã GV",
                    DataPropertyName = "Mã GV",
                    Width = 90
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TenGV",
                    HeaderText = "Họ và tên",
                    DataPropertyName = "Họ và tên",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Email",
                    HeaderText = "Email",
                    DataPropertyName = "Email",
                    Width = 200
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "MonHoc",
                    HeaderText = "Môn học",
                    DataPropertyName = "Môn học"
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Khoa",
                    HeaderText = "Khoa",
                    DataPropertyName = "Khoa"
                });
            }

            dgv.DataSource = dt;
        }

    }

}