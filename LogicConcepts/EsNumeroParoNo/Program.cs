do  //Inserta un bucle o ciclo repetitivo, donde el if se va a repetir hasta que presione control+c
{
    Console.Write("Ingrese número o la palabra 'Salir' para salir: "); //Line pone o pide el resultado en una nueva linea, si no lo ponemos, lo ingresado queda en la misma linea
    var numberString = Console.ReadLine();  //console.ReadLine() sirve para leer 
    var numberInt = int.Parse(numberString!); // la variable numberString, la parsea o la convierte en un tipo int o entrero

    if (numberInt % 2 == 0)  // if, para preguntar cosas, si el numero entero es modulo de 2, entonces es par
    {
        Console.WriteLine($"El número {numberInt}, es par."); //${ } interpolación, para agregar texto
    }
    else
    {
        Console.WriteLine($"El número {numberInt}, es impar.");
    }
    } while (true) ; //fin de ciclo repetitivo 
