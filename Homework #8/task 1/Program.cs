//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//   элементы каждой строки двумерного массива.

int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine(" ]");
    }
}

void SortInRow(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            while (matrix[i, j] < matrix[i, j + 1])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = temp;
                j = 0;
            }
        }
    }
}
int[,] array2d = CreateRandomMatrix(3, 4, 1, 10);
ShowMatrix(array2d);

Console.WriteLine();

SortInRow(array2d);
ShowMatrix(array2d);