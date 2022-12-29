using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De2KtraTX2
{
    internal class KhachHang
    {
        public string MaKH { get; set; }
        public string NgayMua { get; set; }
        public float SoLuong { get; set; }

        public double DonGia { get; set; }

        public double ThanhTien
        {
            get{ return SoLuong * DonGia;  }
            
        }

        public KhachHang(string maKH, string ngayMua, float soLuong, double donGia)
        {
            this.MaKH = maKH;
            this.NgayMua = ngayMua;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public KhachHang() { }
    }
}
