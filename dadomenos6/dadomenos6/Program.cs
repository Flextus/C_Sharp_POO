using System;

public class Program
{
    public static void Main(string[] args)
    {
        int aux1, aux2;
        int suma1, suma2;
        int res;

        Random dado = new Random();

        aux1 = dado.Next(1, 7);
        suma1 = aux1;
        aux2 = dado.Next(1, 7);
        suma2 = aux2;
        res = suma1 + suma2;

        if (res < 6)
        {
            Console.WriteLine("Sacaste {0}, haz perdido!", res);
        }
        else
        {
            Console.WriteLine("Sacaste {0}, haz Ganado!", res);
        }
    }
}