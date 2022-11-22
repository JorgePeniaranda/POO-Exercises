using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador yo0 = new Jugador("yo0", 200);
            Jugador yo1 = new Jugador("yo1", 200);
            Jugador yo2 = new Jugador("yo2", 200);
            Jugador yo3 = new Jugador("yo3", 200);

            System.Collections.Generic.List<Jugador> jugadores = new System.Collections.Generic.List<Jugador> { yo0, yo1, yo2, yo3 };

            yo0.apostar("O", "ARG");
            yo0.apostar("C", "BRA");
            yo0.apostar("F", "GER");
            yo0.apostar("SF", "URU");
            yo1.apostar("O", "SEN");
            Apuestas apuestas = new Apuestas(jugadores);
            apuestas.correrApuesta();

            Console.ReadKey();
        }
    }
}                                                                                                  