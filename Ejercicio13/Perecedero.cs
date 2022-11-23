using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Perecedero : Productos
    {
        int diasCaducar;
        public int DiasCaducar { get { return diasCaducar; } set { diasCaducar = value; } }
        public Perecedero(string nombre, int precio, int diasCaducar) : base(nombre, precio)
        {
            this.diasCaducar = diasCaducar;
        }
        public override int Calcular(int cantidad)
        {
            int total = base.Calcular(cantidad);

            switch (diasCaducar)
            {
                case 1:
                    total /= 4;
                    break;
                case 2:
                    total /= 3;
                    break;
                case 3:
                    total /= 2;
                    break;
                default:
                    break;
            }

            return total;
        }
    }
}
