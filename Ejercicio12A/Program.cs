using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> listaJugadores = new List<Jugador>();

            Console.Write("Ingrese cantidad de Jugadores: ");
            int userCantJugador = Convert.ToInt32(Console.ReadLine());
            if (userCantJugador > 0 && userCantJugador < 7)
            {
                for (int i = 0; i < userCantJugador; i++)
                {
                    listaJugadores.Add(new Jugador(i, "Jugador" + (i + 1)));
                }
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    listaJugadores.Add(new Jugador(i, "Jugador" + (i + 1)));
                }
            }


            Revolver revolver = new Revolver();
            Juego juego = new Juego(listaJugadores, revolver);

            juego.ronda();

            Console.ReadKey();
        }
    }
}
