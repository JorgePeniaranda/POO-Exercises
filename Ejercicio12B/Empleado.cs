using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12B
{
    internal abstract class Empleado
    {
        string nombre;
        int edad;
        int salario;
        const int plus = 300;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Salario { get { return salario; } set { salario = value; } }
        public int Plus { get { return plus; } }
        public Empleado(string nombre, int edad, int salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }
    }
}
