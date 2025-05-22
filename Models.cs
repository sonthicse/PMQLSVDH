using System;
using System.Collections.Generic;

namespace PMQLSVDH
{
    public class SinhVien
    {
        public string? MaSV { get; set; }
        public string? TenSV { get; set; }
        public string? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? MaLop { get; set; }
        public List<Diem>? diem { get; set; } = new();
    }

    public class LopHoc
    {
        public string? MaLop { get; set; }
        public string? TenLop { get; set; }
        public string? KhoaHoc { get; set; }
        public List<SinhVien>? sinhViens { get; set; } = new();
    }

    public class Khoa
    {
        public string? MaKhoa { get; set; }
        public string? TenKhoa { get; set; }
    }

    public class MonHoc
    {
        public string? MaMH { get; set; }
        public string? TenMH { get; set; }
        public int SoTinChi { get; set; }
        public string? MaKhoa { get; set; }
    }

    public class GiangVien
    {
        public string? MaGV { get; set; }
        public string? TenGV { get; set; }
        public string? Email { get; set; }
        public string? MaKhoa { get; set; }
        public string? MaMH { get; set; }
        public List<LopHoc>? lopHocs { get; set; } = new();
    }

    public class Diem
    {
        public string? MaSV { get; set; }
        public string? MaMH { get; set; }
        public float Diem_CC { get; set; }
        public float Diem_TX { get; set; }
        public float Diem_THI { get; set; }
        public float Diem_HP { get; set; }
    }

    public class GiangDay
    {
        public string? HocKy { get; set; }
        public string? NamHoc { get; set; }
        public string? MaGV { get; set; }
        public string? MaMH { get; set; }
        public string? MaLop { get; set; }
    }

    public class TaiKhoan
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? MaGV { get; set; }
        public string? MaKhoa { get; set; }
    }
}