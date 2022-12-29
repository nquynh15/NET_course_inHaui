using System;
using System.Transactions;

namespace TongChuoi
{
    internal class Baitap5

    {
        static void Main(string[] args)
        {
            int length;
            do
            {
                Console.Write("Input length: ");
                length = Convert.ToInt32(Console.ReadLine());
            } while (length <= 0);
            double sumA = 0, sumB = 0;
            for (int i = 1; i <= length; i++)
            {
                sumA += i;
            }
            Console.WriteLine("Sum A = " + sumA);
            for (int i = 1; i <= length; i++)
            {
                sumB += (double)1 / i;
            }
            Console.WriteLine("Sum B = {0:F3}", sumB);

            Console.ReadLine();
        }
    }
}