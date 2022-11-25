using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class Partido
    {
        static Random rdn = new Random();
        string[] equipos = new string[2];
        string ganador = "";
        string perdedor = "";
        int local = 0;
        int visitante = 0;

        public string[] Equipos { get { return equipos; } }
        public string Ganador { get { return ganador; } }
        public string Perdedor { get { return perdedor; } }
        public int Visitante { get { return visitante; } }
        public int Local { get { return local; } }


        public Partido(string equipo1, string equipo2)
        {
            equipos[0] = equipo1;
            equipos[1] = equipo2;
            jugarPartido();
        }
        public Partido(string equipo1, string equipo2, bool isArreglado)
        {
            equipos[0] = equipo1;
            equipos[1] = equipo2;
            jugarPartido(isArreglado);
        }
        public void jugarPartido()
        {
            local = rdn.Next(0, 6);
            visitante = rdn.Next(0, 6);

            if (local > visitante) ganador = equipos[0];
            else ganador = equipos[1];
        }
        public void jugarPartido(bool isArreglado)
        {
            if (isArreglado)
            {
                ganador = equipos[0];
                perdedor = equipos[1];
            }
            else jugarPartido();
        }
    }
}
