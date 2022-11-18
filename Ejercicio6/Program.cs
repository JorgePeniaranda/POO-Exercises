using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear Libros
            Libro libro1 = new Libro(1111111111, "Libro la precuela", "Inserte Autor", 165);
            Libro libro2 = new Libro(1111111112, "Libro la postprecuela", "Inserte Autor", 254);

            // Mostrar Cantidad de paginas
            Console.WriteLine($"{libro1.Titulo} Tiene {libro1.NumeroPaginas} paginas");
            Console.WriteLine($"{libro2.Titulo} Tiene {libro2.NumeroPaginas} paginas");

            // Comprar numero de paginas
            if (libro1.NumeroPaginas > libro2.NumeroPaginas) Console.WriteLine($"{libro1.Titulo} Tiene mas paginas");
            else if (libro1.NumeroPaginas < libro2.NumeroPaginas) Console.WriteLine($"{libro2.Titulo} Tiene mas paginas");
            else Console.WriteLine("Ambos tienen las mismas paginas");

            Console.ReadKey();

        }
    }
}
