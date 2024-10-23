using System;

public class Arreglo
{
    public static void Main(string[] args)
    {
        /*
        int[] arreglo1; //declaramos un arreglo de enteros
        int[] arreglo2 = { 5, 6, 7, 8, 9, 10, 11 };
        arreglo1 = new int[10] ;
        //imprime "Indice" en la posicion 0 y espacio 0 y "Valor" en la posicion 1, espacio 8
        
        for (int contador1  = 0 ; contador1 < arreglo1.Length; contador1++)
        {
            Console.WriteLine("{0, 5} {1, 8}", contador1, arreglo1[contador1]);
            //los arreglos se usan con un esapcio adicional al que se usara
            //para evitar overflowing
        }        
               
        for (int contador2  = 0 ; contador2 < arreglo2.Length; contador2++)
        {
            Console.WriteLine("{0, 5} {1, 8}", contador2, arreglo2[contador2]);
            //los arreglos se usan con un esapcio adicional al que se usara
            //para evitar overflowing
        }
        Console.WriteLine(arreglo2[3]);
        */
        const int LONG_ARREGLO = 10;
        int[] arreglo1 = new int[LONG_ARREGLO];

        Console.WriteLine("{0}{1, 8}", "Indice", "Valor");

        for (int contador = 0; contador < arreglo1.Length; contador++)
        {
            arreglo1[contador] = 2 + 2 * contador;
            Console.WriteLine("{0, 3} {1, 10}", contador, arreglo1[contador]);
        }

    }
}