using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Series : Entregable
    {
        string titulo = "";
        int numeroTemporadas = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";

        public string Titulo { set { titulo = value; } get { return titulo; } }
        public int NumeroTemporadas { set { numeroTemporadas = value; } get { return numeroTemporadas; } }
        public string Genero { set { genero = value; } get { return genero; } }
        public string Creador { set { creador = value; } get { return creador; } }

        public Series()
        {

        }
        public Series(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }
        public Series(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
            this.creador = creador;
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
            Series serie = (Series)e;

            if (this.numeroTemporadas > serie.numeroTemporadas) return 0; // Esta serie tiene mas temporadas que el otro
            else if (this.numeroTemporadas == serie.numeroTemporadas) return 1; // Esta serie tiene las mismas temporadas que el otro
            else return 2; // Esta serie no tiene mas temporadas que el otro
        }
    }
}
