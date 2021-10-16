using System;
using System.Collections.Generic;
using System.Text;

namespace Enrtidades
{
    public class Recibo: Documento
    {

        public Recibo():base(0)
        {
        }
        public Recibo(int numero) : base(numero)
        {
        }

    }
}
