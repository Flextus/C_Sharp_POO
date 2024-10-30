using System;

public class PaqueteDeCartas
{
    private Carta[] paquete;
    private int cartaActual;
    private const int NUM_DE_CARTAS = 52;
    private Random numAleatorios;

    public PaqueteDeCartas()
    {
        string[] cara = { "AS", "TWO", "THRE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "PRINCE", "QUEEN", "KING" };
        string[] palo = { "DIAMONDS", "HEARTS", "CLUBS", "SPADES" };
        paquete = new Carta[NUM_DE_CARTAS];
        cartaActual = 0;
    }

    public void baraja()
    {
        numAleatorios = new Random();
        cartaActual = numAleatorios.Next(NUM_DE_CARTAS);

    }

    public Carta repartirCarta()
    {
        for (int cuenta = 0; cuenta < NUM_DE_CARTAS; cuenta++)
        {
            
        }
    }

}
