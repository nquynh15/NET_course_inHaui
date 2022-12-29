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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai9_1
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

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //tạo danh sashc cho list box
            lstDanhSach.Items.Add("Công nghệ thực tế ảo");
            lstDanhSach.Items.Add("Đảm bảo chất lượng phần mềm");
            lstDanhSach.Items.Add("Giải thuật di truyền và ứng dụng");
            lstDanhSach.Items.Add("Hệ chuyên gia");
            lstDanhSach.Items.Add("Lập trình căn bản");
            lstDanhSach.Items.Add("Lập trình hướng đối tượng");
            lstDanhSach.Items.Add("Lập trình mạng");
            lstDanhSach.Items.Add("Lập trình trên Windows");
            lstDanhSach.Items.Add("Một số phương pháp tính toán mềm");
            lstDanhSach.Items.Add("Nhập môn tin học");
            lstDanhSach.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSach.Items.Add("Phân tích và thống kê số liệu");
            lstDanhSach.Items.Add("Thiết kế cơ sở dữ liệu");
            lstDanhSach.Items.Add("Thiết kế trang web");
            lstDanhSach.Items.Add("Tin văn phòng");
        }
        private void btnChonMot_Click(object sender, RoutedEventArgs e)
        {
            //Thêm một phần tử sang danh sách chọn đồng thời xóa bên đã chọn
            lstDanhSachChon.Items.Add(lstDanhSach.SelectedItem);
            lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
        }

        private void btnChonNhieu_Click(object sender, RoutedEventArgs e)
        {
            // đưa tất cả các phân tử ds chọn sang dsChọn
            foreach ( var item in lstDanhSach.Items)
            {
                lstDanhSachChon.Items.Add(item);
            }
            //xóa ptu đã chọn
            lstDanhSach.Items.Clear();
        }

        private void btnBoMot_Click(object sender, RoutedEventArgs e)
        {
            //Thêm một phần tử từ danh sách chọn về ban đầu
            lstDanhSach.Items.Add(lstDanhSachChon.SelectedItem);
            lstDanhSachChon.Items.Remove(lstDanhSachChon.SelectedItem);
        }

        private void btnBoNhieu_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in lstDanhSachChon.Items)
            {
                lstDanhSach.Items.Add(item);
            }
            //xóa ptu đã chọn
            lstDanhSachChon.Items.Clear();
        }
    }
}
