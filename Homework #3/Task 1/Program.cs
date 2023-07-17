﻿// Homework lesson 3

// Task 1 Напишите программу, которая принимает на
// вход ?пятизначное? число и проверяет, является ли оно палиндромом.

bool Pal(int num)
{
 int current = num;
 string num2 = "";
 while(current>=1)
 {
    num2 = num2 + (current % 10);
    current = current / 10;
 }   
 int numcheck = Convert.ToInt32(num2);
 if(num == numcheck) return true;
 else return false;
}
Console.WriteLine("Input number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pal(num1) ? "Yes" : "No");