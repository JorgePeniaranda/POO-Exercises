using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] Electrodomesticos = new Electrodomestico[10];

            // Electrodomesticos
            Electrodomesticos[0] = new Electrodomestico(100, "Blanco", 'A', 10);
            Electrodomesticos[1] = new Electrodomestico(200, "Negro", 'B', 20);
            Electrodomesticos[2] = new Electrodomestico(300, "Rojo", 'C', 30);

            // Televisiones
            Electrodomesticos[3] = new Television(21, false, 400, "Azul", 'D', 40);
            Electrodomesticos[4] = new Television(30, false, 500, "Gris", 'E', 50);
            Electrodomesticos[5] = new Television(59, false, 600, "BLANCO", 'F', 60);

            // Lavadoras
            Electrodomesticos[6] = new Lavadora(700, "NEGRO", 'A', 70);
            Electrodomesticos[7] = new Lavadora(800, "ROJO", 'B', 80);
            Electrodomesticos[8] = new Lavadora(900, "AZUL", 'C', 90);

            //Este quedo sin grupo
            Electrodomesticos[9] = new Electrodomestico(1000, "GrIs", 'A', 100);

            //Acumulador de precio de Electrodomesticos, Television y Lavadora
            var precioElectrodomesticos = new double();
            var precioTelevision = new double();
            var precioLavadora = new double();

            // Recorrer Array y Ejecutar precioFinal()
            foreach (Electrodomestico electrodomestico in Electrodomesticos)
            {
                if (electrodomestico is Electrodomestico) precioElectrodomesticos += electrodomestico.precioFinal();
                if (electrodomestico is Television) precioTelevision += electrodomestico.precioFinal();
                if (electrodomestico is Lavadora) precioLavadora += electrodomestico.precioFinal();
            }

            // Mostrar Resultados
            Console.WriteLine($"El precio de los Electrodomesticos es de ${precioElectrodomesticos}");
            Console.WriteLine($"El precio de los Televisores es de ${precioTelevision}");
            Console.WriteLine($"El precio de las Lavadoras es de ${precioLavadora}");
        }
    }
}
