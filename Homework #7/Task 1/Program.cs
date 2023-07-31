// Task 47 Задайте двумерный массив размером m*n заполненный случайными вещественными числами. 

double[,] CreateRandomMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double randomNumber = random.NextDouble() * 100 + 1;
            matrix[i, j] = Math.Round(randomNumber, 2);
        }
    }
    return matrix;
}


void ShowMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],8}");
        }
        Console.WriteLine(" ]");
    }
}

double[,] array2d = CreateRandomMatrix(3, 4);

ShowMatrix(array2d);