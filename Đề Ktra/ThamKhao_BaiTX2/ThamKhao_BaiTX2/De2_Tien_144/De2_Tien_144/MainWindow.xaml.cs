using System;
using System.Collections.Generic;
using System.Windows;
using System.Globalization;
using System.Threading;
using De2De2_Tien_144;

namespace De2_Tien_144
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<KhachHang> listKH = new List<KhachHang>();
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool KiemTra()
        {
            if(txtMa.Text == string.Empty)
            {
                txtMa.Focus();
                MessageBox.Show("Bạn chưa nhập mã khách hàng.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {

                int ckh = 0;
                foreach(KhachHang kh in listKH)
                {
                    if (kh.MaKH.ToLower().Equals(txtMa.Text.ToLower()))
                    {
                        ckh = 1;
                    }
                }
                if (ckh == 1)
                {
                    txtMa.Focus();
                    MessageBox.Show("Trùng mã khách hàng.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            if(dateMua.SelectedDate == null)
            {
                dateMua.Focus();
                MessageBox.Show("Bạn chưa chọn ngày mua.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(txtSoluong.Text == string.Empty)
            {
                txtSoluong.Focus();
                MessageBox.Show("Bạn chưa nhập số lượng.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                try
                {
                    float sl = float.Parse(txtSoluong.Text);
                    if(sl <= 0)
                    {
                        txtSoluong.Focus();
                        MessageBox.Show("Số lượng phải lớn hơn 0.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
                catch(Exception ex)
                {
                    txtSoluong.Focus();
                    MessageBox.Show("Số lượng phải là số thực", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            if(txtDongia.Text == string.Empty)
            {
                txtDongia.Focus();
                MessageBox.Show("Bạn chưa nhập đơn giá.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                try
                {
                    double dg = double.Parse(txtDongia.Text);
                    if(dg < 0)
                    {
                        txtDongia.Focus();
                        MessageBox.Show("Đơn giá phải thừ 0 trở lên.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
                catch(Exception ex)
                {
                    txtDongia.Focus();
                    MessageBox.Show("Đơn giá phải là số thực.", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    float sl = float.Parse(txtSoluong.Text);
                    double dg = double.Parse(txtDongia.Text);
                    DateTime Ngay = dateMua.SelectedDate.Value;
                    KhachHang kh = new KhachHang(txtMa.Text, Ngay, sl, dg);
                    listKH.Add(kh);
                    dvgKH.ItemsSource = null;
                    dvgKH.ItemsSource = listKH;
                }catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi nhập " + ex.Message);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(listKH.Count == 0)
            {
                MessageBox.Show("Danh sach đang trống ");
            }
            else
            {
                try
                {
                    List<KhachHang> lskh = new List<KhachHang>();
                    lskh.Add(listKH[0]);
                    Window2 win2 = new Window2();
                    win2.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    win2.dvgKH.ItemsSource = lskh;
                    win2.Show();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi hiển thị", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //code để dịnh dạng datepicker hiển thị ngày-tháng-năm
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            Thread.CurrentThread.CurrentCulture = ci;
        }
    }
}
