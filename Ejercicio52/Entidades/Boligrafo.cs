using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta -= texto.Length * 0.3f;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Soy un boligrafo");
            sb.AppendLine("Color escritura: " + this.colorTinta);
            sb.AppendLine("Nivel tinta: " + this.tinta);

            return sb.ToString();
        }
    }
}