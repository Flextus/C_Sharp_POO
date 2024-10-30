using System;
using System.Runtime.Intrinsics.X86;

public class Registro
{
    const int PIN_LENGTH = 4;
    int[] pin1, pin2, pin3, pin4, pin5;
    string User1, User2, User3, User4, User5;

    public void abrirCuenta1()
    {
        pin1 = new int[PIN_LENGTH];

        Console.WriteLine("Crea un nombre del Usuario 1");
        User1 = Console.ReadLine();

        Console.WriteLine("Crea el Pin de 4 digitos para tu Cuenta");
        for (int i = 0; i < PIN_LENGTH; i++)
        {
            pin1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El Pin de {0} es:", User1);
        Console.WriteLine("{0, 6} {1} {2} {3}", pin1[0], pin1[1], pin1[2], pin1[3]);
    }

    public void abrirCuenta2()
    {
        pin2 = new int[PIN_LENGTH];

        Console.WriteLine("Crea un nombre del Usuario 2");
        User2 = Console.ReadLine();

        Console.WriteLine("Crea el Pin de 4 digitos para tu Cuenta");
        for (int i = 0; i < PIN_LENGTH; i++)
        {
            pin2[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El Pin de {0} es:", User2);
        Console.WriteLine("{0, 6} {1} {2} {3}", pin2[0], pin2[1], pin2[2], pin2[3]);
    }

    public void abrirCuenta3()
    {
        pin3 = new int[PIN_LENGTH];

        Console.WriteLine("Crea un nombre del Usuario 3");
        User3 = Console.ReadLine();

        Console.WriteLine("Crea el Pin de 4 digitos para tu Cuenta");
        for (int i = 0; i < PIN_LENGTH; i++)
        {
            pin3[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El Pin de {0} es:", User3);
        Console.WriteLine("{0, 6} {1} {2} {3}", pin3[0], pin3[1], pin3[2], pin3[3]);
    }

    public void abrirCuenta4()
    {
        pin4 = new int[PIN_LENGTH];

        Console.WriteLine("Crea un nombre del Usuario 4");
        User4 = Console.ReadLine();

        Console.WriteLine("Crea el Pin de 4 digitos para tu Cuenta");
        for (int i = 0; i < PIN_LENGTH; i++)
        {
            pin4[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El Pin de {0} es:", User4);
        Console.WriteLine("{0, 6} {1} {2} {3}", pin4[0], pin4[1], pin4[2], pin4[3]);
    }

    public void abrirCuenta5()
    {
        pin5 = new int[PIN_LENGTH];

        Console.WriteLine("Crea un nombre del Usuario 5");
        User5 = Console.ReadLine();

        Console.WriteLine("Crea el Pin de 4 digitos para tu Cuenta");
        for (int i = 0; i < PIN_LENGTH; i++)
        {
            pin5[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("El Pin de {0} es:", User5);
        Console.WriteLine("{0, 6} {1} {2} {3}", pin5[0], pin5[1], pin5[2], pin5[3]);
    }
}
