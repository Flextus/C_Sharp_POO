using System;
using System.Runtime.Intrinsics.X86;

public class Registro
{
    String User1;
    int[] pin;
    const int PIN_LENGTH = 4;

    public void abrirCuenta()
    {
        pin = new int[PIN_LENGTH];

        Console.WriteLine("Crea un nombre del Usuario");
        User1 = Console.ReadLine();

        Console.WriteLine("Crea el Pin de 4 diigtos para tu Cuenta");
        for (int i = 0; i == PIN_LENGTH; i++) 
        {
            pin[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El Pin de {0} es:", User1);
        Console.WriteLine("{0, 6} {1} {2} {3}", pin[0], pin[1], pin[2], pin[3]);

    }
}