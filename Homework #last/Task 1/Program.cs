// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($" {num} ");
    NaturalNumbers(num - 1);
}

Console.WriteLine("Input natural number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Incorrect number");
    return;
}

NaturalNumbers(number);