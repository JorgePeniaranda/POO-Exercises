using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class jugarGrupos
    {
        List<string> grupo = new List<string>();
        List<equipoGrupos> gruposEstadisticas = new List<equipoGrupos>();
        public List<string> Grupo { get { return grupo; } }
        public List<equipoGrupos> GruposEstadisticas { get { return gruposEstadisticas; } }
        public jugarGrupos(List<string> grupo)
        {
            this.grupo = grupo;
            crearEstadisticasGrupos();
        }
        public void crearEstadisticasGrupos()
        {
            for (int i = 0; i < grupo.Count; i++)
            {
                equipoGrupos equipoGrupos = new equipoGrupos(grupo[i]);
                gruposEstadisticas.Add(equipoGrupos);
            }
        }
    }
}
