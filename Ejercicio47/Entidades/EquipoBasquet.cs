﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EquipoBasquet : Equipo
    {

        public EquipoBasquet(string nombre, DateTime fecha) : base(nombre, fecha)
        {
        }
        public override string Ficha()
        {
            return string.Format("[{0}] fundado el [{1}]", this.nombre, this.fechaCreacion);
        }


    }
}
