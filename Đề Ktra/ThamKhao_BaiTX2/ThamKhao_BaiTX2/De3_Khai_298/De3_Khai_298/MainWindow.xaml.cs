using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Threading;
namespace De3_Khai_298
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<NhanVien> DSNhanVien = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            dpNgaySinh.SelectedDate = DateTime.Now;
            //DSNhanVien.Add(new NhanVien("test", "Cơ Hữu", "20-2-2002", 5000));
            //dgvNV.ItemsSource = null;
            //dgvNV.ItemsSource = DSNhanVien;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if(Validation())
            {
                DSNhanVien.Add(new NhanVien(txtTen.Text, cbLoaiNV.Text, ((DateTime)dpNgaySinh.SelectedDate).ToString("dd-MM-yyyy"), double.Parse(txtTien.Text)));
                dgvNV.ItemsSource = null;
                dgvNV.ItemsSource = DSNhanVien;
                txtTen.Text = "";
                cbLoaiNV.SelectedIndex = -1;
                dpNgaySinh.SelectedDate = DateTime.Now;
                txtTien.Text = "";
            }
        }
        private bool Validation()
        {
            if(txtTen.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTen.Focus();
                return false;
            }
            if (cbLoaiNV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại nhân viên!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
                cbLoaiNV.Focus();
                return false;
            }
            int tuoi = DateTime.Now.Year - ((DateTime)dpNgaySinh.SelectedDate).Year;
            if(tuoi < 18 || tuoi > 60)
            {
                MessageBox.Show("Tuổi nhân viên không hợp lệ!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
                dpNgaySinh.Focus();
                return false;
            }
            if(txtTien.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số tiền bán hàng!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTien.Focus();
                return false;
            } else
            {
                try
                {
                    double tien = double.Parse(txtTien.Text);
                } catch(Exception)
                {
                    MessageBox.Show("Số tiền bán hàng phải là số thực!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtTien.Focus();
                    txtTien.SelectAll();
                    return false;
                }
            }
            if(double.Parse(txtTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền bán hàng phải lớn hơn 0!", "Lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTien.Focus();
                txtTien.SelectAll();
                return false;
            }
            
            return true;
        }

        private void windowBtn_Click(object sender, RoutedEventArgs e)
        {
            double tienMax = DSNhanVien.Min(nv => nv.SoTienBH);
            List<NhanVien> DSTien = new List<NhanVien>();
            DSTien = DSNhanVien.FindAll(nv => nv.SoTienBH == tienMax);
            Window2 myWindow = new Window2();
            myWindow.dgvNV.ItemsSource = null;
            myWindow.dgvNV.ItemsSource = DSTien;
            myWindow.Show();
        }

        private void txtTen_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //code định dạng datepicker hiển thị ngày - tháng - năm
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            Thread.CurrentThread.CurrentCulture = ci;
        }
    }
}
