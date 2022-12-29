using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De3_Khai_298
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public string LoaiNV { get; set; }
        public string NgaySinh { get; set; }
        public double SoTienBH { get; set; }
        public double TienHoaHong
        {
            get
            {
                if (SoTienBH >= 1000 && SoTienBH <= 5000) return SoTienBH * 0.1;
                else if (SoTienBH > 5000) return SoTienBH * 0.2;
                return 0;
            }
        }
        public NhanVien(string ht, string loai, string ngay, double tien)
        {
            HoTen = ht;
            LoaiNV = loai;
            NgaySinh = ngay;
            SoTienBH = tien;
            
        }
    }
}
