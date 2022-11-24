using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Española
            Console.WriteLine("Baraja Española");
            barajaEspaniola barajaEspaniola = new barajaEspaniola(true);
            barajaEspaniola.barajar();

            Console.WriteLine();
            barajaEspaniola.siguienteCarta();

            Console.WriteLine();
            barajaEspaniola.darCartas(20);

            Console.WriteLine();
            barajaEspaniola.cartasMonton();

            Console.WriteLine();
            barajaEspaniola.mostrarBaraja();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Francesa
            Console.WriteLine("Baraja Francesa");
            barajaFrancesa barajaFrancesa = new barajaFrancesa();
            barajaFrancesa.barajar();

            Console.WriteLine();
            barajaFrancesa.siguienteCarta();

            Console.WriteLine();
            barajaFrancesa.darCartas(20);

            Console.WriteLine();
            barajaFrancesa.cartasMonton();

            Console.WriteLine();
            barajaFrancesa.mostrarBaraja();

            Console.WriteLine();
            Console.WriteLine("Cartas Rojas:");
            foreach (var carta in barajaFrancesa.Cartas) if (barajaFrancesa.cartaRoja(carta)) Console.WriteLine($"{carta.Numero} de {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(carta.Palo)} es roja");

            Console.WriteLine();
            Console.WriteLine("Cartas Negras:");
            foreach (var carta in barajaFrancesa.Cartas) if (barajaFrancesa.cartaNegra(carta)) Console.WriteLine($"{carta.Numero} de {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(carta.Palo)} es negra");

            Console.ReadKey();
        }
    }
}
