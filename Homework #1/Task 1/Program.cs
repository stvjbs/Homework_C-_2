
// Homework. Lesson 1.
// Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
    Console.Write($"Большее число - {num1}, а меньшее - {num2}");
    else
    Console.Write($"Большее число - {num2}, а меньшее - {num1}");



