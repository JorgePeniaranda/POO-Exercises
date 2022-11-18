using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta Persona = new Cuenta("PEPE", 200);

            if (Persona.Ingresar(1000)) Console.WriteLine("Se ingresó el dinero correctamente!");
            else Console.WriteLine("No se ingresó el dinero");

            if (Persona.Retirar(1201)) Console.WriteLine("Se retiro el dinero");
            else
            {
                Console.WriteLine("No se realizó");
                Console.WriteLine("Saldo Actual: $" + Persona.Cantidad);
            }

            Console.ReadKey();
        }
    }
}
