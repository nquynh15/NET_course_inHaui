using System;
using System.Collections.Generic;
using System.Text;

namespace De2De2_Tien_144
{
    class KhachHang
    {
        public string MaKH { get; set; }
        public DateTime NgayMua { get; set; }
        public float SoLuongMua { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien
        {
            get
            {
                return SoLuongMua * DonGia;
            }
        }
        public string Ngay
        {
            get
            {
                return NgayMua.ToString("dd-MM-yyyy");
            }
        }
        
        public KhachHang(string makh, DateTime ngay, float soluong, double dongia)
        {
            this.MaKH = makh;
            this.NgayMua = ngay;
            this.SoLuongMua = soluong;
            this.DonGia = dongia;
        }
        public KhachHang(string makh)
        {
            this.MaKH = makh;
        }
        
    }
}
