using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pido datos al usuario

            Console.Write("Ingrese Nombre: ");
            string userName = Console.ReadLine();

            Console.Write("Ingrese Edad: ");
            byte userAge = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese Sexo: ");
            char userSex = Convert.ToChar(Console.ReadLine());

            Console.Write("Ingrese Peso: ");
            double userWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese Altura: ");
            double userHeight = Convert.ToDouble(Console.ReadLine());

            // Creo objetos

            Persona userPersona1 = new Persona(userName, userAge, userSex, userWeight, userHeight);
            Persona userPersona2 = new Persona(userName, userAge, userSex);
            Persona setPersona = new Persona();

            // Ingreso datos por set

            setPersona.Nombre = "Pepe";
            setPersona.Edad = 16;
            setPersona.Sexo = 'H';
            setPersona.Peso = 60;
            setPersona.Altura = 1.70;

            // Compruebo peso ideal a cada objeto

            CalcularPersonaIMC(userPersona1);
            CalcularPersonaIMC(userPersona2);
            CalcularPersonaIMC(setPersona);

            // Compruebo edad de cada objeto

            userPersona1.esMayorDeEdad();
            userPersona2.esMayorDeEdad();
            setPersona.esMayorDeEdad();

            // Muestro informacion de cada objeto

            userPersona1.toString();
            userPersona2.toString();
            setPersona.toString();

            void CalcularPersonaIMC(Persona personaCalcular)
            {
                if (personaCalcular.calcularIMC() == -1) Console.WriteLine($"{personaCalcular.Nombre} esta debajo de su peso ideal");
                else if (personaCalcular.calcularIMC() == 1) Console.WriteLine($"{personaCalcular.Nombre} esta en su peso ideal");
                else if (personaCalcular.Peso == 0 || personaCalcular.Altura == 0) Console.WriteLine($"{personaCalcular.Nombre} le faltan datos");
                else Console.WriteLine($"{personaCalcular.Nombre} esta por encima de su peso ideal");
            }
        }
    }
}
