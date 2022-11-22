using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12A
{
    internal class Revolver
    {
        int posicionActual = 1;
        int posicionBala;
        static Random rdn = new Random();
        public Revolver()
        {
            posicionBala = posicionRandomBala();
        }
        public Revolver(int posicionBala)
        {
            this.posicionBala = posicionBala;
        }
        public int posicionRandomBala()
        {
            return rdn.Next(1, 6);
        }
        public void comprobarPosicionBala(int posicionBala)
        {
            if (posicionBala > 0 && posicionBala < 7) this.posicionBala = posicionBala;
            else this.posicionActual = rdn.Next(1, 6);
        }
        public bool disparar()
        {
            if (posicionActual == posicionBala) return true;
            else return false;
        }
        public void siguienteBala()
        {
            posicionActual++;
        }
        public void mostrarRevolver()
        {
            Console.WriteLine("Revolver:");
            Console.WriteLine("    El tambor se encuentra en " + posicionActual);
            Console.WriteLine("    La bala se encuentra en " + posicionBala);
        }
    }
}
