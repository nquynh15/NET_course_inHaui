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

namespace De6_Hoang_017
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

        List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            Thread.CurrentThread.CurrentCulture = ci;
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDuLieu())
            {
                string doiTuongUuTien = "";
                if (radKhong.IsChecked == true)
                {
                    doiTuongUuTien = "KHONG";
                }
                if (radUuTien1.IsChecked == true)
                {
                    doiTuongUuTien = "UT1";
                }
                if (radUuTien2.IsChecked == true)
                {
                    doiTuongUuTien = "UT2";
                }
                string ngaySinh = ((DateTime)dtpNgaySinh.SelectedDate).ToString("dd-MM-yyyy");
                // kiểm tra xem báo danh vừa nhập đã tồn tại chưa
                bool kiemTraSBD = false;
                foreach (var item in danhSachThiSinh)
                {
                    if (item.SoBaoDanh == txtSBD.Text)
                    {
                        MessageBox.Show("Số báo danh " + txtSBD.Text + " đã tồn tại", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                        kiemTraSBD = true;
                        break;
                    }
                }
                if (kiemTraSBD == false)
                {
                    ThiSinh thiSinh = new ThiSinh(txtSBD.Text, Convert.ToDouble(txtDiemThi.Text), ngaySinh, doiTuongUuTien);
                    danhSachThiSinh.Add(thiSinh);
                    dgvThiSinh.Items.Add(thiSinh);
                }
            }
        }

        private bool KiemTraDuLieu()
        {
            // kiểm tra xem đã nhập số báo danh chưa
            if (String.IsNullOrEmpty(txtSBD.Text))
            {
                MessageBox.Show("Chưa nhập số báo danh", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSBD.Focus();
                return false;
            }
            // kiểm tra xem đã nhập điểm thi chưa
            if (String.IsNullOrEmpty(txtDiemThi.Text))
            {
                MessageBox.Show("Chưa nhập điểm thi", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDiemThi.Focus();
                return false;
            }
            else
            {
                try
                {
                    double diemThi = Convert.ToDouble(txtDiemThi.Text);
                    if (diemThi < 0 || diemThi > 30)
                    {
                        MessageBox.Show("Điểm thi phải >= 0 và <= 30", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtDiemThi.Text = "";
                        txtDiemThi.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Điểm thi phải là số", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtDiemThi.Text = "";
                    txtDiemThi.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            if (danhSachThiSinh.Count > 0)
            {
                // tìm điểm tổng cao nhất
                double diemTongCaoNhat = danhSachThiSinh.Max(x => x.DiemTong);
                List<ThiSinh> danhSachThiSinhDiemTongCaoNhat = danhSachThiSinh.FindAll(x => x.DiemTong == diemTongCaoNhat);
                Window2 window2 = new Window2();
                window2.dgvThiSinh.ItemsSource = danhSachThiSinhDiemTongCaoNhat;
                window2.Show();
            }
            else
            {
                MessageBox.Show("Danh sách thí sinh trống!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
