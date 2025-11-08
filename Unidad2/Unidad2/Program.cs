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

        //pares while
        int pares_0 = 0;
        i= -100;
        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                pares_0++;
            }
            i++;
        }

        Console.WriteLine("\nHay {0} números pares entre -100 y 100 \n", pares_0);

        //ejemplo for (ups)
        for (int j = 1; j <= 10; j++) 
        { 
            Console.WriteLine("Vamos por {0}", j);
        }

        //for dentro del for
        Console.WriteLine("\n A pintar \n");

        for (int fila = 1; fila <= 8; fila++) 
        {
            for (int columna = 1; columna <= 8; columna++) 
            {
                if((columna % 2 == 0) && (fila % 2 != 0) || (columna % 2 != 0) && (fila % 2 == 0))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }

            }
            Console.WriteLine();
        }

        //pares for
        int pares = 0;
        for (int j = -100; j <= 100; j += 1)
        {
            if (j % 2 == 0)
            {
                pares++;
            }
        }
        Console.WriteLine("\nHay {0} números pares entre -100 y 100 \n", pares_0);

        //ej menu simple
        Console.WriteLine("\n Menú de opciones. Dame 2 números: ");

        int num1, num2;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        int opcion = -1;

        while (opcion != 5) 
        {
            Console.WriteLine("\nSelecciona una opción (1=sumar, 2=restar, 3=multiplicar, 4=dividir, 5=cerrar.");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion) {
                case 1:
                    Console.WriteLine("La suma es {0}", num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("La resta es {0}", num1 - num2);
                    break;
                case 3: 
                    Console.WriteLine("La multiplicación es {0}", num1 * num2);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("La división es {0}", (float)num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Cerrando el programa...");
                    break;
            }
        }



        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
