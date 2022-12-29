using System;

internal class Baitap3a
{
    private static void Main(string[] args)
    {
        float a, b;
        Console.WriteLine("Nhap he so a = ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap he so b = ");
        b = float.Parse(Console.ReadLine());

        if (a == 0)
            Console.WriteLine("Khong phai pt bac nhat!");
        else
            Console.WriteLine("PT co nghiem la: "+ -b/a);
    }
}