using System;
using System.Collections.Generic;

#nullable disable

namespace DemoKTHP.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string MaLoai { get; set; }
        public int? SoLuongCo { get; set; }
        public double? DonGia { get; set; }

        public virtual LoaiSanPham MaLoaiNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
