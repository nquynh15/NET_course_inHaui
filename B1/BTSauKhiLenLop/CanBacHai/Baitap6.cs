using System;
namespace CanBacHai
{
    internal class Baitap6
    {
        static void Main(string[] args)
        {
            int a;
            double n;
            do
            {
                Console.Write("Input number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input epsilon: ");
                n = Convert.ToDouble(Console.ReadLine());
            } while (a < 0);
            double result = 1.0F;
            if (a == 0)
                result = 1;
            else
            {

                while (Math.Abs(result * result - a) >= n)
                {
                    result = ((double)a / result + result) / 2;

                }

            }
            Console.WriteLine("Sqrt(a) = " + result);

            Console.ReadLine();
        }
    }
}