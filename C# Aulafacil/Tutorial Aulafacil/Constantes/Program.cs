using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const int ruedas = 4;
            const int espejos = 2;

            //Variables
            int coches = 5;

            //Declaración de dos variables en la misma línea
            int totalRuedas, totalEspejos;

            //operaciones
            totalRuedas = ruedas * coches;
            totalEspejos = espejos * coches;

            //sacamos el resultado por pantalla
            Console.WriteLine("Total Ruedas:" + totalRuedas);
            Console.WriteLine("Total Espejos:" + totalEspejos);
            Console.ReadKey();
        }
    }
}
