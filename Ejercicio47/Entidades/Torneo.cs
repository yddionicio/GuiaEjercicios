using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach (T item in t.equipos)
            {
                if (item == e)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            if (t == e)
            {
                t.equipos.Add(e);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre torneo: " + this.nombre);

            foreach (Equipo item in this.equipos)
            {
                sb.AppendLine("Datos de Equipo: " + item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random r = new Random();
            return string.Format("[{0}][{1}] – [{2}] [{3}]", e1.nombre, r.Next(0, 10), e2.nombre, r.Next(0, 10));
        }

        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                return this.CalcularPartido(this.equipos[r.Next(0, this.equipos.Count - 1)], this.equipos[r.Next(0, this.equipos.Count - 1)]);
            }
        }


    }
}
