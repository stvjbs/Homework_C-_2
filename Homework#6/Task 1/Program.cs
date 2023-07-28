// Пользователь вводит с клав. М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 


double[] CreateArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input element");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}


void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumberOfPositiveNumbers(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Input a quanity of numbers (M): ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
Console.WriteLine("Number of positive numbers is - " + NumberOfPositiveNumbers(myArray));