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

namespace De3KtraTX2
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-mm-yyyy";
            

            dgNV.ItemsSource = null;
            dgNV.ItemsSource = dsNV;

        }

        public bool check()
        {
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            if (dtNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                dtNgaySinh.Focus();
                return false;
            }
            DateTime ns = (DateTime)dtNgaySinh.SelectedDate;
            int tuoi = DateTime.Now.Year - ns.Year;
            if(tuoi <18 || tuoi > 60)
            {
                MessageBox.Show("Ngày sinh phải thuộc khoảng [18; 60]!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                dtNgaySinh.Focus();
                return false;
            }
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Số tiền bán hàng!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            else if(float.Parse(txtSoTien.Text) < 0)
            {
                MessageBox.Show("Số tiền bán hàng phải lớn hơn 0!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            else
            {
                try
                {
                    float SoTien = float.Parse(txtSoTien.Text);
                }
                catch
                {
                    MessageBox.Show("Số tiền bán hàng phải là số thực!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHoTen.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btn_Nhap(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                float SoTien = float.Parse(txtSoTien.Text);
                string ns = ((DateTime)dtNgaySinh.SelectedDate).ToString("dd-mm-yyyy");
                string loaiNV;
                if(cbCoHuu.IsSelected == true)
                {
                    loaiNV = "Cơ hữu";
                }
                else if(cbHopDong.IsSelected == true)
                {
                    loaiNV = "Hợp đồng";
                }
                else
                {
                    loaiNV = "Cộng tác viên";
                }

                NhanVien nv = new NhanVien(txtHoTen.Text, loaiNV, ns, SoTien);
                dsNV.Add(nv);

                dgNV.ItemsSource = null;
                dgNV.ItemsSource = dsNV;
            }

        }

        private void btn_Win(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            float min;
            min = dsNV[0].SoTien;
            foreach(NhanVien item in dsNV)
            {
                if(min < dsNV[0].SoTien)
                {
                    min = dsNV[0].SoTien;
                }
            }
            List<NhanVien> ds = new List<NhanVien>();
            for (int i=0; i<dsNV.Count; i++)
            {
                if (min == dsNV[i].SoTien)
                {
                    ds.Add(dsNV[i]);
                }
            }

            win2.dgNV.ItemsSource = ds;
            win2.Show();

        }

    }
}
