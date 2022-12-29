using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De6_Hoang_017
{
    class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public double DiemThi { get; set; }
        public string NgaySinh { get; set; }
        public string DoiTuongUuTien { get; set; }
        public double DiemUuTien
        {
            get
            {
                if (DoiTuongUuTien == "UT1")
                {
                    return 2;
                }
                else if (DoiTuongUuTien == "UT2")
                {
                    return 1;
                }
                return 0;
            }
        }
        
        public double DiemTong
        {
            get
            {
                return DiemThi + DiemUuTien;
            }
        }

        public ThiSinh() { }

        public ThiSinh(string soBaoDanh, double diemThi, string ngaySinh, string doiTuongUuTien)
        {
            SoBaoDanh = soBaoDanh;
            DiemThi = diemThi;
            NgaySinh = ngaySinh;
            DoiTuongUuTien = doiTuongUuTien;
        }
    }
}
