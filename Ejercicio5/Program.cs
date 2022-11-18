using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Series
            Series[] arraySeries = new Series[5];
            arraySeries[0] = new Series("C#: La revolución de la programación", 3, "Programción", "POO");
            arraySeries[1] = new Series("C#: El nacimiento de la programacion orientada a objetos", 2, "Programción", "POO");
            arraySeries[2] = new Series("C#: El golpe a la programación estructurada a objetos", 2, "Programción", "POO");
            arraySeries[3] = new Series("C#: La revancha de la programación estructurada a objetos", 5, "Programción", "POO");
            arraySeries[4] = new Series("C#: El fin", 1, "Programción", "POO");

            arraySeries[0].entregar();
            arraySeries[1].entregar();
            arraySeries[2].entregar();

            int seriesEntregadas = 0;
            foreach (Series series in arraySeries)
            {
                if (series.isEntregado())
                {
                    seriesEntregadas++;
                }
            }

            int serieMasTemporadas = 0;
            foreach (Series series in arraySeries)
            {
                if (series.NumeroTemporadas > serieMasTemporadas)
                {
                    serieMasTemporadas = series.NumeroTemporadas;
                }
            }


            // VideoJuegos
            Videojuegos[] arrayVideojuegos = new Videojuegos[5];
            arrayVideojuegos[0] = new Videojuegos("C#: Programando ando", 12, "Programción", "POOCompany");
            arrayVideojuegos[1] = new Videojuegos("C#: La Evaluación", 3, "Programción", "POOCompany");
            arrayVideojuegos[2] = new Videojuegos("C#: El Recuperatorio", 3, "Programción", "POOCompany");
            arrayVideojuegos[3] = new Videojuegos("C#: El Recuperatorio del Recuperatorio", 5, "Programción", "POOCompany");
            arrayVideojuegos[4] = new Videojuegos("C#: Destino Final", 10, "Programción", "POOCompany");

            arrayVideojuegos[2].entregar();
            arrayVideojuegos[3].entregar();
            arrayVideojuegos[4].entregar();

            int videoJuegosEntregados = 0;
            String[] nombreVideoJuegosEntregados = new String[5];
            foreach (Videojuegos videojuegos in arrayVideojuegos)
            {
                if (videojuegos.isEntregado())
                {
                    videoJuegosEntregados++;
                }
            }

            int videoJuegoMasHorasEstimadas = 0;
            foreach (Videojuegos videojuegos in arrayVideojuegos)
            {
                if (videojuegos.HorasEstimadas > videoJuegoMasHorasEstimadas)
                {
                    videoJuegoMasHorasEstimadas = videojuegos.HorasEstimadas;
                }
            }


            // Mostrar Resultado
            Console.WriteLine("Series:");
            Console.WriteLine("    Series entregadas: " + seriesEntregadas);
            Console.WriteLine("    Series con mas temporadas: " + serieMasTemporadas);
            Console.WriteLine("Videojuegos:");
            Console.WriteLine("    Videojuegos entregados: " + videoJuegosEntregados);
            Console.WriteLine("    Videojuegos con mas horas: " + videoJuegoMasHorasEstimadas);

            Console.ReadKey();
        }
    }
}
