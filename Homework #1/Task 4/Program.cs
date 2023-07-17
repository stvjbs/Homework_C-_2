// Task 4: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input the number.");
int num = Convert.ToInt32(Console.ReadLine());
if(num>1)
{
    Console.Write("Все четные числа от 1 до " + num + " - ");
    while(num>4)
{
    if(num % 2 == 0)
    {
    num = num - 2;
    Console.Write(num + ", ");
    }
    else
    {
    num = num - 1;
    Console.Write(num + ", ");
    }
}
    Console.Write("2.");
}
else
Console.Write("Четных чисел между 1 и " + num + " нет");