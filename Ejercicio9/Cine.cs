using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Cine
    {
        List<Sala> salas;

        public List<Sala> Salas { get { return salas; } set { salas = value; } }

        public Cine(List<Sala> salas) // Para hacerlo mas dinamico pase el precio y la pelicula a clase sala
        {
            this.salas = salas;
        }
    }
}
