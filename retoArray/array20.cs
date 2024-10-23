using System;

public class Array20
{
    const int LONG_ARREGLO = 21;
    int[] arreglo1 = new int[LONG_ARREGLO];

    public void Llenado()
    {
        for (int i = 0; i < arreglo1.Length; i++)
        {
            Console.WriteLine("Por favor anote el dato #{0}", i);
            arreglo1[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void tabla()
    {
        Console.WriteLine("\n");
        Console.WriteLine("{0}{1, 8}", "Indice", "Valor");
        Console.WriteLine("\n");

        for (int i = 0; i < arreglo1.Length; i++)
        {
            Console.WriteLine("{0, 3} {1, 10}", i, arreglo1[i]);
        }
    }
}
