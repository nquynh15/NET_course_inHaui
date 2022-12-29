using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace De2KtraTX2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        List<KhachHang> dsKH = new List<KhachHang>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";

            KhachHang kh1 = new KhachHang("kh1", "22-1-2000", 2, 55);
            dsKH.Add(kh1);
            dgKhachHang.ItemsSource = null;
            dgKhachHang.ItemsSource = dsKH;
        }
        private bool check()
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaKH.Focus();
                return false;
            }
            else
            {

                int ckh = 0;
                foreach (KhachHang kh in dsKH)
                {
                    if (kh.MaKH.ToLower().Equals(txtMaKH.Text.ToLower()))
                    {
                        ckh = 1;
                    }
                }
                if (ckh == 1)
                {
                    txtMaKH.Focus();
                    MessageBox.Show("Trùng mã khách hàng.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            if (dtNgayMua.Text == "")
            {
                MessageBox.Show("Chưa ngày mua!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                dtNgayMua.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Chưa nhập đơn giá", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDonGia.Focus();
                return false;
            }
            if (txtSoLuong.Text == "" )
            {
                MessageBox.Show("Chưa nhập số lượng!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSoLuong.Focus();
                return false;
            }
            else if (float.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSoLuong.Focus();
                return false;
            }
            else
            {
                try
                {
                    float soLuong = float.Parse(txtSoLuong.Text);
                }
                catch
                {
                    MessageBox.Show("Số lượng phải là số thực!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoLuong.Focus();
                    return false;
                }
            }
            return true;

        }
        private void btn_nhap(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                string ngayMua = ((DateTime)dtNgayMua.SelectedDate).ToString("dd-MM-yyyy");

                
                KhachHang kh = new KhachHang(txtMaKH.Text, ngayMua, float.Parse(txtSoLuong.Text), double.Parse(txtDonGia.Text));
                dsKH.Add(kh);

                dgKhachHang.ItemsSource = "null";
                dgKhachHang.ItemsSource = dsKH;
            }
        }

        private void btn_Window(object sender, RoutedEventArgs e)
        {
            List<KhachHang> lskh = new List<KhachHang>();
            lskh.Add(dsKH[0]);
            
            Window2 mywindow = new Window2();
            mywindow.dgKhachHang.ItemsSource = lskh;
            mywindow.Show();
        }
    }
}
