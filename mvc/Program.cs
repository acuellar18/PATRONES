
using System;

// MODELO: contiene los datos.
class ModeloEstudiante
{
    public string Nombre { get; set; } = "Anthony";
}

// VISTA: muestra la informacion.
class VistaEstudiante
{
    public void Mostrar(string nombre)
    {
        Console.WriteLine("Estudiante: " + nombre);
    }
}

// CONTROLADOR: conecta modelo y vista.
class ControladorEstudiante
{
    private ModeloEstudiante modelo = new ModeloEstudiante();
    private VistaEstudiante vista = new VistaEstudiante();

    public void MostrarEstudiante()
    {
        vista.Mostrar(modelo.Nombre);
    }
}

class Program
{
    static void Main()
    {
        ControladorEstudiante controlador =
            new ControladorEstudiante();

        controlador.MostrarEstudiante();
    }
}
