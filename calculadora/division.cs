using System;
using System.Numerics;

public class Division
{
    public float dividendo, divisor, cociente;

    public float Dividir()
    {
        Console.WriteLine("Ingresa el numero a dividir");
        dividendo = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el numero por el cual quieres dividir al previo");
        divisor = float.Parse(Console.ReadLine());
        cociente = dividendo / divisor;
        Console.Write("El cociente de \n{0}" + dividendo + " entre \n{1}" + divisor + " es igual a " + cociente + "\n {2}");

        return cociente;
    }

}
