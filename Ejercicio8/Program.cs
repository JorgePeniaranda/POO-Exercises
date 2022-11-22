using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            Estudiante[] estudiantes = new Estudiante[30];
            Profesor[] profesores = new Profesor[5];

            // Generar Estudiantes y Docentes
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante("Estudiante" + i, rdn.Next(1, 19), 'H');
                System.Threading.Thread.Sleep(1); // Esto es para datos random
            }
            for (int i = 0; i < profesores.Length; i++)
            {
                profesores[i] = new Profesor("Profesor" + i, rdn.Next(25, 80), 'H');
                System.Threading.Thread.Sleep(1); // Esto es para evitar que genere profesores con la misma materia
            }


            // Crear Aula
            Aula aula = new Aula(estudiantes, profesores, 214, 30, "Matematicas");


            // Lista Profesores
            Console.WriteLine("Profesores:");
            for (int i = 0; i < profesores.Length; i++)
            {
                Console.WriteLine("    " + profesores[i].Nombre + " -> " + profesores[i].MateriaAsignada + ", " + ((profesores[i].Asistencia) ? "Asistio" : "Falto") + ", " + ((profesores[i].Disponibilidad) ? "Disponible" : "No Disponible"));
            }

            // Lista Alumnos
            Console.WriteLine("Alumnos:");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("    " + estudiantes[i].Nombre + " -> " + ((estudiantes[i].Asistencia) ? "Asistio" : "Falto"));
            }

            // ¿Hay clases?
            Console.WriteLine();
            Console.WriteLine((aula.hayClases()) ? "Hay clases" : "NO hay clases");
            Console.WriteLine();

            // Evaluar si hay clases
            if (aula.hayClases())
            {
                Console.WriteLine("Nota Alumnos:");
                for (int i = 0; i < estudiantes.Length; i++)
                {
                    Console.WriteLine("    " + estudiantes[i].Nombre + " -> " + ((estudiantes[i].Calificacion >= 6) ? "Aprobo" : "Reprobo"));
                }
                Console.WriteLine();
                Console.WriteLine("Aprobaron " + aula.aprobados(6).Count + " y reprobaron " + aula.desaprobados(6).Count);
            }

            Console.ReadKey();
        }
    }
}
