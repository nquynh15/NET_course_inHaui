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

namespace BaiKtraTX2
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

        //tạo ds sao lưu các nhận viên
        private List<NhanVien> dsNV = new List<NhanVien>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //định djang hiện thị ngày tháng năm trong datapicker
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            //Thread.CurrentThread.CurrentCulture = ci;

            //tạo dữ liệu cho data grid để test định dạng dữ liệu
            NhanVien nv = new NhanVien("NV01", "AAA", "31-10-2000", "Nữ", "Phòng tổ chức", 2);
            dsNV.Add(nv);

            //kết nối nguồn dl cho datagrid
            dgvNhanVien.ItemsSource = null;
            dgvNhanVien.ItemsSource = dsNV;
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDuLieu())
            {
                string ns = ((DateTime)dtpNgaySinh.SelectedDate).ToString("dd-MM-yyyy");
                string gt;
                if(rdbNam.IsChecked == true){
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                NhanVien nv = new(txtMa.Text, txtHoTen.Text, ns, gt, cbp.Text, double.Parse(txtHSL.Text));
                dsNV.Add(nv);

                dgvNhanVien.ItemsSource = null;
                dgvNhanVien.ItemsSource = dsNV;
            }
        }
        private bool KiemTraDuLieu()
        {
            //viết phương thức kiểm tra dữ liệu trước khi nhập
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMa.Focus();
                return false;
            }
            if (txtHoTen.Text == String.Empty)
            {
                MessageBox.Show("Chưa nhập họ tên", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }

            DateTime ns = (DateTime)dtpNgaySinh.SelectedDate;
            int tuoi = DateTime.Now.Year - ns.Year;
            if (tuoi < 18)
            {
                MessageBox.Show("Tuổi của nhân viên phải > 18", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(txtHSL.Text == String.Empty)
            {
                MessageBox.Show("Chưa nhập hệ số lương", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHSL.Focus();
                return false;
            }
            else
            {
                try
                {
                    double hsLuong = double.Parse(txtHSL.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Hệ số lương phải là số", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHSL.Focus();
                    txtHSL.SelectAll(); // chọn hết văn bản đã nhập
                    return false;
                }
            }
            return true;
        }

        private void btnWindow_click(object sender, RoutedEventArgs e)
        {
            int tuoiMax = dsNV.Max(nv => nv.Tuoi);
            List<NhanVien> dsTuoi = dsNV.FindAll(nv => nv.Tuoi == tuoiMax);
            Window2 myWindow = new Window2();
            myWindow.dgvNhanVien.ItemsSource = dsTuoi;
            myWindow.Show();
        }
    }
}
