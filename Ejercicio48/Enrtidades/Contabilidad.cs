﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enrtidades
{
    public class Contabilidad <T, U> 
        where T: Documento
        where U : Documento, new ()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }


        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EGRESOS");
            foreach (T item in this.egresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }

            sb.AppendLine();
            sb.AppendLine("INGRESOS");
            foreach (U item in this.ingresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }

            return sb.ToString();
        }

    }
}
