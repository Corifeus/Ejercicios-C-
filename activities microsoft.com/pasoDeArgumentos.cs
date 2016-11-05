// Paso de argumentos
//Los argumentos los pasaremos al ejecutar un archivo
using System;

public class pasarArgumentos
{
   public static void Main(string[] variables)
   {
      Console.WriteLine("Bienvenido");
      Console.WriteLine("Has introducido {0} comandos:",
         variables.Length );
      for (int i=0; i < variables.Length; i++)
      {
         Console.WriteLine("{0}", variables[i]); 
      }
   }
}