using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial0 = new Comercial("Comercial0", 18, 500, 100);
            Comercial comercial1 = new Comercial("Comercial1", 50, 2000, 500);

            Repartidor repartidor0 = new Repartidor("Repartidor0", 18, 500, "zona 1");
            Repartidor repartidor1 = new Repartidor("Repartidor1", 50, 2000, "zona 3");

            comercial0.plus();
            comercial1.plus();

            Console.WriteLine();

            repartidor0.plus();
            repartidor1.plus();

            Console.ReadKey();
        }
    }
}
