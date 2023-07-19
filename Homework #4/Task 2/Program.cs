// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int num)
{
    int result = 0;
    while (num >= 1)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum = {SumOfDigits(number)}");