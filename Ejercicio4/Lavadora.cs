using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Lavadora : Electrodomestico
    {
        private const int carga = 5;

        public int Carga { get { return carga; } }

        public Lavadora() : base()
        {

        }
        public Lavadora(int precio, double peso) : base(precio, peso)
        {

        }
        public Lavadora(int precio, string color, char consumoEnergetico, double peso) : base(precio, color, consumoEnergetico, peso)
        {

        }
        public override double precioFinal()
        {
            double finalPrice = base.precioFinal();

            if (base.Peso > 30) finalPrice += 30;
            else base.precioFinal();

            return finalPrice;
        }
    }
}
