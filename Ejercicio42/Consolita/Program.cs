using System;
using Entidades;

namespace Consolita
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase c = new OtraClase();
                c.OtroMetodo();
            }
            catch (MiExcepcion e)
            {
                Exception ex = e;
                do
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                } while (!object.ReferenceEquals(ex, null));
            }

            Console.ReadKey();



        }
    }
}
