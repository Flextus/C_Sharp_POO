using System;
using System.Numerics;

public class Raiz
{
    public double bassen, raizcuad;

    public double Enraizar()
    {
        Console.WriteLine("Ingresa el numero a calcularle la raiz cuadrada");
        bassen = float.Parse(Console.ReadLine());
        raizcuad = Math.Sqrt(bassen);
        Console.Write("La raiz cuadrada de \n{0}" + bassen + " es igual a " + raizcuad + "\n {2}");

        return raizcuad;
    }
}
