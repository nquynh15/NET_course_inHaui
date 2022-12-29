using System.Reflection;

namespace XepLoaiHS
{
    internal class Baitap4
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Input Student's name: ");
            name = Console.ReadLine().ToUpper();
            double mark;
            do
            {
                Console.Write("Input mark: ");
                mark = double.Parse(Console.ReadLine());
            } while (mark <= 0 || mark > 10);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Mark: " + mark);
            if (mark >= 8)
                Console.WriteLine("Xep loai: Gioi");
            else if (mark >= 6.5)
                Console.WriteLine("Xep loai: Kha");
            else if (mark >= 5)
                Console.WriteLine("Xep loai: Trung binh");
            else
                Console.WriteLine("Xep loai: Yeu");
            Console.ReadLine();
        }
    }
}