// Задача 66: Задайте значения n и m. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от n до m.
// 1 2 3 4
int FactorialRec(int n, int m)
{
    if (m > n)
    {
        if (m == n + 1) return n + m;
        else return m + FactorialRec(n, m - 1);
    }
    else if (m < n)
    {
        if (n == m + 1) return n + m;
        else return n + FactorialRec(n - 1, m);
    }
    else return m;
}

Console.WriteLine(FactorialRec(5, 2));