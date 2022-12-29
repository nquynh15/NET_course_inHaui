using System;

internal class Baitap4
{
    private static void Main(string[] args)
    {
        float bacLuong, phuCap;
        int ngayCong;
        Console.WriteLine("Nhap bac luong: ");
        bacLuong = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap ngay cong: ");
        ngayCong = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap phu cap: ");
        phuCap = float.Parse(Console.ReadLine());

        if(ngayCong >= 25)
        {
            ngayCong = 25 + (ngayCong - 25) * 2;
        }
        double tien = bacLuong * 1490000 * ngayCong + phuCap;
        Console.WriteLine("Tien linh: " + tien);
    }
}