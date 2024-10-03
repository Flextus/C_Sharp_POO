using System;

public class Suma
{
    public float sumando1, sumando2, sumaRes;

    public float Sumar()
    {
        Console.WriteLine("Ingresa el primer numero a sumar");
        sumando1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero a sumar");
        sumando2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        sumaRes = sumando1 + sumando2;
        Console.Write("La suma  de \n{0}" + sumando1 + " y \n{1}" + sumando2 + " es igual a " + sumaRes + "\n {2}");
    
        return sumaRes;
    }
}
