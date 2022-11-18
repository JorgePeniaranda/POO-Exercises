using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Estudiante : Persona
    {
        byte calificacion;

        public byte Calificacion { get { return calificacion; } }

        public Estudiante(string nombre,int edad,char sexo) : base(nombre, edad, sexo)
        {
            asignarCalificacion();
        }
        public void asignarCalificacion()
        {
            Random rdn = new Random();
            calificacion = Convert.ToByte(rdn.Next(1, 11));
        }
    }
}
