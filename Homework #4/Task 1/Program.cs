// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

int NumbersDegree(int numA, int numB)
{
    int degree = numA;
    for (int i = 1; i < numB; i++)
    {
        degree *= numA;
    }
    return degree;
}

Console.WriteLine("Input number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Degree = {NumbersDegree(a,b)}");
