// propiedades.cs
using System;
class Persona
{
    private string miNombre ="N/A";
    private int miEdad = 0;

    //Declaramos el nombre
    public string Nombre
    {
        get 
        {
           return miNombre; 
        }
        set 
        {
           miNombre = value; 
        }
    }

    // Declaramos la edad:
    public int Edad
    {
        get 
        { 
           return miEdad; 
        }
        set 
        { 
           miEdad = value; 
        }
    }

    public override string ToString()//Usamos esto para instanciar la clase
    {
        return "Nombre = " + Nombre + ", Edad = " + Edad;
    }

    public static void Main()
    {
        Console.WriteLine("Aprendiendo a usar clases");

        // Creamos un objeto persona:
        Persona persona1 = new Persona();

        // Imprimimos los comandos predefinidos:
        Console.WriteLine("Persona Predefinida - {0}", persona1);

        // Definimos los valores de la clase:
        persona1.Nombre = "Jotaro";
        persona1.Edad = 18;
        Console.WriteLine("Persona con valores asignados - {0}", persona1);

        // Imcrementamos la edad 21 años:
        persona1.Edad += 21;
        Console.WriteLine("Persona con la edad incrementada - {0}", persona1);
    }
}