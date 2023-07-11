﻿// HW lesson 2

// Task 1 Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int FunctUnit(int num)
// {
//     int first = num / 10;
//     int second = first % 10;
//     return second;
// }
// Console.WriteLine("Input трезначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = FunctUnit(num);
// Console.WriteLine($"Вторая цифра вашего числа - {result}");

// Task 2 Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// int FunctThird(int num)
// {
//     if(num>99)
//     {
//         while(num > 1000)
//         {
//             num = num / 10;
//         }
//         int num1 = num % 10;
//         return num1;
//     }
//     else 
//         return(-1);
// }
// Console.WriteLine("Input number");
// int result = FunctThird(Convert.ToInt32(Console.ReadLine()));
// if(result == -1) 
//     Console.WriteLine("третьей цифры нет");
// else 
//     Console.WriteLine($"The third unit of yout number is - {result}");

// Task 3 

// bool Weekend(int num)
// {
//     if (num == 6 || num == 7)
//         return true;
//     else
//         return false;    
// }
// Console.WriteLine("Введите день недели от 1-7");
// int dayOfWeek = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( Weekend (dayOfWeek) ? "Выбранный день - выходной" : "Выбранный день - рабочий");