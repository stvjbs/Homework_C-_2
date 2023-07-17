// Task 3  Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int num)
{
    if (num == 6 || num == 7)
        return true;
    else
        return false;    
}
Console.WriteLine("Введите день недели от 1-7");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( Weekend (dayOfWeek) ? "Выбранный день - выходной" : "Выбранный день - рабочий");
//