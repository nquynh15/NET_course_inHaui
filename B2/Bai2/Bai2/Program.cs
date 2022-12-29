using System;

internal class Mang
{
    public static void Main(string[] args)
    {
        int n;
        int[] a;
        
        Console.Write("Emter the length of Array: ");
        n = int.Parse(Console.ReadLine());
        a= new int[n];
        for(int i=0; i<n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        int max = a[0];
        foreach(int x in a)
        {
            if (max < x) 
                max = x; 
        }
        int min = a[0];
        foreach(int x in a)
        {
            if(min > x) 
                min= x; 
        }
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Min = " + min);
    }
}
