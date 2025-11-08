using System;
namespace PrimerEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int lado1 = 5;
            int lado2 = 3;
            double hipotenusa = Math.Sqrt(lado1 * lado1 + lado2 * lado2);
            Console.WriteLine("La hipotenusa vale " + hipotenusa);
        }
    }
}