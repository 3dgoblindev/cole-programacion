using System;

class Program
{
    static void Main()
    {
        //EJEMLPO
        Console.WriteLine("Hello World!");
        int lado1 = 5;
        int lado2 = 3;
        double hipotenusa = Math.Sqrt(lado1 * lado1 + lado2 * lado2);
        Console.WriteLine("La hipotenusa vale " + hipotenusa);

        //EJEMPLO NOMBRE
        string nombre, apellido;
        nombre = "Arturo";
        apellido = "Cáceres";
        string nombreCompleto = nombre + " " + apellido;
        Console.WriteLine(nombreCompleto);
        string algo = "5";

        Console.WriteLine("YIIIIIIIPIIE");

        // Pedir datos al usuario
        Console.WriteLine("Ejemplos operadores\n");

        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division = num2 != 0 ? num1 / num2 : double.NaN; // Evitar división por cero
        double modulo = num2 != 0 ? num1 % num2 : double.NaN;

        Console.WriteLine("\n Resultados ");
        Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
        Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
        Console.WriteLine($"División: {num1} / {num2} = {division}");
        Console.WriteLine($"Módulo: {num1} % {num2} = {modulo}");

        Console.WriteLine("\n adios");
        Console.ReadKey();

        //BOOLS
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


        //EJ CLASE
        //
        Console.Write("Escribe tu nombre: ");
        string nombre1 = Console.ReadLine();

        Console.WriteLine($"Holi {nombre1}!");


        Console.Write("Vamos a ver un número es mayor que otro. \n");
        Console.Write("Escribe el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escribe el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Tus numerines son: {n1} y {n2}");

        bool esMayor = n1 > n2;

        if (esMayor)
        {
            Console.WriteLine("\n Era mayor.");
        }
        else
        {
            Console.WriteLine("\n Era menor.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
