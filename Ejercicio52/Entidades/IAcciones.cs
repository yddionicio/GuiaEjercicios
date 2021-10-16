using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }
        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);

    }
}
