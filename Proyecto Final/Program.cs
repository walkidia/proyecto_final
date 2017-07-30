using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Su nombre es " + nombre);

            Console.WriteLine("Presione una tecla para salir!");
            Console.ReadLine();
        }
    }
}
