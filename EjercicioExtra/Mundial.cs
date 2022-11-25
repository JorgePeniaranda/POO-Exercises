using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class Mundial
    {
        List<string> grupo;
        jugarGrupos jugarGrupos;
        public Mundial(List<string> grupo, jugarGrupos jugarGrupos)
        {
            this.grupo = grupo;
            this.jugarGrupos = jugarGrupos;
        }
        public void jugarMundial()
        {
            Partido partido = new Partido(grupo[0], grupo[1], true);
            foreach (var grupoP in jugarGrupos.GruposEstadisticas)
            {
                if (grupoP.Nombre == partido.Ganador)
                {
                    grupoP.PartidosGanados++;
                }
            }
        }
    }
}
