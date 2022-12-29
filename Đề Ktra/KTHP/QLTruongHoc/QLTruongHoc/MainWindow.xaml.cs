using QLTruongHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace QLTruongHoc
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

        truonghocdb2Context db = new truonghocdb2Context();

        private void HienThiDataGrid()
        {
            var query = from sv in db.Sinhviens select sv;
            dgSV.ItemsSource = query.ToList();
        }
        private void HienThiConboBoxDiaChi()
        {
            var query = from sv in db.Sinhviens select sv;
            cboDiaChi.ItemsSource = query.ToList();
            cboDiaChi.DisplayMemberPath = "Diachi";
            cboDiaChi.SelectedValuePath = "Masv";
            cboDiaChi.SelectedIndex = 0;
        }
      
        private void HienThiConboBoxLop()
        {
            var query = from lp in db.Lophocs select lp;
            cboLop.ItemsSource = query.ToList();
            cboLop.DisplayMemberPath = "Tenlop";
            cboLop.SelectedValuePath = "Malop";
            cboLop.SelectedIndex = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDataGrid();
            HienThiConboBoxDiaChi();
            HienThiConboBoxLop();

        }
        private bool check()
        {
            string ma = txtMa.Text;
            string hoten = txtHoTen.Text;
            string diem = txtDiem.Text;
            if (ma == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMa.Focus();
                return false;
            }
            if (hoten == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            if (diem == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDiem.Focus();
                return false;
            }
            else
            {
                try
                {
                    byte d = byte.Parse(diem);
                    if(d <1  || d > 10)
                    {
                        MessageBox.Show("Điểm phải thuộc khoảng [1-10]", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtDiem.Focus();
                        return false;
                    }                    
                }
                catch
                {
                    MessageBox.Show("Điểm phải là số thực trong khoảng [1-10]", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtDiem.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btn_Them(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                try
                {
                    Sinhvien s = new Sinhvien();
                    s.Masv = int.Parse(txtMa.Text);
                    s.Hoten = txtHoTen.Text;
                    s.Diachi = cboDiaChi.Text;
                    s.Diem = byte.Parse(txtDiem.Text);
                    s.Malop = int.Parse(cboLop.SelectedValue.ToString());

                    db.Sinhviens.Add(s);
                    db.SaveChanges();

                    HienThiDataGrid();
                    XoaDuLieu();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi khi thêm", x.Message);
                    db.ChangeTracker.Clear();
                }
            }

        }

        private void SelectCell_Click(object sender, SelectedCellsChangedEventArgs e)
        {
            object obj = dgSV.SelectedItem;
            if (obj != null)
            {
                try
                {
                    Type t = dgSV.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMa.Text = p[0].GetValue(dgSV.SelectedItem).ToString();
                    txtHoTen.Text = p[1].GetValue(dgSV.SelectedItem).ToString();

                    string dc = p[2].GetValue(dgSV.SelectedItem).ToString().ToLower();
                    if (dc.Equals("hà nội"))
                    {
                        cboDiaChi.SelectedIndex = 0;
                    }
                    else if (dc.Equals("hải phòng"))
                    {

                        cboDiaChi.SelectedIndex = 1;
                    }
                    else
                    {
                        cboDiaChi.SelectedIndex = 2;
                    }

                    txtDiem.Text = p[3].GetValue(dgSV.SelectedItem).ToString();

                    cboLop.SelectedValue = p[4].GetValue(dgSV.SelectedItem).ToString();


                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi xảy ra", x.Message);
                }
            }
        }

        private void btn_Sua(object sender, RoutedEventArgs e)
        {
            try
            {
                var svSua = db.Sinhviens.SingleOrDefault(sv => sv.Masv == int.Parse(txtMa.Text));
                if(svSua != null)
                {
                    if (check())
                    {
                        svSua.Hoten = txtHoTen.Text;
                        svSua.Diachi = cboDiaChi.Text;
                        svSua.Diem = byte.Parse(txtDiem.Text);
                        svSua.Malop = int.Parse(cboLop.SelectedValue.ToString());

                        db.SaveChanges();
                        HienThiDataGrid();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Có lỗi khi sửa", x.Message);
                db.ChangeTracker.Clear();

            }
        }

        private void btn_Xoa(object sender, RoutedEventArgs e)
        {
            try
            {
                var svXoa = db.Sinhviens.SingleOrDefault( sv => sv.Masv == int.Parse(txtMa.Text));
                db.Sinhviens.Remove(svXoa);
                db.SaveChanges();
                HienThiDataGrid();
                XoaDuLieu();
            }
            catch(Exception x)
            {
                MessageBox.Show("Có lỗi khi xóa", x.Message);
                db.ChangeTracker.Clear();

            }
        }
        private void XoaDuLieu()
        {
            txtMa.Clear();
            txtHoTen.Clear();
            txtDiem.Clear();
            cboDiaChi.SelectedIndex = 0; 
            cboLop.SelectedIndex = 0;
            txtMa.Focus(); // đặt con trỏ tại đây để nhạp lại cho nhanh
        }
        private void XoaDong(object sender, RoutedEventArgs e)
        {
            object obj = dgSV.SelectedItem;
            if(obj != null)
            {
                try
                {
                    Type t = obj.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    int masv = int.Parse(p[0].GetValue(dgSV.SelectedItem).ToString());

                    MessageBoxResult mbr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if(mbr == MessageBoxResult.Yes)
                    {
                        var svXoa = db.Sinhviens.SingleOrDefault(sv => sv.Masv == masv);
                        db.Sinhviens.Remove(svXoa);
                        db.SaveChanges();
                        HienThiDataGrid();
                        XoaDuLieu();
                    }
                    
                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi khi xóa", x.Message);
                    db.ChangeTracker.Clear();
                }
            }
        }

        //Khi click vao Tim thì mở cửa sổ mới trog đó có danh sách các sv có malop=3 và diem>5
        private void btn_Tim(object sender, RoutedEventArgs e)
        {
            TimKiem win2 = new TimKiem();
            win2.Show();

        }

        private void btn_Thoat(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
