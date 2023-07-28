// Task 47 Задайте двумерный массив размером m*n заполненный случайными вещественными числами. 

double[,] CreateRandomMatrix(int rows, int columns, double minValue, double maxValue)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().ToDouble(minValue,maxValue+1);
        }
    }
    return matrix;
}


void ShowMatrix(int[,] matrix)
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

double[,] array2d = CreateRandomMatrix(3, 4, 1, 10);

ShowMatrix(array2d);