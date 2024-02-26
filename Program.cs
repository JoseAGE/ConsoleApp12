//Un array contiene los elementos indicados más abajo. Utilizando el algoritmo de ordenación Shell encuentre
//las pasadas y los intercambios que se realizan para su ordenación. ARRAY: 8 43 17 6 40 16 18 97 11 7
//Partiendo del mismo array anterior, encuentre las particiones e intercambios que realiza el algoritmo de ordenación quicksort para su ordenación.//
using System;

class Program
{
    static void Main()
    {
        int[] array = { 8, 43, 17, 6, 40, 16, 18, 97, 11, 7 };

        Console.WriteLine("Array antes de la ordenación:");
        MostrarArray(array);

        ShellSort(array);

        Console.WriteLine("\nArray después de la ordenación con Shell Sort:");
        MostrarArray(array);
    }

    static void ShellSort(int[] array)
    {
        int n = array.Length;
        int pasadas = 0;
        int intercambios = 0;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = array[i];
                int j = i;

                while (j >= gap && array[j - gap] > temp)
                {
                    array[j] = array[j - gap];
                    j -= gap;
                    intercambios++;
                }

                array[j] = temp;
            }

            pasadas++;
        }

        Console.WriteLine($"\nPasadas realizadas: {pasadas}");
        Console.WriteLine($"Intercambios realizados: {intercambios}");
    }

    static void MostrarArray(int[] array)
    {
        foreach (var elemento in array)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}

