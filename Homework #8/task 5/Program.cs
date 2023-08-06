// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

int[,] CreateRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int i =0;
    int j = 0;
    while (i)
    count++;
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

int[,] matrix1 = CreateRandomMatrix(4, 4);
ShowMatrix(matrix1);