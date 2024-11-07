using System;

public class Hola
{
    // Instancia de la clase Random para generar números aleatorios
    private Random Dice = new Random();

    // Enumeración que representa los posibles estados del juego
    private enum Estado { CONTNUA, GANA, PIERDE }

    // Enumeración que representa los valores específicos de los dados
    private enum Dados
    {
        DOS = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12
    }

    // Método principal para jugar
    public void Jugar()
    {
        // Inicializa el estado de la partida como CONTINUA
        Estado partida = Estado.CONTNUA;
        int miPunto = 0;

        // Llama al método TirarDados para obtener la suma de los dados
        int sumaDados = TirarDados();

        // Determina el estado inicial de la partida basado en la suma de los dados
        switch ((Dados)sumaDados)
        {
            case Dados.SIETE:
            case Dados.ONCE:
                partida = Estado.GANA;
                break;

            case Dados.DOCE:
            case Dados.DOS:
            case Dados.TRES:
                partida = Estado.PIERDE;
                break;

            default:
                partida = Estado.CONTNUA;
                miPunto = sumaDados;
                Console.WriteLine("El punto es {0}", miPunto);
                break;
        }

        // Mientras la partida esté en estado CONTINUA, sigue tirando los dados
        while (partida == Estado.CONTNUA)
        {
            sumaDados = TirarDados();

            // Si la suma de los dados es igual a miPunto, el jugador gana
            if (sumaDados == miPunto)
            {
                partida = Estado.GANA;
            }
            else
            {
                // Si la suma de los dados es igual a SIETE, el jugador pierde
                if (sumaDados == (int)Dados.SIETE)
                {
                    partida = Estado.PIERDE;
                }
            }
        }

        // Muestra el resultado final de la partida
        if (partida == Estado.GANA)
        {
            Console.WriteLine("GANASTE!!");
        }
        else
        {
            Console.WriteLine("Perdiste");
        }
    }

    // Método para tirar los dados y obtener la suma de dos números aleatorios entre 1 y 6
    public int TirarDados()
    {
        int dado1 = Dice.Next(1, 7);
        int dado2 = Dice.Next(1, 7);

        int resul = dado1 + dado2;
        // Muestra el resultado de la tirada de los dados
        Console.WriteLine("El jugador tiro {0} y {1} = {2}", dado1, dado2, resul);
        return resul;
    }
}
