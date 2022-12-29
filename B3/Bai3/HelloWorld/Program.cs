using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var b = 24L / 5 == 24 / 5d;

        var a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a = a == null ? "" : a);
    }
}
