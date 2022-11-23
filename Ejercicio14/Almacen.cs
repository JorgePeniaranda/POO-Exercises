using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Almacen
    {
        List<List<Bebidas>> estanteria = new List<List<Bebidas>>();
        public Almacen(int cantidadColumnas)
        {
            for (int i = 0; i < cantidadColumnas; i++)
            {
                estanteria.Add(new List<Bebidas>());
            }
        }
        public Almacen(List<List<Bebidas>> estanteria)
        {
            this.estanteria = estanteria;
        }
        public double calcularPrecioTotal()
        {
            double precioTotal = 0;
            foreach (var estante in estanteria)
            {
                for (int i = 0; i < estante.Count; i++)
                {
                    precioTotal += estante[i].Precio;
                }
            }
            return precioTotal;
        }
        public double calcularPrecioMarca(string marca)
        {
            double precioTotal = 0;
            foreach (var estante in estanteria)
            {
                for (int i = 0; i < estante.Count; i++)
                {
                    if (estante[i].Marca == marca) precioTotal += estante[i].Precio;
                }
            }
            return precioTotal;
        }
        public double calcularPrecioColumna(int columna)
        {
            double precioTotal = 0;
            if (columna > estanteria.Count || columna < 0) return 0;
            else
            {
                foreach (var estante in estanteria)
                {
                    precioTotal += estante[columna].Precio;
                }
                return precioTotal;
            }
        }
        public void agregarProducto(Bebidas bebida)
        {
            int cantFilas = estanteria[0].Count;
            List<Bebidas> estanteriaEspacioLibre = estanteria[0];

            foreach (var estante in estanteria)
            {
                if (estante.Count < cantFilas)
                {
                    cantFilas = estante.Count;
                    estanteriaEspacioLibre = estante;
                }
            }

            estanteria[estanteria.IndexOf(estanteriaEspacioLibre)].Add(bebida);
        }
        public void eliminarProducto(int id)
        {
            foreach (var estante in estanteria)
            {
                for (int i = 0; i < estante.Count; i++)
                {
                    if (estante[i].ID == id) estanteria[estanteria.IndexOf(estante)].Remove(estante[i]);
                }
            }
        }
        public void mostrarInformacion()
        {
            foreach (var estante in estanteria)
            {
                Console.WriteLine("Fila " + estanteria.IndexOf(estante));
                for (int i = 0; i < estante.Count; i++)
                {
                    Console.WriteLine($"    {estante[i].Marca}");
                    Console.WriteLine($"        ID: {estante[i].ID}");
                    Console.WriteLine($"        Litros: {estante[i].Litros}");
                    Console.WriteLine($"        Precio: {estante[i].Precio}");
                }
                Console.WriteLine();
            }
        }
    }
}
