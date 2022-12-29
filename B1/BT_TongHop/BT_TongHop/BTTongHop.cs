using System;

internal class BaitapTongHop
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao 1 phan so: ");
        Console.WriteLine("Tu so: ");
        int tu = int.Parse(Console.ReadLine());
        Console.WriteLine("Mau so: ");
        int mau = int.Parse(Console.ReadLine());
        int u = gcd(Math.Abs(tu), Math.Abs(mau));
        Console.WriteLine("Result: "+ tu/u+"/"+mau/u);
    }

    public static int gcd(int n, int m)
    {
        if (m == 0)
            return n;
        return gcd(m, n % m);
    }

}
