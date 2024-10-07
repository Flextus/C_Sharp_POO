using System;

public class Multiplicacion
{
    public float factor1, factor2, producto;

    public void multiplicar()
    {
        Console.WriteLine("Ingresa el primer numero a multiplicar");
        factor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero a multiplicar");
        factor2 = float.Parse(Console.ReadLine());
        producto = factor1 * factor2;
        Console.Write("El producto de \n{0}" + factor1 + " y \n{1}" + factor2 + " es igual a " + producto + "\n {2}");
    }
}
