
using System;

// Interfaz que necesita la aplicacion nueva.
interface IPago
{
    void Pagar();
}

// Sistema antiguo que no podemos modificar.
class SistemaPagoAntiguo
{
    public void ProcesarPago()
    {
        Console.WriteLine("Pago procesado por el sistema antiguo");
    }
}

// Adapter: conecta ambas interfaces.
class AdaptadorPago : IPago
{
    private SistemaPagoAntiguo sistema;

    public AdaptadorPago(SistemaPagoAntiguo sistema)
    {
        this.sistema = sistema;
    }

    public void Pagar()
    {
        sistema.ProcesarPago();
    }
}

class Program
{
    static void Main()
    {
        SistemaPagoAntiguo sistemaAntiguo =
            new SistemaPagoAntiguo();

        IPago pago = new AdaptadorPago(sistemaAntiguo);

        pago.Pagar();
    }
}

