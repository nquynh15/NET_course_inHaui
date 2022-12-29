using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De6Ktra2
{
    internal class ThiSinh
    {
        public string SBD { get; set; }
        public float Diem { get; set; }
        public string NS { get; set; }
        public int UT { get; set; }

        public ThiSinh(string sBD, float diem, string nS, int uT)
        {
            this.SBD = sBD;
            this.Diem = diem;
            this.NS = nS;
            this.UT = uT;
        }
    }
}
