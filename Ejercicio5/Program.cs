using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Cree un programa de consola que solicite al cliente la cantidad de notas que quiere promediar, 
 * luego el programa debe solicitar dicha cantidad de notas para promediarlas. Finalmente debe mostrar por 
 * pantalla el resultado del promedio e indicar si el alumno aprobó o reprobó la asignatura. */

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.Write("Indique el numero 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("El resultado es un numero ");
            if (num1 % 2 == 0)
                Console.Write("Par");
            else
                Console.Write("Impar");

            Console.ReadKey();
        }
    }
}
