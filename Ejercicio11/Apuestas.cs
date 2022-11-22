using System;
using System.Collections.Generic;

namespace Ejercicio11
{
    internal class Apuestas : Mundial
    {
        List<Jugador> jugadores = new List<Jugador>();

        public Apuestas(List<Jugador> jugadores) : base()
        {
            this.jugadores = jugadores;
        }
        public void correrApuesta()
        {
            int premio = 0;
            for (int i = 0; i < jugadores.Count; i++)
            {
                premio += jugadores[i].Apuestas.Count;
            }

            base.jugarMundial();
            
            bool yaGanaron = false;
            foreach (var persona in jugadores)
            {
                for (int i = 0; i < persona.Apuestas.Count; i++)
                {
                    if (persona.Apuestas[i].Fase == "O" && comprobarOctavos(persona.Apuestas[i].EquipoGanador))
                    {
                        Console.WriteLine(persona.Nombre + " acerto su apuesta!");
                        persona.CantidadAciertos++;
                    }
                    else if (persona.Apuestas[i].Fase == "C" && comprobarCuartos(persona.Apuestas[i].EquipoGanador))
                    {
                        Console.WriteLine(persona.Nombre + " acerto su apuesta!");
                        persona.CantidadAciertos++;
                    }
                    else if (persona.Apuestas[i].Fase == "SF" && comprobarSemiFinal(persona.Apuestas[i].EquipoGanador))
                    {
                        Console.WriteLine(persona.Nombre + " acerto su apuesta!");
                        persona.CantidadAciertos++;
                    }
                    else if (persona.Apuestas[i].Fase == "F" && comprobarFinal(persona.Apuestas[i].EquipoGanador))
                    {
                        Console.WriteLine(persona.Nombre + " acerto su apuesta!");
                        persona.CantidadAciertos++;
                    }
                }
                if (persona.CantidadAciertos > 1 && !yaGanaron)
                {
                    persona.agregarDinero(premio);
                    Console.WriteLine(persona.Nombre + " ya gano la apuesta!");
                    yaGanaron = true;
                }
            }

            mostrarResultados();
        }
        public bool comprobarOctavos(string equipoApostado)
        {
            foreach (var O in Octavos) if (O.Ganador == equipoApostado) return true;
            return false;
        }
        public bool comprobarCuartos(string equipoApostado)
        {
            foreach (var O in Cuartos) if (O.Ganador == equipoApostado) return true;
            return false;
        }
        public bool comprobarSemiFinal(string equipoApostado)
        {
            foreach (var O in SemiFinal) if (O.Ganador == equipoApostado) return true;
            return false;
        }
        public bool comprobarFinal(string equipoApostado)
        {
            if (Final.Ganador == equipoApostado) return true;
            else return false;
        }
        public void mostrarResultados()
        {
            foreach (var persona in jugadores)
            {
                Console.WriteLine();
                Console.WriteLine(persona.Nombre + ":");
                Console.WriteLine($"    Cantidad de Apuestas: {persona.Apuestas.Count}");
                Console.WriteLine($"    Cantidad de Aciertos: {persona.CantidadAciertos}");
                Console.WriteLine($"    Cantidad de Dinero: {persona.Dinero}");
            }
        }
    }
}
