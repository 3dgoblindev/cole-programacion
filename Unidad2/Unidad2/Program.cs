using System;

class Program
{
    static void Main()
    {
        //Primera prueba de if, comprar dos números
        Console.WriteLine("Mete un número a ver");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n > 5)
            {
            Console.WriteLine("El número es mayor que 5. Que grandote");
        }
        else
        {
            Console.WriteLine("El número es menor o igual que 5. Que chikito.");
        }

        //ejemplos a,b,c (sobre tabulados?) Calcular el mayor de tres números
        int a = 1, b = 2, c = 3;
        int max;

        if (a >= b)
            if (a >= c)
                max = a;
            else
                max = c;
        else
            if (b >= c)
                max = b;
            else
                max = c;

        Console.WriteLine("\nEl mayor de {0}, {1}, {2} es {3}", a, b, c, max);

        //ej de la edad
        Console.WriteLine("Dime tu edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad > 45)
        {
            Console.WriteLine("OK BOOMER");
        }
        else if (edad > 30)
        {
            Console.WriteLine("... Hm ... You are a millenial. How is adulting going?");
        }
        else 
        {
            Console.WriteLine("Gen Z baby. Hey, don't look away! I have subway surfer I promise!");
        }


        //switch
        int variable = 3;
        switch (variable) {
            case 1:
                    Console.WriteLine("Variable vale 1");
                    break;
                case 2:
                    Console.WriteLine("Variable vale 2");
                    break;
                case 3:
                case 4:
                Console.WriteLine("Variable vale 3 o 4");
            break;
                default:
                    Console.WriteLine("La variable no está entre el 1 y el 4");
                    break;
        }

        //whiles
        int i = 1;
        while (i <= 20)
        {
            Console.WriteLine("AYUDA");
            i++; //Es lo mismo que i=i+1
        }

        //pares
        int pares = 0;
        for (int j = -100; j <= 100; j += 1)
        {
            if (j % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine("\nHay {0} números pares entre -100 y 100", pares);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
