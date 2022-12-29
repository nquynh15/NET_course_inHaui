using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKtraTX2
{
    internal class NhanVien
    {
        // dùng auto property để tiết kiệm thời gian gõ code
        public string MaNhanVien { get; set; }

        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string PhongBan { get; set; }
        public double HeSoLuong { get; set; }
        public int Tuoi
        {
            get
            {
                DateTime ns = DateTime.Parse(NgaySinh, new CultureInfo("vi-VI", true));
                return DateTime.Now.Year - ns.Year;
            }
        }
        public NhanVien(string maNhanVien, string hoTen, string ngaySinh, string gioiTinh, 
            string phongBan, double heSoLuong)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            PhongBan = phongBan;
            HeSoLuong = heSoLuong;
        }
        public NhanVien() { }

    }
}
