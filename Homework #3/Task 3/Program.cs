// Task 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableCubes(int n)
{
int current = 1; 
    while(current <= n)
    {
        Console.WriteLine(current + "-" + (Math.Pow(current,3)));
        current++;
    }
}
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
TableCubes(n);