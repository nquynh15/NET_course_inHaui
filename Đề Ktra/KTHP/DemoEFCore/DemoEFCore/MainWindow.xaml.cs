using DemoEFCore.Models;
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

namespace DemoEFCore
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();

            var query = from lsp in db.LoaiSanPhams
                        select lsp;

            dgSP.ItemsSource = query.ToList();

        }

        private void btn_Them(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Sua(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Xoa(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Thoat(object sender, RoutedEventArgs e)
        {

        }
    }
}
