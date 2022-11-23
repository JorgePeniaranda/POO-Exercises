using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agendaTelefonica = new AgendaTelefonica();
            Contacto testContact = new Contacto("Test", 1122334455);

            for (int i = 0; i < 9; i++) agendaTelefonica.agregarContacto(new Contacto("Contacto" + i, 1122334455));
            agendaTelefonica.agregarContacto(testContact);
            agendaTelefonica.agregarContacto(testContact);
            Console.WriteLine();

            agendaTelefonica.existeContacto(testContact);
            agendaTelefonica.listarContactos();
            agendaTelefonica.buscaContacto("Test");
            agendaTelefonica.eliminarContacto(testContact);
            agendaTelefonica.agendaLlena();
            agendaTelefonica.huecosLibres();

            Console.ReadKey();
        }
    }
}
