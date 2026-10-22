
using System;

class Configuracion
{
    // Se conserva una sola instancia.
    private static Configuracion? instancia;

    private Configuracion() { }

    // Método para obtener la instancia.
    public static Configuracion ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new Configuracion();
        }

        return instancia;
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("Configuracion del sistema activa");
    }
}

class Program
{
    static void Main()
    {
        Configuracion c1 = Configuracion.ObtenerInstancia();
        Configuracion c2 = Configuracion.ObtenerInstancia();

        c1.MostrarMensaje();

        Console.WriteLine(
            "¿Es la misma instancia? " +
            ReferenceEquals(c1, c2)
        );
    }
}
