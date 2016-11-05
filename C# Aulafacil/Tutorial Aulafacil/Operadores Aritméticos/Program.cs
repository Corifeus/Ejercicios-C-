using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 3;
            float resultado;

            resultado = (float)a / (float)b;

            Console.WriteLine("El resultado es " + resultado);
            Console.ReadKey();
        }
    }
}
