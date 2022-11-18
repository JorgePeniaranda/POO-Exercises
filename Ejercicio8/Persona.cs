using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Persona
    {
        string nombre;
        char sexo;
        int edad;
        bool asistencia;

        public string Nombre { get { return nombre; } }
        public char Sexo { get { return sexo; } }
        public int Edad { get { return edad; } }
        public bool Asistencia { get { return asistencia; } }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            comprobarSexo(sexo);
            this.edad = edad;
            probabilidadAsistencia();
        }
        void comprobarSexo(char sexo)
        {
            Random rdn = new Random();

            if (sexo == 'H' || sexo == 'h') sexo = 'H';
            else if (sexo == 'M' || sexo == 'm') sexo = 'M';
            else sexo = ((rdn.Next(1, 3) == 1) ? 'H':'M');
        }
        void probabilidadAsistencia()
        {
            Random rdn = new Random();
            int probabilidad = rdn.Next(1, 101);

            if (probabilidad < 11 && this is Estudiante) asistencia = false;
            else if (probabilidad < 21 && this is Profesor) asistencia = false;
            else asistencia = true;
        }
    }
}
