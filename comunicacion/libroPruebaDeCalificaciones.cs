using System;

public class LibroPruebaDeCalificaciones
{
    public static void Main(string[] args)
    {
        int nuMaterias;
        int seleccion;

        LibroCalificaciones Libro1 = new LibroCalificaciones("Historia de los Juegos");
        Libro1.MostrarMensaje();

        Analisis analisis = new Analisis();
        Console.WriteLine("Bienvenido al libro de calificaciones");
        Console.WriteLine("Escrobre la opcion deseada:");
        Console.WriteLine("\n \n 1.- Calificar examenes");
        Console.WriteLine("\n \n 1.- Subir Calidicaciones");
        seleccion = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("\n");
        if (seleccion == 1) 
        {
            analisis.ProcesarResultados();
        }
        else if (seleccion == 2) 
        {
            Console.WriteLine("Cuantas materias vas a registrar?");
            nuMaterias = Convert.ToInt16(Console.ReadLine());
            Libro1.DeterminaPromedio(nuMaterias);
        }
        else { Console.WriteLine("Por favor Ingresa un valor Valido"); }

    }
}
