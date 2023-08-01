// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

bool CheckPosibility(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
        return true;
    else return false;
}

int[,] MultiplyMatrixes(int[,] a, int[,] b)
{
    int rowsRes = a.GetLength(0);
    int columnsRes = b.GetLength(1);
    int[,] c = new int[rowsRes, columnsRes];

    for (int i = 0; i < c.GetLength(0); i++)
    {
        for (int j = 0; j < c.GetLength(1); j++)
        {
            c[i, j] = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                c[i, j] += a[i, k] * b[k, j];
            }

        }
    }
    return c;
}

int[,] matrix1 = CreateRandomMatrix(3, 4, 1, 5);
ShowMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateRandomMatrix(4, 3, 1, 5);
ShowMatrix(matrix2);

if (!CheckPosibility(matrix1, matrix2))
{
    Console.Write("Imposible to multiply");
}
Console.WriteLine();

int[,] matrixResult = MultiplyMatrixes(matrix1, matrix2);
ShowMatrix(matrixResult);