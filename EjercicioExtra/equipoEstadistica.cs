using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class equipoEstadistica
    {
        public string Nombre;
        public int Puntos = 0;
        public int PartidosGanados = 0;
        public int PartidosEmpatados = 0;
        public int PartidosPerdidos = 0;
        public equipoEstadistica(string nombre)
        {
            Nombre = nombre;
        }
    }
}
