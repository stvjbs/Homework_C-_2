// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

void FindElem(int[,] matr, int row, int column)
{
    if (row < matr.GetLength(0) && column < matr.GetLength(1))
        Console.WriteLine($"Элемент [ {row},{column} ] - {matr[row, column]}");
    else Console.WriteLine("Такого элемента нет");

}

int[,] array2d = CreateRandomMatrix(3, 4, -100, 100);
ShowMatrix(array2d);

Console.WriteLine("Input row's index");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column's index");
int c = Convert.ToInt32(Console.ReadLine());

FindElem(array2d, r, c);
