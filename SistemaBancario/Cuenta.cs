//establecer un saldo en una cuenta bancaria
using System;

public class Cuenta
{
    private decimal saldo; //variable de instancia que almacenara el saldo de la cuenta
                           // una instancia es una variable vacia que espera el dato
                           // de el constructor interno

    //contructor interno que rellena la instancia
    public Cuenta(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    //acreditar un monto en la cuenta

    public void Acredita(decimal monto)
    {
        Saldo = Saldo + monto; //suma monto al saldo
    }

    public decimal Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value >= 0)
            {
                saldo = value;
            }
        }
    }
}
