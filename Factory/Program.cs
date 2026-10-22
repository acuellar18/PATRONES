
using System;

interface INotificacion
{
    void Enviar();
}

class Correo : INotificacion
{
    public void Enviar()
    {
        Console.WriteLine("Enviando correo electronico");
    }
}

class SMS : INotificacion
{
    public void Enviar()
    {
        Console.WriteLine("Enviando mensaje SMS");
    }
}

class FabricaNotificaciones
{
    public static INotificacion? Crear(string tipo)
    {
        if (tipo == "correo")
            return new Correo();

        if (tipo == "sms")
            return new SMS();

        return null;
    }
}

class Program
{
    static void Main()
    {
        INotificacion? aviso =
            FabricaNotificaciones.Crear("correo");

        if (aviso != null)
            aviso.Enviar();
        else
            Console.WriteLine("Tipo no valido");
    }
}
    