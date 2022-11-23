using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12B
{
    internal class Comercial : Empleado
    {
        double comision;
        public double Comision { get { return comision; } set { comision = value; } }
        public Comercial(string nombre, int edad, int salario, double comision) : base(nombre, edad, salario)
        {
            this.comision = comision;
        }
        public void plus()
        {
            if (Edad > 30 && comision > 200)
            {
                Console.WriteLine($"{Nombre} aplico para el plus");
                Salario += Plus;
            }
            else
            {
                Console.WriteLine($"{Nombre} NO aplico para el plus");
            }
        }
    }
}
