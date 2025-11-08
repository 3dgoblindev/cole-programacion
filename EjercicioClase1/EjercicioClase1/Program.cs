using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine($"Holi {nombre}!");


        Console.Write("Vamos a ver un número es mayor que otro. \n");
        Console.Write("Escribe el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escribe el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Tus numerines son: {n1} y {n2}");

        bool esMayor = n1 > n2;

        if (esMayor) {
            Console.WriteLine("\n Era mayor.");
        } 
        else {
            Console.WriteLine("\n Era menor.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
