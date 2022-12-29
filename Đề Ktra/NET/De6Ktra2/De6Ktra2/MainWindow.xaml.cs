using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace De6Ktra2
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
        List<ThiSinh> list = new List<ThiSinh>();

        public bool check()
        {
            if(txtSBD.Text == "")
            {
                MessageBox.Show("Chưa nhập Số báo danh!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSBD.Focus();
                return false;
            }
            else
            {
                int c=0;
                foreach(ThiSinh t in list)
                {
                    if (t.SBD.ToLower().Equals(txtSBD.Text.ToLower())){
                        c = 1;
                    }
                }
                if(c == 1)
                {
                    MessageBox.Show("Số báo danh đã tồn tại!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSBD.Focus();
                    return false;
                }
            }
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Chưa nhập Điểm thi!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDiem.Focus();
                return false;
            }
            else
            {
                try
                {
                    float d = float.Parse(txtDiem.Text);

                    if (d < 0 || d > 30)
                    {
                        MessageBox.Show("Điểm thi phải trong khoảng [0-30]", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtDiem.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Điểm thi phải là số!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtDiem.Focus();
                    return false;
                }
            }
            

            return true;
        }
        private void btn_Nhap(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                string ns = ((DateTime)dpNS.SelectedDate).ToString("dd-MM-yyyy");
                int UT;
                if (rd0.IsChecked == true)
                {
                    UT = 0;
                }
                else if(rd1.IsChecked == true)
                {
                    UT = 2;
                }
                else
                {
                    UT = 1;
                }

                ThiSinh t = new ThiSinh(txtSBD.Text, float.Parse(txtDiem.Text), ns, UT);

                list.Add(t);

                dgTS.ItemsSource = null;
                dgTS.ItemsSource = list;

            }

        }

        private void btn_Win(object sender, RoutedEventArgs e)
        {
            float tong = list[0].Diem + list[0].UT;
            foreach(ThiSinh t in list)
            {
                if(tong < t.Diem + t.UT)
                {
                    tong = t.Diem + t.UT;
                }
            }

            List<ThiSinh> ds = new List<ThiSinh>();

            for(int i=0; i<list.Count; i++)
            {
                if (tong == list[i].Diem + list[i].UT)
                {
                    ds.Add(list[i]);
                }
            }

            Window2 win = new Window2();
            win.dgTS.ItemsSource = null;
            win.dgTS.ItemsSource = ds;
            win.Show();
        }
    }
}
