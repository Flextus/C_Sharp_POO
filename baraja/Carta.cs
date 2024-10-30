using System;

public class Carta
{
    private string cara; // AS, DOS, REY, ETC
    private string palo; // HEARTS, DIAMOND, ETC


    // Inicializamos el constructor Interno
    public Carta(string caraCarta, string paloCarta)
    {
        cara = caraCarta;
        palo = paloCarta;
    }//Fin del constructor Carta c/ 2 parametros


    //Modifica el string, no seria posible sin el override
    public override string ToString()
    {
        return cara + "de" + palo;
        //Fin del metodo string
    }
}//Fin de la clase Carta