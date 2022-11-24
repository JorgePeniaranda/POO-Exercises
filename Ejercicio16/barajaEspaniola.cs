using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class barajaEspaniola : Baraja
    {
        bool eightAndNine;
        public barajaEspaniola(bool eightAndNine) : base()
        {
            this.eightAndNine = eightAndNine;
        }
        public override void crearBaraja()
        {
            if (eightAndNine)
            {
                string[] palos = { "oros", "copas", "espadas", "bastos" };

                for (int P = 0; P < palos.Length; P++)
                {
                    for (int N = 0; N < 13; N++)
                    {
                        Cartas.Add(new Carta(N, palos[P]));
                    }
                }
            }
            else
            {
                string[] palos = { "oros", "copas", "espadas", "bastos" };
                int[] anyEightAndNine = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

                for (int P = 0; P < palos.Length; P++)
                {
                    for (int N = 0; N < anyEightAndNine.Length; N++)
                    {
                        Cartas.Add(new Carta(anyEightAndNine[N], palos[P]));
                    }
                }
            }
        }
    }
}
