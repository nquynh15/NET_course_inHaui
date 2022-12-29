using System;

internal class Baitap3
{
    public static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            double a, b, c, sum;
            Console.WriteLine("Input 3 sides of triangle");
            do
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
            } while (a <= 0 || b <= 0 || c <= 0);

            if (a < b + c && b < a + c && c < a + b)
            {
                sum = a + b + c;
                Console.Write("Perimeter: " + sum);
                double S, P = sum / 2;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.Write("Area: " + S);
            }
            else
            {
                Console.WriteLine("It's not a triangle!");
            }
        }
    }
}

