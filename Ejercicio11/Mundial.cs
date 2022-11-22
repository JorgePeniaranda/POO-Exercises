using System;
using System.Collections.Generic;

namespace Ejercicio11
{
    internal class Mundial
    {

        List<String> Grupo1 = new List<string> { "QAT", "SEN", "HOL", "ECU" };
        List<String> Grupo2 = new List<string> { "ENG", "IRN", "USA", "WAL" };
        List<String> Grupo3 = new List<string> { "ARG", "KSA", "MEX", "POL" };
        List<String> Grupo4 = new List<string> { "FRA", "DEN", "TUN", "AUS" };
        List<String> Grupo5 = new List<string> { "ESP", "GER", "JPN", "CRC" };
        List<String> Grupo6 = new List<string> { "BEL", "MAR", "CRO", "CAN" };
        List<String> Grupo7 = new List<string> { "BRA", "SRB", "SUI", "CMR" };
        List<String> Grupo8 = new List<string> { "POR", "URU", "KOR", "GHA" };

        public List<String> grupo1 { get { return Grupo1; } }
        public List<String> grupo2 { get { return Grupo2; } }
        public List<String> grupo3 { get { return Grupo3; } }
        public List<String> grupo4 { get { return Grupo4; } }
        public List<String> grupo5 { get { return Grupo5; } }
        public List<String> grupo6 { get { return Grupo6; } }
        public List<String> grupo7 { get { return Grupo7; } }
        public List<String> grupo8 { get { return Grupo8; } }

        List<String> grupos = new List<string>();
        List<Partido> octavos = new List<Partido>();
        List<Partido> cuartos = new List<Partido>();
        List<Partido> semiFinal = new List<Partido>();
        Partido final;

        public List<String> Grupos { get { return grupos; } }
        public List<Partido> Octavos { get { return octavos; } }
        public List<Partido> Cuartos { get { return cuartos; } }
        public List<Partido> SemiFinal { get { return semiFinal; } }
        public Partido Final { get { return final; } }

        public Mundial()
        {

        }
        public void jugarGrupos()  // la fase de grupos es mas compleja, dejemoslo en los primeros equipos
        {
            octavos.Clear();
            cuartos.Clear();
            semiFinal.Clear();
            final = null;

            grupos = new List<string> { grupo1[0], grupo1[1], grupo2[0], grupo2[1], grupo3[0], grupo3[1], grupo4[0], grupo4[1], grupo5[0], grupo5[1], grupo6[0], grupo6[1], grupo7[0], grupo7[1], grupo8[0], grupo8[1] };
        }
        public void jugarOctavos()
        {
            cuartos.Clear();
            semiFinal.Clear();
            final = null;

            Console.WriteLine("Resultados Octavos:");
            for (int i = 0; i < grupos.Count; i += 2)
            {
                Partido partido = new Partido(grupos[i], grupos[i + 1]);
                octavos.Add(partido);
                Console.WriteLine($"{partido.Equipos[0]}({partido.Local}) - {partido.Equipos[1]}({partido.Visitante})");
            }
            Console.WriteLine();
        }
        public void jugarCuartos()
        {
            semiFinal.Clear();
            final = null;

            Console.WriteLine("Resultados Cuartos:");
            for (int i = 0; i < octavos.Count; i += 2)
            {
                Partido partido = new Partido(octavos[i].Ganador, octavos[i + 1].Ganador);
                cuartos.Add(partido);
                Console.WriteLine($"{partido.Equipos[0]}({partido.Local}) - {partido.Equipos[1]}({partido.Visitante})");
            }
            Console.WriteLine();
        }
        public void jugarSemiFinal()
        {
            final = null;

            Console.WriteLine("Resultados Semi-Final:");
            for (int i = 0; i < cuartos.Count; i += 2)
            {
                Partido partido = new Partido(cuartos[i].Ganador, cuartos[i + 1].Ganador);
                semiFinal.Add(partido);
                Console.WriteLine($"{partido.Equipos[0]}({partido.Local}) - {partido.Equipos[1]}({partido.Visitante})");
            }
            Console.WriteLine();
        }
        public void jugarFinal()
        {
            Console.WriteLine("Resultados Final:");
            final = new Partido(semiFinal[0].Ganador, semiFinal[1].Ganador);
            Console.WriteLine($"{final.Equipos[0]}({final.Local}) - {final.Equipos[1]}({final.Visitante})");
            Console.WriteLine();
        }
        public void jugarMundial()
        {
            jugarGrupos();
            jugarOctavos();
            jugarCuartos();
            jugarSemiFinal();
            jugarFinal();
        }
    }
}
