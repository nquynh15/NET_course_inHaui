using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BTTH
{
    internal class Program
    {
        static List<KhachHang> dsKH = new List<KhachHang>();
        static void Main(string[] args)
        {

            string luachon = "";
            do
            {
                Console.WriteLine("====MAIN MENU====");
                Console.WriteLine("1.Nhap thong tin");
                Console.WriteLine("2.Hien thi danh sach khach hang");
                Console.WriteLine("3.Sua thong tin khach hang");
                Console.WriteLine("4.Xoa khach hang");
                Console.WriteLine("5.Tim khach hang");
                Console.WriteLine("6.Sap xep");
                Console.WriteLine("7.Thoat!");
                Console.WriteLine("Moi ban nhap lua chon");
                luachon = Console.ReadLine();
                switch (luachon)
                {
                    case "1":
                        ThemKhachHang();
                        break;
                    case "2":
                        HienThiDS();
                        break;
                    case "3":
                        Sua();
                        break;
                    case "4":
                        Xoa();
                        break;
                    case "5":
                        TimKH();
                        break;
                    case "6":
                        Console.WriteLine("Danh sach sau khi sap xep: ");
                        dsKH.Sort();
                        HienThiDS();
                        break;
                    case "7": break;
                    default:
                        Console.WriteLine("Moi ban nhap lai!");
                        break;
                }

            } while (luachon != "7");

            Console.ReadLine();
        }

        private static void ThemKhachHang()
        {
            Console.WriteLine("===Menu con ===");
            Console.WriteLine("1. Khach Hang");
            Console.WriteLine("2. Khach hang than thiet");
            Console.WriteLine("Lua chon loai khach hang: ");
            string loaiKH = Console.ReadLine();
            switch (loaiKH)
            {
                case "1":
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Gender: ");
                    bool gender = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Quantity: "); ;
                    int quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Price: ");
                    int price = int.Parse(Console.ReadLine());

                    KhachHang kh = new KhachHang(name, gender, quantity, price);
                    if (!dsKH.Contains(kh))
                    {
                        dsKH.Add(kh);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Khach hang da co trong danh sach!");
                        Console.ResetColor();
                    }
                    break;
                case "2":
                    Console.WriteLine("Name: ");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Gender: ");
                    bool gender2 = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Quantity: "); ;
                    int quantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Price: ");
                    int price2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ma The Thanh Vien: ");
                    int matheTV = int.Parse(Console.ReadLine());

                    KhachHangThanThiet khtt = new KhachHangThanThiet(name2, gender2, quantity2, price2, matheTV);
                    if (!dsKH.Contains(khtt))
                    {
                        dsKH.Add(khtt);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Khach hang da co trong danh sach!");
                        Console.ResetColor();
                    }
                    break;
                default:
                    Console.WriteLine("Moi ban chon lai!");
                    break;
            }
            
        }

        private static void HienThiDS()
        {
            Console.WriteLine("\nDanh sach da nhap: ");
            foreach (var item in dsKH)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void Sua()
        {
            Console.Write("\nNhap ten khac hang muon sua:");
            string tenSua = Console.ReadLine();

            for (int i = 0; i < dsKH.Count; i++)
            {
                if (tenSua.ToLower() == dsKH[i].name.ToLower())
                {
                    string loaiKH = dsKH[i].GetType().Name;
                    if (loaiKH == "KhachHang")
                    {
                        Console.WriteLine("Gender: ");
                        dsKH[i].gender = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Quantity: ");
                        dsKH[i].quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Price: ");
                        dsKH[i].price = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Gender: ");
                        dsKH[i].gender = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Quantity: ");
                        dsKH[i].quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Price: ");
                        dsKH[i].price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ma The Thanh Vien: ");

                        (( KhachHangThanThiet ) dsKH[i]).matheTV = int.Parse(Console.ReadLine());
                    }

                    break;
                }
            }
        }
        
        private static void Xoa()
        {
            for (int i = 0; i < dsKH.Count; i++)
            {
                if (dsKH[i].name.EndsWith("a"))
                {
                    dsKH.Remove(dsKH[i]);
                }
            }
        }

        public static double MaxTien()
        {
            double max = dsKH[0].TongTien();
            for (int i = 1; i < dsKH.Count; i++)
            {
                if (max < dsKH[i].TongTien())
                {
                    max = dsKH[i].TongTien();
                }
            }
            return max;
        }
        private static void TimKH()
        {
            List<KhachHang> dsKH2 = new List<KhachHang>();
            for (int i = 0; i < dsKH.Count; i++)
            {
                if (dsKH[i].TongTien() == MaxTien())
                {
                    dsKH2.Add(dsKH[i]);
                }
            }
            Console.WriteLine("\nDanh sach khach hang co tong tien mua hang lon nhat: ");
            foreach (var item in dsKH2)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}