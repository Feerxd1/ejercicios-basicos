using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique la nota 1: ");
            float nota1 = float.Parse(Console.ReadLine());

            if (nota1 > 1 && nota1 <= 7)
            {
                Console.Write("El resultado esta en rango");
            }
            else
                Console.Write("esta fuera de rango");

            Console.ReadKey();
        }
    }

}