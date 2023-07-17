// Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the third number");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max < num2)
    max = num2;
if(max < num3)
    max = num3;
Console.WriteLine("Максимальное число - " + max);