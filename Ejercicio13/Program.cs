using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos producto = new Productos("Perecedero", 200);
            Perecedero perecedero = new Perecedero("Perecedero", 200, 2);
            noPerecedero noPerecedero = new noPerecedero("Perecedero", 200, "Producto Unico y Particular");

            Console.WriteLine(producto.Calcular(5));
            Console.WriteLine(perecedero.Calcular(5));
            Console.WriteLine(noPerecedero.Calcular(5));

            Console.ReadKey();
        }
    }
}
