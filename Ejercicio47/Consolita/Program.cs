using System;
using Entidades;

namespace Consolita
{
    class Program
    {
        static void Main(string[] args)
        {

            Torneo<Equipo> torneo1 = new Torneo<Equipo>("Torneo Uno");
            Torneo<Equipo> torneo2 = new Torneo<Equipo>("Torneo Dos");

            EquipoBasquet basquet1 = new EquipoBasquet("aaa", DateTime.Now);
            EquipoBasquet basquet2 = new EquipoBasquet("bbb", DateTime.Now);
            EquipoBasquet basquet3 = new EquipoBasquet("ccc", DateTime.Now);

            EquipoFutbol futbol1 = new EquipoFutbol("ddd", DateTime.Now);
            EquipoFutbol futbol2 = new EquipoFutbol("eee", DateTime.Now);
            EquipoFutbol futbol3 = new EquipoFutbol("fff", DateTime.Now);

            torneo1.equipos.Add(basquet1);
            torneo1.equipos.Add(basquet2);
            torneo1.equipos.Add(basquet3);

            torneo2.equipos.Add(futbol1);
            torneo2.equipos.Add(futbol2);
            torneo2.equipos.Add(futbol3);

            //Mostrar

            Console.WriteLine(torneo1.Mostrar());
            Console.WriteLine(torneo2.Mostrar());

            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo2.JugarPartido);

        }
    }
}
