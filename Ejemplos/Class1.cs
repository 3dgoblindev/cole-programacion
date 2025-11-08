using System;

class Program
{
    static void Main()
    {
        bool a, b, c, d;

        a = true;
        b = true;
        c = false;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}\n");

        d = (a && b); // Asigna true a d
        Console.WriteLine($"d = (a && b) → {d}");

        d = (a || b); // Asigna true a d
        Console.WriteLine($"d = (a || b) → {d}");

        d = (b && c); // Asigna false a d
        Console.WriteLine($"d = (b && c) → {d}");

        d = (c || c); // Asigna false a d
        Console.WriteLine($"d = (c || c) → {d}");

        d = !a; // Asigna false a d
        Console.WriteLine($"d = !a → {d}");

        d = (c && (a && b)) || (b && c); // Asigna false a d
        Console.WriteLine($"d = (c && (a && b)) || (b && c) → {d}");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
