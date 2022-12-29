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

namespace De9_Quynh_509
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortTimePattern = "dd-MM-yyyy";


        }

        List<ThietBi> dsTB = new List<ThietBi>();

        public bool check()
        {
            if(txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thiết bị !", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMa.Focus();
                return false;
            }
            int c = 0;
            foreach(ThietBi t in dsTB)
            {
                if (txtMa.Text.ToLower().Equals(t.MaTB.ToLower()))
                {
                    c = 1;
                }
            }
            if (c == 1)
            {
                MessageBox.Show("Trùng mã thiết bị !", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMa.Focus();
                return false;
            }

            if (txtViTri.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vị trí !", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtViTri.Focus();
                return false;
            }

            if(DateTime.Now < (DateTime)dpNgay.SelectedDate)
            {
                MessageBox.Show("Ngày sử dụng không hợp lệ!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                dpNgay.Focus();
                return false;
            }
            if(cboMayTinh.IsSelected == false && cboDienThoai.IsSelected == false &&cboMayChieu.IsSelected == false)
            {
                MessageBox.Show("Bạn chưa chọn loại thiết bị !", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }


        private void btn_Nhap(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                string Ngay = ((DateTime)dpNgay.SelectedDate).ToString("dd-MM-yyyy");

                string Loai;
                if(cboMayTinh.IsSelected == true)
                {
                    Loai = "Máy tính";
                }
                else if(cboDienThoai.IsSelected == true)
                {
                    Loai = "Điện thoại";
                }
                else
                {
                    Loai = "Máy chiếu";
                }

                ThietBi tb = new ThietBi(txtMa.Text, txtViTri.Text, Ngay, Loai);
                dsTB.Add(tb);

                dgTB.ItemsSource = null;
                dgTB.ItemsSource = dsTB;
            }

        }


        private void btn_Win(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Parse(dsTB[0].Ngay);

            foreach (ThietBi tb in dsTB)
            {
                if (dt > DateTime.Parse(tb.Ngay))
                {
                    dt = DateTime.Parse(tb.Ngay);
                }
            }

            List<ThietBi> ds2 = new List<ThietBi>();
            for (int i = 0; i < dsTB.Count; i++)
            {
                if (dt == DateTime.Parse(dsTB[i].Ngay))
                {
                    ds2.Add(dsTB[i]);
                }
            }

            Window2 win = new Window2();
            win.dgTB.ItemsSource = null;
            win.dgTB.ItemsSource = ds2;
            win.Show();
        }
    }
}
