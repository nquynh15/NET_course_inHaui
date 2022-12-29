using System;

internal class Baitap3b
{
    private static void Main(string[] args)
    {
        float a, b, c;
        Console.WriteLine("Nhap he so a = ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap he so b = ");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap he so c = ");
        c = float.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Khong phai pt bac hai!");
            Console.WriteLine("PT co nghiem la: \" + -b / c");
        }
        else
        {
            float delta = b*b - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("PT vo nghiem!");
            else if (delta == 0)
                Console.WriteLine("PT co nghiem duy nhat: " + -b / (2 * a));
            else
            {
                Console.WriteLine("PT co 2 nghiem phan biet: ");
                Console.WriteLine("x1 = " + (-Math.Sqrt(delta) + b) / (2 * a));
                Console.WriteLine("x2 = " + (-Math.Sqrt(delta) - b) / (2 * a));
            }
        }
    }
}