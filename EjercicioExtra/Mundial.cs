using System;
using System.Collections.Generic;

namespace EjercicioExtra
{
    internal class Mundial
    {
        crearGrupo grupo;
        List<crearGrupo> posiblesResultados = new List<crearGrupo>();
        int PosibilidadID = 0;
        public List<crearGrupo> PosiblesResultados { get { return posiblesResultados; } }
        public Mundial(List<string> grupo)
        {
            this.grupo = new crearGrupo(grupo);
        }
        public void jugarGrupos()
        {
            List<int[]> combinacionesPartidos = new List<int[]>();
            combinacionesPartidos.Add(new int[2]{ 0, 1 });
            combinacionesPartidos.Add(new int[2]{ 0, 2 });
            combinacionesPartidos.Add(new int[2]{ 0, 3 });
            combinacionesPartidos.Add(new int[2]{ 1, 2 });
            combinacionesPartidos.Add(new int[2]{ 1, 3 });
            combinacionesPartidos.Add(new int[2]{ 2, 3 });
            //{ "Argentina", "Arabia", "Mexico", "Polonia" }

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        for (int d = 0; d < 3; d++)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                // Posibilidad 1 (Gana Equipo 1)
                                grupo.Grupo[combinacionesPartidos[i][0]].Puntos += 3;
                                grupo.Grupo[combinacionesPartidos[i][0]].PartidosGanados++;
                                grupo.Grupo[combinacionesPartidos[i][1]].PartidosPerdidos++;
                                posiblesResultados.Add(grupo);

                                PosibilidadID++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Posibilidad {PosibilidadID}:");
                                mostrarTabla();

                                // Posibilidad 2 (Gana Equipo 2)
                                grupo.Grupo[combinacionesPartidos[i][1]].Puntos += 3;
                                grupo.Grupo[combinacionesPartidos[i][1]].PartidosGanados++;
                                grupo.Grupo[combinacionesPartidos[i][0]].PartidosPerdidos++;
                                posiblesResultados.Add(grupo);

                                PosibilidadID++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Posibilidad {PosibilidadID}:");
                                mostrarTabla();

                                // Posibilidad 3 (Empate)
                                grupo.Grupo[combinacionesPartidos[i][0]].Puntos++;
                                grupo.Grupo[combinacionesPartidos[i][0]].PartidosEmpatados++;
                                grupo.Grupo[combinacionesPartidos[i][1]].Puntos++;
                                grupo.Grupo[combinacionesPartidos[i][1]].PartidosEmpatados++;
                                posiblesResultados.Add(grupo);

                                PosibilidadID++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Posibilidad {PosibilidadID}:");
                                mostrarTabla();
                            }
                        }
                    }
                }
            }
        }
        public void mostrarTabla()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"    Resultado Grupo:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < grupo.Grupo.Count; i++)
            {
                Console.WriteLine($"        {grupo.Grupo[i].Nombre}:");
                Console.WriteLine($"            Puntos: {grupo.Grupo[i].Puntos}");
                Console.WriteLine($"            Partidos Ganados: {grupo.Grupo[i].PartidosGanados}");
                Console.WriteLine($"            Partidos Empatados: {grupo.Grupo[i].PartidosEmpatados}");
                Console.WriteLine($"            Partidos Perdidos: {grupo.Grupo[i].PartidosPerdidos}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}