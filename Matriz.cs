using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("La fila (n) de cuanto sera :");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("La fila (m) de cuanto sera:");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        Console.WriteLine("Ingrese los numeros de la matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Elemento [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < 0)
                {
                    matrix[i, j] = Math.Abs(matrix[i, j]);
                }
            }
        }

        Console.WriteLine("\nMatriz modificada (valores negativos reemplazados por positivos):");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
