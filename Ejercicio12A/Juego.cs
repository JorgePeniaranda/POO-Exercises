using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12A
{
    internal class Juego
    {
        List<Jugador> jugadores = new List<Jugador>();
        Revolver revolver;
        public Juego(List<Jugador> jugadores, Revolver revolver)
        {
            this.jugadores = jugadores;
            this.revolver = revolver;
        }
        public bool finJuego()
        {
            foreach (var jugador in jugadores)
            {
                if (!jugador.Vivo) return true;
            }
            return false;
        }
        public void ronda()
        {
            do
            {
                for (int i = 0; i < jugadores.Count; i++)
                {
                    Console.WriteLine(jugadores[i].Nombre + " se va a dispara");
                    if (jugadores[i].disparar(revolver)) break;
                    Console.WriteLine();
                }
            } while (!finJuego());
        }
    }
}
