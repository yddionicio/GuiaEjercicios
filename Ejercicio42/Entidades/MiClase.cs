using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MiClase
    {
        public static void MiMetodo()
        {
            try
            {
                int aux = 0;
                int resultado = 7 / aux;
            }
            catch (DivideByZeroException e) //capturamos la excepcion
            {
                throw e; // lanzamos la exception ya creada por defecto
            }
        }

        public MiClase()
        {
            try
            {
                MiClase.MiMetodo();       // codigo a controlar, colocamos el codigo que problamente lance una excepcion
            }
            catch (DivideByZeroException ex)       //capturamos la excepcion DivideByZeroException();
            {
                throw ex;                                 //lanzamos nuevamente la exception
            }
        }

        public MiClase(int num)
        {
            try
            {
                MiClase miClase = new MiClase(); // generamos una nueva instancia del constructor para obtener la excepcion que contiene.
            }
            catch (DivideByZeroException e) // atrapamos la excepcion
            {
                throw new UnaExcepcion("Error estoy en 2do constructor MiClase", e); // creamos una nueva excepcion y almacenamos la excepcion atrapada en el catch.
            }
        }



    }
}
