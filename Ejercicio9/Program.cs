using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sala> salas = new List<Sala>();
            for (int i = 1; i <= 10; i++)
            {
                salas.Add(new Sala(i, 8, 9, new Pelicula("Pelicula Increible", 120, 18, "Director"), 200));
            }
            Cine cine = new Cine(salas);

            // Para N cantidad de salas
            for (int S = 0; S < cine.Salas.Count; S++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sala " + cine.Salas[S].IDSala + ":");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");

                //Agrego 10 personas
                for (int i = 0; i < 10; i++)
                {
                    cine.Salas[S].agregarPersona(new Espectador("Espectador" + (i + 1), i + 15, 200));
                }

                // Muestro la sala
                for (int F = 0; F < cine.Salas[S].Asientos.Count; F++)
                {
                    for (int C = 0; C < cine.Salas[S].Asientos[F].Count; C++)
                    {
                        if (cine.Salas[S].Asientos[F][C].Disponibilidad) Console.Write(cine.Salas[S].Asientos[F][C].Fila + " " + cine.Salas[S].Asientos[F][C].Columna + " ");
                        else
                        {
                            Console.Write(cine.Salas[S].Asientos[F][C].Fila);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" X "); // Asiento ocupado
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
