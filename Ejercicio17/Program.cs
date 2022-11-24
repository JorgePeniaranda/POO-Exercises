using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static Random rdn = new Random();
        static void Main(string[] args)
        {
            Pregunta pregunta1 = new Pregunta("¿Cual es la capital de España?", "Madrid", new List<string> { "Paris", "Madrid", "Lisboa", "Londres" });
            Pregunta pregunta2 = new Pregunta("¿Cual de estos animales es mamifero?", "Ballena", new List<string> { "Ballena", "Pulpo", "Anguila" });
            Pregunta pregunta3 = new Pregunta("¿El rubius tiene mas de 20 millones de suscriptores?", "Verdadero", new List<string> { "Verdadero", "Falso" });

            List<Pregunta> listaPreguntas = new List<Pregunta>() { pregunta1, pregunta2, pregunta3 };
            
            Test test = new Test(listaPreguntas, 0);

            Console.ReadKey();

            Pregunta pregunta = null;
            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba una opcion:");
                    Console.WriteLine(";P; <- Pregunta");
                    Console.WriteLine(";R;[Opcion] <- Respuesta");
                    Console.Write(">");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case ";P;":
                            pregunta = test.Preguntas[rdn.Next(test.Preguntas.Count)];
                            pregunta.mostrarPregunta();
                            break;
                        case ";R;0":
                            test.comprobarRespuesta(pregunta.PreguntaTest, 0);
                            break;
                        case ";R;1":
                            test.comprobarRespuesta(pregunta.PreguntaTest, 1);
                            break;
                        case ";R;2":
                            test.comprobarRespuesta(pregunta.PreguntaTest, 2);
                            break;
                        case ";R;3":
                            test.comprobarRespuesta(pregunta.PreguntaTest, 3);
                            break;
                        case ";R;4":
                            test.comprobarRespuesta(pregunta.PreguntaTest, 4);
                            break;
                        case ";R;5":
                            test.comprobarRespuesta(pregunta.PreguntaTest, 5);
                            break;
                        default:
                            return;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
