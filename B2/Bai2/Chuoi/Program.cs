internal class Chuoi
{
    public static void Main(string[] args)
    {
        string s;

        Console.Write("Emter you string: ");
        s = Console.ReadLine();

        Console.WriteLine(s);

        var arr = s.Split(" ");
        foreach(var i in arr)
        {
            Console.WriteLine(i);
        }
        Console.Write("Enter a characters:  ");
        char x = char.Parse(Console.ReadLine()); ;
        int c = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == x)
                c++;
        }
        Console.WriteLine(x+" appears "+c+" times in your string");
    }
}