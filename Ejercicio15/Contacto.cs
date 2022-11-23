using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Contacto
    {
        string nombre;
        int telefono;
        public string Nombre { get { return nombre; } }
        public int Telefono { get { return telefono; } }
        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
    }
}
