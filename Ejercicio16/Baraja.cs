using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal abstract class Baraja
    {
        List<Carta> cartas = new List<Carta>();
        public List<Carta> Cartas { get { return cartas; } }
        int cartaActual = 0;

        public Baraja()
        {
            crearBaraja();
        }
        public abstract void crearBaraja();
        public void barajar()
        {
            Random rnd = new Random();
            cartas = cartas.OrderBy(x => rnd.Next()).ToList();
        }
        public void siguienteCarta()
        {
            Console.WriteLine("Siguiente carta:");
            if (cartas.Count <= cartaActual) Console.WriteLine("No hay mas cartas");
            else
            {
                Console.WriteLine("    " + cartas[cartaActual].Numero + " de " + cartas[cartaActual].Palo);
                cartaActual++;
            }
        }
        public void cartasDisponibles()
        {
            var cantCartasDisponibles = cartas.Count - cartaActual;

            if (cantCartasDisponibles > 1) Console.WriteLine("Hay " + cantCartasDisponibles + " Cartas Disponibles");
            if (cantCartasDisponibles == 1) Console.WriteLine("Hay " + cantCartasDisponibles + " Carta Disponible");
            else Console.WriteLine("No quedan cartas disponibles");
        }
        public void darCartas(int cantCartas)
        {
            Console.WriteLine("Se dio la cartas:");
            for (int i = 0; i < cantCartas; i++)
            {
                if (cartas.Count <= cartaActual)
                {
                    Console.WriteLine("    " + "No hay mas cartas");
                    break;
                }
                else
                {
                    Console.WriteLine("    " + cartas[cartaActual].Numero + " de " + cartas[cartaActual].Palo);
                    cartaActual++;
                }
            }
        }
        public void cartasMonton()
        {
            Console.WriteLine("Salieron las cartas:");
            for (int i = 0; i < cartaActual; i++)
            {
                Console.WriteLine("    " + cartas[i].Numero + " de " + cartas[i].Palo);
            }
        }
        public void mostrarBaraja()
        {
            Console.WriteLine("Mostrar Baraja:");
            for (int i = cartaActual; i < cartas.Count; i++)
            {
                Console.WriteLine("    " + cartas[i].Numero + " de " + cartas[i].Palo);
            }
        }
    }
}
