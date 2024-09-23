using System;
using System.Security.Cryptography.X509Certificates;

public class Suma
{
    public static void Main(string[] args)
    {
        int a;
        int b;
        int suma;
        Console.WriteLine("Escribe el primer numero\n");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());

        suma = a + b;
        Console.WriteLine("La suma es: {0}", suma);
    }
}
