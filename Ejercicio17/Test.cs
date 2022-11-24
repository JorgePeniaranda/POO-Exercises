using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Test
    {
        List<Pregunta> preguntas;
        int puntos;

        public List<Pregunta> Preguntas { get { return preguntas; } }
        public int Puntos { get { return puntos; } }
        public Test(List<Pregunta> preguntas, int puntos)
        {
            this.preguntas = preguntas;
            this.puntos = puntos;
        }
        public bool comprobarRespuesta(string pregunta, int respuesta)
        {
            foreach (var preguntaFor in preguntas)
            {
                Console.WriteLine("preguntaFor.PreguntaTest == pregunta: " + preguntaFor.PreguntaTest == pregunta);
                Console.WriteLine("preguntaFor.RespuestaCorrecta == preguntaFor.Opciones[respuesta]: " + preguntaFor.RespuestaCorrecta == preguntaFor.Opciones[respuesta]);
                if (preguntaFor.PreguntaTest == pregunta && preguntaFor.RespuestaCorrecta == preguntaFor.Opciones[respuesta])
                {
                    puntos += 100;
                    Console.WriteLine("Correcto +100 puntos");
                    Console.WriteLine($"Tienes {puntos} puntos");
                    return true;
                }
            }
            puntos -= 50;
            Console.WriteLine("Incorrecto -50 puntos");
            Console.WriteLine($"Tienes {puntos} puntos");
            return false;
        }
    }
}
