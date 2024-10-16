using System;

public class Analisis
{
    public void ProcesarResultados()
    {
        //Inicializacion de Variables

        int aprobado = 0, reprobado = 0;
        int numEstudiantes;
        int contador = 1;
        int resultado = 0;
        decimal califExamen;

        Console.WriteLine("Ingresa el numero de Estudiantes a Evaluar");
        numEstudiantes = Convert.ToInt16(Console.ReadLine());

        while(contador >= numEstudiantes)
        {
            Console.WriteLine("Escribe la calificacion del estudiante numero {0}:", contador);
            califExamen = Convert.ToDecimal(Console.ReadLine());

        }

    }

}