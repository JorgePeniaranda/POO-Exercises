using System;
using System.Collections.Generic;

namespace Ejercicio15
{
    internal class AgendaTelefonica
    {
        List<Contacto> contactos = new List<Contacto>();
        int tamanio = 10;

        public List<Contacto> Contactos { get { return contactos; } }
        public int Tamanio { get { return tamanio; } }
        public AgendaTelefonica()
        {

        }
        public AgendaTelefonica(int tamanio)
        {
            this.tamanio = tamanio;
        }
        public void agregarContacto(Contacto c)
        {
            if (contactos.Count < tamanio)
            {
                contactos.Add(c);
                Console.WriteLine($"Se agrego a {c.Nombre} a la lista de contactos");
            }
            else agendaLlena();
        }
        public void existeContacto(Contacto c)
        {
            bool existe = false;
            foreach (Contacto contacto in contactos) if (contacto == c) existe = true;

            if (existe) Console.WriteLine("SI existe el contacto " + c.Nombre);
            else Console.WriteLine("NO existe el contacto " + c.Nombre);
        }
        public void listarContactos()
        {
            Console.WriteLine("Contactos:");
            foreach (var contacto in contactos)
            {
                Console.WriteLine($"    - {contacto.Nombre} {contacto.Telefono}");
            }
        }
        public void buscaContacto(string nombre)
        {
            Contacto contactoEncontrado = null;
            foreach (var contacto in contactos)
            {
                if (contacto.Nombre == nombre) contactoEncontrado = contacto;
            }
            if (contactoEncontrado != null) Console.WriteLine($"Se encontro a {nombre} el numero es {contactoEncontrado.Telefono}");
            else Console.WriteLine($"NO se encontro a {nombre}");
        }
        public void eliminarContacto(Contacto c)
        {
            bool seEncontro = false;
            foreach (var contacto in contactos)
            {
                if (contacto == c) seEncontro = true;
            }

            if (seEncontro)
            {
                contactos.Remove(c);
                Console.WriteLine("Se elimino a " + c.Nombre);
            }
            else Console.WriteLine(c.Nombre + " NO se encontro en la lista de contactos");
        }
        public void agendaLlena()
        {
            if (contactos.Count == 10) Console.WriteLine("Tienes la agenda llena");
            else Console.WriteLine("No tienes la agenda llena");
        }
        public void huecosLibres()
        {
            int cantHuecosLibres = tamanio - contactos.Count;
            if (cantHuecosLibres > 0) Console.WriteLine($"Tienes {cantHuecosLibres} huecos libres en la agenda");
            else Console.WriteLine("NO tienes huecos libres en la agenda");
        }
    }
}
