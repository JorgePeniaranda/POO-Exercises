using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class barajaFrancesa : Baraja
    {
        public barajaFrancesa() : base()
        {

        }
        public override void crearBaraja()
        {
            string[] palos = { "diamantes", "picas", "corazones", "treboles" };

            for (int P = 0; P < palos.Length; P++)
            {
                for (int N = 0; N < 13; N++)
                {
                    Cartas.Add(new Carta(N, palos[P]));
                }
            }
        }
        public bool cartaRoja(Carta c)
        {
            return c.Palo == "corazones" || c.Palo == "diamantes";
        }
        public bool cartaNegra(Carta c)
        {
            return c.Palo == "treboles" || c.Palo == "picas";
        }
    }
}
