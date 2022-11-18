using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Persona
    {
        private string nombre = "";
        private byte edad = 0;
        private uint DNI;
        private char sexo = 'H';
        private double peso = 0;
        private double altura = 0;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public byte Edad { set { edad = value; } }
        public char Sexo { set { sexo = value; comprobarSexo(); } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }

        public Persona()
        {

        }
        public Persona(string nombre, byte edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            generaDNI();
            this.sexo = sexo;
            comprobarSexo();
        }
        public Persona(string nombre, byte edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            generaDNI();
            this.sexo = sexo;
            comprobarSexo();
            this.peso = peso;
            this.altura = altura;
        }
        public sbyte calcularIMC()
        {
            if (this.peso / (this.altura * this.altura) < 20) return -1; // Debajo de su peso ideal
            else if (this.peso / (this.altura * this.altura) > 19 && this.peso / (this.altura * this.altura) < 26) return 1; // En su peso ideal
            else return 0; // Por encima de su peso ideal
        }
        public bool esMayorDeEdad()
        {
            if (this.edad > 17) return true;
            else return false;
        }
        private void comprobarSexo()
        {
            if (this.sexo == 'H' || this.sexo == 'M') this.sexo = sexo;
            else this.sexo = 'H';
        }
        public void toString()
        {
            Console.WriteLine(this.nombre);
            Console.WriteLine($"  Edad: {this.edad}");
            Console.WriteLine($"  DNI: {this.DNI}");
            Console.WriteLine($"  Peso: {this.peso}");
            Console.WriteLine($"  Sexo: {this.sexo}");
            Console.WriteLine($"  Altura: {this.altura}");
        }
        private void generaDNI()
        {
            var random = new Random();
            uint value = Convert.ToUInt32(random.Next(1000000, 9999999));
            this.DNI = value;
        }
    }
}
