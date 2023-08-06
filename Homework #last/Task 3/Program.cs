// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0)
        return Ack(n - 1, 1);
    else
        return Ack(n - 1, Ack(n, m - 1));
}

Console.WriteLine("Input natural number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input natural number 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int acker = Ack(number1, number2);
Console.WriteLine($" Result = {acker}");