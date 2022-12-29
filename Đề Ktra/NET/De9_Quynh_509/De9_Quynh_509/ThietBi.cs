using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De9_Quynh_509
{
    internal class ThietBi
    {
        public string MaTB { get; set; }

        public string ViTri { get; set; }
        public string Ngay { get; set; }
        public string Loai { get; set; }

        

        public ThietBi(string maTB, string viTri, string ngay, string loai)
        {
            this.MaTB = maTB;
            this.ViTri = viTri;
            this.Ngay = ngay;
            this.Loai = loai;
        }
        public ThietBi() { }
    }
}
