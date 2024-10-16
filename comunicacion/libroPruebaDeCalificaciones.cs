using System;

public class LibroPruebaDeCalificaciones
{
    public static void Main(string[] args)
    {
        int nuMaterias;

        LibroCalificaciones Libro1 = new LibroCalificaciones("Historia de los Juegos");

        Libro1.MostrarMensaje();
        Console.WriteLine("Cuantas materias vas a registrar?");
        nuMaterias = Convert.ToInt16(Console.ReadLine());
        Libro1.DeterminaPromedio(nuMaterias);

    }
}
