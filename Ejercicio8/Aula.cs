using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio8
{
    internal class Aula
    {
        Estudiante[] estudiantes;
        Profesor docente;
        int id;
        int cantidadAlumnos;
        string aulaMateria;

        public Estudiante[] Estudiantes { get { return estudiantes; } }
        public Profesor Docente { get { return docente; } }
        public int ID { get { return id; } }
        public int CantidadAlumnos { get { return CantidadAlumnos; } }
        public string AulaMateria { get { return aulaMateria; } }

        public Aula(Estudiante[] estudiantes, Profesor[] docentes, int id, int cantidadAlumnos, string aulaMateria)
        {
            this.estudiantes = estudiantes;
            asignarMateriaAula(aulaMateria);
            asignarDocente(docentes);
            this.id = id;
            this.cantidadAlumnos = cantidadAlumnos;
        }
        void asignarMateriaAula(string aulaMateria)
        {
            Random rdn = new Random();
            string[] listaMaterias = { "matematicas", "filosofia", "fisica" };

            if (listaMaterias.Contains(aulaMateria.ToLower())) this.aulaMateria = aulaMateria.ToLower();
            else this.aulaMateria = listaMaterias[rdn.Next(listaMaterias.Length)];
        }
        void asignarDocente(Profesor[] profesores)
        {
            foreach (var prof in profesores)
            {
                if(prof.MateriaAsignada == this.aulaMateria && prof.Asistencia == true && prof.Disponibilidad == true)
                {
                    this.docente = prof;
                    prof.Disponibilidad = false;
                    break;
                }
            }
        }
        public bool hayClases()
        {
            int alumnosPresentes = 0;

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Asistencia) alumnosPresentes++;
            }

            if (alumnosPresentes * 100 / this.cantidadAlumnos > 50 && this.Docente != null) return true;
            else return false;
        }
        public List<Estudiante> aprobados(int minimoAprobado)
        {
            List<Estudiante> listaAprobados = new List<Estudiante>();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Calificacion >= minimoAprobado) listaAprobados.Add(estudiantes[i]);
            }
            return listaAprobados;
        }
        public List<Estudiante> desaprobados(int minimoAprobado)
        {
            List<Estudiante> listaDesaprobados = new List<Estudiante>();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Calificacion < minimoAprobado) listaDesaprobados.Add(estudiantes[i]);
            }
            return listaDesaprobados;
        }
    }
}
