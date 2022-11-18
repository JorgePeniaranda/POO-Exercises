using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password[] arrayPasswords = new Password[5];
            for (int i = 0; i < arrayPasswords.Length; i++)
            {
                arrayPasswords[i] = new Password(20);
                System.Threading.Thread.Sleep(1); // Esto es para evitar que genere las mismas contraseñas
            }

            bool[] arrayBools = new bool[arrayPasswords.Length];
            for (int i = 0; i < arrayPasswords.Length; i++)
            {
                arrayBools[i] = arrayPasswords[i].esFuerte(arrayPasswords[i].Contrasenia);
            }

            // Mostrar datos

            Console.WriteLine("Lista de contraseñas y su seguridad:");
            for(int i = 0; i < arrayPasswords.Length; i++)
            {
                arrayBools[i] = arrayPasswords[i].esFuerte(arrayPasswords[i].Contrasenia);
                Console.WriteLine(arrayPasswords[i].Contrasenia + ": " + ((arrayBools[i]) ? "Es fuerte" : "NO es fuerte"));
            }

            Console.ReadKey();
        }
    }
}
