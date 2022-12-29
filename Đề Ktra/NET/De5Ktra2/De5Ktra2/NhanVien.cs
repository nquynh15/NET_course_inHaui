using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De5Ktra2
{
    internal class NhanVien
    {
        public string HoTen { get; set; }

        public int SoNgay { get; set; }

        public string NgayTD { get; set; }

        public string GioiTinh { get; set; }

        public double TienLuong
        {
            get
            {
                if(SoNgay <= 10)
                {
                    return SoNgay * 200000;
                }
                else
                {
                    return 2000000 + (SoNgay - 10) * 400000;
                }
            }
        }

        public NhanVien(string hoTen, int soNgay, string ngayTD, string gioiTinh)
        {
            this.HoTen = hoTen;
            this.SoNgay = soNgay;
            this.NgayTD = ngayTD;
            this.GioiTinh = gioiTinh;
        }
    }
}
