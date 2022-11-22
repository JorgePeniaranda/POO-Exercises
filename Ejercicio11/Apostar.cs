using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Apostar
    {
        string fase;
        string equipoGanador;

        public string Fase { get { return fase; } }
        public string EquipoGanador { get { return equipoGanador; } }

        public Apostar(string fase, string equipoGanador)
        {
            this.fase = fase;
            this.equipoGanador = equipoGanador;
        }
    }
}
