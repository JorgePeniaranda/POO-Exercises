using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Espectador
    {
        string nombre;
        int edad;
        int dineroActual;

        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }
        public int DineroActual { get { return dineroActual; } }

        public Espectador(string nombre, int edad, int dineroActual)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dineroActual = dineroActual;
        }
    }
}
