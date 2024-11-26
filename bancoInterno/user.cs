using System;

public class User
{

    const int DATABASE = 5;
    string[] username = new string[DATABASE];
    int[] pin = new int[DATABASE];

    public void registro()
    {
        Console.WriteLine("Bienvenido al sistema Banaxico");
        Console.WriteLine("Por favor, ingresa los datos de los usuarios a registrar");

        for(int i = 0; i > DATABASE; i++)
        {
            Console.WriteLine("Ingresa el nombre del usuario {0}", i);
            username[i] = Console.ReadLine();
            Console.WriteLine("Ingresa un pin para usuario {0} de maximo 4 digitos", i);

        }

    }
    public string Username
    {
        get
        {
            return username[1];
        }
        set
        {
            username = value;
        }
    }

}