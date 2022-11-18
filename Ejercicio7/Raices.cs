using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Raices
    {
        private double a;
        private double b;
        private double c;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double[] obtenerRaices()
        {
            double[] raices = { (-b + Math.Sqrt(getDiscriminante())) / (2 * a), (-b - Math.Sqrt(getDiscriminante())) / (2 * a) };

            return raices;
        }
        public double obtenerRaiz()
        {
            double raiz = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);

            return raiz;
        }
        public double getDiscriminante()
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }
        public bool tieneRaices()
        {
            return getDiscriminante() > 0;
        }
        public bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }
        public void calcular()
        {
            if (tieneRaices()) Console.WriteLine($"Las raices de la funcion f(x)={a}x²+{b}x+{c} son {obtenerRaices()[0]} y {obtenerRaices()[1]}");
            else if (tieneRaiz()) Console.WriteLine($"La raiz de la funcion f(x)={a}x²+{b}x+{c} es {obtenerRaiz()}");
            else Console.WriteLine("La funcion f(x)={a}x²+{b}x+{c} no posee solucion");
        }
    }
}
