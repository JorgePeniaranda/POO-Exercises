using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class crearGrupo
    {
        List<equipoEstadistica> grupo = new List<equipoEstadistica>();
        public List<equipoEstadistica> Grupo { get { return grupo; } }
        public crearGrupo(List<string> grupo)
        {
            crearEquipoGrupo(grupo);
        }
        public void crearEquipoGrupo(List<string> listaGrupo)
        {
            for (int i = 0; i < listaGrupo.Count; i++)
            {
                grupo.Add(new equipoEstadistica(listaGrupo[i]));
            }
        }
    }
}
