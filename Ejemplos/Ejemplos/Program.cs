using System;

class Program
{
    static void Main()
    {
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
    }
}
