using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebidas nihuil = new Bebidas(1, .8, 200, "nihuil");
            Bebidas smartwater = new Bebidas(2, 1.5, 220, "Smart Water");
            Bebidas villavicencio = new Bebidas(3, 2, 150, "Villavicencio");

            bebidasAzucaradas fanta = new bebidasAzucaradas(4, 2, 120, "Fanta", 30, true);
            bebidasAzucaradas sprite = new bebidasAzucaradas(5, 2, 180, "Sprite", 30, true);
            bebidasAzucaradas cocacola = new bebidasAzucaradas(6, 2, 200, "Coca-Cola", 30, true);

            Bebidas bebidaGenerica1 = new Bebidas(7, .8, 70, "Bebida Generica v1");
            Bebidas bebidaGenerica2 = new Bebidas(8, 1, 80, "Bebida Generica v2");
            Bebidas bebidaGenerica3 = new Bebidas(9, 2, 90, "Bebida Generica v3");

            bebidasAzucaradas cocacola1 = new bebidasAzucaradas(10, .5, 80, "Coca-Cola", 30, true);
            bebidasAzucaradas cocacola2 = new bebidasAzucaradas(20, 1, 100, "Coca-Cola", 30, true);

            List<Bebidas> estante1 = new List<Bebidas>() { nihuil, smartwater, villavicencio };
            List<Bebidas> estante2 = new List<Bebidas>() { fanta, sprite, cocacola };
            List<Bebidas> estante3 = new List<Bebidas>() { bebidaGenerica1, bebidaGenerica2, bebidaGenerica3 };
            List<Bebidas> estante4 = new List<Bebidas>() { cocacola1, cocacola2 };

            List<List<Bebidas>> estanteria = new List<List<Bebidas>>() { estante1, estante2, estante3, estante4};

            Almacen almacen = new Almacen(estanteria);

            almacen.mostrarInformacion();
            Console.WriteLine("Precio de todas las bebidas: " + almacen.calcularPrecioTotal());
            Console.WriteLine("Precio de las bebidas Coca-Cola: " + almacen.calcularPrecioMarca("Coca-Cola"));
            Console.WriteLine("Precio de la columna 1: " + almacen.calcularPrecioColumna(1));

            almacen.agregarProducto(new bebidasAzucaradas(99, 9, 999, "Coca-Cola", 99, true));
            almacen.mostrarInformacion();

            almacen.eliminarProducto(99);
            almacen.mostrarInformacion();
        }
    }
}
