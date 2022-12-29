using QLTruongHoc.Models;
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

namespace QLTruongHoc
{
    /// <summary>
    /// Interaction logic for TimKiem.xaml
    /// </summary>
    public partial class TimKiem : Window
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        truonghocdb2Context db2 = new truonghocdb2Context();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from sv in db2.Sinhviens
                        join lh in db2.Lophocs
                        on sv.Malop equals lh.Malop
                        where sv.Diem > 5 where sv.Malop == 3
                        select new
                        {
                            sv.Masv,
                            sv.Hoten,
                            sv.Diachi,
                            sv.Diem,
                            lh.Malop,
                            lh.Tenlop
                        };

            dgWindow2.ItemsSource = query.ToList();
        }
    }
}
