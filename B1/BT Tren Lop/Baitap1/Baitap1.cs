using System;

internal class Baitap1
{
    private static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhap vao so nguyen n = ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
            Console.WriteLine(n + " la so chan");
        else 
            Console.WriteLine(n + " la so le");
    }
}