using System;

public class recorrerArray{
    
    public static void Main(){
        
        int[] arrayNumeros = {1,2,456,35,1,6,8,7895}; //definimos el array, el cual solo va a ser de números
        foreach (int i in arrayNumeros)
        {
            System.Console.WriteLine(i);
        }

        string[] nombres = {"One", "Punch", "Man"};//un array formado por strings
        foreach (string cadena in nombres)
        {
            System.Console.WriteLine(cadena);
        }


        bool[] booleano = {true,false,false,true};// un array de booleanos
        foreach (bool cadaBool in booleano)
        {
           System.Console.WriteLine(cadaBool);
        }
        
        //Una matriz multidimensional
        
        int[,] numeros = new int[3, 2] {{9, 99}, {3, 33}, {5, 55}};
        foreach(int i in numeros)
        {
           Console.Write("{0} ", i);
        }
        
    }
    
}