using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12A
{
    internal class Jugador
    {
        int id;
        string nombre;
        bool vivo = true;

        public int ID { get { return id; } }
        public string Nombre { get { return nombre; } }
        public bool Vivo { get { return vivo; } }
        public Jugador(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public bool disparar(Revolver r)
        {
            if (r.disparar())
            {
                Console.WriteLine(Nombre + " murio");
                vivo = false;
                return true;
            }
            else
            {
                Console.WriteLine("La bala no salio");
                r.siguienteBala();
                return false;
            };
        }
    }
}
