// Task 2 Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int FunctThird(int num)
{
    if(num>99)
    {
        while(num > 1000)
        {
            num = num / 10;
        }
        int num1 = num % 10;
        return num1;
    }
    else 
        return(-1);
}
Console.WriteLine("Input number");
int result = FunctThird(Convert.ToInt32(Console.ReadLine()));
if(result == -1) 
    Console.WriteLine("третьей цифры нет");
else 
    Console.WriteLine($"The third unit of yout number is - {result}");
