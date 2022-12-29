﻿using System;
using System.Collections.Generic;

namespace Demo_OOP_Tong_Hop
{
    class Program
    {
        static List<KhachHang> dsKhachHang = new List<KhachHang>();
        static void Main(string[] args)
        {
            //thêm sẵn một số phần tử để test sắp xếp
            dsKhachHang.Add(new KhachHang("An", true, 30, 1));
            dsKhachHang.Add(new KhachHang("Xuan", false, 25, 2));
            dsKhachHang.Add(new KhachHangThanThiet("Ha", true, 30, 3, 111));
            dsKhachHang.Add(new KhachHang("Thu", true, 10, 4));
            dsKhachHang.Add(new KhachHangThanThiet("Dong", false, 30, 5, 333));
            dsKhachHang.Add(new KhachHang("Tuan", true, 5, 6));
            string luaChon = "";
            do
            {
                Console.WriteLine("\nMAIN MENU: ");
                Console.WriteLine("\n1. Nhap thong tin");
                Console.WriteLine("\n2. Hien thi danh sach khach hang");
                Console.WriteLine("\n3. Sua thong tin khach hang");
                Console.WriteLine("\n4. Xoa khach hang");
                Console.WriteLine("\n5. Tim khach hang");
                Console.WriteLine("\n6. Sap xep");
                Console.WriteLine("\n7. Thoat");
                Console.Write("\nNhap vao lua chon cua ban: ");
                luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1":
                        ThemKhachHangMoi();
                        break;
                    case "2":
                        HienThiDanhSach();
                        break;
                    case "3":
                        Console.Write("\nNhap ten khac hang muon sua:");
                        string tenSua = Console.ReadLine();
                        for (int i = 0; i < dsKhachHang.Count; i++)
                        {
                            if (tenSua.ToLower() == dsKhachHang[i].HoTen.ToLower())
                            {//nếu tìm thấy
                                //lấy ra loại khách hàng
                                string loaiKH = dsKhachHang[i].GetType().Name;
                                if (loaiKH == "KhachHang")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nviet code de sua khach hang thuong");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nviet code de sua khach hang THAN THIET");
                                    Console.ResetColor();
                                }

                                break;
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Xoa");
                        break;
                    case "5":
                        Console.WriteLine("Tim");
                        break;
                    case "6":
                        Console.WriteLine("\nDanh sach sau sap xep");
                        dsKhachHang.Sort();
                        HienThiDanhSach();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Nhap sai, moi nhap lai");
                        break;
                }
                //Console.ReadLine();
                //Console.Clear();
            } while (luaChon != "7");

            Console.ReadLine();
        }

        private static void HienThiDanhSach()
        {
            Console.WriteLine("\nDanh sach da nhap: ");
            foreach (var item in dsKhachHang)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void ThemKhachHangMoi()
        {
            Console.WriteLine("\nMenu con: ");
            Console.WriteLine("\n1. Khach hang");
            Console.WriteLine("\n2. Khach hang than thiet");
            Console.WriteLine("\nChon loai khach hang: ");
            string loaiKH = Console.ReadLine();
            switch (loaiKH)
            {
                case "1":
                    Console.WriteLine("Nhap ho ten khach hang: ");
                    string hoTen = Console.ReadLine();
                    Console.WriteLine("Nhap gioi tinh: ");
                    bool gioiTinh = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap don gia: ");
                    int donGia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so luong mua: ");
                    int soLuong = int.Parse(Console.ReadLine());
                    KhachHang kh1 = new KhachHang(hoTen, gioiTinh, soLuong, donGia);
                    //kiểm tra một phần tử đã có trong danh sách ?
                    if (dsKhachHang.Contains(kh1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKhach hang da co trong danh sach");
                        Console.ResetColor();
                    }
                    else
                    {
                        dsKhachHang.Add(kh1);
                    }

                    break;
                case "2":
                    Console.WriteLine("Nhap ho ten khach hang: ");
                    string hoTentt = Console.ReadLine();
                    Console.WriteLine("Nhap gioi tinh: ");
                    bool gioiTinhtt = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap don gia: ");
                    int donGiatt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so luong mua: ");
                    int soLuongtt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap ma the thanh vien: ");
                    int mathett = int.Parse(Console.ReadLine());
                    KhachHangThanThiet khtt1 = new KhachHangThanThiet(hoTentt, gioiTinhtt,
                        soLuongtt, donGiatt, mathett);

                    if (!dsKhachHang.Contains(khtt1))
                    {
                        dsKhachHang.Add(khtt1);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nKhach hang da co trong danh sach");
                        Console.ResetColor();
                    }

                    break;
                default:
                    break;
            }


        }
    }
}
