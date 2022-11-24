using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Pregunta
    {
        string pregunta;
        List<string> opciones = new List<string>();
        string respuestaCorrecta;

        public string PreguntaTest { get { return pregunta; } }
        public List<string> Opciones { get { return opciones; } }
        public string RespuestaCorrecta { get { return respuestaCorrecta; } }
        public Pregunta(string pregunte, string respuestaCorrecta, List<string> opciones)
        {
            this.pregunta = pregunte;
            this.opciones = opciones;
            this.respuestaCorrecta = respuestaCorrecta;
        }
        public void mostrarPregunta()
        {
            Console.WriteLine(pregunta);
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine(i + ". " + opciones[i]);
            }
        }
    }
}
