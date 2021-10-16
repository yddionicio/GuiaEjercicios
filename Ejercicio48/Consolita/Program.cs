using System;
using Enrtidades;


namespace Consolita
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Recibo recibo = new Recibo();
            Factura factura = new Factura(1);

            c += factura;
            c += recibo;

            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
        }
    }
}
