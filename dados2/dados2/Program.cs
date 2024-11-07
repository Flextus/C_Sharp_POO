using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;
        int n6 = 0;

        int mano;
        Random dado = new Random();

        for (int i = 0; i <= 6000; i++)
        {
            mano = dado.Next(1, 7);

            switch (mano)
            {
                case 1:
                    n1++;
                    break;

                case 2:
                    n2++;
                    break;

                case 3:
                    n3++;
                    break;

                case 4:
                    n4++;
                    break;

                case 5:
                    n5++;
                    break;

                case 6:
                    n6++;
                    break;

                default:
                    break;
            }
            mano = 0;
        }

        Console.WriteLine("{0, 5} {1, 15}", "Valor", "Frecuencia");
        Console.WriteLine("{0, 5} {1, 15}", "1", n1);
        Console.WriteLine("{0, 5} {1, 15}", "2", n2);
        Console.WriteLine("{0, 5} {1, 15}", "3", n3);
        Console.WriteLine("{0, 5} {1, 15}", "4", n4);
        Console.WriteLine("{0, 5} {1, 15}", "5", n5);
        Console.WriteLine("{0, 5} {1, 15}", "6", n6);
    }
}

