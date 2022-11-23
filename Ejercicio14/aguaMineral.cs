using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class aguaMineral : Bebidas
    {
        string origen;
        public aguaMineral(int id, int litros, double precio, string marca, string origen) : base(id, litros, precio, marca)
        {
            this.origen = origen;
        }
    }
}
