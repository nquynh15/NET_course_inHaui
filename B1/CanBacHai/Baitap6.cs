using System;

internal class Baitap6
{
    public static void Main(string[] args)
    {
        double n, e;
        do
        {
            Console.WriteLine("Nhap vao mot so duong: ");
            n = Convert.ToDouble(Console.ReadLine());
        }while (n < 0);

        Console.WriteLine("Nhap vao so epsilon e =  ");
        e = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Result: " + SquareRoot(n, e));
    }

    public static double SquareRoot(double a, double b)
    {
        double result = 1.0f;
        if (a == 0)
            return 1;
        else
        {
            while (Math.Abs(result * result - a) / a >= b)
                result = (a / result - result) / 2 + result;
            return result;
        }
    }
}
