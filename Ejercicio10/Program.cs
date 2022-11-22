using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            baraja.barajar();

            Console.WriteLine();
            baraja.siguienteCarta();
            
            Console.WriteLine();
            baraja.darCartas(20);

            Console.WriteLine();
            baraja.cartasMonton();

            Console.WriteLine();
            baraja.mostrarBaraja();

            Console.ReadKey();
        }
    }
}
