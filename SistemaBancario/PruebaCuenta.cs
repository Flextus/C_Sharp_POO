using System;
using System.Timers;

public class PruebaCuenta
{
    public static void Main(string[] args)
    {
        Cuenta cuenta1 = new Cuenta(50.00M);//constructor 1er objeto
        Cuenta cuenta2 = new Cuenta(-7.53M);//constructor 2do objeto
        //la "M" es para decimales tal que "f" es para float

        Console.WriteLine("Saldo de la Primer Cuenta: {0:C}", cuenta1.Saldo);
        Console.WriteLine("Saldo de la Segunda Cuenta: {0:C}", cuenta2.Saldo);
        //al hacer el ":C" declaramos que el dato lo queremos en formato de dinero

        decimal montoDepositado;//deposita la cantidad indicada por el usuario

        //solicita la usuario el monto a depositar
        Console.WriteLine("Escriba el monto a depositar a la cuenta 1: ");
        montoDepositado = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Se agregaron {0 :C} al saldo de la Cuenta 1", montoDepositado);
        cuenta1.Acredita(montoDepositado);
        Console.WriteLine("Escriba el monto a depositar a la cuenta 2: ");
        montoDepositado = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Se agregaron {0 :C} al saldo de la Cuenta 2", montoDepositado);
        cuenta2.Acredita(montoDepositado);

        //muestra el saldo actualizado
        Console.WriteLine("El saldo de la Cuenta 1 es: {0:C}", cuenta1.Saldo);
        Console.WriteLine("El saldo de la Cuenta 2 es: {0:C}", cuenta2.Saldo);

    }

}
