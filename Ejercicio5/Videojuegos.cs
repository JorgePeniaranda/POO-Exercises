using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Videojuegos : Entregable
    {
        string titulo = "";
        int horasEstimadas = 10;
        bool entregado = false;
        string genero = "";
        string compania = "";

        public string Titulo { set { titulo = value; } get { return titulo; } }
        public int HorasEstimadas { set { horasEstimadas = value; } get { return horasEstimadas; } }
        public string Genero { set { genero = value; } get { return genero; } }
        public string Compania { set { compania = value; } get { return compania; } }

        public Videojuegos()
        {

        }
        public Videojuegos(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
        }
        public Videojuegos(string titulo, int horasEstimadas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            this.genero = genero;
            this.compania = compania;
        }

        // Interfaces
        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
        public byte compareTo(object e)
        {
            Videojuegos videojuego = (Videojuegos)e;

            if (this.horasEstimadas > videojuego.horasEstimadas) return 0; // Este videojuego tiene mas horas que el otro
            else if (this.horasEstimadas == videojuego.horasEstimadas) return 1; // Este videojuego tiene las mismas horas que el otro
            else return 2; // Este videojuego no tiene mas horas que el otro
        }
    }
}
