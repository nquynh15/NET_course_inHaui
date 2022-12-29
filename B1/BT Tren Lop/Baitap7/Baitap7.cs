using System;

internal class Baitap7
{
    private static void Main(string[] args)
    {
        int d;

        Console.Write("Nhap vao 1 so nguyen : ");
        d = int.Parse(Console.ReadLine());

        if (d < 0 || !isPrimeNumber(d))
            Console.WriteLine(d + " khong phai so nguyen to");
        else
            Console.WriteLine(d+ " la so nguye to!");


    }

    public static Boolean isPrimeNumber(int n)
    {
        for(int i=2; i<= Math.Sqrt(n); i++)
        {
            if(n%i == 0)
                return false;
        }
        return n >= 2;
    }
}

