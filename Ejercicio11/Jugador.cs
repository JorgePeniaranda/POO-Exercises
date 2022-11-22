using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Jugador
    {
        string nombre;
        int dinero;
        List<Apostar> apuestas = new List<Apostar>();
        int cantidadAciertos = 0;

        public string Nombre { get { return nombre; } }
        public int Dinero { get { return dinero; } }
        public List<Apostar> Apuestas { get { return apuestas; } }
        public int CantidadAciertos { get { return cantidadAciertos; } set { cantidadAciertos = value; } }

        public Jugador(string Nombre, int dineroInicial)
        {
            nombre = Nombre;
            dinero = dineroInicial;
        }
        public void apostar(string fase,string equipoGanador)
        {
            equipoGanador = comprobarEquipo(equipoGanador);
            List<string> fases = new List<string> { "O", "C", "SF", "F" };
            string[] fasesNombres = { "Octavos de Final", "Cuartos de Final", "SemiFinal", "Final" };

            // O: Octavos
            // C: Cuartos
            // SF: SemiFinal
            // F; Final

            bool yaAposto = false;
            for (int i = 0; i < apuestas.Count; i++)
            {
                if (apuestas[i].EquipoGanador == equipoGanador) yaAposto = true;
                if (apuestas[i].Fase == fase) yaAposto = true;
            }

            if (equipoGanador == "")
            {
                Console.WriteLine("ingrese correctamente el equipo para apostar");
            }
            else if (!fases.Contains(fase))
            {
                Console.WriteLine("ingrese correctamente la fase para apostar");
            }
            else if (yaAposto)
            {
                Console.WriteLine(nombre + ", ya apostaste en esta fase");
            }
            else
            {
                apuestas.Add(new Apostar(fase, equipoGanador));
                Console.WriteLine(nombre + " aposto por " + equipoGanador + " en " + fasesNombres[fases.IndexOf(fase)]);
                dinero--;
            }
        }
        public string comprobarEquipo(string equipoTest)
        {
            string[] listaEquipos = { "QAT", "SEN", "HOL", "ECU", "ENG", "IRN", "USA", "WAL", "ARG", "KSA", "MEX", "POL", "FRA", "DEN", "TUN", "AUS", "ESP", "GER", "JPN", "CRC", "BEL", "MAR", "CRO", "CAN", "BRA", "SRB", "SUI", "CMR", "POR", "URU", "KOR", "GHA" };

            if (listaEquipos.Contains(equipoTest.ToUpper()))
            {
                return equipoTest.ToUpper();
            }
            else
            {
                return "";
            }
        }
        public void agregarDinero(int cantidad)
        {
            dinero += cantidad;
        }
    }
}
