using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class OtraClase: Exception
    {

        public void OtroMetodo()
        {
            try
            {
                MiClase c = new MiClase(1);
            }
            catch(UnaExcepcion e)
            {
                throw new MiExcepcion("Error estoy en OtraClase", e);
            }
        }


    }
}
