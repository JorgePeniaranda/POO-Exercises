using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12B
{
    internal class Repartidor : Empleado
    {
        string zona;
        public string Zona { get { return zona; } set { zona = value; } }
        public Repartidor(string nombre, int edad, int salario, string zona) : base(nombre, edad, salario)
        {
            this.zona = zona;
        }
        public void plus()
        {
            if (Edad > 25 && zona.ToLower() == "zona 3")
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
