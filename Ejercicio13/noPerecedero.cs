using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class noPerecedero : Productos
    {
        string tipo;
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public noPerecedero(string nombre, int precio, string tipo) : base(nombre, precio)
        {
            this.tipo = tipo;
        }
    }
}
