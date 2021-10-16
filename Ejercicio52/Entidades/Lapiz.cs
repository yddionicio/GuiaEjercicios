using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -= texto.Length * 0.1f;
            return new EscrituraWrapper(texto, this.Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Soy un Lapiz");
            sb.AppendLine("Color escritura: " + this.Color);
            sb.AppendLine("Nivel tinta: " + this.UnidadesDeEscritura);

            return sb.ToString();
        }

    }
}
