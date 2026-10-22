
using System;

class Procesador
{
    public void Iniciar()
    {
        Console.WriteLine("Procesador iniciado");
    }
}

class Memoria
{
    public void Preparar()
    {
        Console.WriteLine("Memoria preparada");
    }
}

class SistemaOperativo
{
    public void Cargar()
    {
        Console.WriteLine("Sistema operativo cargado");
    }
}

// Facade: coordina todos los componentes.
class Computadora
{
    private Procesador procesador = new Procesador();
    private Memoria memoria = new Memoria();
    private SistemaOperativo sistema = new SistemaOperativo();

    public void Encender()
    {
        procesador.Iniciar();
        memoria.Preparar();
        sistema.Cargar();

        Console.WriteLine("Computadora lista");
    }
}

class Program
{
    static void Main()
    {
        Computadora pc = new Computadora();
        pc.Encender();
    }
}
