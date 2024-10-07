using System;

public class Resta
{
    public float restando1, restando2, restaRes;

    public float Restar()
    {
        Console.WriteLine("Ingresa el primer numero a restar");
        restando1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero a restar");
        restando2 = float.Parse(Console.ReadLine());
        restaRes = restando1 - restando2;
        Console.Write("La resta  de \n{0}" + restando1 + " y \n{1}" + restando2 + " es igual a " + restaRes + "\n {2}");

        return restaRes;

    }


}
