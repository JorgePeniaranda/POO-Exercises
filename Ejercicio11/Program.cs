using System;
using System.Collections.Generic;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dineroInicial = 200;

            Jugador yo0 = new Jugador("yo0", dineroInicial);
            Jugador yo1 = new Jugador("yo1", dineroInicial);
            Jugador yo2 = new Jugador("yo2", dineroInicial);
            Jugador yo3 = new Jugador("yo3", dineroInicial);

            List<Jugador> jugadores = new List<Jugador> { yo0, yo1, yo2, yo3 };

            yo1.apostar("O", "SEN");
            yo0.apostar("O", "GER");
            yo0.apostar("C", "URU");
            yo0.apostar("SF", "BRA");
            yo0.apostar("F", "ARG");
            Apuestas apuestas = new Apuestas(jugadores);
            apuestas.correrApuesta();

            Console.ReadKey();
        }
    }
}                                                                                                  