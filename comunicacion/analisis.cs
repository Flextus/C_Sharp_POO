using System;

public class Analisis
{
    public void ProcesarResultados()
    {
        //Inicializacion de Variables

        int aprobado = 0, reprobado = 0;
        int numEstudiantes;
        int contador = 1;
        decimal califExamen;

        Console.WriteLine("Ingresa el numero de Estudiantes a Evaluar");
        numEstudiantes = Convert.ToInt16(Console.ReadLine());

        while(contador <= numEstudiantes)
        {
            Console.WriteLine("Escribe la calificacion del estudiante numero {0}:", contador);
            califExamen = Convert.ToDecimal(Console.ReadLine());

            if (califExamen >= 6 )
            {
                Console.WriteLine(" El alumno numero {0} ha aprobado", contador);
                aprobado++;
            }
            else if (califExamen < 5 )
            {
                Console.WriteLine(" El alumno numero {0} ha reprobado", contador);
                reprobado++;
            }
            contador++;
        }

        Console.WriteLine("\n El total de Aprobados es: {0} \n El Total de Reprobados es {1}", aprobado, reprobado);
    }

}