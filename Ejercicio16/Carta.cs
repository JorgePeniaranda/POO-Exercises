using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
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
            int[] listaNumerosEspaniol = { 0, 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
            int[] listaNumerosFrances = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            if (listaNumerosEspaniol.Contains(numero) || listaNumerosFrances.Contains(numero)) this.numero = numero;
            else this.numero = 0;
        }
        public void comprobarPalo(string palo)
        {
            string[] listaPalosEspaniol = { "oros", "copas", "espadas", "bastos" };
            string[] listaPalosFrances = { "diamantes", "picas", "corazones", "treboles" };

            if (listaPalosEspaniol.Contains(palo.ToLower()) || listaPalosFrances.Contains(palo.ToLower())) this.palo = palo.ToLower();
            else this.palo = "";
        }
    }
}
