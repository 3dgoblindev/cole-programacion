using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                Console.WriteLine(array[x, y]);
            }
        }
        //podemos verla en forma de matriz:
        string matrixToString(int[,] M)
        { 
            string result = "";
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    result += M[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }
        Console.WriteLine(matrixToString(array));

        //crear un array de 5 doubles y calcular la media
        int[] ints = { 1, 2, 3, 4, 5 };
        double media = 0;
        foreach (int x in ints)
        {
            media += x;
        }
        media /= ints.Length;
        Console.WriteLine("La media es: " + media);


        //Primer ejercicio: crear una función que devuelva true si encuentra un elemento en un array de enteros
        bool findElement(int[] arr, int element)
        {
            foreach (int i in arr)
            {
                if (i == element)
                {
                    return true;
                }
            }
            return false;
        }

        int[] myArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine(findElement(myArray, 3)); // true

        //Segundo ejercicio: crear una función que devuelva el número de suspensos de un array de notas
        int countFailures(int[] grades)
        {
            int count = 0;
            foreach (int grade in grades)
            {
                if (grade < 5)
                {
                    count++;
                }
            }
            return count;
        }
        int[] myGrades = { 3, 5, 7, 2, 8, 4 };
        Console.WriteLine(countFailures(myGrades)); // 3

        //Tercer ejercicio: crear una función que devuelva un array con los primeros N números pares.
        int[] firstNEvenNumbers(int n)
        {
            int[] evenNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                evenNumbers[i] = i * 2;
            }
            return evenNumbers;
        }

        int N = 5;
        int[] evenNumbersArray = firstNEvenNumbers(N);
        Console.WriteLine(string.Join(", ", evenNumbersArray)); // 0, 2, 4, 6, 8

        //Cuarto ejercicio: crear una función que reciba el array generado en la función anterior como parámetro y modifique dichos números para hacerlos impares.

        int[] makeArrayOdd(int[] arr)
        { 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 1;
            }
            return arr;
        }

        int[] oddNumbersArray = makeArrayOdd(evenNumbersArray);
        Console.WriteLine(string.Join(", ", oddNumbersArray)); // 1, 3, 5, 7, 9

    }

}