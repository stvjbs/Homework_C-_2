// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void ShowArray(int[] matrix)
{
    Console.Write("[");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"  {matrix[i]}  ");
    }
    Console.WriteLine(" ]");
}

int[] SumsOfElemsInRows(int[,] matrix)
{
    int[] sumsOfElems = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumsOfElems[i] = sum;
        sum = 0;
    }
    return sumsOfElems;
}

bool CheckRectangle(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
        return true;
    else return false;
}

int FindMinRow(int[] array)
{
    int minElem = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array2d = CreateRandomMatrix(4, 3, 1, 10);
ShowMatrix(array2d);
Console.WriteLine();

if (!CheckRectangle(array2d))
{
    Console.WriteLine("The matrix must be ractangle, change size!");
    return;
}

int[] sumsOfElemsInRow = SumsOfElemsInRows(array2d);

ShowArray(sumsOfElemsInRow);

Console.Write($"Index of row with minimal sum of elements is {FindMinRow(sumsOfElemsInRow)}");