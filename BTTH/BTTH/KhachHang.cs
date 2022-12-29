using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH
{
    internal class KhachHang:IComparable<KhachHang>
    {
        private string _hoten;
        public string name
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        private bool _gioitinh;
        public bool gender 
        { 
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private int _slmua;
        public int quantity
        {
            get { return _slmua; }
            set { _slmua = value;}   
        }

        private int _dongia;
        public int price
        {
            get { return _dongia; }
            set {  _dongia = value; }
        }

        public KhachHang() { }

        public KhachHang(string name, bool gender, int quantity, int price )
        { 
            this.name = name;
            this.gender = gender;
            this.quantity = quantity;
            this.price = price;
        }

        public double TongTien()
        {
            if(this.quantity<100)
                return (double)quantity * price;
            else
                return (double)0.9 * quantity * price;
        }

        public string GioiTinh;
        public override string ToString()
        {
            if (gender) this.GioiTinh = "Nam";
            else this.GioiTinh = "Nu";
            return this.name + "\t" + this.GioiTinh + "\t" + this.quantity + "\t" + this.price + "\t" + this.TongTien();
        }

        public void Nhap(string name, bool gender, int quantity, int price)
        {
            this.name = name;
            this.gender = gender;
            this.quantity = quantity;
            this.price = price;
        }
        public override bool Equals(object obj)
        {
            KhachHang kh = (KhachHang) obj;
            return this.name.Equals(kh.name);
        }

        public int CompareTo([AllowNull] KhachHang other)
        {
            if ( other.quantity == this.quantity)
                return -this.name.CompareTo(other.name);
            else
                return this.quantity.CompareTo(other.quantity);

        }
    }
}
