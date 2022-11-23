using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class bebidasAzucaradas : Bebidas
    {
        int porcentajeAzucar;
        bool hasPromocion;
        const int descuento = 10;
        public bebidasAzucaradas(int id, double litros, double precio, string marca, int porcentajeAzucar, bool hasPromocion) : base(id, litros, precio, marca)
        {
            this.porcentajeAzucar = porcentajeAzucar;
            this.hasPromocion = hasPromocion;
        }
    }
}
