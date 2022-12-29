using System;

internal class Baitap8
{
    public static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine("Nhap vao 1 so nguyen duong: ");
            n = int.Parse(Console.ReadLine());
        }while(n<= 0);

        for(int i=1; i<=n; i++)
        {
            if(i%5 == 0)
            {
                continue;
            }
            Console.WriteLine(i + " ");
        }
    }
}