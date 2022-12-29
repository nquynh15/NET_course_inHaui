using System;

internal class Baitap2
{
    private static void Main(string[] args)
    {
        double d, r;
        Console.WriteLine("Nhap vao chieu dai d = ");
        d = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap vao chieu rong r = ");
        r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Dien tich HCN : " + d * r);
        Console.WriteLine("Chu vi HCN : " + 2*(d+r));
    }
}