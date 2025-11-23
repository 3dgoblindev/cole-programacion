using System;
using System.Collections.Generic; // <- necesario para List<T>

class Program
{
    static void Main()
    {
        //Crear una lista y añadir elementos:
        List<int> primes = new List<int>();
        primes.Add(2);
        primes.Add(3);
        primes.Add(5);
        primes.Add(7);

        //Iterar con for:
        for (int i = 0; i < primes.Count; i++)
        {
            Console.WriteLine(primes[i]);
        }

        //Iterar con foreach:
        foreach (int p in primes)
        {
            Console.WriteLine("Prime: " + p);
        }

        //Insertar en una posición concreta:
        primes.Insert(1, 11); //insertamos en la posición 1
        Console.WriteLine("Después de insertar 11: " + string.Join(", ", primes));

        //Borrar un elemento:
        primes.Remove(11);
        Console.WriteLine("Después de borrar 11: " + string.Join(", ", primes));

        //Comprobar si existe un elemento:
        Console.WriteLine(primes.Contains(5)); // true
        Console.WriteLine(primes.IndexOf(7));  // índice de 7

        //Ordenar una lista:
        primes.Sort();
        Console.WriteLine("Ordenada: " + string.Join(", ", primes));

        //Vaciar la lista:
        List<string> colors = new List<string>() { "rojo", "verde", "azul" };
        colors.Clear();
        Console.WriteLine("Colores tras Clear(): " + colors.Count);


        //Obtener un elemento aleatorio:
        List<string> fruits = new List<string>() { "manzana", "pera", "uva", "plátano" };
        Random rnd = new Random();
        int index = rnd.Next(fruits.Count);
        Console.WriteLine("Fruta aleatoria: " + fruits[index]);



    }
}
