using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Password
    {
        int longitud = 8;
        string contrasenia = string.Empty;
        static Random rdn = new Random();

        public int Longitud { set { longitud = value; } get { return longitud; } }
        public string Contrasenia { get { return contrasenia; } }

        public Password()
        {

        }
        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contrasenia = generarPassword(this.longitud);
        }
        public bool esFuerte(string contraseniaComprobar)
        {
            int cantMayus = 0;
            int cantMinus = 0;
            int cantNum = 0;
            foreach (char charContrasenia in contraseniaComprobar)
            {
                if ((int)charContrasenia > 65 && (int)charContrasenia < 90) cantMayus++;
                if ((int)charContrasenia > 97 && (int)charContrasenia < 122) cantMinus++;
                if ((int)charContrasenia > 48 && (int)charContrasenia < 57) cantNum++;
            }

            if (cantMayus > 2 && cantMinus > 1 && cantNum > 5) return true;
            else return false;
        }
        public string generarPassword(int longitud)
        {
            string caracteres = "abcdefABCDEF1234567."; // Se puede aumentar a los caracteres que desee que contenga la contraseña (lo reduje porque no cumplia casi nunca la condicion con la lista de caracteres completa)
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitud; i++)
            {
                contraseniaAleatoria += caracteres[rdn.Next(longitud)].ToString();
            }
            return contraseniaAleatoria;
        }
    }
}
