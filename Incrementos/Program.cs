using System;

public class Incrementos
{
    public static void Main(string[] args)
    {
        int c = 5;
        Console.WriteLine(c);
        Console.WriteLine(++c);
        Console.WriteLine(c);
        Console.WriteLine(c++);
        Console.WriteLine(c);
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", c++, --c, ++c, c--, c++ );
        Console.WriteLine(c);

    }
}