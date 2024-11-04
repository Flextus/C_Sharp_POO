using System;

public class Registro
{
    private Userbasic[] users;
    private const int PIN_LENGTH = 4;
    private const int USER_BASE = 5;
    public int userCount = 0;

    public Registro()
    {
        users = new Userbasic[USER_BASE];
        String[] username = new String[USER_BASE];
        int[] pin = new int[PIN_LENGTH];
    }
    
    public void abrirCuenta(int pin, string username)
    {
        if (userCount <= USER_BASE) 
        {
            for (userCount; userCount < USER_BASE; userCount++)
            {
                Console.WriteLine("Ingresa un nombre de Usuario a eleccion");
                username[i] = Console.ReadLine();
            }
        }
    }

}