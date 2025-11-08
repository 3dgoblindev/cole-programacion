using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        //funcion suma. Suma dos enteros y devuelve el resultado
        int suma(int a, int b)
        {
            return a + b;
        }

        //funcion resta. Resta dos enteros y devuelve el resultado
        int resta(int a, int b)
        {
            return a - b;
        }

        //factorial de un número
        int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        //funcion mayor. Devuelve si un número es mayor que otro
        bool mayor(int a, int b)
        {
            return a > b;
        }

        //funcion media. Calcula la media de dos números
        double media(double a, double b)
        {
            return (a + b) / 2;
        }

        //procedimiento que imprime un menú de operaciones
        void ImprimirMenu()
        {
            Console.WriteLine("1: Mayor");
            Console.WriteLine("2: Sumar");
            Console.WriteLine("3: Media");
            Console.WriteLine("Otro número para salir");
        }

        //operaciones
        int resultado1;
        int resultado2;
        resultado1 = suma(1, 2);
        resultado2 = suma(4, resultado1);
        Console.WriteLine("El resultado es " + resultado2);

        int a = 3;
        int b = 5;
        int resultado3 = resta(b, a);
        Console.WriteLine("El resultado es " + resultado3);

        int numero = 5;
        int resultadoFactorial = factorial(numero);
        Console.WriteLine("El factorial de " + numero + " es " + resultadoFactorial);

        //////////////////////////////
        //voids
        void ImprimirMensaje(string nombre, bool esHola)
        {
            if (esHola == true)
                Console.WriteLine("Hola " + nombre);
            else
                Console.WriteLine("Adiós " + nombre);
            return;
        }

        ImprimirMensaje("Carlos", true);

        //ref
        void ConvertirARuso(ref string nombre, ref string apellido)
        {
            nombre = nombre + "ov";
            apellido = apellido + "vich";
        }

        string name = "Pablo";
        string apel = "Garcia";
        ConvertirARuso(ref name, ref apel);
        Console.WriteLine(name + " " + apel);


        ////////////
        //muchos parametros
        double CalcularPrecioConIVA(double precioSinIva, double tasaIVA = 0.21, double descuento = 0)
        {
            double precio = precioSinIva * (1 + tasaIVA) - descuento;
            return precio;
        }
        double p = CalcularPrecioConIVA(100);
        double p2 = CalcularPrecioConIVA(100, 0.16);
        double p3 = CalcularPrecioConIVA(100, 0.16, 20);

        //////////////////////////////
        //programa principal con menú
        while (true)
        {
            Console.Write("Introduce el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            ImprimirMenu();
            Console.Write("Elige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
                Console.WriteLine("¿El primero es mayor? " + mayor((int)n1, (int)n2));
            else if (opcion == 2)
                Console.WriteLine("La suma es: " + suma((int)n1, (int)n2));
            else if (opcion == 3)
                Console.WriteLine("La media es: " + media(n1, n2));
            else
                break;
        }
    }
}
