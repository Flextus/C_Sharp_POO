using System;
using System.Numerics;

public class Potencia
{
    public float basic, cuadrado;

    public float Elevar()
    {
        Console.WriteLine("Ingresa el numero a elevar al cuadrado");
        basic = float.Parse(Console.ReadLine());
        cuadrado = basic * basic;
        Console.Write("El cuadrado de \n{0}" + basic + " es igual a " + cuadrado + "\n {2}");

        return cuadrado;
    }
}
