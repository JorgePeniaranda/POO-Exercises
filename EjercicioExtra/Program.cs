using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mundial mundial = new Mundial(new List<string> { "Argentina", "Arabia", "Mexico", "Polonia" });
            mundial.jugarGrupos();

            Console.ReadKey();
        }
    }
}

// 