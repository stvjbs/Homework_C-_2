// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. 


double[] CreateArray(int size)
{
    double[] array1 = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        double randomNumber = random.NextDouble() * 100 + 1;
        array1[i] = Math.Round(randomNumber,2);
    }
    return array1;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double Diff_MaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    return result;
}
Console.WriteLine("Inpt a quanity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
Console.WriteLine("Difference between the max and the min numbers is - " + Diff_MaxAndMin(myArray));