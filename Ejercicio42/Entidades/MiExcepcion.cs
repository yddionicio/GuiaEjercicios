using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MiExcepcion: Exception
    {
        public MiExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
