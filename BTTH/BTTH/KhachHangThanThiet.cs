using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH
{
    internal class KhachHangThanThiet:KhachHang
    {
        public int matheTV { get; set; }

        public KhachHangThanThiet() { }
        public KhachHangThanThiet(string name, bool gender, int quantity, int price, int matheTV)
            :base(name, gender, quantity, price)
        {
            this.matheTV = matheTV;
        }
        public string XacDinhQuaTang()
        {
            if (this.TongTien() <= 1000)
                return "Coupon 200";
            else
                return "Coupon 500";
        }
        public override string ToString()
        {
            return base.ToString() + this.matheTV + "\t" + this.XacDinhQuaTang();
        }

    }
}
