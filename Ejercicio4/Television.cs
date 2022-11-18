using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Television : Electrodomestico
    {
        private double resolucion = 20;
        private bool sincronizadorTDT = false;

        public double Resolucion { get { return resolucion; } }
        public bool SincronizadorTDT { get { return sincronizadorTDT; } }

        public Television() : base()
        {

        }
        public Television(int precio, double peso) : base(precio, peso)
        {

        }
        public Television(double resolucion, bool sincronizadorTDT, int precio, string color, char consumoEnergetico, double peso) : base(precio, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sincronizadorTDT = sincronizadorTDT;
        }
        public override double precioFinal()
        {
            double finalPrice = base.precioFinal();

            if (this.resolucion > 40) finalPrice += base.PrecioBase * .3;
            else if (this.sincronizadorTDT == true) finalPrice += 50;
            else base.precioFinal();

            return finalPrice;
        }
    }
}
