using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ejercicio9
{
    internal class Sala
    {
        int idSala;
        List<List<Asiento>> asientos;
        Pelicula pelicula;
        int precioEntrada;

        public int IDSala { get { return idSala; } }
        public List<List<Asiento>> Asientos { get { return asientos; } }

        public Sala(int idSala, int cantidadFilas, int cantidadColumnas, Pelicula pelicula, int precioEntrada)
        {
            this.idSala = idSala;
            generarAsientos(cantidadFilas, cantidadColumnas);
            this.pelicula = pelicula;
            this.precioEntrada = precioEntrada;
        }
        public void generarAsientos(int cantidadFilas, int cantidadColumnas)
        {
            List<List<Asiento>> asientos= new List<List<Asiento>>();
            string caracteresAsientos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            for (int F = 0; F < cantidadFilas; F++)
            {
                List<Asiento> fila= new List<Asiento>();
                for (int C = 0; C < cantidadColumnas; C++)
                {
                    fila.Add(new Asiento(caracteresAsientos[C], F + 1, true));
                }
                asientos.Add(fila);
            }
            this.asientos = asientos;
        }
        public void agregarPersona(Espectador espectador)
        {
            Random rdn0 = new Random();
            System.Threading.Thread.Sleep(1); // Esto es para evitar que genere distintos valores
            Random rdn1 = new Random();
            System.Threading.Thread.Sleep(1); // Esto es para evitar que genere distintos valores


            if (this.asientos[rdn0.Next(0, asientos.Count)][rdn1.Next(0, asientos[0].Count)].Disponibilidad && espectador.Edad >= this.pelicula.EdadMinima && espectador.DineroActual >= this.precioEntrada)
            {
                this.asientos[rdn0.Next(0, asientos.Count)][rdn1.Next(0, asientos[0].Count)].Disponibilidad = false;
            }
            else if (espectador.Edad < this.pelicula.EdadMinima || espectador.DineroActual < this.precioEntrada) Console.WriteLine("No se pudo agregar a " + espectador.Nombre);
            else agregarPersona(espectador); // Perdon profe por este crimen contra la informatica
        }
        public void agregarPersona(Espectador espectador, char fila, int columna)
        {
            string caracteresAsientos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            if (caracteresAsientos.IndexOf(fila) != -1) asientos[columna][caracteresAsientos["ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".IndexOf(fila)]].Disponibilidad = false;
            else agregarPersona(espectador);
        }
    }
}
