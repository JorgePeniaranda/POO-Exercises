using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Carta
    {
        int numero;
        string palo;

        public int Numero { get { return numero; } }
        public string Palo { get { return palo; } }

        public Carta(int numero, string palo)
        {
            comprobarNumero(numero);
            comprobarPalo(palo);
        }
        public void comprobarNumero(int numero)
        {
            Random rdn = new Random();
            int[] listaNumeros = { 0, 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

            if (listaNumeros.Contains(numero)) this.numero = numero;
            else this.numero = listaNumeros[rdn.Next(listaNumeros.Length)];
        }
        public void comprobarPalo(string palo)
        {
            Random rdn = new Random();
            string[] listaPalos = { "oros", "copas", "espadas", "bastos" };

            if (listaPalos.Contains(palo.ToLower())) this.palo = palo.ToLower();
            else this.palo = listaPalos[rdn.Next(listaPalos.Length)];
        }
    }
}
