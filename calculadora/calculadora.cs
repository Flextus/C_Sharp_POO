using System;

public class Calculadora
{
    public int menu1;

    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la Calculadora ");
        Console.WriteLine("Por favor, selecciona la operacion a realizar de la siguiente lista utilizando los numeros presentados");
        Console.WriteLine("1 \t Suma");
        Console.WriteLine("2 \t Resta");
        Console.WriteLine("3 \t Multiplicacion");
        Console.WriteLine("4 \t Division");
        Console.WriteLine("5 \t Potencia");
        Console.WriteLine("6 \t Raiz Cuadrada");

        Resta resta = new Resta();
        Suma suma = new Suma();
        Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();
        Potencia potencia = new Potencia();
        Raiz raiz = new Raiz();

        int menu1 = Convert.ToInt32(Console.ReadLine());

        if (menu1 == 1)
        {
            Console.WriteLine("Has seleccionado Suma");
            suma.Sumar();
        }
        if (menu1 == 2)
        {
            Console.WriteLine("Has seleccionado Resta");
            resta.Restar();
        }
        if (menu1 == 3)
        {
            Console.WriteLine("Has seleccionado Multiplicacion");
            multiplicacion.multiplicar();
        }
        if (menu1 == 4)
        {
            Console.WriteLine("Has seleccionado Division");
            division.Dividir();
        }
        if (menu1 == 5)
        {
            Console.WriteLine("Has seleccionado Potencia");
        }
        if (menu1 == 6)
        {
            Console.WriteLine("Has seleccionado Raiz Cuadrada");
            raiz.Enraizar();
        }
        else if (menu1 >= 7 && menu1 <= 0)
        {
            Console.WriteLine("Seleccion no valida");
        }

    }
}
