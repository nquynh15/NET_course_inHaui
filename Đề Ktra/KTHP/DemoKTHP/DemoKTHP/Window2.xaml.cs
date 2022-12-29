using DemoKTHP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoKTHP
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        QLBanHangContext db = new QLBanHangContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        join lsp in db.LoaiSanPhams
                        on sp.MaLoai equals lsp.MaLoai
                        join hd in db.HoaDonChiTiets
                        on sp.MaSp equals hd.MaSp
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            lsp.TenLoai,
                            hd.SoLuongMua,
                            Tien = sp.DonGia * hd.SoLuongMua
                        };


            dgSanPham2.ItemsSource = query.ToList();
        }
    }
}
