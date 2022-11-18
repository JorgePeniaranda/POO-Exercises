using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Libro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private int numeroPaginas;

        public int ISBN { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public int NumeroPaginas { get { return numeroPaginas; } set { numeroPaginas = value; } }

        public Libro(int pISBN, String pTitulo, String pAutor, int pNumPaginas)
        {
            this.isbn = pISBN;
            this.titulo = pTitulo;
            this.autor = pAutor;
            this.numeroPaginas = pNumPaginas;
        }
    }
}
