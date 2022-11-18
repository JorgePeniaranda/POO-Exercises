using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Profesor : Persona
    {
        string materiaAsignada;
        bool disponibilidad;

        public string MateriaAsignada { get { return materiaAsignada; } }
        public bool Disponibilidad { get { return disponibilidad; } set { disponibilidad = value; } }

        public Profesor(string nombre, int edad, char sexo, string materiaAsignada = "", bool disponibilidad = true) : base(nombre, edad, sexo)
        {
            this.disponibilidad = (base.Asistencia && disponibilidad) ? true:false;
            asignarMateria(materiaAsignada);
        }

        public void asignarMateria(string materia)
        {
            Random rdn = new Random();
            string[] listaMaterias = { "matematicas", "filosofia", "fisica" };

            if (listaMaterias.Contains(materia.ToLower())) materiaAsignada = materia.ToLower();
            else materiaAsignada = listaMaterias[rdn.Next(listaMaterias.Length)];
        }
    }
}
