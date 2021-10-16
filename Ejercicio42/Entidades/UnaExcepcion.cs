using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class UnaExcepcion: Exception
    {
        public UnaExcepcion(string mensaje, Exception innerException): base(mensaje, innerException)
        {
        }

        public UnaExcepcion(string message):base(message)
        {
        }
    }
}
