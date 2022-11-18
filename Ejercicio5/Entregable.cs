using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        byte compareTo(Object e);
    }
}
