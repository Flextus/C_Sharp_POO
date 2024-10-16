using System;

public class LibroCalificaciones
{
    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre;
    }
    private string nombreCurso;

    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        }
        set
        {
            nombreCurso = value;
        }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al curso de  \n{0}", NombreCurso);
    }

    public void DeterminaPromedio(int numCalif)
    {
        decimal calif;        
        decimal totalCalif;        
        decimal promedio;
        int contador;

        totalCalif = 0;
        contador = 1;

        while (contador <= numCalif) 
        {
            Console.WriteLine("Escribe la calificacion: ");
            calif = Convert.ToDecimal(Console.ReadLine());
            totalCalif += calif;
            contador++;
        }
        promedio = totalCalif / numCalif;
        Console.WriteLine("\nEl total de las {0} Calificaciones es {1}", numCalif, totalCalif);
        Console.WriteLine("EL Promedio de las calificaciones {0}", promedio);
    }
}
