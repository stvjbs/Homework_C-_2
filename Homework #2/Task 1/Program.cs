// HW lesson 2

// Task 1 Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FunctUnit(int num)
{
    int first = num / 10;
    int second = first % 10;
    return second;
}
Console.WriteLine("Input трезначное число");
int num = Convert.ToInt32(Console.ReadLine());
int result = FunctUnit(num);
Console.WriteLine($"Вторая цифра вашего числа - {result}");



