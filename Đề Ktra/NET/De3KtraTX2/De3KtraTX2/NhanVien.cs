using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De3KtraTX2
{
    internal class NhanVien
    {
        public string HoTen { get; set; }
        public string LoaiNV { get; set; }
        public string NgaySinh { get; set; }
        public float SoTien { get; set; }
        public string TienHH
        {
            get
            {
                if(SoTien < 1000)
                {
                    return "0%";
                }
                else if (SoTien > 5000)
                {
                    return "20%";
                }
                else
                {
                    return "10%";
                }
            }
        }
        
        public NhanVien(string hotEN, string loaiNV, string ngaySinh, float soTien)
        {
            this.HoTen = hotEN;
            this.LoaiNV = loaiNV;
            this.NgaySinh = ngaySinh;
            this.SoTien = soTien;
        }
    }
}
