using System;

public class Calculadora
{
    public int menu1;

    public static void Main(string[] args)
    {
        Calculadora calc = new Calculadora(); // Crear una instancia de la clase Calculadora

        Console.WriteLine("Bienvenido a la Calculadora ");
        Console.WriteLine("Por favor, selecciona la operacion a realizar de la siguiente lista utilizando los numeros presentados");
        Console.WriteLine("1 \t Suma");
        Console.WriteLine("2 \t Resta");
        Console.WriteLine("3 \t Multiplicacion");
        Console.WriteLine("4 \t Division");
        Console.WriteLine("5 \t Potencia");
        Console.WriteLine("6 \t Raiz Cuadrada");

        string input = Console.ReadLine();
        if (int.TryParse(input, out calc.menu1))
        {
            switch (calc.menu1)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Suma");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado Resta");
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado Multiplicacion");
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado Division");
                    break;
                case 5:
                    Console.WriteLine("Has seleccionado Potencia");
                    break;
                case 6:
                    Console.WriteLine("Has seleccionado Raiz Cuadrada");
                    break;
                default:
                    Console.WriteLine("Seleccion no valida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
        }
    }
}
