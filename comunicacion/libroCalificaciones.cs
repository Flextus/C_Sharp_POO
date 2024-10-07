using System;

public class LibroCalificaciones
{
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
        Console.WriteLine("Bienvenido al curso de \n{0}", NombreCurso);
    }
}
