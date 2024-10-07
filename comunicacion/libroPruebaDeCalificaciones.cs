using System;

public class LibroPruebaDeCalificaciones
{
    public static void Main(string[] args)
    {
        LibroCalificaciones Libro1 = new LibroCalificaciones();
        //Muestra el valor inicial si esta asignado
        Console.WriteLine("El nombre inicial del Curso es: '{0}' \n ", Libro1.NombreCurso);


        //Pedimos la emtrada del Usuario
        Console.WriteLine("Por Favor escribe el nombre del curso");
        string nombre = Console.ReadLine();

        //Guardamos el nombre en la otra clase
        Libro1.NombreCurso = nombre;
        
        //Muestra el mensjae de Bienvenida despues de especificar tu nombre
        Libro1.MostrarMensaje();

    }
}
