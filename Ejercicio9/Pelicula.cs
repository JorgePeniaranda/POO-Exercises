using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Pelicula
    {
        string titulo;
        int duracion; // En minutos
        int edadMinima;
        string director;

        public string Titulo { get { return titulo; } }
        public int Duracion { get { return duracion; } }
        public int EdadMinima { get { return edadMinima; } }
        public string Director { get { return director; } }

        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima= edadMinima;
            this.director = director;
        }
    }
}
