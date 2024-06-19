using System;

class Program
{
    static void Main()
    {
        double[,] matrix = new double[3, 3];
        Console.WriteLine("Въведете елементите на 3x3 матрица, ред по ред, разделени с интервал: ");
        for (int i = 0; i < 3; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = double.Parse(row[j]);
            }
        }

        double determinant = CalculateDeterminant(matrix);
        Console.WriteLine($"Детерминанта: {determinant}");
    }

    static double CalculateDeterminant(double[,] matrix)
    {
        double determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                           - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                           + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        return determinant;
    }
}
