using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> grupo = new List<string>() { "Argentina", "Arabia", "Mexico", "Polonia" };

            jugarGrupos jugarGrupos = new jugarGrupos(grupo);

            Partido partido = new Partido(grupo[0], grupo[1], true);
            foreach (var grupoP in jugarGrupos.GruposEstadisticas)
            {
                if (grupoP.Nombre == partido.Ganador)
                {
                    grupoP.PartidosGanados++;
                }
            }
            // jugarGrupos.GruposEstadisticas[jugarGrupos.GruposEstadisticas.IndexOf(partido.Ganador)].PartidosGanados++;

            foreach (var grupoE in jugarGrupos.GruposEstadisticas)
            {
                Console.WriteLine($"{grupoE.Nombre}:");
                Console.WriteLine($"    Puntos: {grupoE.Puntos}");
                Console.WriteLine($"    Partidos Ganados: {grupoE.PartidosGanados}");
                Console.WriteLine($"    Partidos Empatados: {grupoE.PartidosEmpatados}");
                Console.WriteLine($"    Partidos Perdidos: {grupoE.PartidosPerdidos}");
            }

            Console.ReadKey();
        }
    }
}
