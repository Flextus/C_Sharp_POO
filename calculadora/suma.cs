using System;

public class Suma
{
    public float sumando1, sumando2, sumaRes;

    public void Sumar()
    {
        Console.WriteLine("Ingresa el primer numero a sumar");
        sumando1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero a sumar");
        sumando2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        sumaRes = sumando1 + sumando2;
        Console.Write("La suma  de  {0} y \n{1} es igual a\n {2} \n" , sumando1, sumando2 ,sumaRes);
        
    }
}
