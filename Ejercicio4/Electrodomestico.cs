using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Electrodomestico
    {
        private double precioBase = 100;
        private string color = "Blanco";
        private char consumoEnergetico = 'F';
        private double peso = 5;

        public double PrecioBase { get { return precioBase; } set { precioBase = value; } }
        public string Color { get { return color; } set { color = value; } }
        public char ConsumoEnergetico { get { return consumoEnergetico; } set { consumoEnergetico = value; } }
        public double Peso { get { return peso; } set { peso = value; } }

        public Electrodomestico()
        {

        }
        public Electrodomestico(int precio, double peso)
        {
            this.precioBase = precio;
            this.peso = peso;
        }
        public Electrodomestico(int precio, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precio;
            comprobarColor(color);
            comprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }
        private void comprobarConsumoEnergetico(char letra)
        {
            char[] categorias = { 'A', 'B', 'C', 'D', 'E', 'F' }; // Agregar mas categorias en caso de ser necesario
            if (categorias.Contains(letra)) consumoEnergetico = letra;
        }
        private void comprobarColor(string color)
        {
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" }; // Agregar mas colores en caso de ser necesario (en minuscula)
            if (colores.Contains(color.ToLower())) this.color = color;
        }
        public virtual double precioFinal()
        {
            double finalPrice = this.precioBase;

            // Segun Letra
            switch (this.consumoEnergetico)
            {
                case 'A':
                    finalPrice += 100;
                    break;
                case 'B':
                    finalPrice += 80;
                    break;
                case 'C':
                    finalPrice += 60;
                    break;
                case 'D':
                    finalPrice += 50;
                    break;
                case 'E':
                    finalPrice += 30;
                    break;
                case 'F':
                    finalPrice += 10;
                    break;
            }

            // Segun Tamaño
            if (this.peso > -1 && this.peso < 20) finalPrice += 10;
            else if (this.peso > 19 && this.peso < 50) finalPrice += 50;
            else if (this.peso > 49 && this.peso < 80) finalPrice += 80;
            else if (this.peso > 79) finalPrice += 100;

            return finalPrice;
        }
    }
}
