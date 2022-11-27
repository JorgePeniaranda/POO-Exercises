using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class equipoGrupos
    {
        string nombre;
        int puntos = 0;
        int partidosGanados = 0;
        int partidosEmpatados = 0;
        int partidosPerdidos = 0;

        public string Nombre { get { return nombre; } }
        public int Puntos { get { return puntos; } set { puntos = value; } }
        public int PartidosGanados { get { return partidosGanados; } set { partidosGanados = value; } }
        public int PartidosEmpatados { get { return partidosEmpatados; } set { partidosEmpatados = value; } }
        public int PartidosPerdidos { get { return partidosPerdidos; } set { partidosPerdidos = value; } }
        public equipoGrupos(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
