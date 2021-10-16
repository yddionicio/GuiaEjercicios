using System;
using System.Collections.Generic;
using System.Text;

namespace Enrtidades
{
    public class Documento
    {
        private int numero;

        public int Numero{ get { return this.numero; } }

        public Documento(int numero)
        {
            this.numero = numero;
        }


    }
}
