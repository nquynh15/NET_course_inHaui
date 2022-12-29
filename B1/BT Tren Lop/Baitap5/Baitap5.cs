using System;

internal class Biatap5
{
    private static void Main(string[] args)
    {;

        Console.Write("Nhap vao 1 so nguyen trong khong 1-7: ");
        int d = int.Parse(Console.ReadLine());

        switch (d)
        {
            case 1: Console.WriteLine("Chu nhat"); break;
            case 2: Console.WriteLine("Thu Hai"); break;
            case 3: Console.WriteLine("Thu Ba"); break;
            case 4: Console.WriteLine("Thu Tu"); break;
            case 5: Console.WriteLine("Thu Nam"); break;
            case 6: Console.WriteLine("Thu Sau"); break;
            case 7: Console.WriteLine("Thu Bay"); break;
                default: Console.WriteLine("So nhap vao khong hop le!"); break;
        }
    }
}

