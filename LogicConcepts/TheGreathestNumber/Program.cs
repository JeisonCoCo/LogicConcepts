// See https://aka.ms/new-console-template for more information

//2 NÚMERO MAYOR Construir un programa que pida por pantalla 3 números y
//luego diga cuál es el mayor de los números ingresados. Prueba: al ejecutar
//el programa debe mostrar lo siguiente: Ingrese primer número: 45 Ingrese segundo
//número: 23 Ingrese tercer número: 12 El número mayor es: 45 

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese 3 números diferentes ");
        Console.WriteLine(" ");
        Console.Write("Ingrese primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Ingrese tercer número: ");
        int c = int.Parse(Console.ReadLine());

        
        if (a > b && a > c)
        {

            if (b > c)
            {
                Console.WriteLine($"El mayor es {a}, el medio es {b} y el menor es {c}");
            }
            else
            {
                Console.WriteLine($"El mayor es {a}, el medio es {c} y el menor es {b}");
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine($"El mayor es {b}, el medio es {a} y el menor es {c}");
            }
            else
            {
                Console.WriteLine($"El mayor es {a}, el medio es {c} y el menor es {b}");
            }
        }
    }
     
    
}