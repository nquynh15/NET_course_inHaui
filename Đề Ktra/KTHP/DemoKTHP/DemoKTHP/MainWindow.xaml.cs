using DemoKTHP.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace DemoKTHP
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
        QLBanHangContext db = new QLBanHangContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiComboBox();
            HienThiDataGrid();
        }

        public void HienThiComboBox()
        {
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            cboLoai.ItemsSource = query.ToList();

            cboLoai.DisplayMemberPath = "TenLoai";
            cboLoai.SelectedValuePath = "MaLoai";
            cboLoai.SelectedIndex = 0;

        }

        public void HienThiDataGrid()
        {
            var query = from sp in db.SanPhams
                        join lsp in db.LoaiSanPhams
                        on sp.MaLoai equals lsp.MaLoai
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.DonGia,
                            sp.SoLuongCo,
                            ThanhTien = sp.DonGia * sp.SoLuongCo
                        };
            dgSanPham.ItemsSource = query.ToList();
        }
        public bool check()
        {
            if(txtmasp.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtmasp.Focus();
                return false;
            }

            if (txttensp.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sản phẩm!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txttensp.Focus();
                return false;
            }

            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng có!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtsoluong.Focus();
                return false;
            }
            else
            {
                try
                {
                    int slco = int.Parse(txtsoluong.Text);
                    if(slco < 0)
                    {
                        MessageBox.Show("Số lượng có phải lớn hơn 0 !", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtsoluong.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Số lượng phải là số nguyên!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtsoluong.Focus();
                    return false;
                }
            }
            

            if (txtdongia.Text == "")
            {
                MessageBox.Show("Chưa nhập đơn giá!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtdongia.Focus();
                return false;
            }
            else
            {
                try
                {
                    double dg = double.Parse(txtdongia.Text);
                    if (dg < 0)
                    {
                        MessageBox.Show("Đơn giá có phải lớn hơn 0 !", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtsoluong.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Đơn giá phải là số thực!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtsoluong.Focus();
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
                    SanPham spMoi = new SanPham();
                    spMoi.MaSp = txtmasp.Text;
                    spMoi.TenSp = txttensp.Text;
                    spMoi.DonGia = double.Parse(txtdongia.Text);
                    spMoi.SoLuongCo = int.Parse(txtsoluong.Text);

                    LoaiSanPham lsp = (LoaiSanPham)cboLoai.SelectedItem;

                    spMoi.MaLoai = lsp.MaLoai;

                    db.SanPhams.Add(spMoi);
                    db.SaveChanges();

                    HienThiDataGrid();
                    XoaDL();
                }
                catch(Exception x)
                {
                    MessageBox.Show("Có lỗi", x.Message);
                }
            }            

        }
        private void btn_Sua(object sender, RoutedEventArgs e)
        {
            try
            {
                var spSua = db.SanPhams.SingleOrDefault(sp => sp.MaSp == txtmasp.Text);
                if(spSua != null)
                {
                    if (check())
                    {
                        spSua.MaSp = txtmasp.Text;
                        spSua.TenSp = txttensp.Text;
                        spSua.DonGia = double.Parse(txtdongia.Text);
                        spSua.SoLuongCo = int.Parse(txtsoluong.Text);

                        LoaiSanPham lsp = (LoaiSanPham)cboLoai.SelectedItem;

                        spSua.MaLoai = lsp.MaLoai;

                        db.SaveChanges();

                        HienThiDataGrid();
                        XoaDL();
                    }

                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Có lỗi", x.Message);
            }

        }

        private void btn_Xoa(object sender, RoutedEventArgs e)
        {
            try
            {
                var spXoa = db.SanPhams.SingleOrDefault(sp => sp.MaSp == txtmasp.Text);
                if (spXoa != null)
                {
                    db.SanPhams.Remove(spXoa);
                    MessageBoxResult mbr = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này", "Thông báo", 
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if(mbr == MessageBoxResult.Yes)
                    {
                        db.SanPhams.Remove(spXoa);

                        db.SaveChanges();
                        HienThiDataGrid();
                        XoaDL();
                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Có lỗi", x.Message);
            }
        }
        public void XoaDL()
        {
            txtmasp.Clear();
            txttensp.Clear();
            cboLoai.SelectedIndex = 0;
            txtdongia.Clear();
            txtsoluong.Clear();

        }

        private void btn_Tim(object sender, RoutedEventArgs e)
        {
            Window2 tk = new Window2();

            tk.Show();
        }


        private void Select_Change(object sender, SelectedCellsChangedEventArgs e)
        {
            object obj = dgSanPham.SelectedItem;
            if(obj != null)
            {
                try
                {
                    Type t = obj.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtmasp.Text = p[0].GetValue(obj).ToString();
                    txttensp.Text = p[1].GetValue(obj).ToString();

                    string loai = p[2].GetValue(obj).ToString().ToLower();
                    if (loai.Equals("máy tính"))
                    {
                        cboLoai.SelectedIndex = 0;
                    }
                    else if (loai.Equals("điện thoại"))
                    {
                        cboLoai.SelectedIndex = 1;
                    }
                    else
                    {
                        cboLoai.SelectedIndex = 2;
                    }
                    txtdongia.Text = p[3].GetValue(obj).ToString();
                    txtsoluong.Text = p[4].GetValue(obj).ToString();

                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi", x.Message);
                }
            }
            
        } 
            
    }
}
