// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] CreateRandomMatrix(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] matrix = new int[rows, columns, depth];
    int count = 11;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
    return matrix;
}

void ShowMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"matrix[{i} {j} {k}] - {matrix[i, j, k],2}");
            }
        }
    }
}

int[,,] matrix1 = CreateRandomMatrix(2, 2, 2, 1, 5);
ShowMatrix(matrix1);