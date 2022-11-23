using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Productos
    {
        string nombre;
        int precio;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Precio { get { return precio; } set { precio = value; } }
        public Productos(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public virtual int Calcular(int cantidad)
        {
            return precio * cantidad;
        }
    }
}
