using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Partido
    {
        static Random rdn = new Random();
        string[] equipos = new string[2];
        string ganador = "";
        int local = 0;
        int visitante = 0;

        public string[] Equipos { get { return equipos; } }
        public string Ganador { get { return ganador; } }
        public int Visitante { get { return visitante; } }
        public int Local { get { return local; } }


        public Partido(string equipo1, string equipo2)
        {
            equipos[0] = equipo1;
            equipos[1] = equipo2;
            jugarPartido();
        }
        public void jugarPartido()
        {
            local = rdn.Next(0, 6);
            visitante = rdn.Next(0,6);

            if (local > visitante) ganador = equipos[0];
            else ganador = equipos[1];
        }
    }
}
