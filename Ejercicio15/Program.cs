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
            
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Lista de Opciones:");
                    Console.WriteLine("1. Agregar Contacto");
                    Console.WriteLine("2. Existe Contacto");
                    Console.WriteLine("3. Mostrar Lista de Contactos");
                    Console.WriteLine("4. Buscar Contacto");
                    Console.WriteLine("5. Eliminar Contacto");
                    Console.WriteLine("6. Comprobar si agenda esta llena");
                    Console.WriteLine("7. Huecos libres");
                    Console.WriteLine("0. Salir");
                    Console.Write("Elige una de las opciones: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            agendaTelefonica.agregarContacto(userCreateContact());
                            break;
                        case 2:
                            agendaTelefonica.existeContacto(userCreateContact());
                            break;
                        case 3:
                            agendaTelefonica.listarContactos();
                            break;
                        case 4:
                            agendaTelefonica.buscaContacto(Console.ReadLine());
                            break;
                        case 5:
                            agendaTelefonica.eliminarContacto(userCreateContact());
                            break;
                        case 6:
                            agendaTelefonica.agendaLlena();
                            break;
                        case 7:
                            agendaTelefonica.huecosLibres();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Contacto userCreateContact()
            {
                Console.Write("Ingrese nombre del contacto: ");
                string nombreConntacto = Console.ReadLine();

                Console.Write("Ingrese numero del contacto: ");
                int numeroContacto = Convert.ToInt32(Console.ReadLine());

                return new Contacto(nombreConntacto, numeroContacto);
            }
        }
    }
}
