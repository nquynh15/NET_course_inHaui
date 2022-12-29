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

namespace De5Ktra2
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
        List<NhanVien> dsNV = new List<NhanVien>();
        private void Win_Loaded(object sender, RoutedEventArgs e)
        {

            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";

            dgNV.ItemsSource = null;
            dgNV.ItemsSource = dsNV;
        }
        public bool check()
        {
            if(txthoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txthoten.Focus();
                return false;
            }
            if (txtsongay.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số ngày làm việc!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txthoten.Focus();
                return false;
            }
            else
            {
                try
                {
                    int SoNgay = int.Parse(txtsongay.Text);
                    if(SoNgay <= 0)
                    {
                        MessageBox.Show("Số ngày làm việc phải lớn hơn 0", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        txthoten.Focus();
                        return false;
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Số ngày làm việc phải là số thập phân", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txthoten.Focus();
                    return false;
                }
            }
            if(DateTime.Now < (DateTime)txtngay.SelectedDate)
            {
                MessageBox.Show("Ngày tuyển dụng không hợp lệ!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txthoten.Focus();
                return false;
            }
            return true;
        }
        private void btn_Nhap(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                int SoNgay = int.Parse(txtsongay.Text);
                string NgayTD = ((DateTime)txtngay.SelectedDate).ToString("dd-MM-yyyy");
                string GioiTinh;
                if (rdNam.IsChecked == true)
                {
                    GioiTinh = "Nam";
                }
                else
                {
                    GioiTinh = "Nữ";
                }

                NhanVien nv = new NhanVien(txthoten.Text, SoNgay, NgayTD, GioiTinh);

                dsNV.Add(nv);
            }
            

            dgNV.ItemsSource = null;
            dgNV.ItemsSource = dsNV;

        }

        private void btn_Win(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            double max = dsNV[0].TienLuong;
            foreach(NhanVien x in dsNV)
            {
                if(max < x.TienLuong)
                {
                    max = x.TienLuong;
                }
            }
            List<NhanVien> tmp = new List<NhanVien>();
            for(int i=0; i<dsNV.Count; i++)
            {
                if (max == dsNV[i].TienLuong)
                {
                    tmp.Add(dsNV[i]);
                }
            }

            win.dgNV.ItemsSource = null;
            win.dgNV.ItemsSource = tmp;
            win.Show();

        }


    }
}
