using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace De5_Hanh_490
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public string NgayTuyenDung { get; set; }
        public string GioiTinh { get; set; }
        public int SoNgayLamViec { get; set; }
        public NhanVien(string HoTen, string NgayTuyenDung, string GioiTinh, int SoNgayLamViec)
        {
            this.HoTen = HoTen;
            this.NgayTuyenDung = NgayTuyenDung;
            this.GioiTinh = GioiTinh;
            this.SoNgayLamViec = SoNgayLamViec;
        }
        public int Luong
        {
            get
            {
                if (SoNgayLamViec <= 10)
                {
                    return SoNgayLamViec * 200000;
                }
                else
                {
                    return 2000000 + (SoNgayLamViec - 10) * 400000;
                }
            }
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<NhanVien> NhanVienList = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            Thread.CurrentThread.CurrentCulture = ci;
            dtNgayTuyenDung.SelectedDate = DateTime.Now;
            dgNhanVien.ItemsSource = null;
            dgNhanVien.ItemsSource = NhanVienList;
            rdNam.IsChecked = true;
        }
        bool Validation()
        {
            if (txHoTen.Text == "")
            {
                MessageBox.Show("Họ tên không được để trống.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txHoTen.Focus();
                return false;
            }
            var check = DateTime.Now < DateTime.Parse(dtNgayTuyenDung.Text);
            if (check)
            {
                MessageBox.Show("Ngày tuyển dụng không hợp lệ.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                dtNgayTuyenDung.Focus();
                return false;
            }
            if (txSoNgayLamViec.Text == "")
            {
                MessageBox.Show("Số ngày làm việc không được để trống.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txSoNgayLamViec.Focus();
                return false;
            }
            else
            {
                try
                {
                    if (int.Parse(txSoNgayLamViec.Text) <= 0)
                    {
                        MessageBox.Show("Hệ số lương phải lớn hơn 0.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        txSoNgayLamViec.Focus();
                        txSoNgayLamViec.SelectAll();
                        return false;
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Số ngày phải là số thập phân.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txSoNgayLamViec.Focus();
                    txSoNgayLamViec.SelectAll();
                    return false;
                }
            }
            return true;
        }
        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                var tmp = new NhanVien(txHoTen.Text, dtNgayTuyenDung.Text, (rdNam.IsChecked == true) ? "Nam" : "Nữ", int.Parse(txSoNgayLamViec.Text));
                NhanVienList.Add(tmp);
                dgNhanVien.ItemsSource = null;
                dgNhanVien.ItemsSource = NhanVienList;
            }
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            int Max = NhanVienList.Max(tmp => tmp.Luong);
            var tmpList = NhanVienList.FindAll(tmp => tmp.Luong == Max); ;
            Window1 myWin = new Window1();
            myWin.dgNhanVien.ItemsSource = tmpList;
            myWin.Show();
        }
    }
}
