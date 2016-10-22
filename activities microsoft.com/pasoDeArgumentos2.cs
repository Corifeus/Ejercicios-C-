// cmdline1.cs
// arguments: A B C
using System;

public class lineaComandos
{
   public static void Main(string[] vars)
   {
       // Usamos length para obtener la longitud del array
       
       Console.WriteLine("Número de parametros = {0}",
          vars.Length);
       for(int i = 0; i < vars.Length; i++)
       {
           Console.WriteLine("Argumento[{0}] = [{1}]", i, vars[i]);
       }
   }
}