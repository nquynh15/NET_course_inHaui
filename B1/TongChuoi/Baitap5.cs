using System;

internal class Baitap5
{
    public static void Main(string[] args)
    {
        int n, s=0;
        double p=0;
        do
        {
            Console.WriteLine("Nhap vao mot so nguyen duong: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n <= 0);
        for(int i= 1; i <= n; i++)
        {
            s += i;
        }

        for (double i = 1; i <= n; i++)
        {

            p += (1 / i);
        }

        Console.WriteLine("Sa =  "+ s);
        Console.WriteLine("Sb: " + p);
    }


}
