using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Asiento
    {
        char columna;
        int fila;
        bool disponibilidad;

        public char Columna { get { return columna; } }
        public int Fila { get { return fila; } }
        public bool Disponibilidad { get { return disponibilidad; } set { disponibilidad = value; } }

        public Asiento(char columna, int fila, bool disponibilidad)
        {
            this.columna = columna;
            this.fila = fila;
            this.disponibilidad = disponibilidad;
        }
    }
}
