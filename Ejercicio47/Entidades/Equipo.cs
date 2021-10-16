using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha) 
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public abstract string Ficha();

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }



    }
}
