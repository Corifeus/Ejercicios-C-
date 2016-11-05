using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_Pares_e_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion=2;
            while (eleccion != 0)
            {
              Console.WriteLine("Introduce un número para saber si es par o impar,escribe 0 para parar");
              eleccion = Convert.ToInt32(Console.ReadLine());
                
                if (eleccion != 0)
                {
                     if (eleccion % 2 == 0)
                     {
                         Console.WriteLine("Es par");
                     }else{
                         Console.WriteLine("Es impar");
                     }
                }

            }
        }
    }
}
